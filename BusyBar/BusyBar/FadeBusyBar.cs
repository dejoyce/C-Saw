using System;
using System.Drawing;

namespace System.Windows.Forms.BusyBar
{
	public abstract class FadeBusyBar : BorderedBusyBarWithText
	{
		protected Image		_imageForward;
		protected Image		_imageReverse;
		
		protected bool		_bPingPong = false;
		protected bool		_bLeftToRight = true;
		protected bool		_bInitialSlide = true;

		protected bool		_bSwitchFlag = false;

		public FadeBusyBar()
		{
			this._iStepTimeout = 50;
			this._iStepSize = 5;

		}

		public bool PingPong
		{
			get	{	return _bPingPong;	}
			set	
			{
				lock(this)
				{
					if ( value == false )
						this._bLeftToRight = true;
					_bPingPong = value;	
				}
			}
		}

		protected abstract void CreateImage();

		protected override void OnShowBorderChanged()
		{
			base.OnShowBorderChanged ();
			this.CreateImage();
		}


		protected override void IncreaseBarPosition()
		{
			bool bChangeDirection = false;

			if ( _bLeftToRight )
			{
				int iNewPos = _iBarPosition + _iStepSize;
				if (this.PingPong)
				{
					if ( iNewPos <= this.Width)
						_iBarPosition = iNewPos;
					else
					{
						_iBarPosition = this.Width - ( iNewPos - this.Width);
						bChangeDirection = true;
					}
				}
				else
				{
					_iBarPosition = iNewPos;
					if (_iBarPosition > this.Width)
						_iBarPosition = iNewPos - this.Width;
				}
			}
			else
			{
				int iNewPos = _iBarPosition - _iStepSize;
				
				if ( iNewPos >= 0)
					_iBarPosition = iNewPos;
				else
				{
					_iBarPosition = iNewPos *-1;
					bChangeDirection = true;
				}	
			}

			if (bChangeDirection)
				_bLeftToRight = !_bLeftToRight;
		}

		protected void DoPaintPingPong( System.Drawing.Graphics g )
		{
			int iLowestPos = -1;
			int iHighestPos = -1;
			int iDrawHeight = this.Height;
			int iStartPosY = 0;

			if (this.ShowBorder)
			{
				iDrawHeight -= 2;
				iStartPosY = 1;
			}

	
			if ( _bLeftToRight )
			{
				//
				// check if we have to draw a refelection behind the current pos
				//
				if ( this._iBarPosition < this._imageForward.Width)
				{
					// first draw the reflection in the reverse order
					int iReflectionLen = this._imageReverse.Width - this._iBarPosition;
					g.DrawImage( this._imageReverse, -(_imageReverse.Width-iReflectionLen), iStartPosY);

					iHighestPos = iReflectionLen;
					if ( iHighestPos<_iBarPosition)
						iHighestPos = _iBarPosition;
				}
				else
				{
					iLowestPos = this._iBarPosition - _imageReverse.Width;
					iHighestPos = this._iBarPosition;
				}
				g.DrawImage( _imageForward, this._iBarPosition-_imageForward.Width, iStartPosY);			
			}
			else
			{
				//
				// check if we have to draw a refelection in front the current pos
				//
				if ( this._iBarPosition + this._imageForward.Width > this.Width)
				{
					// first draw the reflection in the reverse order
					int iReflectionLen = this._imageForward.Width - (this.Width - this._iBarPosition);
					g.DrawImage( this._imageForward, this.Width-iReflectionLen, iStartPosY);
					iLowestPos = this.Width-iReflectionLen;

					if (  this._iBarPosition < iLowestPos)
						iLowestPos = this._iBarPosition;	
				}
				else
				{
					iLowestPos = _iBarPosition;
					iHighestPos = _iBarPosition + _imageForward.Width;
				}
				g.DrawImage( _imageReverse, this._iBarPosition, iStartPosY);			
			}

			if (iLowestPos != -1 || iHighestPos != -1)
			{
				if (iLowestPos != -1)
					g.FillRectangle( _backgroundBrush, 0,iStartPosY,iLowestPos, iDrawHeight);

				if (iHighestPos != -1)
					g.FillRectangle( _backgroundBrush, iHighestPos,iStartPosY, this.Width - iHighestPos, iDrawHeight);
			}

		}
		protected void DoPaintNormal( System.Drawing.Graphics g )
		{
			int iDrawHeight = this.Height;
			int iStartPosY = 0;

			if (this.ShowBorder)
			{
				iDrawHeight -= 2;
				iStartPosY = 1;
			}


			// check if we have to draw something on the left side (the end)
			if (this._iBarPosition < this._imageForward.Width)
			{
				int iEndLen = this._imageForward.Width - this._iBarPosition;
				g.DrawImage( this._imageForward, this.Width-iEndLen, iStartPosY );
				g.DrawImage( _imageForward, this._iBarPosition-_imageForward.Width, iStartPosY);	

				//erase the rect in the middle
				g.FillRectangle( _backgroundBrush, _iBarPosition,iStartPosY,this.Width - this._imageForward.Width, iDrawHeight);
			}	
			else
			{
				g.DrawImage( _imageForward, this._iBarPosition-_imageForward.Width, iStartPosY);	
		
				//erase the left rect
				if (this._iBarPosition-this._imageForward.Width > 0)
					g.FillRectangle( _backgroundBrush, 0,iStartPosY,this._iBarPosition-this._imageForward.Width, iDrawHeight);

				//erase the right rect
				if ( this._iBarPosition < this.Width)
					g.FillRectangle( _backgroundBrush, this._iBarPosition,iStartPosY,this.Width-_iBarPosition, iDrawHeight);
			}
		}

		protected override void DoPaint( System.Drawing.Graphics g )
		{
			if (this.PingPong)
				DoPaintPingPong(g);
			else
				DoPaintNormal(g);
			this.DrawBorder( g );
			this.DoDrawText( g );
			return;
		}
	}	
}
