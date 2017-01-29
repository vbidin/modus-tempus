using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModusTempus.Domain.ValueObjects;
using ModusTempus.GUI.Activity;
using ModusTempus.GUI.Group;
using ModusTempus.GUI.Login;
using ModusTempus.GUI.Register;

namespace ModusTempus.GUI.Forms
{
	using Activity = Domain.Entities.Activity;

	public partial class MainForm : Form, ILoginView, IRegisterView, IGroupView, IActivityView
	{
		public ILoginView Login { get; }
		public IRegisterView Register { get; }
		public IGroupView Group { get; }
		public IActivityView Activity { get; }



		public MainForm()
		{
			InitializeComponent();
			Login = this;
			Register = this;
			Group = this;
			Activity = this;

			// Select hours by default.
			timeUnitComboBox.SelectedIndex = 2;
		}

		#region Login

		LoginController ILoginView.Controller { get; set; }

		string ILoginView.Username
		{
			get { return usernameTextBox.Text; }
			set { usernameTextBox.Text = value; }
		}

		string ILoginView.Password
		{
			get { return passwordTextBox.Text; }
			set { passwordTextBox.Text = value; }
		}

		string ILoginView.Info
		{
			get { return infoLabel.Text; }
			set { infoLabel.Text = value; }
		}

		void ILoginView.EnableLogin()
		{
			Login.Username = "";
			Login.Password = "";

			usernameTextBox.Enabled = true;
			passwordTextBox.Enabled = true;
			loginButton.Enabled = true;
			logoutButton.Enabled = false;
		}

		void ILoginView.DisableLogin()
		{
			Login.Username = "";
			Login.Password = "";

			usernameTextBox.Enabled = false;
			passwordTextBox.Enabled = false;
			loginButton.Enabled = false;
			logoutButton.Enabled = true;
		}

		private void loginButton_Click(object sender, EventArgs e)
		{
			Login.Controller.Login(Login.Username, Login.Password);
		}

		private void logoutButton_Click(object sender, EventArgs e)
		{
			Login.Controller.Logout();
		}

		#endregion

		#region Register

		RegisterController IRegisterView.Controller { get; set; }

		string IRegisterView.Username
		{
			get { return rUsernameTextBox.Text; }
			set { rUsernameTextBox.Text = value; }
		}

		string IRegisterView.Email
		{
			get { return rEmailTextBox.Text; }
			set { rEmailTextBox.Text = value; }
		}

		string IRegisterView.Password
		{
			get { return rPassword1TextBox.Text; }
			set { rPassword1TextBox.Text = value; }
		}

		string IRegisterView.RepeatPassword
		{
			get { return rPassword2TextBox.Text; }
			set { rPassword2TextBox.Text = value; }
		}

		string IRegisterView.Info
		{
			get { return rInfoLabel.Text; }
			set { rInfoLabel.Text = value; }
		}

		private void registerButton_Click(object sender, EventArgs e)
		{
			Register.Controller.Register();
		}

		#endregion

		#region Group

		GroupController IGroupView.Controller { get; set; }

		string IGroupView.GroupName
		{
			get { return groupSearchBox.Text; }
			set { groupSearchBox.Text = value; }
		}

		string IGroupView.SelectedGroupName
		{
			get { return selectedGroupLabel.Text; }
			set { selectedGroupLabel.Text = value; }
		}

		void IGroupView.AddGroup(string name, bool subscribed)
		{
			if (subscribed)
				subscribedGroupsListBox.Items.Add(name);
			else
				allGroupsListBox.Items.Add(name);
		}

		void IGroupView.RemoveGroup(string name, bool subscribed)
		{
			if (subscribed)
				subscribedGroupsListBox.Items.Remove(name);
			else
				allGroupsListBox.Items.Remove(name);
		}

		void IGroupView.ClearGroups()
		{
			allGroupsListBox.Items.Clear();
			subscribedGroupsListBox.Items.Clear();
		}

		void IGroupView.EnableAdministration()
		{
			createGroupButton.Enabled = true;
			deleteGroupButton.Enabled = true;
		}

		void IGroupView.DisableAdministration()
		{
			createGroupButton.Enabled = false;
			deleteGroupButton.Enabled = false;
		}

		private void allGroupsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			object item = allGroupsListBox.SelectedItem;
			if (item != null)
				Group.Controller.JoinGroup(item.ToString());
		}

		private void subscribedGroupsListBox_MouseClick(object sender, MouseEventArgs e)
		{
			object item = subscribedGroupsListBox.SelectedItem;
			if (item != null)
				Group.Controller.SelectGroup(item.ToString());
		}

