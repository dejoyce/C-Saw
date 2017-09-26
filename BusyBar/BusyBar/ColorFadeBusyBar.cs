using System;
using System.Drawing;

namespace System.Windows.Forms.BusyBar
{
	public class ColorFadeBusyBar : FadeBusyBar
	{
		protected Color		_color2;
		protected int		_iFadeLength;

		public static Color DefaultColor2
		{	get	{	return	SystemColors.Control;	}	}

		public ColorFadeBusyBar()
		{
			this.Color2 = DefaultColor2;

			this._iStepTimeout = 50;
			this._iStepSize = 5;
			this._iFadeLength = -1;
		}

		public int FadeLength
		{
			get	{	return this._iFadeLength;	}
			set
			{
				lock(this)
				{
					if ( value > this.Width)
						throw new Exception("FadeLength cannot be bigger than the width of the control" );
					_iFadeLength = value;
					CreateImage();
					Invalidate();
				}
			}
		}

		protected override void CreateImage()
		{
			lock(this)
			{
				int iLen;
				int iHeight = this.Height;

				if (this.ShowBorder)
					iHeight -= 2;

				if (this._iFadeLength <= 0)
					iLen = this.Width/2;
				else
					iLen = this._iFadeLength;

				this._imageForward = new Bitmap( iLen, iHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb );

				Graphics gfx = Graphics.FromImage(_imageForward );

				System.Drawing.Drawing2D.LinearGradientBrush washBrush = new System.Drawing.Drawing2D.LinearGradientBrush( new Rectangle(0,0, _imageForward.Width,_imageForward.Height) , this._color2, this.ForeColor, 0.90f, true);
				gfx.FillRectangle(washBrush,this.ClientRectangle);
/*
				for (int i=0 ; i<_imageForward.Width; i++)
				{
					//
					// calculate the new color to use (linear color mix)
					//
					int colorR = ( (int)(this.ForeColor.R - this.Color2.R ) ) * i / _imageForward.Width;
					int colorG = ( (int)(this.ForeColor.G - this.Color2.G ) ) * i / _imageForward.Width;
					int colorB = ( (int)(this.ForeColor.B - this.Color2.B ) ) * i / _imageForward.Width;
					Color color = Color.FromArgb( this.Color2.R+colorR, this.Color2.G+colorG, this.Color2.B+colorB );

					gfx.DrawLine( new Pen( new SolidBrush( color )), i, 0, i, iHeight );
				}
*/		
				this._imageReverse = (Image)this._imageForward.Clone();
				this._imageReverse.RotateFlip( RotateFlipType.Rotate180FlipNone);
			}
		}

		public Color Color2
		{
			get	{	return _color2;	}
			set	
			{	
				_color2 = value;
				OnColor2Changed();
			}
		}
		
		protected override void OnSizeChanged(EventArgs e)
		{
			CreateImage();
			this.Invalidate();
		}


		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			CreateImage();
			this.Invalidate();
		}
		protected override void OnForeColorChanged(EventArgs e)
		{
			CreateImage();
			this.Invalidate();
		}

		protected void OnColor2Changed()
		{
			CreateImage();
			this.Invalidate();
		}
	}
}
