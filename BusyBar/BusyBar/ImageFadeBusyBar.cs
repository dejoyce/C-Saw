using System;
using System.Drawing;

namespace System.Windows.Forms.BusyBar
{
	public class ImageFadeBusyBar : FadeBusyBar
	{
		public ImageFadeBusyBar()
		{
			CreateInitialImage();
			CreateImage();
		}


		public Image Image
		{
			get{	return this._imageForward;	}
			set
			{	
				lock(this)
				{
					if (value == null)
						CreateInitialImage();
					else
						this._imageForward = value;
					
					CreateImage(); 
					Invalidate();
				}
			}	
		}

		protected void CreateInitialImage()
		{
			lock(this)
			{
				int iHeight = this.Height;

				if (this.ShowBorder)
					iHeight -= 2;

				_imageForward = new Bitmap( 30, iHeight, System.Drawing.Imaging.PixelFormat.Format24bppRgb );

				Graphics gfx = Graphics.FromImage(_imageForward );
				for (int i=0 ; i<_imageForward.Width; i++)
				{
					//
					// calculate the new color to use (linear color mix)
					//
					int colorR = ( (int)(this.ForeColor.R - this.BackColor.R ) ) * i / _imageForward.Width;
					int colorG = ( (int)(this.ForeColor.G - this.BackColor.G ) ) * i / _imageForward.Width;
					int colorB = ( (int)(this.ForeColor.B - this.BackColor.B ) ) * i / _imageForward.Width;
					Color color = Color.FromArgb( this.BackColor.R+colorR, this.BackColor.G+colorG, this.BackColor.B+colorB );

					gfx.DrawLine( new Pen( new SolidBrush( color )), i, 0, i, iHeight );
				}
			}
		}

		protected override void CreateImage()
		{
			lock(this)
			{
				this._imageReverse = (Image)this._imageForward.Clone();
				this._imageReverse.RotateFlip( RotateFlipType.Rotate180FlipNone);	
			}
		}

	
	}
}
