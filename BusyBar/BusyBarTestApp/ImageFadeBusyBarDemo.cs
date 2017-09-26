//#define EDIT_MODE

using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace BusyBarDemoApp
{
	/// <summary>
	/// Summary description for ImageFadeBusyBarDemo.
	/// </summary>
#if EDIT_MODE
	public class ImageFadeBusyBarDemo : System.Windows.Forms.Form
#else
	public class ImageFadeBusyBarDemo : System.Windows.Forms.TabPage
#endif
	{
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.GroupBox groupBoxColors;
		private System.Windows.Forms.Label label;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label colorBoxBackground;
		private System.Windows.Forms.Label colorBoxForeground;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.GroupBox groupBoxOptions;
		private System.Windows.Forms.CheckBox checkBoxPingPong;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.Label label98;
		private System.Windows.Forms.TextBox textboxStepSize;
		private System.Windows.Forms.TextBox textboxStepTimeout;
		private System.Windows.Forms.Button buttonOptionsSet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.CheckBox checkBoxShowBorder;
		private System.Windows.Forms.BusyBar.ImageFadeBusyBar imageFadeBusyBar;
		private System.Windows.Forms.Button buttonBrowse;
		private System.Windows.Forms.TextBox textBoxImageName;
		private System.Windows.Forms.Button buttonImageSet;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox textBoxText;
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public ImageFadeBusyBarDemo()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.openFileDialog = new OpenFileDialog();
			this.openFileDialog.InitialDirectory = "c:\\" ;
			this.openFileDialog.Filter = "Bitmap Files (*.bmp)|*.bmp|All files (*.*)|*.*" ;
			this.openFileDialog.FilterIndex = 1 ;
			this.openFileDialog.RestoreDirectory = true;

			this.colorBoxBackground.BackColor = this.imageFadeBusyBar.BackColor;
			this.colorBoxForeground.BackColor = this.imageFadeBusyBar.ForeColor;

			this.textboxStepTimeout.Text = this.imageFadeBusyBar.StepTimeout.ToString();
			this.textboxStepSize.Text = this.imageFadeBusyBar.StepSize.ToString();

			this.checkBoxShowBorder.Checked = this.imageFadeBusyBar.ShowBorder;
			this.checkBoxPingPong.Checked = this.imageFadeBusyBar.PingPong;
		}

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing )
		{
			if( disposing )
			{
				if(components != null)
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
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ImageFadeBusyBarDemo));
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.groupBoxColors = new System.Windows.Forms.GroupBox();
			this.textBoxImageName = new System.Windows.Forms.TextBox();
			this.buttonBrowse = new System.Windows.Forms.Button();
			this.label = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.colorBoxBackground = new System.Windows.Forms.Label();
			this.colorBoxForeground = new System.Windows.Forms.Label();
			this.buttonImageSet = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.buttonStart = new System.Windows.Forms.Button();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.checkBoxPingPong = new System.Windows.Forms.CheckBox();
			this.label99 = new System.Windows.Forms.Label();
			this.label98 = new System.Windows.Forms.Label();
			this.textboxStepSize = new System.Windows.Forms.TextBox();
			this.textboxStepTimeout = new System.Windows.Forms.TextBox();
			this.buttonOptionsSet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.checkBoxShowBorder = new System.Windows.Forms.CheckBox();
			this.imageFadeBusyBar = new System.Windows.Forms.BusyBar.ImageFadeBusyBar();
			this.label10 = new System.Windows.Forms.Label();
			this.textBoxText = new System.Windows.Forms.TextBox();
			this.groupBoxColors.SuspendLayout();
			this.groupBoxOptions.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBoxColors
			// 
			this.groupBoxColors.Controls.Add(this.textBoxImageName);
			this.groupBoxColors.Controls.Add(this.buttonBrowse);
			this.groupBoxColors.Controls.Add(this.label);
			this.groupBoxColors.Controls.Add(this.label2);
			this.groupBoxColors.Controls.Add(this.label5);
			this.groupBoxColors.Controls.Add(this.colorBoxBackground);
			this.groupBoxColors.Controls.Add(this.colorBoxForeground);
			this.groupBoxColors.Controls.Add(this.buttonImageSet);
			this.groupBoxColors.Location = new System.Drawing.Point(16, 40);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(360, 168);
			this.groupBoxColors.TabIndex = 14;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Colors";
			// 
			// textBoxImageName
			// 
			this.textBoxImageName.Location = new System.Drawing.Point(160, 96);
			this.textBoxImageName.Name = "textBoxImageName";
			this.textBoxImageName.Size = new System.Drawing.Size(144, 20);
			this.textBoxImageName.TabIndex = 2;
			this.textBoxImageName.Text = "";
			// 
			// buttonBrowse
			// 
			this.buttonBrowse.Location = new System.Drawing.Point(320, 96);
			this.buttonBrowse.Name = "buttonBrowse";
			this.buttonBrowse.Size = new System.Drawing.Size(24, 23);
			this.buttonBrowse.TabIndex = 1;
			this.buttonBrowse.Text = "...";
			this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click);
			// 
			// label
			// 
			this.label.Location = new System.Drawing.Point(16, 32);
			this.label.Name = "label";
			this.label.Size = new System.Drawing.Size(112, 16);
			this.label.TabIndex = 0;
			this.label.Text = "Background Color";
			this.label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(16, 64);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 16);
			this.label2.TabIndex = 0;
			this.label2.Text = "Foreground Color";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Image";
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
			// buttonImageSet
			// 
			this.buttonImageSet.Location = new System.Drawing.Point(160, 128);
			this.buttonImageSet.Name = "buttonImageSet";
			this.buttonImageSet.Size = new System.Drawing.Size(80, 23);
			this.buttonImageSet.TabIndex = 1;
			this.buttonImageSet.Text = "Set";
			this.buttonImageSet.Click += new System.EventHandler(this.buttonImageSet_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(16, 80);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 16);
			this.label4.TabIndex = 13;
			this.label4.Text = "Slide Color 2";
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(16, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 16);
			this.label1.TabIndex = 11;
			this.label1.Text = "Slide Color";
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(392, 16);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(75, 24);
			this.buttonStart.TabIndex = 10;
			this.buttonStart.Text = "Start";
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.label10);
			this.groupBoxOptions.Controls.Add(this.textBoxText);
			this.groupBoxOptions.Controls.Add(this.checkBoxPingPong);
			this.groupBoxOptions.Controls.Add(this.label99);
			this.groupBoxOptions.Controls.Add(this.label98);
			this.groupBoxOptions.Controls.Add(this.textboxStepSize);
			this.groupBoxOptions.Controls.Add(this.textboxStepTimeout);
			this.groupBoxOptions.Controls.Add(this.buttonOptionsSet);
			this.groupBoxOptions.Controls.Add(this.label6);
			this.groupBoxOptions.Controls.Add(this.label7);
			this.groupBoxOptions.Controls.Add(this.label9);
			this.groupBoxOptions.Controls.Add(this.checkBoxShowBorder);
			this.groupBoxOptions.Location = new System.Drawing.Point(16, 216);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Size = new System.Drawing.Size(360, 216);
			this.groupBoxOptions.TabIndex = 9;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "Options";
			// 
			// checkBoxPingPong
			// 
			this.checkBoxPingPong.Location = new System.Drawing.Point(160, 88);
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
			this.buttonOptionsSet.Size = new System.Drawing.Size(75, 44);
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
			this.label7.Location = new System.Drawing.Point(16, 88);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 24);
			this.label7.TabIndex = 1;
			this.label7.Text = "Ping Pong";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label9
			// 
			this.label9.Location = new System.Drawing.Point(16, 112);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(100, 24);
			this.label9.TabIndex = 1;
			this.label9.Text = "Show Border";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// checkBoxShowBorder
			// 
			this.checkBoxShowBorder.Location = new System.Drawing.Point(160, 112);
			this.checkBoxShowBorder.Name = "checkBoxShowBorder";
			this.checkBoxShowBorder.Size = new System.Drawing.Size(40, 24);
			this.checkBoxShowBorder.TabIndex = 4;
			this.checkBoxShowBorder.CheckedChanged += new System.EventHandler(this.checkBoxShowBorder_CheckedChanged);
			// 
			// imageFadeBusyBar
			// 
			this.imageFadeBusyBar.BackColor = System.Drawing.SystemColors.Control;
			this.imageFadeBusyBar.BorderStyle3D = System.Windows.Forms.Border3DStyle.SunkenInner;
			this.imageFadeBusyBar.ForeColor = System.Drawing.SystemColors.Highlight;
			this.imageFadeBusyBar.Image = ((System.Drawing.Image)(resources.GetObject("imageFadeBusyBar.Image")));
			this.imageFadeBusyBar.Location = new System.Drawing.Point(16, 16);
			this.imageFadeBusyBar.Name = "imageFadeBusyBar";
			this.imageFadeBusyBar.PingPong = false;
			this.imageFadeBusyBar.ShowBorder = true;
			this.imageFadeBusyBar.Size = new System.Drawing.Size(360, 16);
			this.imageFadeBusyBar.StepSize = 5;
			this.imageFadeBusyBar.StepTimeout = 50;
			this.imageFadeBusyBar.TabIndex = 15;
			this.imageFadeBusyBar.TextColor = System.Drawing.SystemColors.ControlText;
			// 
			// label10
			// 
			this.label10.Location = new System.Drawing.Point(16, 136);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(100, 24);
			this.label10.TabIndex = 5;
			this.label10.Text = "Text";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// textBoxText
			// 
			this.textBoxText.Location = new System.Drawing.Point(160, 136);
			this.textBoxText.Name = "textBoxText";
			this.textBoxText.Size = new System.Drawing.Size(184, 20);
			this.textBoxText.TabIndex = 6;
			this.textBoxText.Text = "";
			this.textBoxText.TextChanged += new System.EventHandler(this.textBoxText_TextChanged);
			// 
			// ImageFadeBusyBarDemo
			// 
			this.ClientSize = new System.Drawing.Size(480, 546);
			this.Controls.Add(this.imageFadeBusyBar);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.groupBoxOptions);
			this.Name = "ImageFadeBusyBarDemo";
			this.Text = "ImageFadeBusyBarDemo";
			this.groupBoxColors.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion

		private void buttonImageSet_Click(object sender, System.EventArgs e)
		{
			try
			{
				Image image = Image.FromFile( this.textBoxImageName.Text );
				this.imageFadeBusyBar.Image = image;
			}
			catch
			{
				this.imageFadeBusyBar.Image = null;		
			}
		}

		private void buttonBrowse_Click(object sender, System.EventArgs e)
		{
			if (openFileDialog.ShowDialog() != System.Windows.Forms.DialogResult.OK)
				return;


			this.textBoxImageName.Text = openFileDialog.FileName;
		}

		private void checkBoxPingPong_CheckedChanged(object sender, System.EventArgs e)
		{
			this.imageFadeBusyBar.PingPong = this.checkBoxPingPong.Checked;		
		}

		private void checkBoxShowBorder_CheckedChanged(object sender, System.EventArgs e)
		{
			this.imageFadeBusyBar.ShowBorder = this.checkBoxShowBorder.Checked;		
		}

		private void buttonOptionsSet_Click(object sender, System.EventArgs e)
		{
			int iStepSize;
			int iTimeOut;

			try
			{
				iTimeOut = Convert.ToInt32( this.textboxStepTimeout.Text );
				iStepSize = Convert.ToInt32( this.textboxStepSize.Text );
				
				if(iTimeOut <= 0)
					throw new Exception();

				if(iStepSize <= 0)
					throw new Exception();

				this.imageFadeBusyBar.StepTimeout = iTimeOut;
				this.imageFadeBusyBar.StepSize = iStepSize;
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show( "Invalid number entered" );
				this.textboxStepSize.Text = this.imageFadeBusyBar.StepSize.ToString();
				this.textboxStepTimeout.Text = this.imageFadeBusyBar.StepTimeout.ToString();
			}		
		}

		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			if ( this.imageFadeBusyBar.IsRunning )
			{
				this.buttonStart.Text = "Start";
				this.imageFadeBusyBar.Stop();
			}
			else
			{
				this.buttonStart.Text = "Stop";
				this.imageFadeBusyBar.Start();
			}
		}

		private void colorBoxBackground_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxBackground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxBackground.BackColor = this.colorDialog1.Color;
			this.imageFadeBusyBar.BackColor = this.colorDialog1.Color;			
		}

		private void colorBoxForeground_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxForeground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxForeground.BackColor = this.colorDialog1.Color;
			this.imageFadeBusyBar.ForeColor = this.colorDialog1.Color;				
		}

		private void textBoxText_TextChanged(object sender, System.EventArgs e)
		{
			this.imageFadeBusyBar.Text = this.textBoxText.Text;
		}



	}
}
