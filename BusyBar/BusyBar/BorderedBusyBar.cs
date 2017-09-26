using System;

namespace System.Windows.Forms.BusyBar
{
	public abstract class BorderedBusyBar : BusyBarBase
	{
		protected Border3DStyle		_iBorderStyle;
		protected bool				_bShowBorder = true;

		protected BorderedBusyBar()
		{
			this._iBorderStyle = Border3DStyle.SunkenInner;
		}
		
		public bool ShowBorder
		{
			get	{	return _bShowBorder;	}
			set	
			{
				_bShowBorder = value;
				OnShowBorderChanged();
				this.Invalidate();
			}
		}

		public Border3DStyle BorderStyle3D
		{
			get	{	return this._iBorderStyle;	}
			set	{	this._iBorderStyle = value;	}
		}

		protected virtual void OnShowBorderChanged()
		{
		}


		protected void DrawBorder(System.Drawing.Graphics g)
		{
			if (_bShowBorder)
				ControlPaint.DrawBorder3D( g, 0,0,this.Width, this.Height, this.BorderStyle3D );
		}

		protected override void DoPaint( System.Drawing.Graphics g )
		{
			DrawBorder( g );
		}

	}
}
