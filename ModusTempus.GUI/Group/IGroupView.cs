namespace ModusTempus.GUI.Group
{
	public interface IGroupView
	{
		GroupController Controller { get; set; }

		string GroupName { get; set; }
		string SelectedGroupName { get; set; }

		void AddGroup(string name, bool subscribed);
		void RemoveGroup(string name, bool subscribed);
		void ClearGroups();

		void EnableAdministration();
		void DisableAdministration();
	}
}
