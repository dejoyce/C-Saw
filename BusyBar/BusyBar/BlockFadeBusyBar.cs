using System;
using System.Drawing;
using System.Windows.Forms.BusyBar;


namespace System.Windows.Forms.BusyBar
{
	public class BlockFadeBusyBar : BusyBarBase
	{
		protected Pen	_borderPen;
		protected Color _borderColor = DefaultBorderColor;
		protected Brush _foregroundBrush;
		protected Brush _currentFillBrush;
		protected Color _currentFillColor = DefaultCurrentPositionColor;
		protected Bitmap _blockBitmap;
		protected Bitmap _CurrentBlockBitmap;
		protected int _iBlockCount = -1;
		protected int _iBlockWidth = DefaultBlockWidth;
		protected int _iBlockSpace;
		private bool _bRandomMode = false;
		protected Random _randomNumberGenerator = new Random();

		public static int DefaultBlockWidth
		{	get	{	return 30;	}	}
		public static Color DefaultBorderColor
		{	get	{	return Color.Black;	}	}
		public static Color DefaultCurrentPositionColor
		{	get	{	return SystemColors.HighlightText;	}	}
		new public static int DefaultStepTimeout
		{	get	{	return 250;	}	}
		new public static int DefaultStepSize
		{	get	{	return 1;	}	}

		public bool RandomMode
		{
			get	{	return _bRandomMode;	}	
			set	{	_bRandomMode = value;	}	
		}	

		public BlockFadeBusyBar()
		{
		}

		protected override void OnBackColorChanged(EventArgs e)
		{
			base.OnBackColorChanged(e);
			this.CreateBackgroundBrush();
			this.CreateBlockBitmaps();
			this.Invalidate();
		}

		protected override void OnForeColorChanged(EventArgs e)
		{
			base.OnForeColorChanged(e);
			this.CreateForegroundBrush();
			this.CreateBlockBitmaps();
			this.Invalidate();
		}

		protected override void OnSizeChanged(EventArgs e)
		{
			this.CreateBlockBitmaps();
			this.Invalidate();
		}

		public Color BorderColor
		{
			set
			{	
				_borderColor = value;
				CreateBorderPen();
				CreateBlockBitmaps();
				Invalidate();
			}
			get	{	return _borderColor;	}
		}

		public Color CurrentFillColor
		{
			set
			{	
				_currentFillColor = value;
				CreateFillCurrentBrush();
				CreateBlockBitmaps();
				Invalidate();
			}
			get	{	return _currentFillColor;	}
		}

		public int BlockWidth
		{
			set	
			{	
				_iBlockWidth = value;;
				CreateBlockBitmaps();
				Invalidate();
			}
			get	{	return _iBlockWidth;	}
		}

		protected override void IncreaseBarPosition()
		{
			if ( this._iBlockCount == -1)
				return;

			if (this._bRandomMode)
			{
				int iNewPos;
				
				do {
					iNewPos = _randomNumberGenerator.Next( this._iBlockCount );
				} while (iNewPos == this._iBarPosition);
				_iBarPosition = iNewPos;
			}
			else
			{
				_iBarPosition += this._iStepSize;
				if ( _iBarPosition > _iBlockCount-1)
					_iBarPosition= _iBarPosition-this._iBlockCount;
			}
		}

		protected void CreateBlockBitmaps()
		{
			try
			{
				lock(this)
				{
					//
					// create the block bitmap, erase the bitmap using the control's background color and clone it to get the current bitmap
					//
					this._blockBitmap			= new Bitmap( this._iBlockWidth, this.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb );
					Graphics gfx1 = Graphics.FromImage( this._blockBitmap );
					gfx1.FillRectangle( this._backgroundBrush, 0,0, this._blockBitmap.Width, this._blockBitmap.Height );
					this._CurrentBlockBitmap = (Bitmap) this._blockBitmap.Clone();
					Graphics gfx2 = Graphics.FromImage( this._CurrentBlockBitmap );


					gfx1.FillRectangle( this._foregroundBrush, 0,0, this._iBlockWidth, this._blockBitmap.Height);
					gfx2.FillRectangle( this._currentFillBrush, 0,0, this._iBlockWidth, this._CurrentBlockBitmap.Height );

					//
					// draw the border
					//
					gfx1.DrawLine( this._borderPen, 0,0, this._CurrentBlockBitmap.Width, 0);
					gfx1.DrawLine( this._borderPen, 0,0, 0, this._CurrentBlockBitmap.Height);
					gfx1.DrawLine( this._borderPen, this._CurrentBlockBitmap.Width-1,0, this._CurrentBlockBitmap.Width-1, this._CurrentBlockBitmap.Height-1);
					gfx1.DrawLine( this._borderPen, 0,this._CurrentBlockBitmap.Height-1, this._CurrentBlockBitmap.Width-1, this._CurrentBlockBitmap.Height-1);

					gfx2.DrawLine( this._borderPen, 0,0, this._CurrentBlockBitmap.Width, 0);
					gfx2.DrawLine( this._borderPen, 0,0, 0, this._CurrentBlockBitmap.Height);
					gfx2.DrawLine( this._borderPen, this._CurrentBlockBitmap.Width-1,0, this._CurrentBlockBitmap.Width-1, this._CurrentBlockBitmap.Height-1);
					gfx2.DrawLine( this._borderPen, 0,this._CurrentBlockBitmap.Height-1, this._CurrentBlockBitmap.Width-1, this._CurrentBlockBitmap.Height-1);
				}
			}
			catch( Exception e)
			{
			}
		}

		protected void CreateFillCurrentBrush()
		{
			this._currentFillBrush = new SolidBrush( this._currentFillColor );
		}
		protected void CreateForegroundBrush()
		{
			this._foregroundBrush = new SolidBrush( this.ForeColor );
		}
		protected void CreateBorderPen()
		{
			this._borderPen = new Pen( this._borderColor );
		}

		protected override void DoPaint( System.Drawing.Graphics g )
		{
			int iDrawHeight = this.Height;

			g.FillRectangle( this._backgroundBrush, 0,0,this.Width, this.Height);

			//
			// calculate the amount of blocks to draw
			//
			_iBlockCount = this.Width / ( this._iBlockWidth + this._iBlockWidth/5); //initial space is the width/5s (can change later to fit the block on the right and left border)

			if (_iBlockCount<2)
				return;

			double dSpace = ( Convert.ToDouble(this.Width) - Convert.ToDouble( _iBlockCount * this._iBlockWidth) ) / Convert.ToDouble( _iBlockCount-1);
			for (int i=0 ; i<_iBlockCount ; i++)
			{
				double dPos = Convert.ToDouble(i) * (Convert.ToDouble(this._iBlockWidth+dSpace));

				if (i==this._iBarPosition)
					g.DrawImage( this._CurrentBlockBitmap, Convert.ToInt32(dPos), 0 );
				else
					g.DrawImage( this._blockBitmap, Convert.ToInt32(dPos), 0 );			
			}

		}
	}
}
