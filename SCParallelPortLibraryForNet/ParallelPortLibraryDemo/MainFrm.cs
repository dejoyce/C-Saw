using System;
using System.Windows.Forms;
using ParallelPortLibrary;

namespace ParallelPortLibraryDemo
{
    public partial class MainFrm : Form
    {
        //Parallel Port Instance.
        private ParallelPort parallelPort;
        
        //Constructor.
        public MainFrm()
        {
            InitializeComponent();
            MessageBox.Show("PLEASE REMEMBER YOU MUST CONNECT EVERYTHING THROUGH A 500 Ohm RESISTOR!!! OTHERWISE YOU MAY CAUSE HARM TO YOUR PC!!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            DisableControls();
        }

        //Open LPT Port.
        private void OpenLPTPort(ParallelPort.Ports port)
        {
            try
            {
                //Close LPT Port if opened.
                if (parallelPort != null) if (parallelPort.IsOpened) parallelPort.Close();
                //Try to open LPT Port.
                parallelPort = new ParallelPort("Unregistered", "User", port);
                parallelPort.Open();
                switch (port)
                {
                    case ParallelPort.Ports.LPT1: lptPortComboBox.SelectedItem = "LPT1 378h"; break;
                    case ParallelPort.Ports.LPT2: lptPortComboBox.SelectedItem = "LPT2 278h"; break;
                }
                //Set the mode to be current LPT Port mode.
                SetLPTPortMode(parallelPort.Mode);
                //Turn on an Event raising mechanism.
                parallelPort.PinStateChanged += new ParallelPort.PinStateChangedHandler(parallelPort_PinStateChanged);
                parallelPort.RaiseEvents = true;
            }
            catch (LPTPortAlreadyInUseException)
            {
                MessageBox.Show("LPT Port is already in use!", "Error opening the LPT Port.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //Disable controls if an LPT Port opening fails.
                DisableControls();
            }
        }

        //Set LPT Port Read/Write Mode.
        private void SetLPTPortMode(ParallelPort.Modes mode)
        {
            //Set Mode.
            parallelPort.Mode = mode;
            //Enable and update controls.
            EnableControls(mode);
        }

        //Disable Controls.
        private void DisableControls()
        {
            ledUserControl1.Checked = false;
            ledUserControl2.Checked = false;
            ledUserControl3.Checked = false;
            ledUserControl4.Checked = false;
            ledUserControl5.Checked = false;
            ledUserControl6.Checked = false;
            ledUserControl7.Checked = false;
            ledUserControl8.Checked = false;
            ledUserControl9.Checked = false;
            ledUserControl10.Checked = false;
            ledUserControl11.Checked = false;
            ledUserControl12.Checked = false;
            ledUserControl13.Checked = false;
            ledUserControl14.Checked = false;
            ledUserControl15.Checked = false;
            ledUserControl16.Checked = false;
            ledUserControl17.Checked = false;
            ledUserControl1.Enabled = false;
            ledUserControl2.Enabled = false;
            ledUserControl3.Enabled = false;
            ledUserControl4.Enabled = false;
            ledUserControl5.Enabled = false;
            ledUserControl6.Enabled = false;
            ledUserControl7.Enabled = false;
            ledUserControl8.Enabled = false;
            ledUserControl9.Enabled = false;
            ledUserControl10.Enabled = false;
            ledUserControl11.Enabled = false;
            ledUserControl12.Enabled = false;
            ledUserControl13.Enabled = false;
            ledUserControl14.Enabled = false;
            ledUserControl15.Enabled = false;
            ledUserControl16.Enabled = false;
            ledUserControl17.Enabled = false;
            modeComboBox.Enabled = false;
            modeComboBox.Text = "Choose Mode";
            lptPortComboBox.Text = "Choose LPT Port";
        }

        //Enable and update controls.
        private void EnableControls(ParallelPort.Modes mode)
        {
            ledUserControl1.Enabled = true;
            ledUserControl2.Enabled = true;
            ledUserControl3.Enabled = true;
            ledUserControl4.Enabled = true;
            ledUserControl5.Enabled = true;
            ledUserControl6.Enabled = true;
            ledUserControl7.Enabled = true;
            ledUserControl8.Enabled = true;
            ledUserControl9.Enabled = true;
            ledUserControl10.Enabled = true;
            ledUserControl11.Enabled = true;
            ledUserControl12.Enabled = true;
            ledUserControl13.Enabled = true;
            ledUserControl14.Enabled = true;
            ledUserControl15.Enabled = true;
            ledUserControl16.Enabled = true;
            ledUserControl17.Enabled = true;
            ledUserControl1.LedType = LedUserControl.LedTypes.WriteLed;
            ledUserControl2.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl3.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl4.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl5.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl6.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl7.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl8.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl9.LedType = (mode == ParallelPort.Modes.Write) ? LedUserControl.LedTypes.WriteLed : LedUserControl.LedTypes.ReadLed;
            ledUserControl10.LedType = LedUserControl.LedTypes.ReadLed;
            ledUserControl11.LedType = LedUserControl.LedTypes.ReadLed;
            ledUserControl12.LedType = LedUserControl.LedTypes.ReadLed;
            ledUserControl13.LedType = LedUserControl.LedTypes.ReadLed;
            ledUserControl14.LedType = LedUserControl.LedTypes.WriteLed;
            ledUserControl15.LedType = LedUserControl.LedTypes.ReadLed;
            ledUserControl16.LedType = LedUserControl.LedTypes.WriteLed;
            ledUserControl17.LedType = LedUserControl.LedTypes.WriteLed;
            ledUserControl1.Checked = (parallelPort.Pin01 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl2.Checked = (parallelPort.Pin02 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl3.Checked = (parallelPort.Pin03 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl4.Checked = (parallelPort.Pin04 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl5.Checked = (parallelPort.Pin05 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl6.Checked = (parallelPort.Pin06 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl7.Checked = (parallelPort.Pin07 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl8.Checked = (parallelPort.Pin08 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl9.Checked = (parallelPort.Pin09 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl10.Checked = !((parallelPort.Pin10 == ParallelPort.Potentials.Hi) ? true : false);
            ledUserControl11.Checked = !((parallelPort.Pin11 == ParallelPort.Potentials.Hi) ? true : false);
            ledUserControl12.Checked = !((parallelPort.Pin12 == ParallelPort.Potentials.Hi) ? true : false);
            ledUserControl13.Checked = !((parallelPort.Pin13 == ParallelPort.Potentials.Hi) ? true : false);
            ledUserControl14.Checked = (parallelPort.Pin14 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl15.Checked = !((parallelPort.Pin15 == ParallelPort.Potentials.Hi) ? true : false);
            ledUserControl16.Checked = (parallelPort.Pin16 == ParallelPort.Potentials.Hi) ? true : false;
            ledUserControl17.Checked = (parallelPort.Pin17 == ParallelPort.Potentials.Hi) ? true : false;
            if (mode == ParallelPort.Modes.Read)
            {
                ledUserControl2.Checked = !ledUserControl2.Checked;
                ledUserControl3.Checked = !ledUserControl3.Checked;
                ledUserControl4.Checked = !ledUserControl4.Checked;
                ledUserControl5.Checked = !ledUserControl5.Checked;
                ledUserControl6.Checked = !ledUserControl6.Checked;
                ledUserControl7.Checked = !ledUserControl7.Checked;
                ledUserControl8.Checked = !ledUserControl8.Checked;
                ledUserControl9.Checked = !ledUserControl9.Checked;
            }
            modeComboBox.Enabled = true;
            switch (mode)
            {
                case ParallelPort.Modes.Write: modeComboBox.SelectedItem = "Write to Data Pins"; break;
                case ParallelPort.Modes.Read: modeComboBox.SelectedItem = "Read from Data Pins"; break;
            }
        }

        /////////////////////////////////////////////////LED EVENTS///////////////////////////////////////////////////
        private void ledUserControl1_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try { parallelPort.Pin01 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo; }
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl2_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin02 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl3_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin03 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl4_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin04 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl5_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin05 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl6_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin06 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl7_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin07 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl8_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin08 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl9_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin09 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl14_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin14 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl16_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try {parallelPort.Pin16 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo;}
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void ledUserControl17_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            try { parallelPort.Pin17 = (e.Checked) ? ParallelPort.Potentials.Hi : ParallelPort.Potentials.Lo; }
            catch (LPTPortNotOpenedException) { MessageBox.Show("LPT Port is not opened! You must open it first.", "Error setting the LPT Port mode.", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        //////////////////////////////////////////////PARALLEL PORT EVENTS////////////////////////////////////////////////
        private void parallelPort_PinStateChanged(object sender, PinStateChangedEventArgs e)
        {
            switch (e.readablePin)
            {
                case ParallelPort.ReadablePins.Pin02:
                    ledUserControl2.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin03:
                    ledUserControl3.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin04:
                    ledUserControl4.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin05:
                    ledUserControl5.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin06:
                    ledUserControl6.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin07:
                    ledUserControl7.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin08:
                    ledUserControl8.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin09:
                    ledUserControl9.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin10:
                    ledUserControl10.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin11:
                    ledUserControl11.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin12:
                    ledUserControl12.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin13:
                    ledUserControl13.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
                case ParallelPort.ReadablePins.Pin15:
                    ledUserControl15.Checked = !((e.potential == ParallelPort.Potentials.Hi) ? true : false);
                    break;
            }
        }

        /////////////////////////////////////////////////FILE SUBMENU/////////////////////////////////////////////////
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /////////////////////////////////////////////////HELP SUBMENU/////////////////////////////////////////////////
        private void helpTopicsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(Application.StartupPath + @"\..\..\..\SoftCollectionParallelPortLibraryForNET.chm");
        }

        private void visitWebSiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.soft-collection.com");
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox about = new AboutBox();
            about.ShowDialog();
        }

        /////////////////////////////////////////////////MAIN FORM EVENTS////////////////////////////////////////////////
        private void MainFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void lptPortComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)lptPortComboBox.SelectedItem)
            {
                case "LPT1 378h": OpenLPTPort(ParallelPort.Ports.LPT1); break;
                case "LPT2 278h": OpenLPTPort(ParallelPort.Ports.LPT2); break;
            }
        }

        private void modeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch ((string)modeComboBox.SelectedItem)
            {
                case "Write to Data Pins": SetLPTPortMode(ParallelPort.Modes.Write); break;
                case "Read from Data Pins": SetLPTPortMode(ParallelPort.Modes.Read); break;
            }
        }
    }
}