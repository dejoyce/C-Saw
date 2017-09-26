namespace ParallelPortLibraryDemo
{
    partial class MainFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lptPortComboBox = new System.Windows.Forms.ComboBox();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuBar = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpTopicsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visitWebSiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ledUserControl13 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl17 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl12 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl14 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl11 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl16 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl10 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl15 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl9 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl1 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl8 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl2 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl7 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl3 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl6 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl4 = new ParallelPortLibraryDemo.LedUserControl();
            this.ledUserControl5 = new ParallelPortLibraryDemo.LedUserControl();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.menuBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::ParallelPortLibraryDemo.Properties.Resources.parallel;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.ledUserControl13);
            this.panel1.Controls.Add(this.ledUserControl17);
            this.panel1.Controls.Add(this.ledUserControl12);
            this.panel1.Controls.Add(this.ledUserControl14);
            this.panel1.Controls.Add(this.ledUserControl11);
            this.panel1.Controls.Add(this.ledUserControl16);
            this.panel1.Controls.Add(this.ledUserControl10);
            this.panel1.Controls.Add(this.ledUserControl15);
            this.panel1.Controls.Add(this.ledUserControl9);
            this.panel1.Controls.Add(this.ledUserControl1);
            this.panel1.Controls.Add(this.ledUserControl8);
            this.panel1.Controls.Add(this.ledUserControl2);
            this.panel1.Controls.Add(this.ledUserControl7);
            this.panel1.Controls.Add(this.ledUserControl3);
            this.panel1.Controls.Add(this.ledUserControl6);
            this.panel1.Controls.Add(this.ledUserControl4);
            this.panel1.Controls.Add(this.ledUserControl5);
            this.panel1.Location = new System.Drawing.Point(24, 19);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 67);
            this.panel1.TabIndex = 17;
            // 
            // lptPortComboBox
            // 
            this.lptPortComboBox.FormattingEnabled = true;
            this.lptPortComboBox.Items.AddRange(new object[] {
            "LPT1 378h",
            "LPT2 278h"});
            this.lptPortComboBox.Location = new System.Drawing.Point(24, 19);
            this.lptPortComboBox.Name = "lptPortComboBox";
            this.lptPortComboBox.Size = new System.Drawing.Size(134, 21);
            this.lptPortComboBox.TabIndex = 18;
            this.lptPortComboBox.Text = "Choose LPT Port";
            this.lptPortComboBox.SelectedIndexChanged += new System.EventHandler(this.lptPortComboBox_SelectedIndexChanged);
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Write to Data Pins",
            "Read from Data Pins"});
            this.modeComboBox.Location = new System.Drawing.Point(23, 19);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(134, 21);
            this.modeComboBox.TabIndex = 19;
            this.modeComboBox.Text = "Choose Mode";
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lptPortComboBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 59);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Choose LPT Port";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.modeComboBox);
            this.groupBox2.Location = new System.Drawing.Point(213, 134);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 59);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Choose Data Pins Mode";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Location = new System.Drawing.Point(12, 27);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(381, 101);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            // 
            // menuBar
            // 
            this.menuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuBar.Location = new System.Drawing.Point(0, 0);
            this.menuBar.Name = "menuBar";
            this.menuBar.Size = new System.Drawing.Size(405, 24);
            this.menuBar.TabIndex = 23;
            this.menuBar.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpTopicsToolStripMenuItem,
            this.visitWebSiteToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // helpTopicsToolStripMenuItem
            // 
            this.helpTopicsToolStripMenuItem.Name = "helpTopicsToolStripMenuItem";
            this.helpTopicsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.helpTopicsToolStripMenuItem.Text = "Help Topics";
            this.helpTopicsToolStripMenuItem.Click += new System.EventHandler(this.helpTopicsToolStripMenuItem_Click);
            // 
            // visitWebSiteToolStripMenuItem
            // 
            this.visitWebSiteToolStripMenuItem.Name = "visitWebSiteToolStripMenuItem";
            this.visitWebSiteToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.visitWebSiteToolStripMenuItem.Text = "Visit Web Site";
            this.visitWebSiteToolStripMenuItem.Click += new System.EventHandler(this.visitWebSiteToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // ledUserControl13
            // 
            this.ledUserControl13.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl13.Checked = false;
            this.ledUserControl13.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl13.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl13.Location = new System.Drawing.Point(8, 7);
            this.ledUserControl13.Name = "ledUserControl13";
            this.ledUserControl13.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl13.TabIndex = 30;
            // 
            // ledUserControl17
            // 
            this.ledUserControl17.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl17.Checked = false;
            this.ledUserControl17.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl17.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl17.Location = new System.Drawing.Point(221, 43);
            this.ledUserControl17.Name = "ledUserControl17";
            this.ledUserControl17.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl17.TabIndex = 34;
            this.ledUserControl17.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl17_CheckedChanged);
            // 
            // ledUserControl12
            // 
            this.ledUserControl12.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl12.Checked = false;
            this.ledUserControl12.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl12.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl12.Location = new System.Drawing.Point(33, 7);
            this.ledUserControl12.Name = "ledUserControl12";
            this.ledUserControl12.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl12.TabIndex = 29;
            // 
            // ledUserControl14
            // 
            this.ledUserControl14.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl14.Checked = false;
            this.ledUserControl14.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl14.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl14.Location = new System.Drawing.Point(296, 43);
            this.ledUserControl14.Name = "ledUserControl14";
            this.ledUserControl14.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl14.TabIndex = 31;
            this.ledUserControl14.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl14_CheckedChanged);
            // 
            // ledUserControl11
            // 
            this.ledUserControl11.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl11.Checked = false;
            this.ledUserControl11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl11.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl11.Location = new System.Drawing.Point(58, 7);
            this.ledUserControl11.Name = "ledUserControl11";
            this.ledUserControl11.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl11.TabIndex = 28;
            // 
            // ledUserControl16
            // 
            this.ledUserControl16.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl16.Checked = false;
            this.ledUserControl16.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl16.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl16.Location = new System.Drawing.Point(246, 43);
            this.ledUserControl16.Name = "ledUserControl16";
            this.ledUserControl16.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl16.TabIndex = 33;
            this.ledUserControl16.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl16_CheckedChanged);
            // 
            // ledUserControl10
            // 
            this.ledUserControl10.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl10.Checked = false;
            this.ledUserControl10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl10.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl10.Location = new System.Drawing.Point(83, 7);
            this.ledUserControl10.Name = "ledUserControl10";
            this.ledUserControl10.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl10.TabIndex = 27;
            // 
            // ledUserControl15
            // 
            this.ledUserControl15.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl15.Checked = false;
            this.ledUserControl15.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl15.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl15.Location = new System.Drawing.Point(271, 43);
            this.ledUserControl15.Name = "ledUserControl15";
            this.ledUserControl15.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl15.TabIndex = 32;
            // 
            // ledUserControl9
            // 
            this.ledUserControl9.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl9.Checked = false;
            this.ledUserControl9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl9.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl9.Location = new System.Drawing.Point(108, 7);
            this.ledUserControl9.Name = "ledUserControl9";
            this.ledUserControl9.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl9.TabIndex = 26;
            this.ledUserControl9.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl9_CheckedChanged);
            // 
            // ledUserControl1
            // 
            this.ledUserControl1.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl1.Checked = false;
            this.ledUserControl1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl1.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl1.Location = new System.Drawing.Point(308, 7);
            this.ledUserControl1.Name = "ledUserControl1";
            this.ledUserControl1.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl1.TabIndex = 18;
            this.ledUserControl1.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl1_CheckedChanged);
            // 
            // ledUserControl8
            // 
            this.ledUserControl8.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl8.Checked = false;
            this.ledUserControl8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl8.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl8.Location = new System.Drawing.Point(133, 7);
            this.ledUserControl8.Name = "ledUserControl8";
            this.ledUserControl8.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl8.TabIndex = 25;
            this.ledUserControl8.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl8_CheckedChanged);
            // 
            // ledUserControl2
            // 
            this.ledUserControl2.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl2.Checked = false;
            this.ledUserControl2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl2.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl2.Location = new System.Drawing.Point(283, 7);
            this.ledUserControl2.Name = "ledUserControl2";
            this.ledUserControl2.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl2.TabIndex = 19;
            this.ledUserControl2.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl2_CheckedChanged);
            // 
            // ledUserControl7
            // 
            this.ledUserControl7.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl7.Checked = false;
            this.ledUserControl7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl7.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl7.Location = new System.Drawing.Point(158, 7);
            this.ledUserControl7.Name = "ledUserControl7";
            this.ledUserControl7.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl7.TabIndex = 24;
            this.ledUserControl7.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl7_CheckedChanged);
            // 
            // ledUserControl3
            // 
            this.ledUserControl3.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl3.Checked = false;
            this.ledUserControl3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl3.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl3.Location = new System.Drawing.Point(258, 7);
            this.ledUserControl3.Name = "ledUserControl3";
            this.ledUserControl3.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl3.TabIndex = 20;
            this.ledUserControl3.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl3_CheckedChanged);
            // 
            // ledUserControl6
            // 
            this.ledUserControl6.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl6.Checked = false;
            this.ledUserControl6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl6.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl6.Location = new System.Drawing.Point(183, 7);
            this.ledUserControl6.Name = "ledUserControl6";
            this.ledUserControl6.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl6.TabIndex = 23;
            this.ledUserControl6.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl6_CheckedChanged);
            // 
            // ledUserControl4
            // 
            this.ledUserControl4.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl4.Checked = false;
            this.ledUserControl4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl4.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl4.Location = new System.Drawing.Point(233, 7);
            this.ledUserControl4.Name = "ledUserControl4";
            this.ledUserControl4.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl4.TabIndex = 21;
            this.ledUserControl4.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl4_CheckedChanged);
            // 
            // ledUserControl5
            // 
            this.ledUserControl5.BackColor = System.Drawing.Color.Transparent;
            this.ledUserControl5.Checked = false;
            this.ledUserControl5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ledUserControl5.LedType = ParallelPortLibraryDemo.LedUserControl.LedTypes.WriteLed;
            this.ledUserControl5.Location = new System.Drawing.Point(208, 7);
            this.ledUserControl5.Name = "ledUserControl5";
            this.ledUserControl5.Size = new System.Drawing.Size(16, 16);
            this.ledUserControl5.TabIndex = 22;
            this.ledUserControl5.CheckedChanged += new ParallelPortLibraryDemo.LedUserControl.CheckedChangedHandler(this.ledUserControl5_CheckedChanged);
            // 
            // MainFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 204);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuBar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuBar;
            this.MaximizeBox = false;
            this.Name = "MainFrm";
            this.Text = "SoftCollection Parallel Port Library Demo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainFrm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.menuBar.ResumeLayout(false);
            this.menuBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private LedUserControl ledUserControl1;
        private LedUserControl ledUserControl2;
        private LedUserControl ledUserControl3;
        private LedUserControl ledUserControl4;
        private LedUserControl ledUserControl5;
        private LedUserControl ledUserControl6;
        private LedUserControl ledUserControl7;
        private LedUserControl ledUserControl8;
        private LedUserControl ledUserControl9;
        private LedUserControl ledUserControl10;
        private LedUserControl ledUserControl11;
        private LedUserControl ledUserControl12;
        private LedUserControl ledUserControl13;
        private LedUserControl ledUserControl14;
        private LedUserControl ledUserControl15;
        private LedUserControl ledUserControl16;
        private LedUserControl ledUserControl17;
        private System.Windows.Forms.ComboBox lptPortComboBox;
        private System.Windows.Forms.ComboBox modeComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.MenuStrip menuBar;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpTopicsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visitWebSiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;


    }
}

