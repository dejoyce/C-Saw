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
	public class BlockFadeBusyBarDemo : System.Windows.Forms.Form

#else
	public class BlockFadeBusyBarDemo : System.Windows.Forms.TabPage

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
		private System.Windows.Forms.Button buttonReset;
		private System.Windows.Forms.GroupBox groupBoxOptions;
		private System.Windows.Forms.Button buttonResetColors;
		private System.Windows.Forms.BusyBar.BlockFadeBusyBar blockFadeBusyBar1;
		private System.Windows.Forms.Label label99;
		private System.Windows.Forms.Label label98;
		private System.Windows.Forms.TextBox textboxStepTimeout;
		private System.Windows.Forms.TextBox textboxStepSize;
		private System.Windows.Forms.Button buttonOptionsSet;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label colorBoxCurrent;
		private System.Windows.Forms.Label colorBoxBorder;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.CheckBox checkBoxRandom;


		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;

		public BlockFadeBusyBarDemo()
		{
			InitializeComponent();

			this.colorBoxBackground.BackColor = this.blockFadeBusyBar1.BackColor;
			this.colorBoxForeground.BackColor = this.blockFadeBusyBar1.ForeColor;
			this.colorBoxCurrent.BackColor = this.blockFadeBusyBar1.CurrentFillColor;
			this.colorBoxBorder.BackColor = this.blockFadeBusyBar1.BorderColor;

			this.textboxStepTimeout.Text = this.blockFadeBusyBar1.StepTimeout.ToString();
			this.textboxStepSize.Text = this.blockFadeBusyBar1.StepSize.ToString();

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
			this.colorBoxCurrent = new System.Windows.Forms.Label();
			this.colorBoxBorder = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.buttonReset = new System.Windows.Forms.Button();
			this.groupBoxOptions = new System.Windows.Forms.GroupBox();
			this.checkBoxRandom = new System.Windows.Forms.CheckBox();
			this.label99 = new System.Windows.Forms.Label();
			this.label98 = new System.Windows.Forms.Label();
			this.textboxStepSize = new System.Windows.Forms.TextBox();
			this.textboxStepTimeout = new System.Windows.Forms.TextBox();
			this.buttonOptionsSet = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.blockFadeBusyBar1 = new System.Windows.Forms.BusyBar.BlockFadeBusyBar();
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
			this.groupBoxColors.Controls.Add(this.colorBoxCurrent);
			this.groupBoxColors.Controls.Add(this.colorBoxBorder);
			this.groupBoxColors.Controls.Add(this.label11);
			this.groupBoxColors.Location = new System.Drawing.Point(16, 40);
			this.groupBoxColors.Name = "groupBoxColors";
			this.groupBoxColors.Size = new System.Drawing.Size(360, 168);
			this.groupBoxColors.TabIndex = 6;
			this.groupBoxColors.TabStop = false;
			this.groupBoxColors.Text = "Colors";
			// 
			// buttonResetColors
			// 
			this.buttonResetColors.Location = new System.Drawing.Point(272, 120);
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
			this.label2.Text = "Foreground";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(16, 96);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 16);
			this.label5.TabIndex = 0;
			this.label5.Text = "Current";
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
			// colorBoxCurrent
			// 
			this.colorBoxCurrent.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.colorBoxCurrent.Location = new System.Drawing.Point(160, 96);
			this.colorBoxCurrent.Name = "colorBoxCurrent";
			this.colorBoxCurrent.Size = new System.Drawing.Size(56, 16);
			this.colorBoxCurrent.TabIndex = 0;
			this.colorBoxCurrent.Click += new System.EventHandler(this.colorBoxCurrent_Click);
			// 
			// colorBoxBorder
			// 
			this.colorBoxBorder.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.colorBoxBorder.Location = new System.Drawing.Point(160, 128);
			this.colorBoxBorder.Name = "colorBoxBorder";
			this.colorBoxBorder.Size = new System.Drawing.Size(56, 16);
			this.colorBoxBorder.TabIndex = 0;
			this.colorBoxBorder.Click += new System.EventHandler(this.colorBoxBorder_Click);
			// 
			// label11
			// 
			this.label11.Location = new System.Drawing.Point(16, 128);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(100, 16);
			this.label11.TabIndex = 0;
			this.label11.Text = "Border";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// buttonReset
			// 
			this.buttonReset.Location = new System.Drawing.Point(0, 0);
			this.buttonReset.Name = "buttonReset";
			this.buttonReset.TabIndex = 0;
			// 
			// groupBoxOptions
			// 
			this.groupBoxOptions.Controls.Add(this.checkBoxRandom);
			this.groupBoxOptions.Controls.Add(this.label99);
			this.groupBoxOptions.Controls.Add(this.label98);
			this.groupBoxOptions.Controls.Add(this.textboxStepSize);
			this.groupBoxOptions.Controls.Add(this.textboxStepTimeout);
			this.groupBoxOptions.Controls.Add(this.buttonOptionsSet);
			this.groupBoxOptions.Controls.Add(this.label6);
			this.groupBoxOptions.Location = new System.Drawing.Point(16, 216);
			this.groupBoxOptions.Name = "groupBoxOptions";
			this.groupBoxOptions.Size = new System.Drawing.Size(360, 216);
			this.groupBoxOptions.TabIndex = 0;
			this.groupBoxOptions.TabStop = false;
			this.groupBoxOptions.Text = "Options";
			// 
			// checkBoxRandom
			// 
			this.checkBoxRandom.Location = new System.Drawing.Point(16, 80);
			this.checkBoxRandom.Name = "checkBoxRandom";
			this.checkBoxRandom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.checkBoxRandom.Size = new System.Drawing.Size(158, 24);
			this.checkBoxRandom.TabIndex = 4;
			this.checkBoxRandom.Text = "Random Mode";
			this.checkBoxRandom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.checkBoxRandom.CheckedChanged += new System.EventHandler(this.checkBoxRandom_CheckedChanged);
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
			// blockFadeBusyBar1
			// 
			this.blockFadeBusyBar1.BackColor = System.Drawing.SystemColors.Control;
			this.blockFadeBusyBar1.BlockWidth = 30;
			this.blockFadeBusyBar1.BorderColor = System.Drawing.Color.Black;
			this.blockFadeBusyBar1.CurrentFillColor = System.Drawing.SystemColors.HighlightText;
			this.blockFadeBusyBar1.ForeColor = System.Drawing.SystemColors.Highlight;
			this.blockFadeBusyBar1.Location = new System.Drawing.Point(16, 16);
			this.blockFadeBusyBar1.Name = "blockFadeBusyBar1";
			this.blockFadeBusyBar1.RandomMode = false;
			this.blockFadeBusyBar1.Size = new System.Drawing.Size(360, 16);
			this.blockFadeBusyBar1.StepSize = 1;
			this.blockFadeBusyBar1.StepTimeout = 250;
			this.blockFadeBusyBar1.TabIndex = 7;
			// 
			// BlockFadeBusyBarDemo
			// 
			this.ClientSize = new System.Drawing.Size(478, 440);
			this.Controls.Add(this.blockFadeBusyBar1);
			this.Controls.Add(this.groupBoxOptions);
			this.Controls.Add(this.groupBoxColors);
			this.Controls.Add(this.buttonStart);
			this.Name = "BlockFadeBusyBarDemo";
			this.Text = "blockFadeBusyBarDemo";
			this.groupBoxColors.ResumeLayout(false);
			this.groupBoxOptions.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion




		private void buttonStart_Click(object sender, System.EventArgs e)
		{
			if ( this.blockFadeBusyBar1.IsRunning )
			{
				this.buttonStart.Text = "Start";
				this.blockFadeBusyBar1.Stop();
			}
			else
			{
				this.buttonStart.Text = "Stop";
				this.blockFadeBusyBar1.Start();
			}
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

				this.blockFadeBusyBar1.StepTimeout = iTimeOut;
				this.blockFadeBusyBar1.StepSize = iStepSize;
			}
			catch
			{
				System.Windows.Forms.MessageBox.Show( "Invalid number entered" );
				this.textboxStepSize.Text = this.blockFadeBusyBar1.StepSize.ToString();
				this.textboxStepTimeout.Text = this.blockFadeBusyBar1.StepTimeout.ToString();
			}
		}

		private void colorBoxForeground_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxForeground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxForeground.BackColor = this.colorDialog1.Color;
			this.blockFadeBusyBar1.ForeColor = this.colorDialog1.Color;			
		}

		private void colorBoxCurrent_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxCurrent.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxCurrent.BackColor = this.colorDialog1.Color;
			this.blockFadeBusyBar1.CurrentFillColor = this.colorDialog1.Color;
		}

		private void colorBoxBackground_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxBackground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxBackground.BackColor = this.colorDialog1.Color;
			this.blockFadeBusyBar1.BackColor = this.colorDialog1.Color;		
		}

		private void buttonResetColors_Click(object sender, System.EventArgs e)
		{
			this.blockFadeBusyBar1.ForeColor = System.Windows.Forms.BusyBar.FadeBusyBar.DefaultForeColor;
			this.blockFadeBusyBar1.BackColor = System.Windows.Forms.BusyBar.FadeBusyBar.DefaultBackColor;
			this.blockFadeBusyBar1.BorderColor = System.Windows.Forms.BusyBar.BlockFadeBusyBar.DefaultBorderColor;
			this.blockFadeBusyBar1.CurrentFillColor = System.Windows.Forms.BusyBar.BlockFadeBusyBar.DefaultCurrentPositionColor;


			this.colorBoxBackground.BackColor = this.blockFadeBusyBar1.BackColor;
			this.colorBoxForeground.BackColor = this.blockFadeBusyBar1.ForeColor;
			this.colorBoxBorder.BackColor = this.blockFadeBusyBar1.BorderColor;
			this.colorBoxCurrent.BackColor = this.blockFadeBusyBar1.CurrentFillColor;
		}

		private void colorBoxBorder_Click(object sender, System.EventArgs e)
		{
			this.colorDialog1.Color = this.colorBoxBackground.BackColor;
			if ( this.colorDialog1.ShowDialog() != DialogResult.OK )
				return;
			this.colorBoxBorder.BackColor = this.colorDialog1.Color;
			this.blockFadeBusyBar1.BorderColor = this.colorDialog1.Color;				
		}

		private void checkBoxRandom_CheckedChanged(object sender, System.EventArgs e)
		{
			this.blockFadeBusyBar1.RandomMode = this.checkBoxRandom.Checked;

			this.textboxStepSize.Enabled = !this.checkBoxRandom.Checked;
		}

	}
}
