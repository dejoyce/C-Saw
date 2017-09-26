using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Windows.Forms;
using System.Threading;

namespace System.Windows.Forms.BusyBar
{
	public abstract class BusyBarBase : System.Windows.Forms.UserControl
	{
		protected bool						_bRunning		= false;
		protected int						_iBarPosition	= 0;
		protected int						_iStepSize		= DefaultStepSize;
		protected int						_iStepTimeout	= DefaultStepTimeout;
		protected bool						_bDisposing		= false;
		protected System.Threading.Thread	_thread;
		protected SolidBrush				_backgroundBrush;


		new public static Color DefaultForeColor
		{	get	{	return	SystemColors.Highlight;	}	}
		new public static Color DefaultBackColor
		{	get	{	return	SystemColors.Control;	}	}
		public static int DefaultStepSize
		{	get	{	return	1;	}	}
		public static int DefaultStepTimeout
		{	get	{	return	250;	}	}

		public int StepTimeout
		{
			get	{	return _iStepTimeout;	}
			set	{	_iStepTimeout = value;	}
		}
		public int StepSize
		{
			get	{	return _iStepSize;	}
			set	{	_iStepSize = value;	}
		}

		public BusyBarBase()
		{
			this.ForeColor = DefaultForeColor;
			this.BackColor = DefaultBackColor;
		
			this.Size = new Size( 300, 25); //default size

			CreateBackgroundBrush();

			// Turn on double buffering to reduce flicker here
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.ResizeRedraw, true);
			UpdateStyles();

			_thread = new Thread( new System.Threading.ThreadStart( WorkerThread ) );
			_thread.Start();

		}

		protected override void OnBackColorChanged(EventArgs e)
		{
			CreateBackgroundBrush();
		}



		protected void CreateBackgroundBrush()
		{
			lock(this)
			{
				_backgroundBrush = new SolidBrush( this.BackColor );
			}
		}
		

		//we do not erase the background. this would cause "flickering"
		protected override void OnPaintBackground( PaintEventArgs e)
		{

		}

		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
			_bDisposing = true;
			bool bRet = _thread.Join( new TimeSpan(1,1,1,1) );
			bRet = _thread.IsAlive;
		}

		protected virtual void DoPaint( System.Drawing.Graphics g )
		{
		}

		protected virtual void IncreaseBarPosition()
		{
			_iBarPosition += _iStepSize;
		}

		protected void WorkerThread()
		{
			while ( _bDisposing == false )
			{
				System.Threading.Thread.Sleep( this._iStepTimeout );		
				
				if (_bRunning == false)
					continue;	
				
				IncreaseBarPosition();
				
				this.Invalidate();
			}
		}

		public bool IsRunning
		{
			get	{	return _bRunning;	}	
		}

		public void Start()
		{
			_bRunning = true;
		}

		public void Stop()
		{
			_bRunning = false;
		}

		//do not allow to override OnPaint() in derived classed because we do a lock here
		protected sealed override void OnPaint(PaintEventArgs e) 
		{
			lock( this )
			{
				DoPaint( e.Graphics );
			}
		}

		//
		// hide the following attributes	
		//
		[Browsable(false)]
		public override System.Drawing.Image BackgroundImage
		{	get	{	return null;	}
			set	{}
		}

	}
}
