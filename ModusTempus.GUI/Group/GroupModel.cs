using System;
using System.Collections.Generic;
using System.Linq;
using ModusTempus.Domain.Entities;
using ModusTempus.Domain.Repositories;
using ModusTempus.GUI.Login;

namespace ModusTempus.GUI.Group
{
	using Group = Domain.Entities.Group;

	public class GroupModel
	{
		private readonly IGroupView _view;

		private readonly LoginModel _model;

		public ICollection<Group> UnsubscribedGroups { get; set; }
		public ICollection<Group> SubscribedGroups { get; set; }
		public Group SelectedGroup { get; set; }

		public GroupModel(IGroupView view, LoginModel model)
		{
			_view = view;
			_model = model;

			LoadGroups();
		}

		public void LoadGroups()
		{
			SelectGroup(null);
			
			if (_model.CurrentUser != null && _model.CurrentUser.Administrator)
				_view.EnableAdministration();
			else
				_view.DisableAdministration();
			

			if (_model.CurrentUser != null)
			{
				SubscribedGroups = new SubscriptionRepository().GetByUser(_model.CurrentUser).Select(s => s.Group).ToList();
				UnsubscribedGroups = new GroupRepository().GetAll().Where(g1 => !SubscribedGroups.Any(g2 => g1.Equals(g2))).ToList();
				UnsubscribedGroups = UnsubscribedGroups.Where(g => g.Name.ToLower().Contains(_view.GroupName.ToLower())).ToList();
			}
			else
			{
				UnsubscribedGroups = new List<Group>();
				SubscribedGroups = new List<Group>();
			}
	
			LoadView();
		}

		public void LoadView()
		{
			_view.ClearGroups();
			foreach (var g in SubscribedGroups)
				_view.AddGroup(g.Name, true);
			foreach (var g in UnsubscribedGroups)
				_view.AddGroup(g.Name, false);
		}

		public void SelectGroup(string name)
		{
			if (name == null)
			{
				SelectedGroup = null;
				_view.SelectedGroupName = "Selected: None";
			}
			else
			{
				var group = new GroupRepository().GetByName(name);
				SelectedGroup = group;
				_view.SelectedGroupName = "Selected: " + group.Name;
			}
		}

		public void JoinGroup(string name)
		{
			var user = _model.CurrentUser;
			var group = new GroupRepository().GetByName(name);
		
			var sub = new Subscription(user.Id, group.Id);
			new SubscriptionRepository().Add(sub);

			SelectGroup(group.Name);
			LoadGroups();
		}

		public void LeaveGroup(string name)
		{
			var user = _model.CurrentUser;
			var group = new GroupRepository().GetByName(name);

			var sub = new SubscriptionRepository().GetBy(s => s.UserId == user.Id && s.GroupId == group.Id).FirstOrDefault();
			new SubscriptionRepository().Delete(sub);

			SelectGroup(null);
			LoadGroups();
		}

		public void CreateGroup(string name)
		{
			// Ignore empty names.
			if (string.IsNullOrWhiteSpace(name))
				return;

			// Do not create groups with duplicate names.
			if (new GroupRepository().GetByName(name) != null)
				return;

			var group = new Group(name);
			new GroupRepository().Add(group);

			LoadGroups();
		}

		public void DeleteSelectedGroup()
		{
			if (SelectedGroup == null)
				return;

			new GroupRepository().Delete(SelectedGroup);
			SelectedGroup = null;
			LoadGroups();
		}
	}
}
