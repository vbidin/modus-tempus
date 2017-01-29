using ModusTempus.GUI.Activity;

namespace ModusTempus.GUI.Group
{
	public class GroupController
	{
		private GroupModel _groupModel;
		private ActivityModel _activityModel;

		public GroupController(GroupModel groupModel, ActivityModel activityModel)
		{
			_groupModel = groupModel;
			_activityModel = activityModel;
		}

		public void JoinGroup(string name)
		{
			_groupModel.JoinGroup(name);
			_activityModel.LoadActivities();
		}

		public void LeaveGroup(string name)
		{
			_groupModel.LeaveGroup(name);
			_activityModel.LoadActivities();
		}

		public void SelectGroup(string name)
		{
			_groupModel.SelectGroup(name);
			_activityModel.LoadActivities();
		}

		public void SearchGroups()
		{
			_groupModel.LoadGroups();
		}

		public void CreateGroup(string name)
		{
			_groupModel.CreateGroup(name);
		}

		public void DeleteGroup()
		{
			_groupModel.DeleteSelectedGroup();
			_activityModel.LoadActivities();
		}
	}
}
