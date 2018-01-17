//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   Class file for managing serial port communication
//
//   Copyright (C) 2009  
//   Derek Joyce 
//   Email: derek_joyce@yahoo.com
//   Created: Jan2009
//
//   This program is not free.
//*****************************************************************************************


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

using ZedGraph;
using PCComm;

using log4net;
using log4net.Config;
using System.Threading;


namespace TemperatureMonitor
{



    public partial class MainForm : Form
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(MainForm));

        public static String DATA_FILES_LOCATION = "c:\\DataFiles\\History\\";
        public static String BACKUP_DATA_FILES_LOCATION = "K:\\";

        public static String RAW_DATA_FILE = "c:\\DataFiles\\RawData.txt";
        public static String BACKUP_DATA_STORE = "c:\\DataFiles\\Backup\\DataBackup.txt";
        private String OUT_OF_CYCLE_DATA_FILES_LOCATION = "c:\\DataFiles\\OutOfCycle\\";
        private String DATA_FILE_EXTENSION = ".dat";

        public delegate TreeNode GetNode(String data);
        public delegate void AddNode(TreeNode tNode, TreeNode nodeName);
        public delegate void TreeViewExistingData(object sender, TreeViewEventArgs e);




        public delegate void DataReceivedDelegate();
        public delegate void COMStatusDelegate();

        private delegate void OnDataReceived(String rawData, FileDataReader data);

        private System.ComponentModel.BackgroundWorker backgroundUpdaterThread;

        CommunicationManager comm = new CommunicationManager();
        DataTable dataTable = new DataTable();
        DataTable dataTableHistory = new DataTable();

        DateTime cycleStartTime;
        String fileName = "";
        String cycleName = "";
        String rawDataFileName = "";

        PointPairList listMc, listEmc, listTa, listTw;
        PointPairList listHistoryMc, listHistoryEmc, listHistoryTa, listHistoryTw;

        LineItem myCurveEmc, myCurveMc, myCurveTa, myCurveTw;

        static MainForm()
        {
            try
            {
                DOMConfigurator.Configure();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public MainForm()
        {
            logger.Debug("Entering MainForm ctor.");

            try
            {



                // Determine whether the directory exists.
                if (!Directory.Exists(OUT_OF_CYCLE_DATA_FILES_LOCATION))
                {
                    // Try to create the directory.
                    DirectoryInfo di = Directory.CreateDirectory(OUT_OF_CYCLE_DATA_FILES_LOCATION);
                    logger.Info("The directory was created successfully at " + Directory.GetCreationTime(OUT_OF_CYCLE_DATA_FILES_LOCATION));
                }

                Directory.CreateDirectory(DATA_FILES_LOCATION);

            }
            catch (Exception e)
            {
                logger.Info("The process failed: " + e.ToString());
            }
            finally { }

            copyDataFilesFromBackup();

            InitializeComponent();

            comm.DataReceived += new CommunicationManager.DataReceivedHandler(this.OnDataReceivedMethod);
            comm.COMStatus += new CommunicationManager.COMStatusHandler(this.UpdateComStatus);

            if (System.Configuration.ConfigurationSettings.AppSettings["COM.TransmissionType"].ToLower().Equals("hex"))
            {
                comm.CurrentTransmissionType = CommunicationManager.TransmissionType.Hex;
            }
            else
            {
                comm.CurrentTransmissionType = CommunicationManager.TransmissionType.Text;
            }


            if (System.Configuration.ConfigurationSettings.AppSettings["TestMode"].ToLower().Equals("on"))
            {   // disable the timer
                this.timer1.Enabled = true;
            }

            comm.Parity = System.Configuration.ConfigurationSettings.AppSettings["COM.Parity"];// cboParity.Text;
            comm.StopBits = System.Configuration.ConfigurationSettings.AppSettings["COM.StopBits"];// cboStop.Text;
            comm.DataBits = System.Configuration.ConfigurationSettings.AppSettings["COM.DataBits"];// cboData.Text;
            comm.BaudRate = System.Configuration.ConfigurationSettings.AppSettings["COM.BaudRate"];// cboBaud.Text;
            comm.PortName = System.Configuration.ConfigurationSettings.AppSettings["COM.PortName"];// cboPort.Text;
            comm.OpenPort();

            // setupDataViewAndTable(this.dataGridView1, this.dataTable);
            setupDataViewAndTable(this.dataGridViewHistory, this.dataTableHistory);

            readExistingData();

            listMc = new PointPairList();
            listEmc = new PointPairList();
            listTa = new PointPairList();
            listTw = new PointPairList();

            setupHistoryGraph();
            setupActiveCycleGraph();

            //  this.treeViewExistingData.Sort();

            


            this.backgroundUpdaterThread = new System.ComponentModel.BackgroundWorker();
            this.backgroundUpdaterThread.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundUpdaterThread_DoWork);



            backgroundUpdaterThread.RunWorkerAsync();



          //  DataUpdater dataUpdaterThread = new DataUpdater();
           // dataUpdaterThread.setMainForm(this);

            //Thread oThread = new Thread(new ThreadStart(dataUpdaterThread.start));

            // Start the thread
            //oThread.Start();


            logger.Debug("Exiting MainForm ctor.");
        }

        private void copyDataFilesFromBackup()
        {
            try
            {
                logger.Debug("Entering copyDataFilesFromBackup");

                String remoteKilnDirectory = System.Configuration.ConfigurationSettings.AppSettings["RemoteKilnDirectory"];// cboBaud.Text;

                if (remoteKilnDirectory == null)
                {
                    remoteKilnDirectory = BACKUP_DATA_FILES_LOCATION;
                }

                DirectoryInfo di = new DirectoryInfo(remoteKilnDirectory);
                FileSystemInfo[] files = di.GetFileSystemInfos();

                foreach (FileSystemInfo i in files)
                {
                    try
                    {
                        FileInfo file = new FileInfo(i.FullName);
                        logger.Debug("Checking if " + i.FullName + " exists in " + DATA_FILES_LOCATION);

                        FileInfo destFile = new FileInfo(Path.Combine(DATA_FILES_LOCATION, file.Name));
                        if (destFile.Exists)
                        {
                            if (file.LastWriteTime > destFile.LastWriteTime)
                            {
                                // now you can safely overwrite it
                                logger.Debug("File Exists and is older, it will be overwrote. " + destFile.FullName);
                                file.CopyTo(destFile.FullName, true);
                            }
                            else
                            {
                                logger.Debug("File Exists and same write date, file will NOT be overwrote." + destFile.FullName);
                            }
                        }
                        else
                        {
                            logger.Debug("Copying file to " + destFile.FullName);
                            file.CopyTo(destFile.FullName, true);
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Warn(ex.StackTrace);
                    }
                }
                logger.Debug("Exiting copyDataFilesFromBackup");
            }
            catch( Exception ex )
            {
                logger.Error(ex.StackTrace);
            }


        }

        private void UpdateComStatus(String message)
        {
            logger.Debug("Entering UpdateComStatus message: " + message);

            this.statusStrip.Items[0].Text = message;

            logger.Debug("Exiting UpdateComStatus message: " + message);
        }

        private void DataReceived(String message)
        {

        }

        private void setupDataViewAndTable(DataGridView dataGrid, DataTable dataTable)
        {
            dataTable.Columns.Add("Time", typeof(DateTime));
            dataTable.Columns.Add("TW");
            dataTable.Columns.Add("T1");
            dataTable.Columns.Add("T2");
            dataTable.Columns.Add("TN");
            dataTable.Columns.Add("E1");
            dataTable.Columns.Add("E2");
            dataTable.Columns.Add("EMC");
            dataTable.Columns.Add("MC");
            dataTable.Columns.Add("Phase");



            dataGrid.DataSource = dataTable;
            dataGrid.Columns[0].Width = 175;
            dataGrid.Columns[1].Width = 75;
            dataGrid.Columns[2].Width = 75;
            dataGrid.Columns[3].Width = 75;
            dataGrid.Columns[4].Width = 75;
            dataGrid.Columns[5].Width = 75;
            dataGrid.Columns[6].Width = 75;
            dataGrid.Columns[7].Width = 75;
            dataGrid.Columns[8].Width = 75;
            dataGrid.Columns[9].Width = 70;

            dataTable.DefaultView.Sort = "Time DESC";
        }

        private void readExistingData()
        {
            logger.Debug("Entering readExistingData.");

            try
            {
                DirectoryInfo di = new DirectoryInfo(DATA_FILES_LOCATION);
                FileSystemInfo[] files = di.GetFileSystemInfos();
                Array.Sort<FileSystemInfo>(files, delegate(FileSystemInfo a, FileSystemInfo b)
                {
                    return a.LastWriteTime.CompareTo(b.LastWriteTime);
                });

                foreach (FileSystemInfo i in files)
                {
                    try
                    {
                        TreeNode newNode = new TreeNode();
                        newNode.Name = i.FullName;

                        String dataFileName = newNode.Name.Replace(DATA_FILES_LOCATION, "");
                        dataFileName = dataFileName.Replace(DATA_FILE_EXTENSION, "");

                        int index = dataFileName.IndexOf(" ");
                        String year = dataFileName.Substring(0, index);
                        year = year.Trim();
                        String displayName = dataFileName.Substring(index);
                        displayName = displayName.Replace("-", ":");
                        newNode.Text = displayName;

                        TreeNode rootNode = getNode(year);
                        rootNode.Nodes.Add(newNode);

                        logger.Debug("Adding node to history view: " + dataFileName + ", completeName: " + i);
                    }
                    catch (Exception ex)
                    {
                        logger.Warn(ex.StackTrace);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Warn(ex.StackTrace);
            }

            logger.Debug("Exiting readExistingData.");
        }

        public void addNode(TreeNode tNode, TreeNode node)
        {
            tNode.Nodes.Add( node );
        }

        public TreeNode getNode(String data)
        {
            foreach (TreeNode node in treeViewExistingData.Nodes)
            {
                if (node.Text.Equals(data))
                {
                    return node;
                }
            }

            TreeNode rootNode = new TreeNode(data);

            if (DateTime.Now.Year.ToString().Equals(data))
            {   // only expand data for current year
                rootNode.ExpandAll();
            }
            this.treeViewExistingData.Nodes.Add(rootNode);
            return rootNode;
        }

        private DataRow createRow(DataTable table, FileDataReader data)
        {
            DataRow myNewRow = table.NewRow();
            myNewRow[0] = data.DateTime;
            //.ToString("hh:mm:ss") + " - " + data.DateTime.DayOfWeek + " " + data.DateTime.Day + " " + data.DateTime.ToString("MMM");
            myNewRow[1] = data.TemperatureWood;
            myNewRow[2] = data.T1;
            myNewRow[3] = data.T2;
            myNewRow[4] = data.TN;
            myNewRow[5] = data.E1;
            myNewRow[6] = data.E2;
            myNewRow[7] = data.EN;
            myNewRow[8] = data.MC;
            myNewRow[9] = data.PHASE;

            return myNewRow;
        }

        private void SetSize()
        {
            //    zedGraphControl.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            //  zedGraphControl.Size = new Size(panel1.Width - 20,
            //                        panel1.Height - 20);
        }

        /* private void buttonStart_Click(object sender, EventArgs e)
         {
             logger.Debug("Entering buttonStart_Click.");

             dataTable.Clear();

          //   colorFadeBusyBar.Visible = true;
         //    colorFadeBusyBar.Text = "Drying Cycle in Progress....";
          //   colorFadeBusyBar.Start();

             cycleStartTime = DateTime.Now;
     ///        this.textBoxStartTime.Text = cycleStartTime.Day + " " + cycleStartTime.ToString("MMM") + " " + cycleStartTime.ToString("hh-mm-ss");
                
        //     this.buttonEndSession.Visible = true;
          //   this.buttonStart.Visible = false;
             cycleName = cycleStartTime.Year + " " + cycleStartTime.Day + " " + cycleStartTime.ToString("MMM") + " " + cycleStartTime.ToString("hh-mm-ss");


             fileName = DATA_FILES_LOCATION + cycleName + DATA_FILE_EXTENSION;


             // get a reference to the GraphPane
            
         //    GraphPane myPane = zedGraphControl.GraphPane;

             // Set the Titles
            // myPane.Title.Text = "Drying Cycle " + cycleStartTime.Day + " " + cycleStartTime.ToString("MMM") + " " + cycleStartTime.ToString("hh:mm:ss"); ;
   //          myPane.XAxis.Title.Text = "Time";
     //        myPane.YAxis.Title.Text = "Temperature";

       //      myPane.XAxis.Type = AxisType.Date;
            // myPane.XAxis.Scale.MajorUnit = DateUnit.Second;
         //    myPane.XAxis.Scale.Format = "d MMM HH:MM";
           //  myPane.XAxis.Scale.FontSpec.Angle = 65;

             //DateTime mynow = DateTime.Now;


             listMc.Clear();
             listEmc.Clear();
             listTa.Clear();
             listTw.Clear();

            
             // Tell ZedGraph to refigure the
             // axes since the data have changed
            // zedGraphControl.AxisChange();

             logger.Debug("Exiting buttonStart_Click.");
         }*/

        private void setupHistoryGraph()
        {
            GraphPane myPane = this.zedGraphControlHistoryDisplay.GraphPane;

            // Set the Titles
            myPane.XAxis.Title.Text = "Time";
            myPane.YAxis.Title.Text = "Temperature";

            myPane.XAxis.Type = AxisType.Date;
            // myPane.XAxis.Scale.MajorUnit = DateUnit.Second;
            myPane.XAxis.Scale.Format = "d MMM HH:mm";
            myPane.XAxis.Scale.FontSpec.Angle = 65;

            listHistoryMc = new PointPairList();
            listHistoryEmc = new PointPairList();
            listHistoryTa = new PointPairList();
            listHistoryTw = new PointPairList();

            // Generate a red curve with diamond
            // symbols, and "Porsche" in the legend
            myCurveEmc = myPane.AddCurve("EMC",
                  listHistoryEmc, Color.Red, SymbolType.None);
            myCurveEmc.Line.Width = 3;

            // Generate a blue curve with circle
            // symbols, and "Piper" in the legend
            myCurveMc = myPane.AddCurve("MC",
                  listHistoryMc, Color.Blue, SymbolType.None);
            myCurveMc.Line.Width = 3;

            myCurveTa = myPane.AddCurve("TA(Air Temp)",
            listHistoryTa, Color.Green, SymbolType.None);
            myCurveTa.Line.Width = 3;

            myCurveTw = myPane.AddCurve("TW(Wood Temp))",
            listHistoryTw, Color.Yellow, SymbolType.None);
            myCurveTw.Line.Width = 3;

            // Tell ZedGraph to refigure the
            // axes since the data have changed
            zedGraphControlHistoryDisplay.AxisChange();

            zedGraphControlHistoryDisplay.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControlHistoryDisplay.Size = new Size(panel2.Width - 20,
                                    panel2.Height - 20);
        }

        private void setupActiveCycleGraph()
        {
            /*  GraphPane myPane = this.zedGraphControl.GraphPane;

              // Set the Titles
              myPane.XAxis.Title.Text = "Time";
              myPane.YAxis.Title.Text = "Temperature";

              myPane.XAxis.Type = AxisType.Date;
              // myPane.XAxis.Scale.MajorUnit = DateUnit.Second;
              myPane.XAxis.Scale.Format = "d MMM HH:mm";
              myPane.XAxis.Scale.FontSpec.Angle = 65;

              listMc = new PointPairList();
              listEmc = new PointPairList();
              listTa = new PointPairList();
              listTw = new PointPairList();

              // Generate a red curve with diamond
              // symbols, and "Porsche" in the legend
              LineItem myCurveEmc = myPane.AddCurve("EMCr",
                    listEmc, Color.Red, SymbolType.None);
              myCurveEmc.Line.Width = 3;

              // Generate a blue curve with circle
              // symbols, and "Piper" in the legend
              LineItem myCurveMc = myPane.AddCurve("MC",
                    listMc, Color.Blue, SymbolType.None);
              myCurveMc.Line.Width = 3;

              LineItem myCurveTa = myPane.AddCurve("TA",
              listTa, Color.Green, SymbolType.None);
              myCurveTa.Line.Width = 3;

              LineItem myCurveTw = myPane.AddCurve("TW",
              listTw, Color.Yellow, SymbolType.None);
              myCurveTw.Line.Width = 3;

              // Tell ZedGraph to refigure the
              // axes since the data have changed
          //    zedGraphControl.AxisChange();

         //     zedGraphControl.Location = new Point(10, 10);
              // Leave a small margin around the outside of the control
           //   zedGraphControl.Size = new Size(panel2.Width - 20,
             //                         panel2.Height - 20);



              */

        }

        private String getDuration(DateTime startTime, DateTime endTime)
        {
            String retValue = "";

            long duration = endTime.Ticks - startTime.Ticks;

            TimeSpan ts = new TimeSpan(duration);

            //  TimeSpan ts = new TimeSpan(23,40,3);
            DateTime d = new DateTime(ts.Ticks);
            string time = d.ToString("dd:hh:mm") + " (days:hours:min)";



            return time;
        }

        private void OnComStatusReceived(String message)
        {
            this.statusStrip.Text = DateTime.Now + "  -  " + message;
        }

        private void OnDataReceivedMethod(String rawData, FileDataReader data)
        {
            if (this.InvokeRequired)
            {
                OnDataReceived del = new OnDataReceived(OnDataReceivedMethod); //delegate

                this.Invoke(del, new object[] { rawData, data });

                return;

            }

            data.writeDataToFile(this.fileName);

            // create row and add to data to file
            //dataTable.Rows.Add(createRow( this.dataTable, data ));
            //double time = (double)new XDate(DateTime.Now);
            //listMc.Add(time, data.MC);
            // listEmc.Add(time, data.EMC);
            //            listTa.Add(time, );
            //listTw.Add(time, data.TemperatureWood);
        }

        /*   private void buttonEndSession_Click(object sender, EventArgs e)
           {
   //            colorFadeBusyBar.Visible = false;
     //          colorFadeBusyBar.Stop();

   //            this.buttonEndSession.Visible = false;
     //          this.buttonStart.Visible = true;

   //            this.textBoxStartTime.Text = "N\\A";
   //            this.textBoxDuration.Text = "0";

               TreeNode newNode = new TreeNode();
               newNode.Name = this.fileName;

               int index = this.cycleName.IndexOf(" ");
               String year = this.cycleName.Substring(0, index);
               String displayName = this.cycleName.Substring(index);
               displayName = displayName.Replace("-", ":");

               newNode.Text = displayName;

               TreeNode rootNode = getNode(year);
               rootNode.Nodes.Add(newNode);
               //this.treeViewExistingData.Nodes.Add(newNode);
               logger.Debug("Adding Node to history data: " + this.cycleName + ", completeName: " + this.fileName);


               this.cycleName = "";
               this.fileName = "";

              // this.outOfCycleFileName = OUT_OF_CYCLE_DATA_FILES_LOCATION + DateTime.Now.Year + " " + DateTime.Now.Day + " " + DateTime.Now.ToString("MMM") + " " + DateTime.Now.ToString("hh-mm-ss") + ".ooc";
           }
   */

        private void timer1_Tick(object sender, EventArgs e)
        {
            Random RandomNumber = new Random();
            FileDataReader data = new FileDataReader();

            data.TemperatureWood = 1 + RandomNumber.NextDouble() * 20;
            //    data.TemperatureAir = 1 + RandomNumber.NextDouble() * 18;
            data.MC = 1 + RandomNumber.NextDouble() * 22;
            //  data.EMC = 1 + RandomNumber.NextDouble() * 12;

            data.T1 = 22.5;
            data.T2 = 21.5;
            data.TN = 20.5;
            data.E1 = 19.5;
            data.E2 = 18.5;
            data.PHASE = 2;
            data.DateTime = DateTime.Now;

            this.OnDataReceivedMethod("Test", data);
        }

        private void serialPortOptionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SerialPortConfigOptions serialPort = new SerialPortConfigOptions();
            serialPort.Show();
        }

        private void treeViewExistingData_AfterSelect(object sender, TreeViewEventArgs e)
        {
            logger.Debug("Entering treeViewExistingData_AfterSelect");

            try
            {
                TreeNode selectedNode = this.treeViewExistingData.SelectedNode;

                if (selectedNode == null)
                {
                    return;
                }

                if (selectedNode.Name.Equals(String.Empty))
                {
                    return;
                }

                GraphPane myPane = this.zedGraphControlHistoryDisplay.GraphPane;

                listHistoryMc.Clear();
                listHistoryEmc.Clear();
                listHistoryTa.Clear();
                listHistoryTw.Clear();
                this.textBoxStartTimeHistory.Text = "";
                textBoxDurationHistory.Text = "";

                Boolean bStartDatePopulated = false;
                DateTime startDateTime = DateTime.Now, endDateTime = DateTime.Now;

                this.dataTableHistory.Clear();
                FileDataReader data;
                StreamReader re = File.OpenText(selectedNode.Name);
                string input = null;
                while ((input = re.ReadLine()) != null)
                {
                    data = new FileDataReader();
                    data.readDataFromFile(input);
                    // create row and add to data to file

                    if (data.MC == 0)
                    {
                        continue;
                    }

                    dataTableHistory.Rows.Add(createRow(this.dataTableHistory, data));

                    if (bStartDatePopulated == false)
                    {
                        bStartDatePopulated = true;

                        startDateTime = data.DateTime;
                    }

                    endDateTime = data.DateTime;

                    myPane.Title.IsVisible = false;

                    //zedGraphControlHistoryDisplay.f


                    //= startDateTime.Day + " " + startDateTime.ToString("MMM") + " " + String.Format("{0:t}", startDateTime); ;



                    // "Drying Cycle " + data.DateTime.Day + " " + data.DateTime.ToString("MMM") + " " + data.DateTime.Year + " " + data.DateTime.ToString("hh:mm:ss"); ;

                    double time = new XDate(data.DateTime);
                    listHistoryMc.Add(time, data.MC);
                    listHistoryEmc.Add(time, data.EN);
                    listHistoryTa.Add(time, data.T1);
                    listHistoryTw.Add(time, data.TemperatureWood);

                    this.textBoxTempAirWhenFinished.Text = "" + data.T1;
                    this.textBoxtEMPwOOD.Text = "" + data.TemperatureWood;
                    this.textBoxMCWhenFinished.Text = "" + data.MC;
                    this.textBoxEMCWhenFinished.Text = "" + data.EN;

                    //this.zedGraphControlHistoryDisplay.AxisChange();
                }
                re.Close();

                this.textBoxStartTimeHistory.Text = startDateTime.Day + " " + startDateTime.ToString("MMM") + " " + String.Format("{0:t}", startDateTime); ;



                //this.zedGraphControlHistoryDisplay.Refresh();
                textBoxDurationHistory.Text = getDuration(startDateTime, endDateTime);

                updateGraph();


                // Tell ZedGraph to refigure the
                // axes since the data have changed
                //this.zedGraphControlHistoryDisplay.AxisChange();


                // Size the control to fill the form with a margin
                //zedGraphControlHistoryDisplay.Location = new Point(10, 10);
                // Leave a small margin around the outside of the control
                //zedGraphControlHistoryDisplay.Size = new Size(panel2.Width - 20,
                //                      panel2.Height - 20);

                //                this.zedGraphControlHistoryDisplay.Refresh();


            }
            catch (Exception ex)
            {
                logger.Error("Exception treeViewExistingData_AfterSelect: " + ex.Message);

            }
            finally
            {
                // colorFadeBusyBarHistory.Visible = false;
            }

            logger.Debug("Exiting treeViewExistingData_AfterSelect");
        }

        public static String processLine(String input)
        {
            String data = "";
            int startIndex = input.IndexOf("[");
            int endIndex = input.IndexOf("]");

            if (startIndex == -1)
            {
                return data;
            }

            if (endIndex == -1)
            {
                data = input.Substring(startIndex + 1, input.Length - startIndex - 1);
            }
            else
            {
                data = input.Substring(startIndex + 1, endIndex - startIndex - 1);
            }

            return data;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //FileDataReader data;
            StreamReader re = File.OpenText("c:\\DataFiles\\RawData.txt");
            string input = null;
            while ((input = re.ReadLine()) != null)
            {
                String data = "";
                try
                {
                    //data = new FileDataReader();
                    if (input.Contains("- "))
                    {
                        logger.Debug("Found start of data:" + input);
                        data = input;// +re.ReadLine() + re.ReadLine() + re.ReadLine();

                        String dateTimeMilli = "", dateTime = "";

                        string[] items = data.Trim().Split(',', '[');
                        if (items.Length > 1)
                        {
                            dateTimeMilli = items[0];
                            dateTime = items[1].Trim();
                        }

                        int startIndex = data.IndexOf("- ");
                        int endIndex = data.IndexOf("]");
                        data = data.Substring(startIndex + 1, endIndex - startIndex - 1);

                        data = data + processLine(re.ReadLine());
                        data = data + processLine(re.ReadLine());
                        data = data + processLine(re.ReadLine());

                        string[] items1 = data.Trim().Split(' ');
                        data = "";
                        foreach (string s in items1)
                        {
                            if (s.Length > 0)
                            {
                                data = data + "," + s;
                            }

                        }

                        data = dateTimeMilli + "," + dateTime + data;
                        logger.Debug("data:" + data);

                        try
                        {
                            StreamWriter writer = new StreamWriter(DATA_FILES_LOCATION + "ProcessedRawData.txt", true);
                            writer.WriteLine(data);
                            writer.Close();
                        }
                        catch (Exception ex)
                        {
                            logger.Error("Exception writing to file: " + ex.Message);
                        }

                    } // end of IF





                }


                catch (Exception eff)
                {
                    logger.Info(eff.Message);
                }






            }
        }

        private void checkBoxMC_CheckedChanged(object sender, EventArgs e)
        {
            updateGraph();
        }

        private void updateGraph()
        {

            if (this.checkBoxEMC.Checked == true)
            {
                myCurveEmc.IsVisible = true;
            }
            else
            {
                myCurveEmc.IsVisible = false;
            }

            if (this.checkBoxMC.Checked == true)
            {
                myCurveMc.IsVisible = true;
            }
            else
            {
                myCurveMc.IsVisible = false;
            }

            if (this.checkBoxTA.Checked == true)
            {
                myCurveTa.IsVisible = true;
            }
            else
            {
                myCurveTa.IsVisible = false;
            }

            if (this.checkBoxTW.Checked == true)
            {
                myCurveTw.IsVisible = true;
            }
            else
            {
                myCurveTw.IsVisible = false;
            }




            // Tell ZedGraph to refigure the
            // axes since the data have changed
            this.zedGraphControlHistoryDisplay.AxisChange();


            // Size the control to fill the form with a margin
            zedGraphControlHistoryDisplay.Location = new Point(10, 10);
            // Leave a small margin around the outside of the control
            zedGraphControlHistoryDisplay.Size = new Size(panel2.Width - 20,
                                    panel2.Height - 20);

            zedGraphControlHistoryDisplay.Refresh();
        }

        private void checkBoxEMC_CheckedChanged(object sender, EventArgs e)
        {
            updateGraph();
        }

        private void checkBoxTA_CheckedChanged(object sender, EventArgs e)
        {
            updateGraph();
        }

        private void checkBoxTW_CheckedChanged(object sender, EventArgs e)
        {
            updateGraph();
        }

        private void backgroundUpdaterThread_DoWork(object sender, DoWorkEventArgs e)
        {
            //this.treeViewExistingData.Invoke(new GetNode(getNode), new object[] { "sss" });


            while (true)
            {
                try
                {

                    Thread.Sleep(300000);

                    Console.WriteLine("DataUpdater is running.");

                    StreamReader rawDataFile = File.OpenText(MainForm.RAW_DATA_FILE);
                    string processedData = null, processedDateTimeMilli = null;

                    string input = null;
                    while ((input = rawDataFile.ReadLine()) != null)
                    {
                        String data = "";
                        try
                        {
                            if (input.Contains("- "))
                            {
                                logger.Debug("Found start of data:" + input);
                                data = input;

                                String dateTimeMilli = "", dateTime = "";

                                string[] items = data.Trim().Split(',', '[');
                                if (items.Length > 1)
                                {
                                    dateTimeMilli = items[0];
                                    dateTime = items[1].Trim();
                                }

                                int startIndex = data.IndexOf("- ");
                                int endIndex = data.IndexOf("]");
                                data = data.Substring(startIndex + 1, endIndex - startIndex - 1);

                                data = data + MainForm.processLine(rawDataFile.ReadLine());
                                data = data + MainForm.processLine(rawDataFile.ReadLine());
                                data = data + MainForm.processLine(rawDataFile.ReadLine());

                                string[] items1 = data.Trim().Split(' ');
                                data = "";
                                foreach (string s in items1)
                                {
                                    if (s.Length > 0)
                                    {
                                        data = data + "," + s;
                                    }

                                }

                                data = dateTimeMilli + "," + dateTime + data;
                                logger.Debug("data:" + data);

                                try
                                {
                                    StreamWriter writer = new StreamWriter(MainForm.BACKUP_DATA_STORE, true);
                                    writer.WriteLine(data);
                                    writer.Close();

                                    processedData = data;
                                    processedDateTimeMilli = dateTimeMilli;
                                }
                                catch (Exception ex)
                                {
                                    logger.Error("Exception writing to file: " + ex.Message);
                                }
                            } // end of IF
                        }
                        catch (Exception eff)
                        {
                            logger.Info(eff.Message);
                        }
                    }

                    try
                    {
                        rawDataFile.Close();
                    }
                    catch (Exception ex)
                    {
                        logger.Error("Exception closing to file: " + ex.Message);
                    }

                    // attempts to delete the file
                    for (int i = 0; i < 5; i++)
                    {

                        try
                        {
                            StreamWriter writer = new StreamWriter(MainForm.RAW_DATA_FILE, false);
                            writer.WriteLine("");
                            writer.Close();

                            break;
                        }
                        catch (Exception ex)
                        {
                            logger.Error("Exception writing to file: " + ex.Message);
                        }

                        Thread.Sleep(100);
                    }

                    if (processedData == null)
                    {
                        logger.Debug("No data to process");
                        continue;
                    }

                    // now we need to get last modified file on file system
                    DirectoryInfo di = new DirectoryInfo(MainForm.DATA_FILES_LOCATION);
                    FileSystemInfo[] files = di.GetFileSystemInfos();
                    Array.Sort<FileSystemInfo>(files, delegate(FileSystemInfo a, FileSystemInfo b)
                    {
                        return a.LastWriteTime.CompareTo(b.LastWriteTime);
                    });

                    long dateTicks = Convert.ToInt64(processedDateTimeMilli);
                    DateTime dateTimeOfThisRecord = new DateTime(dateTicks);

                    FileSystemInfo lastModifiedDataFile = files[files.Length - 1];
                    logger.Debug("LastWriteTime: " + lastModifiedDataFile.LastWriteTime + "(" + lastModifiedDataFile.LastWriteTime.Ticks + ")" + ". processedDateTimeMilli: " + dateTimeOfThisRecord + "(" + processedDateTimeMilli + ")" );

                    TimeSpan t = TimeSpan.FromHours(1.3);


                    if (lastModifiedDataFile.LastWriteTime.Ticks + t.Ticks > dateTicks)
                    {
                        logger.Debug("Found existing file name: " + lastModifiedDataFile.Name + " which will be used to write data: " + processedData);

                        try
                        {
                            StreamWriter writer = new StreamWriter(MainForm.DATA_FILES_LOCATION + lastModifiedDataFile.Name, true);
                            writer.WriteLine(processedData);
                            writer.Close();
                        }
                        catch (Exception ex)
                        {
                            logger.Error("Exception writing to file: " + lastModifiedDataFile.Name + "." + ex.Message);
                        }

                        this.treeViewExistingData.Invoke(new TreeViewExistingData(treeViewExistingData_AfterSelect), new object[] { null, null });
                    }
                    else
                    {   // create a new file
                        //DateTime thisDateFileName = DateTime.Now;
                        String fileName1 = dateTimeOfThisRecord.ToString("yyyy dd MMM h-mm tt");

                        try
                        {
                            StreamWriter writer = new StreamWriter(MainForm.DATA_FILES_LOCATION + fileName1 + ".dat", true);
                            writer.WriteLine(processedData);
                            writer.Close();
                        }
                        catch (Exception ex)
                        {
                            logger.Error("Exception writing to file: " + ex.Message);
                        }

                        TreeNode newNode = new TreeNode();
                        newNode.Name = MainForm.DATA_FILES_LOCATION + fileName1 + ".dat";

                        int index = fileName1.IndexOf(" ");
                        String year = fileName1.Substring(0, index);
                        year = year.Trim();
                        String displayName = fileName1.Substring(index);
                        displayName = displayName.Replace("-", ":");
                        newNode.Text = displayName;

                        TreeNode rootNode = (TreeNode)this.treeViewExistingData.Invoke(new GetNode(getNode), new object[] { year });
                        this.treeViewExistingData.Invoke(new AddNode(addNode), new object[] { rootNode, newNode });
                    }
                }
                catch (Exception ex)
                {
                    logger.Error("Exception writing to file: " + ex.Message);
                }
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}




