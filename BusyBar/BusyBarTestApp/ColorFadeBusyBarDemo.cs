//#define EDIT_MODE

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;


namespace BusyBarDemoApp
{
	/// <summary>
	/// Summary description for Form1.
	/// </summary>
	
#if EDIT_MODE
	public class ColorFadeBusyBarDemo : System.Windows.Forms.Form

#else
	public class ColorFadeBusyBarDemo : System.Windows.Forms.TabPage

#endif
	{
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.GroupBox groupBoxColors;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label colorBoxBackground;
		private System.Windows.Forms.Label colorBoxForeground;
		private System.Windows.Forms.Label colorBoxColor2;
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.GroupBox groupBoxOptions;
		private System.Windows.Forms.Button buttonResetColors;
		private System.Windows.Forms.BusyBar.ColorFadeBusyBar colorFadeBusyBar1;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.Label label98;
		private System.Windows.Forms.TextBox textboxStepTimeout;
		private System.Windows.Forms.TextBox textboxStepSize;
		private System.Windows.Forms.Button buttonOptionsSet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox checkBoxPingPong;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textboxFadeLength;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox checkBoxShowBorder;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxText;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ColorFadeBusyBarDemo()
		{
			InitializeComponent();

			this.colorBoxBackground.BackColor = this.colorFadeBusyBar1.BackColor;
			this.colorBoxForeground.BackColor = this.colorFadeBusyBar1.ForeColor;
			this.colorBoxColor2.BackColor = this.colorFadeBusyBar1.Color2;

			this.textboxStepTimeout.Text = this.colorFadeBusyBar1.StepTimeout.ToString();
			this.textboxStepSize.Text = this.colorFadeBusyBar1.StepSize.ToString();
			this.textboxFadeLength.Text = this.colorFadeBusyBar1.FadeLength.ToString();


			this.checkBoxShowBorder.Checked = this.colorFadeBusyBar1.ShowBorder;
			this.checkBoxPingPong.Checked = this.colorFadeBusyBar1.PingPong;

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
			this.buttonStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.buttonResetColors = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.colorBoxBackground = new System.Windows.Forms.Label();
			this.colorBoxForeground = new System.Windows.Forms.Label();
			this.colorBoxColor2 = new System.Windows.Forms.Label();
			this.buttonReset = new System.Windows.Forms.Button();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.checkBoxPingPong = new System.Windows.Forms.CheckBox();
			this.label99 = new System.Windows.Forms.Label();
			this.label98 = new System.Windows.Forms.Label();
			this.textboxStepSize = new System.Windows.Forms.TextBox();
			this.textboxStepTimeout = new System.Windows.Forms.TextBox();
			this.buttonOptionsSet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.textboxFadeLength = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.checkBoxShowBorder = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxText = new System.Windows.Forms.TextBox();
			this.colorFadeBusyBar1 = new System.Windows.Forms.BusyBar.ColorFadeBusyBar();
			this.groupBoxColors.SuspendLayout();
			this.groupBoxOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(392, 16);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 24);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Start";
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 4;
			this.label1.Text = "Slide Color";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(16, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 16);
			this.label3.TabIndex = 4;
			this.label3.Text = "Background Color";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 72);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 4;
			this.label4.Text = "Slide Color 2";
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.buttonResetColors);
			this.groupBoxColors.Controls.Add(this.label);
			this.groupBoxColors.Controls.Add(this.label2);
			this.groupBoxColors.Controls.Add(this.label5);
			this.groupBoxColors.Controls.Add(this.colorBoxBackground);
			this.groupBoxColors.Controls.Add(this.colorBoxForeground);
			this.groupBoxColors.Controls.Add(this.colorBoxColor2);
			this.groupBoxColors.Location = new System.Drawing.Point(16, 40);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(360, 168);
			this.groupBoxColors.TabIndex = 6;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Colors";
			// 
			// buttonResetColors
			// 
			this.buttonResetColors.Location = new System.Drawing.Point(160, 128);
			this.buttonResetColors.Name = "buttonResetColors";
			this.buttonResetColors.TabIndex = 1;
			this.buttonResetColors.Text = "Reset";
			this.buttonResetColors.Click += new System.EventHandler(this.buttonResetColors_Click);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(16, 32);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(104, 16);
			this.label.TabIndex = 0;
			this.label.Text = "Background";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Fade Color 1";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Fade Color 2";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// colorBoxBackground
			// 
			this.colorBoxBackground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.colorBoxBackground.Location = new System.Drawing.Point(160, 32);
			this.colorBoxBackground.Name = "colorBoxBackground";
			this.colorBoxBackground.Size = new System.Drawing.Size(56, 16);
			this.colorBoxBackground.TabIndex = 0;
			this.colorBoxBackground.Click += new System.EventHandler(this.colorBoxBackground_Click);
			// 
			// colorBoxForeground
			// 
			this.colorBoxForeground.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.colorBoxForeground.Location = new System.Drawing.Point(160, 64);
			this.colorBoxForeground.Name = "colorBoxForeground";
			this.colorBoxForeground.Size = new System.Drawing.Size(56, 16);
			this.colorBoxForeground.TabIndex = 0;
			this.colorBoxForeground.Click += new System.EventHandler(this.colorBoxForeground_Click);
			// 
			// colorBoxColor2
			// 
			this.colorBoxColor2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.colorBoxColor2.Location = new System.Drawing.Point(160, 96);
			this.colorBoxColor2.Name = "colorBoxColor2";
			this.colorBoxColor2.Size = new System.Drawing.Size(56, 16);
			this.colorBoxColor2.TabIndex = 0;
			this.colorBoxColor2.Click += new System.EventHandler(this.colorBoxColor2_Click);
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(0, 0);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.TabIndex = 0;
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.checkBoxPingPong);
			this.groupBoxOptions.Controls.Add(this.label99);
			this.groupBoxOptions.Controls.Add(this.label98);
			this.groupBoxOptions.Controls.Add(this.textboxStepSize);
			this.groupBoxOptions.Controls.Add(this.textboxStepTimeout);
			this.groupBoxOptions.Controls.Add(this.buttonOptionsSet);
			this.groupBoxOptions.Controls.Add(this.label6);
			this.groupBoxOptions.Controls.Add(this.label7);
			this.groupBoxOptions.Controls.Add(this.label8);
			this.groupBoxOptions.Controls.Add(this.textboxFadeLength);
			this.groupBoxOptions.Controls.Add(this.label9);
			this.groupBoxOptions.Controls.Add(this.checkBoxShowBorder);
			this.groupBoxOptions.Controls.Add(this.label10);
			this.groupBoxOptions.Controls.Add(this.textBoxText);
			this.groupBoxOptions.Location = new System.Drawing.Point(16, 216);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Size = new System.Drawing.Size(360, 216);
			this.groupBoxOptions.TabIndex = 0;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "Options";
			// 
			// checkBoxPingPong
			// 
			this.checkBoxPingPong.Location = new System.Drawing.Point(160, 112);
			this.checkBoxPingPong.Name = "checkBoxPingPong";
			this.checkBoxPingPong.Size = new System.Drawing.Size(40, 24);
			this.checkBoxPingPong.TabIndex = 4;
			this.checkBoxPingPong.CheckedChanged += new System.EventHandler(this.checkBoxPingPong_CheckedChanged);
			// 
			// label99
			// 
			this.label99.Location = new System.Drawing.Point(16, 32);
			this.label99.Name = "label99";
			this.label99.Size = new System.Drawing.Size(100, 24);
			this.label99.TabIndex = 1;
			this.label99.Text = "Step Timeout";
			this.label99.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label98
			// 
			this.label98.Location = new System.Drawing.Point(16, 56);
			this.label98.Name = "label98";
			this.label98.Size = new System.Drawing.Size(100, 24);
			this.label98.TabIndex = 1;
			this.label98.Text = "Step Size";
			this.label98.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textboxStepSize
			// 
			this.textboxStepSize.Location = new System.Drawing.Point(160, 56);
			this.textboxStepSize.Name = "textboxStepSize";
			this.textboxStepSize.Size = new System.Drawing.Size(56, 20);
			this.textboxStepSize.TabIndex = 3;
			this.textboxStepSize.Text = "";
			// 
			// textboxStepTimeout
			// 
			this.textboxStepTimeout.Location = new System.Drawing.Point(160, 30);
			this.textboxStepTimeout.Name = "textboxStepTimeout";
			this.textboxStepTimeout.Size = new System.Drawing.Size(56, 20);
			this.textboxStepTimeout.TabIndex = 0;
			this.textboxStepTimeout.Text = "";
			// 
			// buttonOptionsSet
			// 
			this.buttonOptionsSet.Location = new System.Drawing.Point(264, 36);
			this.buttonOptionsSet.Name = "buttonOptionsSet";
			this.buttonOptionsSet.Size = new System.Drawing.Size(75, 64);
			this.buttonOptionsSet.TabIndex = 1;
			this.buttonOptionsSet.Text = "Set";
			this.buttonOptionsSet.Click += new System.EventHandler(this.buttonOptionsSet_Click);
			// 
			// label6
			// 
			this.label6.Location = new System.Drawing.Point(224, 32);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 16);
			this.label6.TabIndex = 1;
			this.label6.Text = "(ms)";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label7
			// 
			this.label7.Location = new System.Drawing.Point(16, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 24);
			this.label7.TabIndex = 1;
			this.label7.Text = "Ping Pong";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label8
			// 
			this.label8.Location = new System.Drawing.Point(16, 80);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 24);
			this.label8.TabIndex = 1;
			this.label8.Text = "Fade Length";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textboxFadeLength
			// 
			this.textboxFadeLength.Location = new System.Drawing.Point(160, 80);
			this.textboxFadeLength.Name = "textboxFadeLength";
			this.textboxFadeLength.Size = new System.Drawing.Size(56, 20);
			this.textboxFadeLength.TabIndex = 3;
			this.textboxFadeLength.Text = "";
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 136);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 24);
			this.label9.TabIndex = 1;
			this.label9.Text = "Show Border";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxShowBorder
			// 
			this.checkBoxShowBorder.Location = new System.Drawing.Point(160, 136);
			this.checkBoxShowBorder.Name = "checkBoxShowBorder";
			this.checkBoxShowBorder.Size = new System.Drawing.Size(40, 24);
			this.checkBoxShowBorder.TabIndex = 4;
			this.checkBoxShowBorder.CheckedChanged += new System.EventHandler(this.checkBoxShowBorder_CheckedChanged);
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 160);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 24);
			this.label10.TabIndex = 1;
			this.label10.Text = "Text";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxText
			// 
			this.textBoxText.Location = new System.Drawing.Point(160, 160);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(184, 20);
			this.textBoxText.TabIndex = 3;
			this.textBoxText.Text = "";
			this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
			// 
			// colorFadeBusyBar1
			// 
			this.colorFadeBusyBar1.BackColor = System.Drawing.SystemColors.Control;
			this.colorFadeBusyBar1.BorderStyle3D = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.colorFadeBusyBar1.Color2 = System.Drawing.SystemColors.Control;
			this.colorFadeBusyBar1.FadeLength = -1;
			this.colorFadeBusyBar1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.colorFadeBusyBar1.Location = new System.Drawing.Point(16, 16);
			this.colorFadeBusyBar1.Name = "colorFadeBusyBar1";
			this.colorFadeBusyBar1.PingPong = false;
			this.colorFadeBusyBar1.ShowBorder = true;
			this.colorFadeBusyBar1.Size = new System.Drawing.Size(360, 16);
			this.colorFadeBusyBar1.StepSize = 5;
			this.colorFadeBusyBar1.StepTimeout = 50;
			this.colorFadeBusyBar1.TabIndex = 7;
			this.colorFadeBusyBar1.TextColor = System.Drawing.SystemColors.ControlText;
			// 
			// ColorFadeBusyBarDemo
			// 
			this.ClientSize = new System.Drawing.Size(478, 440);
			this.Controls.Add(this.colorFadeBusyBar1);
			this.Controls.Add(this.groupBoxOptions);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.buttonStart);
			this.Name = "ColorFadeBusyBarDemo";
			this.Text = "colorFadeBusyBarDemo";
			this.groupBoxColors.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion




		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			if ( this.colorFadeBusyBar1.IsRunning )
			{
				this.buttonStart.Text = "Start";
				this.colorFadeBusyBar1.Stop();
			}
			else
			{
				this.buttonStart.Text = "Stop";
				this.colorFadeBusyBar1.Start();
			}
		}

		private void buttonOptionsSet_Click(object sender, System.EventArgs e)
		{
			int iStepSize;
			int iTimeOut;
			int iFadeLength;

			try
			{
				iTimeOut = Convert.ToInt32( this.textboxStepTimeout.Text );
				iStepSize = Convert.ToInt32( this.textboxStepSize.Text );
				iFadeLength = Convert.ToInt32( this.textboxFadeLength.Text);
				
				if(iTimeOut <= 0)
					throw new Exception();

				if(iStepSize <= 0)
					throw new Exception();

				this.colorFadeBusyBar1.FadeLength = iFadeLength;
				this.colorFadeBusyBar1.StepTimeout = iTimeOut;
				this.colorFadeBusyBar1.StepSize = iStepSize;
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show( "Invalid number entered" );
				this.textboxStepSize.Text = this.colorFadeBusyBar1.StepSize.ToString();
				this.textboxStepTimeout.Text = this.colorFadeBusyBar1.StepTimeout.ToString();
				this.textboxFadeLength.Text = this.colorFadeBusyBar1.FadeLength.ToString();
			}
		}

		private void colorBoxForeground_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxForeground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxForeground.BackColor = this.colorDialog1.Color;
			this.colorFadeBusyBar1.ForeColor = this.colorDialog1.Color;			
		}

		private void colorBoxColor2_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxColor2.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxColor2.BackColor = this.colorDialog1.Color;
			this.colorFadeBusyBar1.Color2 = this.colorDialog1.Color;			
		}

		private void colorBoxBackground_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxBackground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxBackground.BackColor = this.colorDialog1.Color;
			this.colorFadeBusyBar1.BackColor = this.colorDialog1.Color;		
		}

		private void buttonResetColors_Click(object sender, System.EventArgs e)
		{
			this.colorFadeBusyBar1.ForeColor = System.Windows.Forms.BusyBar.FadeBusyBar.DefaultForeColor;
			this.colorFadeBusyBar1.BackColor = System.Windows.Forms.BusyBar.FadeBusyBar.DefaultBackColor;
			this.colorFadeBusyBar1.Color2 = System.Windows.Forms.BusyBar.ColorFadeBusyBar.DefaultColor2;

			this.colorBoxBackground.BackColor = this.colorFadeBusyBar1.BackColor;
			this.colorBoxForeground.BackColor = this.colorFadeBusyBar1.ForeColor;
			this.colorBoxColor2.BackColor = this.colorFadeBusyBar1.Color2;		
		}

		private void checkBoxPingPong_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorFadeBusyBar1.PingPong = this.checkBoxPingPong.Checked;
		}

		private void checkBoxShowBorder_CheckedChanged(object sender, System.EventArgs e)
		{
			this.colorFadeBusyBar1.ShowBorder = this.checkBoxShowBorder.Checked;
		}

		private void textBoxText_TextChanged(object sender, System.EventArgs e)
		{
			this.colorFadeBusyBar1.Text = this.textBoxText.Text;
		}
	}
}
