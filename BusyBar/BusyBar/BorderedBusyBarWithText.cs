using System;
using System.Drawing;

namespace System.Windows.Forms.BusyBar
{
	/// <summary>
	/// Summary description for BorderedBusyBarWithText.
	/// </summary>
	public class BorderedBusyBarWithText : BorderedBusyBar
	{
		private string _strText;
		private Color _textColor;
		private SolidBrush _textBrush;
		private StringFormat _stringFormat;
		public static readonly Color DefaultTextColor = System.Drawing.SystemColors.ControlText;

		public new string Text
		{
			get	{	return	_strText;	}
			set	{	
				_strText = value;
				Invalidate();
			}
		}

		public Color TextColor
		{
			get	{	return	_textColor;	}
			set {
				_textColor = value;
				_textBrush = new SolidBrush( _textColor );
				Invalidate();
			}
		}

		public BorderedBusyBarWithText()
		{
			this.TextColor = DefaultTextColor;
			_stringFormat = new StringFormat();
			_stringFormat.Alignment = StringAlignment.Center;
			_stringFormat.LineAlignment = StringAlignment.Center;

		}

		protected void DoDrawText( System.Drawing.Graphics g)
		{
			if (this._strText == null)
				return;

			if (this._strText == "")
				return;
			
			g.DrawString( _strText, this.Font, _textBrush, this.ClientRectangle, this._stringFormat );
		
		}

		protected override void DoPaint( System.Drawing.Graphics g )
		{
			base.DoPaint( g );
			DrawBorder( g );
		}
	}
}