		private void subscribedGroupsListBox_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			object item = subscribedGroupsListBox.SelectedItem;
			if (item != null)
				Group.Controller.LeaveGroup(item.ToString());
		}

		private void groupSearchBox_TextChanged(object sender, EventArgs e)
		{
			Group.Controller.SearchGroups();
		}

		private void createGroupButton_Click(object sender, EventArgs e)
		{
			Group.Controller.CreateGroup(groupSearchBox.Text);
		}

		private void deleteGroupButton_Click(object sender, EventArgs e)
		{
			Group.Controller.DeleteGroup();
		}

		#endregion

		#region Activity

		ActivityController IActivityView.Controller { get; set; }

		string IActivityView.SelectedActivityName
		{
			get { return selectedActivityLabel.Text; }
			set { selectedActivityLabel.Text = value; }
		}

		string IActivityView.Info
		{
			get { return permissionLabel.Text; }
			set
			{
				permissionLabel.Text = value;

				if (string.IsNullOrWhiteSpace(value))
					permissionLabel.Visible = false;
				else
					permissionLabel.Visible = true;
			}
		}

		void IActivityView.AddRoot(Activity activity)
		{
			CreateNode(activity, null);
			activityTreeView.ExpandAll();
		}

		void IActivityView.ClearTree()
		{
			activityTreeView.Nodes.Clear();
		}

		void IActivityView.TemporaryDisableRecording()
		{
			var t = Task.Delay(500);

			recordButton.Enabled = false;
			confirmationLabel.Visible = true;
			t.Wait();
			confirmationLabel.Visible = false;
			timeSpentNumericUpDown.Value = 0;
			recordButton.Enabled = true;
		}

		void IActivityView.EnableRecording()
		{
			recordButton.Enabled = true;
		}

		void IActivityView.DisableRecording()
		{
			recordButton.Enabled = false;
		}

		void IActivityView.EnableModeration()
		{
			createActivityButton.Enabled = true;
			deleteActivityButton.Enabled = true;
		}

		void IActivityView.DisableModeration()
		{
			createActivityButton.Enabled = false;
			deleteActivityButton.Enabled = false;
		}

		void CreateNode(Activity activity, TreeNode parent)
		{
			string key = activity.Id.ToString();
			string text = activity.Name;

			TreeNode node;
			if (parent == null)
				node = activityTreeView.Nodes.Add(key, text);
			else
				node = parent.Nodes.Add(key, text);

			foreach(var child in activity.Children)
				CreateNode(child, node);
		}

		private void activityTreeView_AfterSelect(object sender, TreeViewEventArgs e)
		{
			TreeNode node = activityTreeView.SelectedNode;
			if (node != null)
				Activity.Controller.ActivitySelected(node.Name);
		}

		private void recordButton_Click(object sender, EventArgs e)
		{
			TimeUnit unit = (TimeUnit)Enum.Parse(typeof(TimeUnit), timeUnitComboBox.SelectedItem.ToString(), true);
			int seconds = Convert.ToInt32(timeSpentNumericUpDown.Value);
			switch (unit)
			{
				case TimeUnit.Seconds:
					break;
				case TimeUnit.Minutes:
					seconds *= 60;
					break;
				case TimeUnit.Hours:
					seconds *= 60*60;
					break;
				default:
					throw new InvalidOperationException("Invalid time unit: " + unit);
			}
			Activity.Controller.Record(seconds);
		}

		private void viewStatisticsButton_Click(object sender, EventArgs e)
		{
			Activity.Controller.ViewStatistics();
		}

		private void createActivityButton_Click(object sender, EventArgs e)
		{
			Activity.Controller.CreateActivity(activityNameBox.Text);
		}

		private void deleteActivityButton_Click(object sender, EventArgs e)
		{
			Activity.Controller.DeleteActivity();
		}

		private void timeUnitComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			TimeUnit unit = (TimeUnit)Enum.Parse(typeof(TimeUnit), timeUnitComboBox.SelectedItem.ToString(), true);
			switch (unit)
			{
				case TimeUnit.Seconds:
					timeSpentNumericUpDown.Maximum = 1000;
					break;
				case TimeUnit.Minutes:
					timeSpentNumericUpDown.Maximum = 1000;
					break;
				case TimeUnit.Hours:
					timeSpentNumericUpDown.Maximum = 20;
					break;
			}
		}

		#endregion


	}
}
