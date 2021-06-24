using System;
using System.Text;
using System.Drawing;
using System.IO.Ports;
using System.Windows.Forms;

using System.IO;

using TemperatureMonitor;

using log4net;
using log4net.Config;
using System.Text.RegularExpressions;
//*****************************************************************************************
//                           LICENSE INFORMATION
//*****************************************************************************************
//   PCCom.SerialCommunication Version 1.0.0.0
//   Class file for managing serial port communication
//
//   Copyright (C) 2007  
//   Richard L. McCutchen 
//   Email: richard@psychocoder.net
//   Created: 20OCT07
//
//   This program is free software: you can redistribute it and/or modify
//   it under the terms of the GNU General Public License as published by
//   the Free Software Foundation, either version 3 of the License, or
//   (at your option) any later version.
//
//   This program is distributed in the hope that it will be useful,
//   but WITHOUT ANY WARRANTY; without even the implied warranty of
//   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//   GNU General Public License for more details.
//
//   You should have received a copy of the GNU General Public License
//   along with this program.  If not, see <http://www.gnu.org/licenses/>.
//*****************************************************************************************
namespace PCComm
{
    public class CommunicationManager
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(CommunicationManager));

        public delegate void DataReceivedHandler(String rawData, FileDataReader receivedData);
        public event DataReceivedHandler DataReceived;

        public delegate void COMStatusHandler(String message);
        public event COMStatusHandler COMStatus;


        Boolean trackData = false;
        FileDataReader data = new FileDataReader();

        #region Manager Enums
        /// <summary>
        /// enumeration to hold our transmission types
        /// </summary>
        public enum TransmissionType { Text, Hex }

        /// <summary>
        /// enumeration to hold our message types
        /// </summary>
        public enum MessageType { Incoming, Outgoing, Normal, Warning, Error };
        #endregion

        #region Manager Variables
        //property variables
        private string _baudRate = string.Empty;
        private string _parity = string.Empty;
        private string _stopBits = string.Empty;
        private string _dataBits = string.Empty;
        private string _portName = string.Empty;
        private TransmissionType _transType;
        private RichTextBox _displayWindow;
        //global manager variables
        private Color[] MessageColor = { Color.Blue, Color.Green, Color.Black, Color.Orange, Color.Red };
        private SerialPort comPort = new SerialPort();

        #endregion

        #region Manager Properties
        /// <summary>
        /// Property to hold the BaudRate
        /// of our manager class
        /// </summary>
        public string BaudRate
        {
            get { return _baudRate; }
            set { _baudRate = value; }
        }

        /// <summary>
        /// property to hold the Parity
        /// of our manager class
        /// </summary>
        public string Parity
        {
            get { return _parity; }
            set { _parity = value; }
        }

        /// <summary>
        /// property to hold the StopBits
        /// of our manager class
        /// </summary>
        public string StopBits
        {
            get { return _stopBits; }
            set { _stopBits = value; }
        }

        /// <summary>
        /// property to hold the DataBits
        /// of our manager class
        /// </summary>
        public string DataBits
        {
            get { return _dataBits; }
            set { _dataBits = value; }
        }

        /// <summary>
        /// property to hold the PortName
        /// of our manager class
        /// </summary>
        public string PortName
        {
            get { return _portName; }
            set { _portName = value; }
        }

        /// <summary>
        /// property to hold our TransmissionType
        /// of our manager class
        /// </summary>
        public TransmissionType CurrentTransmissionType
        {
            get { return _transType; }
            set { _transType = value; }
        }

        /// <summary>
        /// property to hold our display window
        /// value
        /// </summary>
        public RichTextBox DisplayWindow
        {
            get { return _displayWindow; }
            set { _displayWindow = value; }
        }
        #endregion

        #region Manager Constructors
        /// <summary>
        /// Constructor to set the properties of our Manager Class
        /// </summary>
        /// <param name="baud">Desired BaudRate</param>
        /// <param name="par">Desired Parity</param>
        /// <param name="sBits">Desired StopBits</param>
        /// <param name="dBits">Desired DataBits</param>
        /// <param name="name">Desired PortName</param>
        public CommunicationManager(string baud, string par, string sBits, string dBits, string name, RichTextBox rtb)
        {
            logger.Debug("Entering CommunicationManager ctor. baud: " + baud + ". par: " + par + ", sBits" + dBits + ", name:" + name + ", rtb: " + rtb);

            _baudRate = baud;
            _parity = par;
            _stopBits = sBits;
            _dataBits = dBits;
            _portName = name;
            _displayWindow = rtb;
            //now add an event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);

            logger.Debug("Exiting CommunicationManager ctor. baud: " + baud + ". par: " + par + ", sBits" + dBits + ", name:" + name + ", rtb: " + rtb);
        }

        /// <summary>
        /// Comstructor to set the properties of our
        /// serial port communicator to nothing
        /// </summary>
        public CommunicationManager()
        {
            logger.Debug("Entering CommunicationManager ctor.");

            _baudRate = string.Empty;
            _parity = string.Empty;
            _stopBits = string.Empty;
            _dataBits = string.Empty;
            _portName = string.Empty;
            _displayWindow = null;
            //add event handler
            comPort.DataReceived += new SerialDataReceivedEventHandler(comPort_DataReceived);

            logger.Debug("Exiting CommunicationManager ctor.");
        }
        #endregion

        #region WriteData
        public void WriteData(string msg)
        {
            switch (CurrentTransmissionType)
            {
                case TransmissionType.Text:
                    //first make sure the port is open
                    //if its not open then open it
                    if (!(comPort.IsOpen == true)) comPort.Open();
                    //send the message to the port
                    comPort.Write(msg);
                    //display the message
                    DisplayData(MessageType.Outgoing, msg + "\n");
                    break;
                case TransmissionType.Hex:
                    try
                    {
                        //convert the message to byte array
                        byte[] newMsg = HexToByte(msg);
                        //send the message to the port
                        comPort.Write(newMsg, 0, newMsg.Length);
                        //convert back to hex and display
                        DisplayData(MessageType.Outgoing, ByteToHex(newMsg) + "\n");
                    }
                    catch (FormatException ex)
                    {
                        //display error message
                        DisplayData(MessageType.Error, ex.Message);
                    }
                    finally
                    {
                        _displayWindow.SelectAll();
                    }
                    break;
                default:
                    //first make sure the port is open
                    //if its not open then open it
                    if (!(comPort.IsOpen == true)) comPort.Open();
                    //send the message to the port
                    comPort.Write(msg);
                    //display the message
                    DisplayData(MessageType.Outgoing, msg + "\n");
                    break;
                    break;
            }
        }
        #endregion

        #region HexToByte
        /// <summary>
        /// method to convert hex string into a byte array
        /// </summary>
        /// <param name="msg">string to convert</param>
        /// <returns>a byte array</returns>
        private byte[] HexToByte(string msg)
        {
            //remove any spaces from the string
            msg = msg.Replace(" ", "");
            //create a byte array the length of the
            //divided by 2 (Hex is 2 characters in length)
            byte[] comBuffer = new byte[msg.Length / 2];
            //loop through the length of the provided string
            for (int i = 0; i < msg.Length; i += 2)
                //convert each set of 2 characters to a byte
                //and add to the array
                comBuffer[i / 2] = (byte)Convert.ToByte(msg.Substring(i, 2), 16);
            //return the array
            return comBuffer;
        }
        #endregion

        #region ByteToHex
        /// <summary>
        /// method to convert a byte array into a hex string
        /// </summary>
        /// <param name="comByte">byte array to convert</param>
        /// <returns>a hex string</returns>
        private string ByteToHex(byte[] comByte)
        {
            //create a new StringBuilder object
            StringBuilder builder = new StringBuilder(comByte.Length * 3);
            //loop through each byte in the array
            foreach (byte data in comByte)
                //convert the byte to a string and add to the stringbuilder
                builder.Append(Convert.ToString(data, 16).PadLeft(2, '0').PadRight(3, ' '));
            //return the converted value
            return builder.ToString().ToUpper();
        }
        #endregion

        #region DisplayData
        /// <summary>
        /// method to display the data to & from the port
        /// on the screen
        /// </summary>
        /// <param name="type">MessageType of the message</param>
        /// <param name="msg">Message to display</param>
        [STAThread]
        private void DisplayData(MessageType type, string msg)
        {
            /*_displayWindow.Invoke(new EventHandler(delegate
        {
            _displayWindow.SelectedText = string.Empty;
            _displayWindow.SelectionFont = new Font(_displayWindow.SelectionFont, FontStyle.Bold);
            _displayWindow.SelectionColor = MessageColor[(int)type];
            _displayWindow.AppendText(msg);
            _displayWindow.ScrollToCaret();
        }));*/
        }
        #endregion

        #region OpenPort
        public bool OpenPort()
        {
           // this.COMStatus("Connecting to COM Port: " + comPort.PortName);

            try
            {
                //first check if the port is already open
                //if its open then close it
                if (comPort.IsOpen == true) comPort.Close();

                //set the properties of our SerialPort Object
                comPort.BaudRate = int.Parse(_baudRate);    //BaudRate
                comPort.DataBits = int.Parse(_dataBits);    //DataBits
                comPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), _stopBits);    //StopBits
                comPort.Parity = (Parity)Enum.Parse(typeof(Parity), _parity);    //Parity
                comPort.PortName = this._portName;   //PortName

                comPort.Handshake = Handshake.RequestToSendXOnXOff;
                //comPort.
                //comPort.RT
                
               // comPort.


                //now open the port
                comPort.Open();
                //display message
                //DisplayData(MessageType.Normal, "Port opened at " + DateTime.Now + "\n");
                //return true

                //this.COMStatus("Connected to COM Port: " + comPort.PortName);
                return true;
            }
            catch (Exception ex)
            {
                DisplayData(MessageType.Error, ex.Message);
                this.COMStatus("Cannot connect to COM Port: " + comPort.PortName + ". " + ex.Message);
                return false;
            }

           // this.COMStatus("Connected to COM Port: " + comPort.PortName);
        }
        #endregion

        #region SetParityValues
        public void SetParityValues(object obj)
        {
            foreach (string str in Enum.GetNames(typeof(Parity)))
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region SetStopBitValues
        public void SetStopBitValues(object obj)
        {
            foreach (string str in Enum.GetNames(typeof(StopBits)))
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        #region SetPortNameValues
        public void SetPortNameValues(object obj)
        {

            foreach (string str in SerialPort.GetPortNames())
            {
                ((ComboBox)obj).Items.Add(str);
            }
        }
        #endregion

        private FileDataReader parseData(String receivedData)
        {

            FileDataReader dataReceived = new FileDataReader();
            dataReceived.DateTime = DateTime.Now;

            /*
            try
            {
                string[] items = data.Trim().Split(',');

                if (items.Length > 1)
                {
                    long dateTicks = Convert.ToInt64(items[1]);
                    date = new DateTime(dateTicks);
                    tw = Convert.ToDouble(items[2]);
                    ta = Convert.ToDouble(items[3]);
                    mc = Convert.ToDouble(items[4]);
                    t1 = Convert.ToDouble(items[5]);
                    t2 = Convert.ToDouble(items[6]);
                    tn = Convert.ToDouble(items[7]);
                    emc = Convert.ToDouble(items[8]);
                    e1 = Convert.ToDouble(items[9]);
                    e2 = Convert.ToDouble(items[10]);
                    phase = Convert.ToInt16(items[11]);
                }
            }
            catch (Exception ex)
            {
                logger.Error("Exception reading data: " + ex.Message);
            }

            */




            return dataReceived;
        }


        private double getDataFromIndex(int index, String[] items)
        {
            double retValue = 0;
            try
            {
                if (items.Length > index)
                {
                    String value = items[index];
                    value = value.Replace("*", "");
                    value = value.Trim();

                    if (value != null && value.Length > 0)
                    {
                        retValue = Convert.ToDouble(value);
                    }
                }
            }
            catch (Exception ex)
            {
                logger.Warn("Exception reading value " + ex.Message);
            }

            return retValue;
        }

        #region comPort_DataReceived
        /// <summary>
        /// method that will be called when theres data waiting in the buffer
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void comPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            logger.Debug("Entering comPort_DataReceived.");

            System.Threading.Thread.Sleep(200);

            string message = "";
            //CurrentTransmissionType = TransmissionType.Hex;
            switch (CurrentTransmissionType)
            {
                //user chose string
                case TransmissionType.Text:
                    //read data waiting in the buffer

                    logger.Info(comPort.BytesToRead + " bytesToRead [" + message + "]");
                    logger.Info( comPort.BaudRate + "|" + comPort.BytesToRead + "|" + comPort.ReadBufferSize + "|" + comPort.ReadTimeout + "|" + comPort.ReceivedBytesThreshold + "|");

                    message = comPort.ReadExisting();

                    logger.Info(comPort.BytesToRead + " bytesToRead [" + message + "]");

                    break;
                //user chose binary
                case TransmissionType.Hex:
                    //retrieve number of bytes in the buffer
                    int bytes = comPort.BytesToRead;
                    //create a byte array to hold the awaiting data
                    byte[] comBuffer = new byte[bytes];
                    //read the data and store it
                    comPort.Read(comBuffer, 0, bytes);

                    message = ByteToHex(comBuffer);

                    logger.Info("[" + message + "]");
                    break;
                default:
                    //read data waiting in the buffer
                    message = comPort.ReadExisting();
                    //display the data to the user
                    logger.Info("[" + message + "]");
                    break;
            }
           
            try
            {
                String messageToSave = DateTime.Now.ToString() + DateTime.Now.Millisecond + "   [";
                messageToSave += message.Replace('\t', ',');
                messageToSave = messageToSave.Replace('\n', 'N');
                messageToSave = messageToSave.Replace('\r', 'R');
                messageToSave = messageToSave.Replace('\v', 'V');
                messageToSave += "]";

                bool writeFile = false;
                if (message.Contains("-"))
                {
                    writeFile = true;
                }
                if (message.Contains("0"))
                {
                    writeFile = true;
                }
                if (message.Contains("1"))
                {
                    writeFile = true;
                }
                if (message.Contains("2"))
                {
                    writeFile = true;
                }
                if (message.Contains("3"))
                {
                    writeFile = true;
                }
                if (message.Contains("4"))
                {
                    writeFile = true;
                }
                if (message.Contains("5"))
                {
                    writeFile = true;
                }
                if (message.Contains("6"))
                {
                    writeFile = true;
                }
                if (message.Contains("7"))
                {
                    writeFile = true;
                }
                if (message.Contains("8"))
                {
                    writeFile = true;
                }
                if (message.Contains("9"))
                {
                    writeFile = true;
                }

                logger.Info(comPort.BytesToRead + " bytesToRead [" + message + "]");
                logger.Info("writeFile: " + writeFile);

                if (writeFile == true)
                {
                    StreamWriter writer = new StreamWriter("c:\\DataFiles\\RawData.txt", true);
                    writer.WriteLine(DateTime.Now.Ticks + "," + DateTime.Now.ToString() + DateTime.Now.Millisecond + "   [" + message + "]");
                    writer.Close();
                }

                try
                {
                    string msg = Regex.Replace(message, @"/.?()>[^0-9a-zA-Z:,]+ ", "");
                    StreamWriter writer = new StreamWriter("c:\\DataFiles\\AllTheDataRawData.txt", true);
                    writer.WriteLine(DateTime.Now.Ticks + "," + DateTime.Now.ToString() + DateTime.Now.Millisecond + "   [" + msg + "]");
                    writer.Close();
                }
                catch (Exception ex)
                {

                }

            }
            catch( Exception ex )
            {
                logger.Error("Exception writing to file: " + ex.Message );
            }

       

            //String messageT



          //  if (this.trackData == true)
            //{
                string[] items = message.Split('\t');
                
                data.DateTime = DateTime.Now;
                int i = 0;

               /* data.E1 = getDataFromIndex(4, items);
                data.E2 = getDataFromIndex(13, items);
                data.MC = getDataFromIndex(4, items);
                data.TN = getDataFromIndex(1, items);
                data.T1 = getDataFromIndex(4, items);
                data.T2 = getDataFromIndex(15, items);
                data.EMC = getDataFromIndex(63, items);*/

                this.DataReceived(message, data);
           
       /*     }
            else if (message.Contains("MC        FS       M1       M5       Ph"))
            {
                logger.Info("Tracking data, we received data: " + message);

                string[] items = message.Trim().Split('\t');

                this.DataReceived(data);

                this.trackData = true;
            }
                */
            logger.Debug("Exiting comPort_DataReceived.");
        }
        #endregion
    }
}
