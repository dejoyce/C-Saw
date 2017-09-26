using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;




namespace BusyBarDemoApp
{
	/// <summary>
	/// Summary description for AppMainForm.
	/// </summary>
	public class AppMainForm : System.Windows.Forms.Form
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.Container components = null;
		private System.Windows.Forms.Button buttonClose;
		private System.Windows.Forms.TabControl tabControl;

		public AppMainForm()
		{
			//
			// Required for Windows Form Designer support
			//
			InitializeComponent();

			//
			// TODO: Add any constructor code after InitializeComponent call
			//
			this.tabControl.TabPages.Add( new ColorFadeBusyBarDemo() );
			this.tabControl.TabPages.Add( new ImageFadeBusyBarDemo() );
			this.tabControl.TabPages.Add( new BlockFadeBusyBarDemo() );

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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Location = new System.Drawing.Point(16, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(496, 472);
            this.tabControl.TabIndex = 0;
            // 
            // buttonClose
            // 
            this.buttonClose.Location = new System.Drawing.Point(432, 504);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(80, 23);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Close";
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // AppMainForm
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(528, 538);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.tabControl);
            this.Name = "AppMainForm";
            this.Text = "BusyBar Demo App";
            this.ResumeLayout(false);

		}
		#endregion

		private void buttonClose_Click(object sender, System.EventArgs e)
		{
			this.Close();
		}

	}
}
