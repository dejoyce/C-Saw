using System;
using System.Drawing;
using System.Windows.Forms;

namespace ParallelPortLibraryDemo
{
    public partial class LedUserControl : UserControl
    {
        //Possible LED types.
        public enum LedTypes { ReadLed, WriteLed }
        //Current LED type.
        private LedTypes ledType = LedTypes.WriteLed;
        //Current LED state (checked/unchecked).
        private bool check = false;
        //Previous LED state (checked/unchecked).
        private bool previousCheck = true;
        /// <summary>
        /// Gets or sets LED type.
        /// </summary>
        public LedTypes LedType
        {
            get { return (ledType); }
            set
            {
                if (value == LedTypes.WriteLed) Cursor = Cursors.Hand; else Cursor = Cursors.Arrow;
                ledType = value;
            }
        }
        /// <summary>
        /// Gets or sets LED state.
        /// </summary>
        public bool Checked { get { return (check); } set { check = value; } }

        public delegate void CheckedChangedHandler(Object sender, CheckedChangedEventArgs e);
        /// <summary>
        /// Occurs when you clicks with the mouse on the LED.
        /// </summary>
        public event CheckedChangedHandler CheckedChanged;

        //Constructor.
        public LedUserControl()
        {
            InitializeComponent();
            Cursor = Cursors.Hand;
        }

        //On mouse down event.
        private void LedUserControl_MouseDown(object sender, MouseEventArgs e)
        {
            if (ledType == LedTypes.WriteLed)
            {
                this.check = !this.check;
                //Raise Event.
                if (CheckedChanged != null)
                {
                    CheckedChangedEventArgs e1 = new CheckedChangedEventArgs(this.check);
                    CheckedChanged(this, e1);
                }
            }
        }

        //On paint event.
        private void LedUserControl_Paint(object sender, PaintEventArgs e)
        {
            if (this.check)
            {
                if (ledType == LedTypes.WriteLed) e.Graphics.DrawImage(global::ParallelPortLibraryDemo.Properties.Resources.led_yellow, 0, 0);
                else e.Graphics.DrawImage(global::ParallelPortLibraryDemo.Properties.Resources.led_aqua, 0, 0);
            }
            else e.Graphics.DrawImage(global::ParallelPortLibraryDemo.Properties.Resources.led_gray, 0, 0);
        }

        //On timer event.
        private void refreshTimer_Tick(object sender, EventArgs e)
        {
            if (previousCheck != check)
            {
                this.Refresh();
                previousCheck = check;
            }
        }
    }

    /// <summary>
    /// Occurs when you clicks with the mouse on the LED.
    /// </summary>
    public class CheckedChangedEventArgs : EventArgs
    {
        public readonly bool Checked;
        public CheckedChangedEventArgs(bool Checked) { this.Checked = Checked; }
    }
}