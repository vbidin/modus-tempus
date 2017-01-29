using System;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using ModusTempus.Domain.Entities;
using ModusTempus.Domain.Repositories;
using ModusTempus.Domain.ValueObjects;
using ModusTempus.GUI.Group;
using ModusTempus.GUI.Login;


namespace ModusTempus.GUI.Activity
{
	using Activity = Domain.Entities.Activity;
	using Group = Domain.Entities.Group;

	public class ActivityModel
	{
		private readonly IActivityView _view;

		private readonly LoginModel _loginModel;
		private readonly GroupModel _groupModel;

		public Activity SelectedActivity { get; set; }
		public User CurrentUser => _loginModel.CurrentUser;
		public Group CurrentGroup => _groupModel.SelectedGroup;

		public ActivityModel(IActivityView view, LoginModel loginModel, GroupModel groupModel)
		{
			_view = view;
			_loginModel = loginModel;
			_groupModel = groupModel;

			LoadActivities();
		}

		public void SelectActivity(long id)
		{
			if (id == -1)
			{
				SelectedActivity = null;
				_view.SelectedActivityName = "Selected: None";
				return;
			}

			Activity activity = new ActivityRepository().GetById(id);
			SelectedActivity = activity;
			_view.SelectedActivityName = "Selected: " + activity.Name;
		}

		public void LoadActivities()
		{
			SelectActivity(-1);
			_view.ClearTree();

			var user = _loginModel.CurrentUser;
			var group = _groupModel.SelectedGroup;

			if (group == null)
			{
				_view.DisableRecording();
				_view.DisableModeration();
				return;
			}

			// Use permission if it exists, otherwise set default group permission.		
			var type = group.DefaultPermission;
			var perm = new PermissionRepository().Get(user, group);
			if (perm != null)
				type = perm.Type;
			if (user.Administrator)
				type = PermissionType.Moderate;

			if (type == PermissionType.None)
			{
				_view.Info = "Insufficient permission";
				_view.DisableRecording();
				_view.DisableModeration();
				return;
			}
			_view.Info = "";

			if (type == PermissionType.Read)
			{
				_view.DisableRecording();
				_view.DisableModeration();
			}

			if (type == PermissionType.Write)
			{
				_view.EnableRecording();
				_view.DisableModeration();
			}

			if (type == PermissionType.Moderate)
			{
				_view.EnableRecording();
				_view.EnableModeration();
			}

			var roots = new GroupRepository().GetByName(group.Name).Activities.Where(a => a.Parent == null).ToList();
			
			foreach (var root in roots)
			{
				SetChildren(root);
				_view.AddRoot(root);
			}
		}

		public void SetChildren(Activity activity)
		{
			var children = new ActivityRepository().GetChildren(activity);

			foreach (var child in children)
				SetChildren(child);

			activity.Children = children;
		}

		public void AddRecord(int duration)
		{
			var user = _loginModel.CurrentUser;
			var record = new Record(TimeSpan.FromSeconds(duration), SelectedActivity.Id, user.Id);
			new RecordRepository().Add(record);
			_view.TemporaryDisableRecording();
		}

		public void CreateChildActivity(string name)
		{
			if (string.IsNullOrWhiteSpace(name))
				return;

			var activity = new Activity(name, null, TimeSpan.FromSeconds(0), CurrentGroup.Id);
			if (SelectedActivity == null)
				activity.ParentId = null;
			else
				activity.ParentId = SelectedActivity.Id;

			new ActivityRepository().Add(activity);
			LoadActivities();
		}

		public void DeleteActivity()
		{
			if (SelectedActivity == null)
				return;

			new ActivityRepository().Delete(SelectedActivity);
			SelectedActivity = null;
			LoadActivities();
		}
	}
}
