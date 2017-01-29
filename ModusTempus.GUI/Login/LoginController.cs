using ModusTempus.GUI.Activity;
using ModusTempus.GUI.Group;

namespace ModusTempus.GUI.Login
{
	public class LoginController
	{
		private readonly LoginModel _loginModel;
		private readonly GroupModel _groupModel;
		private readonly ActivityModel _activityModel;

		public LoginController(LoginModel loginModel, GroupModel groupModel, ActivityModel activityModel)
		{
			_loginModel = loginModel;
			_groupModel = groupModel;
			_activityModel = activityModel;
		}

		public void Login(string username, string password)
		{
			bool success = _loginModel.Login(username, password);
			if (success)
				_groupModel.LoadGroups();
			_activityModel.LoadActivities();
		}

		public void Logout()
		{
			bool success = _loginModel.Logout();
			if (success)
				_groupModel.LoadGroups();
			_activityModel.LoadActivities();
		}
	}
}
