using System;

namespace BusyBarDemoApp
{
	/// <summary>
	/// Summary description for AppMain.
	/// </summary>
	public class AppMain
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main() 
		{
			System.Windows.Forms.Application.Run(new AppMainForm());
		}
	}
}
