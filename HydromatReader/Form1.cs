using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HydromatReader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            comm.Parity = cboParity.Text;
            comm.StopBits = cboStop.Text;
            comm.DataBits = cboData.Text;
            comm.BaudRate = cboBaud.Text;
            //comm.DisplayWindow = rtbDisplay;
            comm.PortName = cboPort.Text;
            comm.OpenPort();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comm.WriteData("dddddddddddddddddddddddddd");
        }
    }
}
