using System;
using System.Windows.Forms;
using ModusTempus.GUI.Activity;
using ModusTempus.GUI.Forms;
using ModusTempus.GUI.Group;
using ModusTempus.GUI.Login;
using ModusTempus.GUI.Register;

namespace ModusTempus.GUI
{
	public static class Startup
	{
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);

			// Main Form
			var mainForm = new MainForm();

			// Models
			var loginModel = new LoginModel(mainForm);
			var registerModel = new RegisterModel(mainForm);
			var groupModel = new GroupModel(mainForm, loginModel);
			var activityModel = new ActivityModel(mainForm, loginModel, groupModel);

			// Controllers
			mainForm.Login.Controller = new LoginController(loginModel, groupModel, activityModel);
			mainForm.Register.Controller = new RegisterController(registerModel);
			mainForm.Group.Controller = new GroupController(groupModel, activityModel);
			mainForm.Activity.Controller = new ActivityController(activityModel);

			// Start
			Application.Run(mainForm);
		}
	}
}
