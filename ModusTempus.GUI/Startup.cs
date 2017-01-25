using System;
using System.Windows.Forms;
using ModusTempus.GUI.Forms;

namespace ModusTempus.GUI
{
	public static class Startup
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new LoginForm());
		}
	}
}
