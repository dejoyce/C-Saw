/* -----------------------------------------------------------------
 * 
 * LCD initialization code written by Levent S. 
 * E-mail: ls@izdir.com
 * 
 * This code is provided without implied warranty so the author is
 * not responsible about damages by the use of the code.
 * 
 * You can use this code for any purpose even in any commercial 
 * distributions by referencing my name. 
 * 
 * ! Don't remove or alter this notice in any distribution !
 * 
 * -----------------------------------------------------------------*/

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using System.Threading;
using System.Text;
using System.Xml;
using System.Xml.XPath;

namespace LCD
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	public class Form1 : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		public int control = 890, data = 888, delay;
		private System.Windows.Forms.Button button_Show_Port_Info;
		private System.Windows.Forms.TextBox line1;
		private System.Windows.Forms.TextBox line2;
		private System.Windows.Forms.Button button_Write_to_screen;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.CheckBox checkBox_Enable_cursor;
		private System.Windows.Forms.CheckBox checkBox_Enable_cursor_blink;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox_Autoscroll_line1;
		private System.Windows.Forms.CheckBox checkBox_Typewriter_line1;
		private System.Windows.Forms.CheckBox checkBox_Typewriter_line2;
		private System.Windows.Forms.GroupBox groupBox_Process_LCD;
		private System.Windows.Forms.GroupBox groupBox_Prepare_LCD;
		private System.Windows.Forms.ComboBox comboBox_delay_line1;
		private System.Windows.Forms.ComboBox comboBox_delay_line2;
		private System.Windows.Forms.GroupBox groupBox_Parallel_Port_Info;
		private System.Windows.Forms.Label label_Parallel_Port_Info;
		private System.Windows.Forms.CheckBox checkBox_codeproject_news;
		private System.Windows.Forms.Button button_Motion1;
		private System.Windows.Forms.Button button_Motion2;
		private System.Windows.Forms.CheckBox checkBox_msdn_news;
		private System.Windows.Forms.Button button_Write_news_to_screen;
		private System.Windows.Forms.Button button_Prepare_LCD;

		public Form1()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if (components != null) 
				{
					components.Dispose();
				}
			}
			base.Dispose( disposing );
		}

		#region Windows Form Designer generated code
		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button_Show_Port_Info = new System.Windows.Forms.Button();
			this.button_Prepare_LCD = new System.Windows.Forms.Button();
			this.checkBox_Enable_cursor = new System.Windows.Forms.CheckBox();
			this.checkBox_Enable_cursor_blink = new System.Windows.Forms.CheckBox();
			this.line1 = new System.Windows.Forms.TextBox();
			this.line2 = new System.Windows.Forms.TextBox();
			this.button_Write_to_screen = new System.Windows.Forms.Button();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox_Autoscroll_line1 = new System.Windows.Forms.CheckBox();
			this.checkBox_Typewriter_line1 = new System.Windows.Forms.CheckBox();
			this.checkBox_Typewriter_line2 = new System.Windows.Forms.CheckBox();
			this.groupBox_Process_LCD = new System.Windows.Forms.GroupBox();
			this.button_Write_news_to_screen = new System.Windows.Forms.Button();
			this.button_Motion2 = new System.Windows.Forms.Button();
			this.button_Motion1 = new System.Windows.Forms.Button();
			this.checkBox_codeproject_news = new System.Windows.Forms.CheckBox();
			this.checkBox_msdn_news = new System.Windows.Forms.CheckBox();
			this.comboBox_delay_line2 = new System.Windows.Forms.ComboBox();
			this.comboBox_delay_line1 = new System.Windows.Forms.ComboBox();
			this.groupBox_Prepare_LCD = new System.Windows.Forms.GroupBox();
			this.groupBox_Parallel_Port_Info = new System.Windows.Forms.GroupBox();
			this.label_Parallel_Port_Info = new System.Windows.Forms.Label();
			this.groupBox_Process_LCD.SuspendLayout();
			this.groupBox_Prepare_LCD.SuspendLayout();
			this.groupBox_Parallel_Port_Info.SuspendLayout();
			this.SuspendLayout();
			// 
			// button_Show_Port_Info
			// 
			this.button_Show_Port_Info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Show_Port_Info.Location = new System.Drawing.Point(320, 24);
			this.button_Show_Port_Info.Name = "button_Show_Port_Info";
			this.button_Show_Port_Info.Size = new System.Drawing.Size(104, 23);
			this.button_Show_Port_Info.TabIndex = 1;
			this.button_Show_Port_Info.Text = "Show Port Info";
			this.button_Show_Port_Info.Click += new System.EventHandler(this.button_Show_Port_Info_Click);
			// 
			// button_Prepare_LCD
			// 
			this.button_Prepare_LCD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Prepare_LCD.Location = new System.Drawing.Point(8, 24);
			this.button_Prepare_LCD.Name = "button_Prepare_LCD";
			this.button_Prepare_LCD.Size = new System.Drawing.Size(80, 23);
			this.button_Prepare_LCD.TabIndex = 4;
			this.button_Prepare_LCD.Text = "Prepare LCD";
			this.button_Prepare_LCD.Click += new System.EventHandler(this.button_Prepare_LCD_Click);
			// 
			// checkBox_Enable_cursor
			// 
			this.checkBox_Enable_cursor.Location = new System.Drawing.Point(96, 24);
			this.checkBox_Enable_cursor.Name = "checkBox_Enable_cursor";
			this.checkBox_Enable_cursor.Size = new System.Drawing.Size(96, 24);
			this.checkBox_Enable_cursor.TabIndex = 8;
			this.checkBox_Enable_cursor.Text = "enable cursor";
			// 
			// checkBox_Enable_cursor_blink
			// 
			this.checkBox_Enable_cursor_blink.Location = new System.Drawing.Point(192, 24);
			this.checkBox_Enable_cursor_blink.Name = "checkBox_Enable_cursor_blink";
			this.checkBox_Enable_cursor_blink.Size = new System.Drawing.Size(120, 24);
			this.checkBox_Enable_cursor_blink.TabIndex = 9;
			this.checkBox_Enable_cursor_blink.Text = "enable cursor blink";
			this.checkBox_Enable_cursor_blink.CheckedChanged += new System.EventHandler(this.checkBox_Enable_cursor_blink_CheckedChanged);
			// 
			// line1
			// 
			this.line1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.line1.Location = new System.Drawing.Point(56, 24);
			this.line1.Name = "line1";
			this.line1.Size = new System.Drawing.Size(112, 20);
			this.line1.TabIndex = 10;
			this.line1.Text = "";
			// 
			// line2
			// 
			this.line2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.line2.Location = new System.Drawing.Point(56, 48);
			this.line2.Name = "line2";
			this.line2.Size = new System.Drawing.Size(112, 20);
			this.line2.TabIndex = 11;
			this.line2.Text = "";
			// 
			// button_Write_to_screen
			// 
			this.button_Write_to_screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Write_to_screen.Location = new System.Drawing.Point(440, 24);
			this.button_Write_to_screen.Name = "button_Write_to_screen";
			this.button_Write_to_screen.Size = new System.Drawing.Size(96, 48);
			this.button_Write_to_screen.TabIndex = 12;
			this.button_Write_to_screen.Text = "Write to screen";
			this.button_Write_to_screen.Click += new System.EventHandler(this.button_Write_to_screen_Click);
			// 
			// linkLabel1
			// 
			this.linkLabel1.LinkColor = System.Drawing.Color.Green;
			this.linkLabel1.Location = new System.Drawing.Point(432, 216);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(144, 16);
			this.linkLabel1.TabIndex = 25;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Programmed By Levent S.";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(8, 26);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(40, 16);
			this.label1.TabIndex = 26;
			this.label1.Text = "Line 1";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(8, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 16);
			this.label2.TabIndex = 27;
			this.label2.Text = "Line 2";
			// 
			// checkBox_Autoscroll_line1
			// 
			this.checkBox_Autoscroll_line1.Location = new System.Drawing.Point(176, 24);
			this.checkBox_Autoscroll_line1.Name = "checkBox_Autoscroll_line1";
			this.checkBox_Autoscroll_line1.Size = new System.Drawing.Size(56, 24);
			this.checkBox_Autoscroll_line1.TabIndex = 28;
			this.checkBox_Autoscroll_line1.Text = "scroll";
			this.checkBox_Autoscroll_line1.CheckedChanged += new System.EventHandler(this.checkBox_Autoscroll_line1_CheckedChanged);
			// 
			// checkBox_Typewriter_line1
			// 
			this.checkBox_Typewriter_line1.Location = new System.Drawing.Point(240, 24);
			this.checkBox_Typewriter_line1.Name = "checkBox_Typewriter_line1";
			this.checkBox_Typewriter_line1.Size = new System.Drawing.Size(96, 24);
			this.checkBox_Typewriter_line1.TabIndex = 30;
			this.checkBox_Typewriter_line1.Text = "typewriter --->";
			this.checkBox_Typewriter_line1.CheckedChanged += new System.EventHandler(this.checkBox_Typewriter_line1_CheckedChanged);
			// 
			// checkBox_Typewriter_line2
			// 
			this.checkBox_Typewriter_line2.Location = new System.Drawing.Point(240, 48);
			this.checkBox_Typewriter_line2.Name = "checkBox_Typewriter_line2";
			this.checkBox_Typewriter_line2.Size = new System.Drawing.Size(96, 24);
			this.checkBox_Typewriter_line2.TabIndex = 31;
			this.checkBox_Typewriter_line2.Text = "typewriter --->";
			this.checkBox_Typewriter_line2.CheckedChanged += new System.EventHandler(this.checkBox_Typewriter_line2_CheckedChanged);
			// 
			// groupBox_Process_LCD
			// 
			this.groupBox_Process_LCD.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.button_Write_news_to_screen,
																							   this.button_Motion2,
																							   this.button_Motion1,
																							   this.checkBox_codeproject_news,
																							   this.checkBox_msdn_news,
																							   this.comboBox_delay_line2,
																							   this.comboBox_delay_line1,
																							   this.line2,
																							   this.line1,
																							   this.checkBox_Typewriter_line1,
																							   this.checkBox_Typewriter_line2,
																							   this.checkBox_Autoscroll_line1,
																							   this.label1,
																							   this.label2,
																							   this.button_Write_to_screen});
			this.groupBox_Process_LCD.Location = new System.Drawing.Point(8, 80);
			this.groupBox_Process_LCD.Name = "groupBox_Process_LCD";
			this.groupBox_Process_LCD.Size = new System.Drawing.Size(544, 136);
			this.groupBox_Process_LCD.TabIndex = 32;
			this.groupBox_Process_LCD.TabStop = false;
			this.groupBox_Process_LCD.Text = "Process LCD";
			// 
			// button_Write_news_to_screen
			// 
			this.button_Write_news_to_screen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Write_news_to_screen.Location = new System.Drawing.Point(184, 80);
			this.button_Write_news_to_screen.Name = "button_Write_news_to_screen";
			this.button_Write_news_to_screen.Size = new System.Drawing.Size(168, 48);
			this.button_Write_news_to_screen.TabIndex = 44;
			this.button_Write_news_to_screen.Text = "Write news to screen";
			this.button_Write_news_to_screen.Click += new System.EventHandler(this.button_Write_news_to_screen_Click);
			// 
			// button_Motion2
			// 
			this.button_Motion2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Motion2.Location = new System.Drawing.Point(448, 80);
			this.button_Motion2.Name = "button_Motion2";
			this.button_Motion2.Size = new System.Drawing.Size(88, 48);
			this.button_Motion2.TabIndex = 43;
			this.button_Motion2.Text = "Motion 2";
			this.button_Motion2.Click += new System.EventHandler(this.button_Motion2_Click);
			// 
			// button_Motion1
			// 
			this.button_Motion1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_Motion1.Location = new System.Drawing.Point(360, 80);
			this.button_Motion1.Name = "button_Motion1";
			this.button_Motion1.Size = new System.Drawing.Size(88, 48);
			this.button_Motion1.TabIndex = 42;
			this.button_Motion1.Text = "Motion 1";
			this.button_Motion1.Click += new System.EventHandler(this.button_Motion_Click);
			// 
			// checkBox_codeproject_news
			// 
			this.checkBox_codeproject_news.Location = new System.Drawing.Point(16, 104);
			this.checkBox_codeproject_news.Name = "checkBox_codeproject_news";
			this.checkBox_codeproject_news.Size = new System.Drawing.Size(176, 24);
			this.checkBox_codeproject_news.TabIndex = 39;
			this.checkBox_codeproject_news.Text = "codeproject.com news ----->";
			this.checkBox_codeproject_news.CheckedChanged += new System.EventHandler(this.checkBox_codeproject_news_CheckedChanged);
			// 
			// checkBox_msdn_news
			// 
			this.checkBox_msdn_news.Location = new System.Drawing.Point(16, 80);
			this.checkBox_msdn_news.Name = "checkBox_msdn_news";
			this.checkBox_msdn_news.Size = new System.Drawing.Size(168, 24);
			this.checkBox_msdn_news.TabIndex = 38;
			this.checkBox_msdn_news.Text = "msdn news -------------------->";
			this.checkBox_msdn_news.CheckedChanged += new System.EventHandler(this.checkBox_msdn_news_CheckedChanged);
			// 
			// comboBox_delay_line2
			// 
			this.comboBox_delay_line2.Enabled = false;
			this.comboBox_delay_line2.Items.AddRange(new object[] {
																	  "1",
																	  "50",
																	  "250",
																	  "1000",
																	  "3000",
																	  "10000"});
			this.comboBox_delay_line2.Location = new System.Drawing.Point(344, 48);
			this.comboBox_delay_line2.Name = "comboBox_delay_line2";
			this.comboBox_delay_line2.Size = new System.Drawing.Size(88, 21);
			this.comboBox_delay_line2.TabIndex = 33;
			this.comboBox_delay_line2.Text = "Delay (?) ms";
			// 
			// comboBox_delay_line1
			// 
			this.comboBox_delay_line1.Enabled = false;
			this.comboBox_delay_line1.Items.AddRange(new object[] {
																	  "1",
																	  "50",
																	  "250",
																	  "1000",
																	  "3000",
																	  "10000"});
			this.comboBox_delay_line1.Location = new System.Drawing.Point(344, 24);
			this.comboBox_delay_line1.Name = "comboBox_delay_line1";
			this.comboBox_delay_line1.Size = new System.Drawing.Size(88, 21);
			this.comboBox_delay_line1.TabIndex = 32;
			this.comboBox_delay_line1.Text = "Delay (?) ms";
			// 
			// groupBox_Prepare_LCD
			// 
			this.groupBox_Prepare_LCD.Controls.AddRange(new System.Windows.Forms.Control[] {
																							   this.button_Show_Port_Info,
																							   this.checkBox_Enable_cursor,
																							   this.checkBox_Enable_cursor_blink,
																							   this.button_Prepare_LCD});
			this.groupBox_Prepare_LCD.Location = new System.Drawing.Point(8, 8);
			this.groupBox_Prepare_LCD.Name = "groupBox_Prepare_LCD";
			this.groupBox_Prepare_LCD.Size = new System.Drawing.Size(432, 64);
			this.groupBox_Prepare_LCD.TabIndex = 33;
			this.groupBox_Prepare_LCD.TabStop = false;
			this.groupBox_Prepare_LCD.Text = "Prepare LCD";
			// 
			// groupBox_Parallel_Port_Info
			// 
			this.groupBox_Parallel_Port_Info.Controls.AddRange(new System.Windows.Forms.Control[] {
																									  this.label_Parallel_Port_Info});
			this.groupBox_Parallel_Port_Info.Location = new System.Drawing.Point(448, 8);
			this.groupBox_Parallel_Port_Info.Name = "groupBox_Parallel_Port_Info";
			this.groupBox_Parallel_Port_Info.Size = new System.Drawing.Size(104, 64);
			this.groupBox_Parallel_Port_Info.TabIndex = 34;
			this.groupBox_Parallel_Port_Info.TabStop = false;
			this.groupBox_Parallel_Port_Info.Text = "Parallel Port Info";
			// 
			// label_Parallel_Port_Info
			// 
			this.label_Parallel_Port_Info.Location = new System.Drawing.Point(8, 24);
			this.label_Parallel_Port_Info.Name = "label_Parallel_Port_Info";
			this.label_Parallel_Port_Info.Size = new System.Drawing.Size(88, 24);
			this.label_Parallel_Port_Info.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
			this.ClientSize = new System.Drawing.Size(560, 229);
			this.Controls.AddRange(new System.Windows.Forms.Control[] {
																		  this.groupBox_Parallel_Port_Info,
																		  this.groupBox_Prepare_LCD,
																		  this.groupBox_Process_LCD,
																		  this.linkLabel1});
			this.MaximizeBox = false;
			this.Name = "Form1";
			this.Text = "Control Your HD44780 Compliant LCD Module with Parallel Port";
			this.groupBox_Process_LCD.ResumeLayout(false);
			this.groupBox_Prepare_LCD.ResumeLayout(false);
			this.groupBox_Parallel_Port_Info.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			Application.Run(new Form1());
		}

		private void Prepare_LCD(int cursor_status)
		{
			/* Look at the instruction table to make these comments make sense*/
			/* Thread.Sleep() function is not needed for some type of LCD instructions and also this is changeable from an LCD
			 * to another so tryout the best for your module */
            /* Sends 12(d) = 1100 binary to open the entire display and makes a delay that LCD needs for execution */
			if(cursor_status == 0)
			PortAccess.Output(data, 12); //Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Sends 14(d) = 1110 binary to open the entire display and makes the cursor active and also
			 *  makes a delay that LCD needs for execution */
			if(cursor_status == 1)
			PortAccess.Output(data, 14); //Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Sends 15(d) = 1111 binary to open the entire display, makes the cursor active and blink and also
			 *  makes a delay that LCD needs for execution */
			if(cursor_status == 2)
			PortAccess.Output(data, 15); //Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Makes the enable pin high and register pin low */
			PortAccess.Output(control, 8); Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Makes the enable pin low for LCD to read its data pins and also register pin low */
			PortAccess.Output(control, 9); Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article
			
			/* Clears entire display and sets DDRAM address 0 in address counter */
			PortAccess.Output(data, 1); //Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Makes the enable pin high and register pin low */
			PortAccess.Output(control, 8); Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Makes the enable pin low for LCD to read its data pins and also register pin low */
			PortAccess.Output(control, 9); Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* We are setting the interface data length to 8 bits with selecting 2-line display and 5 x 7-dot character font. 
			 * Lets turn the display on so we have to send */
			PortAccess.Output(data, 56); //Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Makes the enable pin high and register pin low */
			PortAccess.Output(control, 8); Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article

			/* Makes the enable pin low for LCD to read its data pins and also register pin low */
			PortAccess.Output(control, 9); Thread.Sleep(1); //The delays can be smaller, Check Busy Flag info in the article
		}
		
		/* At First I use these to funcs to go to first and second lines then I made move_to_specific func so I ripped these two off 
		private void move_to_first_line()
		{
			// Makes the RS pin low 
			PortAccess.Output(control, 8); Thread.Sleep(2);
			
			// Sets RAM address so that the cursor is positioned at the head of the 1st line. 
			PortAccess.Output(data, 128); Thread.Sleep(2);
		}
				
		private void move_to_second_line()
		{
			// Makes the RS pin low 
			PortAccess.Output(control, 8); Thread.Sleep(2);
			
			// Sets RAM address so that the cursor is positioned at the head of the 2nd line. 
			PortAccess.Output(data, 192); Thread.Sleep(2);
		}*/

		private void move_to_specific(int line, int column)
		{
			/* Makes the RS pin low */
			PortAccess.Output(control, 8); //Thread.Sleep(1);

			if(line == 1)
			{
				/* Sets RAM address so that the cursor is positioned at a specific column of the 1st line. */
				PortAccess.Output(data, 127+column); //Thread.Sleep(1);
			}
			if(line == 2)
			{
				/* Sets RAM address so that the cursor is positioned at a specific column of the 2nd line. */
				PortAccess.Output(data, 191+column); //Thread.Sleep(1);
			}
		}
		
		private void button_Show_Port_Info_Click(object sender, System.EventArgs e)
		{
			label_Parallel_Port_Info.Text = "Control : " + PortAccess.Input(control).ToString() + "\nData : " + PortAccess.Input(data).ToString();
		}		
		
		private void button_Prepare_LCD_Click(object sender, System.EventArgs e)
		{
			if(checkBox_Enable_cursor.Checked == true && checkBox_Enable_cursor_blink.Checked == false)
			{
				Prepare_LCD(1);
			}
			else if(checkBox_Enable_cursor_blink.Checked == true && checkBox_Enable_cursor.Checked == true)
			{
				Prepare_LCD(2);
			}
			else
			{
				Prepare_LCD(0);
			}
		}

		private void linkLabel1_LinkClicked(object sender, System.Windows.Forms.LinkLabelLinkClickedEventArgs e)
		{
			// Change the color of the link text by setting LinkVisited 
			// to True.
			linkLabel1.LinkVisited = true;
   
			// Call the Process.Start method to open the default browser 
			// with a URL:
			System.Diagnostics.Process.Start("mailto:ls@izdir.com");
		}

		private void checkBox_Enable_cursor_blink_CheckedChanged(object sender, System.EventArgs e)
		{
			checkBox_Enable_cursor.Checked = true; // This equal means for blinking is made for the cursor
		}

		private void button_Write_to_screen_Click(object sender, System.EventArgs e)
		{
			// Prepares LCD befores operation
			Prepare_LCD(0);
			
			if(line1.Text == "" && line2.Text == "")
				MessageBox.Show("Type Something in text boxes", "Fill the line boxes");
			 
			int a;
			char [] line1_ch_buffer, line2_ch_buffer; // For pumping character to LCD
			string line1_st_buffer, line2_st_buffer;
			
			line1_st_buffer = line1.Text; line1_ch_buffer = line1_st_buffer.ToCharArray(); // String to Character Array Conversion
			line2_st_buffer = line2.Text; line2_ch_buffer = line2_st_buffer.ToCharArray(); // String to Character Array Conversion
			
			if(checkBox_Typewriter_line1.Checked == true) //For typewriting style (line1)
			{	
				if(this.comboBox_delay_line1.SelectedItem == null)
					MessageBox.Show("Select delay time from the box", "Select delay");
				else
				{
					// Loop for sending data continuesly
					for(a=0; a<line1_ch_buffer.Length; a++)
					{
						delay = Int32.Parse(this.comboBox_delay_line1.SelectedItem.ToString());

						PortAccess.Output(control, 4);
						PortAccess.Output(data, (int)line1_ch_buffer[a]); Thread.Sleep(delay);
						PortAccess.Output(control, 5);
					}
				}
			}
			else //For not typewriting style (line1)
			{
				if(checkBox_Autoscroll_line1.Checked == true)
					scroll(1, line1.Text + " ",true);
				// Loop for sending data continuesly
				for(a=0; a<line1_ch_buffer.Length; a++)
				{
					PortAccess.Output(control, 4); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(data, (int)line1_ch_buffer[a]); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(control, 5); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
				}
			}
			
			move_to_specific(2,1); //Moves the cursor to the first column of the second line

			if(checkBox_Typewriter_line2.Checked == true) //For typewriting style (line2)
			{					
				if(this.comboBox_delay_line2.SelectedItem == null)
					MessageBox.Show("Select delay time from the box", "Select delay");
				else
				{
					// Loop for sending data continuesly
					for(a=0; a<line2_ch_buffer.Length; a++)
					{
						delay = Int32.Parse(this.comboBox_delay_line2.SelectedItem.ToString());
						PortAccess.Output(control, 5);
						PortAccess.Output(control, 4);
						PortAccess.Output(data, (int)line2_ch_buffer[a]); Thread.Sleep(delay);
						PortAccess.Output(control, 5);
					}
				}
			}
			else //For not typewriting style (line2)
			{
				// Loop for sending data continuesly
				for(a=0; a<line2_ch_buffer.Length; a++)
				{
					PortAccess.Output(control, 5); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(control, 4); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(data, (int)line2_ch_buffer[a]); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(control, 5); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
				}
			}
		}
		
		/* I tried to make some funny movements with this for ex: a block of solid squares in line1 go from left to right
		 * while they are going reverse on line2 it will be a good but my 2x16 LCD has only one controller so the the shift 
		 * can be increment or decrement not both of them. On the other hand if you use a 4x40 LCD I know that they have  
		 * two controllers and you can send two actions on the shifts... */
		private void button_Motion_Click(object sender, System.EventArgs e)
		{
			int a;
			Prepare_LCD(0);
			for(a=0; a<16; a++) // Because I have a 2x16 LCD (2 row, 16 column)
			{
				PortAccess.Output(control, 4); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
				PortAccess.Output(data, 255); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
				PortAccess.Output(control, 5); Thread.Sleep(1);
			}
			
			move_to_specific(1,1);

			for(a=0; a<16; a++)
			{
				PortAccess.Output(control, 5); Thread.Sleep(1);
				PortAccess.Output(control, 4); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
				PortAccess.Output(data, 32); Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
				PortAccess.Output(control, 5); Thread.Sleep(1);
			}
		}

		private void button_Motion2_Click(object sender, System.EventArgs e)
		{
			Prepare_LCD(0);
			int line, column = 1;
			for(line=1; line<3; line++)
			{
				while (column<17)
				{
					move_to_specific(line,column);
					PortAccess.Output(control, 5); Thread.Sleep(1);
					PortAccess.Output(control, 4); //Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(data, 126); //Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(control, 5); Thread.Sleep(1);
					column+=2;
				}
				column=2;				
			}
			column=0;
			for(line=1; line<3; line++)
			{
				while (column<17)
				{
					move_to_specific(line,column);
					PortAccess.Output(control, 5); Thread.Sleep(1);
					PortAccess.Output(control, 4); //Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(data, 126); //Thread.Sleep(1); //You can disable this little delay but your controller needs some time for execution, Look for the datasheet mine is "KSC0066"
					PortAccess.Output(control, 5); Thread.Sleep(1);
					column+=2;
				}
				column=1;				
			}

		}

		private void scroll(int line, string st_buffer, bool prepare)
		{
			char [] ch_buffer; char buffer_char;
			int a, times;

			ch_buffer = st_buffer.ToCharArray();

			for(times=0; times<150; times++) //How many times to scroll...
			{
				if(prepare == true)
					Prepare_LCD(0);
							
				move_to_specific(line,1);

				buffer_char = ch_buffer[0];
			
				for(a=0;a<st_buffer.Length-1;a++)
				{
					ch_buffer[a] = ch_buffer[a+1];
				}
				ch_buffer[st_buffer.Length-1] = buffer_char;

				for(a=0;a<ch_buffer.Length;a++)
				{
					PortAccess.Output(control, 5); //Thread.Sleep(1);
					PortAccess.Output(control, 4); //Thread.Sleep(1);
					PortAccess.Output(data, (int)ch_buffer[a]); //Thread.Sleep(1);
					PortAccess.Output(control, 5); Thread.Sleep(1);
				}
			}
		}
		private void checkBox_Autoscroll_line1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox_Autoscroll_line1.Checked == true)
			{
				checkBox_Typewriter_line1.Enabled = false;
			}
			else
			{
				checkBox_Typewriter_line1.Enabled = true;
			}
		}
		
		private void checkBox_Typewriter_line1_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox_Typewriter_line1.Checked == true)
			{
				comboBox_delay_line1.Enabled = true;
				checkBox_Autoscroll_line1.Enabled = false;
			}
			else
			{
				comboBox_delay_line1.Enabled = false;
				checkBox_Autoscroll_line1.Enabled = true;
			}
		}

		private void checkBox_Typewriter_line2_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox_Typewriter_line2.Checked == true)
			{
				comboBox_delay_line2.Enabled = true;
			}
			else
			{
				comboBox_delay_line2.Enabled = false;
			}
		}
		
		private void checkBox_msdn_news_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox_msdn_news.Checked == true)
			{
				checkBox_Autoscroll_line1.Enabled = false;
				checkBox_Typewriter_line1.Enabled = false;
				comboBox_delay_line1.Enabled = false;
				checkBox_Typewriter_line2.Enabled = false;
				comboBox_delay_line2.Enabled = false;
				checkBox_codeproject_news.Enabled = false;
			}
			else
			{
				checkBox_Autoscroll_line1.Enabled = true;
				checkBox_Typewriter_line1.Enabled = true;
				comboBox_delay_line1.Enabled = true;
				checkBox_Typewriter_line2.Enabled = true;
				comboBox_delay_line2.Enabled = true;
				checkBox_codeproject_news.Enabled = true;
			}
		}

		private void checkBox_codeproject_news_CheckedChanged(object sender, System.EventArgs e)
		{
			if(checkBox_codeproject_news.Checked == true)
			{
				checkBox_Autoscroll_line1.Enabled = false;
				checkBox_Typewriter_line1.Enabled = false;
				comboBox_delay_line1.Enabled = false;
				checkBox_Typewriter_line2.Enabled = false;
				comboBox_delay_line2.Enabled = false;
				checkBox_msdn_news.Enabled = false;
			}
			else
			{
				checkBox_Autoscroll_line1.Enabled = true;
				checkBox_Typewriter_line1.Enabled = true;
				comboBox_delay_line1.Enabled = true;
				checkBox_Typewriter_line2.Enabled = true;
				comboBox_delay_line2.Enabled = true;
				checkBox_msdn_news.Enabled = true;
			}
		}


		private void button_Write_news_to_screen_Click(object sender, System.EventArgs e)
		{
			char [] ch_buffer;

			if(checkBox_msdn_news.Checked == true)
			{
				String URLString = "http://msdn.microsoft.com/rss.xml";
				string news = "   MSDN News"; int a;
				// Load the XmlTextReader from the URL
				ch_buffer = news.ToCharArray();
				XmlTextReader reader = new XmlTextReader (URLString);
				
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element)
					{
						if (reader.LocalName.Equals("title"))
						{
							Prepare_LCD(0);
							for(a=0; a<ch_buffer.Length; a++)
							{
								PortAccess.Output(control, 5); Thread.Sleep(1);
								PortAccess.Output(control, 4); Thread.Sleep(1);
								PortAccess.Output(data, (int)ch_buffer[a]); Thread.Sleep(1);
								PortAccess.Output(control, 5); Thread.Sleep(1);
							}
							scroll(2, reader.ReadString() + " ",false);
						}
					}
				}
			}
			else if(checkBox_codeproject_news.Checked == true)
			{
				String URLString = "http://www.codeproject.com/webservices/articlerss.aspx";
				string news = "CODEPROJECT News"; int a;
				// Load the XmlTextReader from the URL
				ch_buffer = news.ToCharArray();
				XmlTextReader reader = new XmlTextReader (URLString);
				
				while (reader.Read())
				{
					if (reader.NodeType == XmlNodeType.Element)
					{
						if (reader.LocalName.Equals("title"))
						{
							Prepare_LCD(0);
							for(a=0; a<ch_buffer.Length; a++)
							{
								PortAccess.Output(control, 5); Thread.Sleep(1);
								PortAccess.Output(control, 4);
								PortAccess.Output(data, (int)ch_buffer[a]); Thread.Sleep(1);
								PortAccess.Output(control, 5);	
							}
							scroll(2, reader.ReadString() + " ",false);
						}
					}
				}
			}
			else
				MessageBox.Show("Choose one of the news site about developing");
		}
	}
}
