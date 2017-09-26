namespace TemperatureMonitor
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBoxBatchId = new System.Windows.Forms.TextBox();
            this.textBoxMCWhenFinished = new System.Windows.Forms.TextBox();
            this.textBoxtEMPwOOD = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxEMCWhenFinished = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTempAirWhenFinished = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxStartTimeHistory = new System.Windows.Forms.TextBox();
            this.textBoxDurationHistory = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.tabControl3 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.zedGraphControlHistoryDisplay = new ZedGraph.ZedGraphControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridViewHistory = new System.Windows.Forms.DataGridView();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.treeViewExistingData = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.cboData = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboStop = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboParity = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cboBaud = new System.Windows.Forms.ComboBox();
            this.cboPort = new System.Windows.Forms.ComboBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serialPortOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.parseRawDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.checkBoxMC = new System.Windows.Forms.CheckBox();
            this.checkBoxEMC = new System.Windows.Forms.CheckBox();
            this.checkBoxTA = new System.Windows.Forms.CheckBox();
            this.checkBoxTW = new System.Windows.Forms.CheckBox();
            this.receivedDataTypeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.buttonSaveBatchId = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2.SuspendLayout();
            this.tabControl3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDataTypeBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.textBoxStartTimeHistory);
            this.groupBox2.Controls.Add(this.textBoxMCWhenFinished);
            this.groupBox2.Controls.Add(this.textBoxtEMPwOOD);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.textBoxEMCWhenFinished);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.textBoxTempAirWhenFinished);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.textBoxDurationHistory);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(208, 27);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(977, 108);
            this.groupBox2.TabIndex = 30;
            this.groupBox2.TabStop = false;
            // 
            // textBoxBatchId
            // 
            this.textBoxBatchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxBatchId.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxBatchId.Location = new System.Drawing.Point(6, 25);
            this.textBoxBatchId.Name = "textBoxBatchId";
            this.textBoxBatchId.Size = new System.Drawing.Size(164, 24);
            this.textBoxBatchId.TabIndex = 33;
            // 
            // textBoxMCWhenFinished
            // 
            this.textBoxMCWhenFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxMCWhenFinished.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxMCWhenFinished.Location = new System.Drawing.Point(415, 60);
            this.textBoxMCWhenFinished.Name = "textBoxMCWhenFinished";
            this.textBoxMCWhenFinished.ReadOnly = true;
            this.textBoxMCWhenFinished.Size = new System.Drawing.Size(76, 24);
            this.textBoxMCWhenFinished.TabIndex = 32;
            // 
            // textBoxtEMPwOOD
            // 
            this.textBoxtEMPwOOD.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxtEMPwOOD.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxtEMPwOOD.Location = new System.Drawing.Point(672, 61);
            this.textBoxtEMPwOOD.Name = "textBoxtEMPwOOD";
            this.textBoxtEMPwOOD.ReadOnly = true;
            this.textBoxtEMPwOOD.Size = new System.Drawing.Size(89, 24);
            this.textBoxtEMPwOOD.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(357, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "MC:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 29);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 20);
            this.label4.TabIndex = 31;
            this.label4.Text = "EMC:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxEMCWhenFinished
            // 
            this.textBoxEMCWhenFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxEMCWhenFinished.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxEMCWhenFinished.Location = new System.Drawing.Point(415, 28);
            this.textBoxEMCWhenFinished.Name = "textBoxEMCWhenFinished";
            this.textBoxEMCWhenFinished.ReadOnly = true;
            this.textBoxEMCWhenFinished.Size = new System.Drawing.Size(76, 24);
            this.textBoxEMCWhenFinished.TabIndex = 24;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(514, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 20);
            this.label2.TabIndex = 22;
            this.label2.Text = "Temp Wood (TW):";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxTempAirWhenFinished
            // 
            this.textBoxTempAirWhenFinished.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxTempAirWhenFinished.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxTempAirWhenFinished.Location = new System.Drawing.Point(644, 27);
            this.textBoxTempAirWhenFinished.Name = "textBoxTempAirWhenFinished";
            this.textBoxTempAirWhenFinished.ReadOnly = true;
            this.textBoxTempAirWhenFinished.Size = new System.Drawing.Size(89, 24);
            this.textBoxTempAirWhenFinished.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(514, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Temp Air (TA):";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 20);
            this.label10.TabIndex = 0;
            this.label10.Text = "Start Time:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxStartTimeHistory
            // 
            this.textBoxStartTimeHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxStartTimeHistory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxStartTimeHistory.Location = new System.Drawing.Point(105, 25);
            this.textBoxStartTimeHistory.Name = "textBoxStartTimeHistory";
            this.textBoxStartTimeHistory.ReadOnly = true;
            this.textBoxStartTimeHistory.Size = new System.Drawing.Size(223, 24);
            this.textBoxStartTimeHistory.TabIndex = 1;
            // 
            // textBoxDurationHistory
            // 
            this.textBoxDurationHistory.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxDurationHistory.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.textBoxDurationHistory.Location = new System.Drawing.Point(105, 61);
            this.textBoxDurationHistory.Name = "textBoxDurationHistory";
            this.textBoxDurationHistory.ReadOnly = true;
            this.textBoxDurationHistory.Size = new System.Drawing.Size(223, 24);
            this.textBoxDurationHistory.TabIndex = 19;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(11, 65);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.TabIndex = 17;
            this.label13.Text = "Duration:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label13.Click += new System.EventHandler(this.label13_Click);
            // 
            // tabControl3
            // 
            this.tabControl3.Controls.Add(this.tabPage3);
            this.tabControl3.Controls.Add(this.tabPage4);
            this.tabControl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl3.Location = new System.Drawing.Point(208, 141);
            this.tabControl3.Name = "tabControl3";
            this.tabControl3.SelectedIndex = 0;
            this.tabControl3.Size = new System.Drawing.Size(977, 735);
            this.tabControl3.TabIndex = 29;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel2);
            this.tabPage3.Location = new System.Drawing.Point(4, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(969, 704);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Graph Display";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.zedGraphControlHistoryDisplay);
            this.panel2.Location = new System.Drawing.Point(3, 6);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(970, 692);
            this.panel2.TabIndex = 22;
            // 
            // zedGraphControlHistoryDisplay
            // 
            this.zedGraphControlHistoryDisplay.BackColor = System.Drawing.Color.Transparent;
            this.zedGraphControlHistoryDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zedGraphControlHistoryDisplay.Location = new System.Drawing.Point(0, 3);
            this.zedGraphControlHistoryDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.zedGraphControlHistoryDisplay.Name = "zedGraphControlHistoryDisplay";
            this.zedGraphControlHistoryDisplay.ScrollGrace = 0D;
            this.zedGraphControlHistoryDisplay.ScrollMaxX = 0D;
            this.zedGraphControlHistoryDisplay.ScrollMaxY = 0D;
            this.zedGraphControlHistoryDisplay.ScrollMaxY2 = 0D;
            this.zedGraphControlHistoryDisplay.ScrollMinX = 0D;
            this.zedGraphControlHistoryDisplay.ScrollMinY = 0D;
            this.zedGraphControlHistoryDisplay.ScrollMinY2 = 0D;
            this.zedGraphControlHistoryDisplay.Size = new System.Drawing.Size(967, 689);
            this.zedGraphControlHistoryDisplay.TabIndex = 21;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridViewHistory);
            this.tabPage4.Controls.Add(this.richTextBox2);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Location = new System.Drawing.Point(4, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(969, 704);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Detail Display";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridViewHistory
            // 
            this.dataGridViewHistory.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.LightSkyBlue;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.RoyalBlue;
            this.dataGridViewHistory.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewHistory.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewHistory.Location = new System.Drawing.Point(3, 6);
            this.dataGridViewHistory.MultiSelect = false;
            this.dataGridViewHistory.Name = "dataGridViewHistory";
            this.dataGridViewHistory.ReadOnly = true;
            this.dataGridViewHistory.Size = new System.Drawing.Size(960, 692);
            this.dataGridViewHistory.TabIndex = 13;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(831, 503);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(121, 34);
            this.richTextBox2.TabIndex = 12;
            this.richTextBox2.Text = "";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(972, 485);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 57);
            this.button2.TabIndex = 11;
            this.button2.Text = "Send";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // treeViewExistingData
            // 
            this.treeViewExistingData.BackColor = System.Drawing.Color.LightBlue;
            this.treeViewExistingData.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeViewExistingData.Location = new System.Drawing.Point(0, 27);
            this.treeViewExistingData.Name = "treeViewExistingData";
            this.treeViewExistingData.Size = new System.Drawing.Size(202, 541);
            this.treeViewExistingData.TabIndex = 28;
            this.treeViewExistingData.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeViewExistingData_AfterSelect);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Data Bits";
            // 
            // cboData
            // 
            this.cboData.FormattingEnabled = true;
            this.cboData.Items.AddRange(new object[] {
            "7",
            "8",
            "9"});
            this.cboData.Location = new System.Drawing.Point(9, 195);
            this.cboData.Name = "cboData";
            this.cboData.Size = new System.Drawing.Size(76, 21);
            this.cboData.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Stop Bits";
            // 
            // cboStop
            // 
            this.cboStop.FormattingEnabled = true;
            this.cboStop.Location = new System.Drawing.Point(9, 155);
            this.cboStop.Name = "cboStop";
            this.cboStop.Size = new System.Drawing.Size(76, 21);
            this.cboStop.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Parity";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Baud Rate";
            // 
            // cboParity
            // 
            this.cboParity.FormattingEnabled = true;
            this.cboParity.Location = new System.Drawing.Point(9, 114);
            this.cboParity.Name = "cboParity";
            this.cboParity.Size = new System.Drawing.Size(76, 21);
            this.cboParity.TabIndex = 12;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 13);
            this.label9.TabIndex = 15;
            this.label9.Text = "Port";
            // 
            // cboBaud
            // 
            this.cboBaud.FormattingEnabled = true;
            this.cboBaud.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "28800",
            "36000",
            "115000"});
            this.cboBaud.Location = new System.Drawing.Point(9, 74);
            this.cboBaud.Name = "cboBaud";
            this.cboBaud.Size = new System.Drawing.Size(76, 21);
            this.cboBaud.TabIndex = 11;
            // 
            // cboPort
            // 
            this.cboPort.FormattingEnabled = true;
            this.cboPort.Location = new System.Drawing.Point(9, 34);
            this.cboPort.Name = "cboPort";
            this.cboPort.Size = new System.Drawing.Size(76, 21);
            this.cboPort.TabIndex = 10;
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolsToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1197, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "Tools";
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serialPortOptionsToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.parseRawDataToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.toolsToolStripMenuItem.Text = "Options";
            // 
            // serialPortOptionsToolStripMenuItem
            // 
            this.serialPortOptionsToolStripMenuItem.Name = "serialPortOptionsToolStripMenuItem";
            this.serialPortOptionsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.serialPortOptionsToolStripMenuItem.Text = "Serial Port Options";
            this.serialPortOptionsToolStripMenuItem.Click += new System.EventHandler(this.serialPortOptionsToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // parseRawDataToolStripMenuItem
            // 
            this.parseRawDataToolStripMenuItem.Name = "parseRawDataToolStripMenuItem";
            this.parseRawDataToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.parseRawDataToolStripMenuItem.Text = "ParseRawData";
            this.parseRawDataToolStripMenuItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.LawnGreen;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 879);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1197, 22);
            this.statusStrip.TabIndex = 2;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 17);
            // 
            // checkBoxMC
            // 
            this.checkBoxMC.AutoSize = true;
            this.checkBoxMC.Checked = true;
            this.checkBoxMC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxMC.Location = new System.Drawing.Point(12, 601);
            this.checkBoxMC.Name = "checkBoxMC";
            this.checkBoxMC.Size = new System.Drawing.Size(107, 21);
            this.checkBoxMC.TabIndex = 23;
            this.checkBoxMC.Text = "Display MC";
            this.checkBoxMC.UseVisualStyleBackColor = true;
            this.checkBoxMC.CheckedChanged += new System.EventHandler(this.checkBoxMC_CheckedChanged);
            // 
            // checkBoxEMC
            // 
            this.checkBoxEMC.AutoSize = true;
            this.checkBoxEMC.Checked = true;
            this.checkBoxEMC.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxEMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxEMC.Location = new System.Drawing.Point(12, 574);
            this.checkBoxEMC.Name = "checkBoxEMC";
            this.checkBoxEMC.Size = new System.Drawing.Size(117, 21);
            this.checkBoxEMC.TabIndex = 31;
            this.checkBoxEMC.Text = "Display EMC";
            this.checkBoxEMC.UseVisualStyleBackColor = true;
            this.checkBoxEMC.CheckedChanged += new System.EventHandler(this.checkBoxEMC_CheckedChanged);
            // 
            // checkBoxTA
            // 
            this.checkBoxTA.AutoSize = true;
            this.checkBoxTA.Checked = true;
            this.checkBoxTA.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTA.Location = new System.Drawing.Point(12, 628);
            this.checkBoxTA.Name = "checkBoxTA";
            this.checkBoxTA.Size = new System.Drawing.Size(187, 21);
            this.checkBoxTA.TabIndex = 32;
            this.checkBoxTA.Text = "Display TA (Air Temp)";
            this.checkBoxTA.UseVisualStyleBackColor = true;
            this.checkBoxTA.CheckedChanged += new System.EventHandler(this.checkBoxTA_CheckedChanged);
            // 
            // checkBoxTW
            // 
            this.checkBoxTW.AutoSize = true;
            this.checkBoxTW.Checked = true;
            this.checkBoxTW.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxTW.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTW.Location = new System.Drawing.Point(12, 655);
            this.checkBoxTW.Name = "checkBoxTW";
            this.checkBoxTW.Size = new System.Drawing.Size(212, 21);
            this.checkBoxTW.TabIndex = 33;
            this.checkBoxTW.Text = "Display TW (Wood Temp)";
            this.checkBoxTW.UseVisualStyleBackColor = true;
            this.checkBoxTW.CheckedChanged += new System.EventHandler(this.checkBoxTW_CheckedChanged);
            // 
            // receivedDataTypeBindingSource
            // 
            this.receivedDataTypeBindingSource.DataSource = typeof(DataTypes.ReceivedDataType);
            // 
            // buttonSaveBatchId
            // 
            this.buttonSaveBatchId.BackColor = System.Drawing.Color.Black;
            this.buttonSaveBatchId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSaveBatchId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSaveBatchId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.buttonSaveBatchId.Location = new System.Drawing.Point(38, 55);
            this.buttonSaveBatchId.Name = "buttonSaveBatchId";
            this.buttonSaveBatchId.Size = new System.Drawing.Size(96, 39);
            this.buttonSaveBatchId.TabIndex = 35;
            this.buttonSaveBatchId.Text = "Save";
            this.buttonSaveBatchId.UseVisualStyleBackColor = false;
            this.buttonSaveBatchId.Click += new System.EventHandler(this.buttonSaveBatchId_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxBatchId);
            this.groupBox1.Controls.Add(this.buttonSaveBatchId);
            this.groupBox1.Location = new System.Drawing.Point(767, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(176, 100);
            this.groupBox1.TabIndex = 36;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Batch Number";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1197, 901);
            this.Controls.Add(this.checkBoxTW);
            this.Controls.Add(this.tabControl3);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.checkBoxTA);
            this.Controls.Add(this.checkBoxMC);
            this.Controls.Add(this.checkBoxEMC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.treeViewExistingData);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Drying Kiln Monitor ";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabControl3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHistory)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.receivedDataTypeBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboData;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cboStop;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboParity;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cboBaud;
        private System.Windows.Forms.ComboBox cboPort;
        private System.Windows.Forms.BindingSource receivedDataTypeBindingSource;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serialPortOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TreeView treeViewExistingData;
        private System.Windows.Forms.TabControl tabControl3;
        private System.Windows.Forms.TabPage tabPage3;
        private ZedGraph.ZedGraphControl zedGraphControlHistoryDisplay;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridViewHistory;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxStartTimeHistory;
        private System.Windows.Forms.TextBox textBoxDurationHistory;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem parseRawDataToolStripMenuItem;
        private System.Windows.Forms.CheckBox checkBoxMC;
        private System.Windows.Forms.CheckBox checkBoxEMC;
        private System.Windows.Forms.CheckBox checkBoxTA;
        private System.Windows.Forms.CheckBox checkBoxTW;
        private System.Windows.Forms.TextBox textBoxtEMPwOOD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTempAirWhenFinished;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxEMCWhenFinished;
        private System.Windows.Forms.TextBox textBoxMCWhenFinished;
        private System.Windows.Forms.TextBox textBoxBatchId;
        private System.Windows.Forms.Button buttonSaveBatchId;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

