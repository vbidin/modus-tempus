namespace ModusTempus.GUI.Forms
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.activityTab = new System.Windows.Forms.TabPage();
			this.permissionLabel = new System.Windows.Forms.Label();
			this.activityTreeView = new System.Windows.Forms.TreeView();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.viewStatisticsButton = new System.Windows.Forms.Button();
			this.confirmationLabel = new System.Windows.Forms.Label();
			this.selectedActivityLabel = new System.Windows.Forms.Label();
			this.recordButton = new System.Windows.Forms.Button();
			this.timeUnitComboBox = new System.Windows.Forms.ComboBox();
			this.timeSpentNumericUpDown = new System.Windows.Forms.NumericUpDown();
			this.activityNameBox = new System.Windows.Forms.TextBox();
			this.createActivityButton = new System.Windows.Forms.Button();
			this.deleteActivityButton = new System.Windows.Forms.Button();
			this.groupsTab = new System.Windows.Forms.TabPage();
			this.splitContainer = new System.Windows.Forms.SplitContainer();
			this.createGroupButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.groupSearchBox = new System.Windows.Forms.TextBox();
			this.allGroupsListBox = new System.Windows.Forms.ListBox();
			this.deleteGroupButton = new System.Windows.Forms.Button();
			this.selectedGroupLabel = new System.Windows.Forms.Label();
			this.subscribedGroupsListBox = new System.Windows.Forms.ListBox();
			this.label2 = new System.Windows.Forms.Label();
			this.profileTab = new System.Windows.Forms.TabPage();
			this.profileTabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.infoLabel = new System.Windows.Forms.Label();
			this.logoutButton = new System.Windows.Forms.Button();
			this.loginButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.passwordTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.usernameTextBox = new System.Windows.Forms.TextBox();
			this.registerTabPage = new System.Windows.Forms.TabPage();
			this.rInfoLabel = new System.Windows.Forms.Label();
			this.registerButton = new System.Windows.Forms.Button();
			this.rPassword2TextBox = new System.Windows.Forms.TextBox();
			this.rPassword1TextBox = new System.Windows.Forms.TextBox();
			this.rEmailTextBox = new System.Windows.Forms.TextBox();
			this.rUsernameTextBox = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.mainTabControl = new System.Windows.Forms.TabControl();
			this.activityTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.timeSpentNumericUpDown)).BeginInit();
			this.groupsTab.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
			this.splitContainer.Panel1.SuspendLayout();
			this.splitContainer.Panel2.SuspendLayout();
			this.splitContainer.SuspendLayout();
			this.profileTab.SuspendLayout();
			this.profileTabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.registerTabPage.SuspendLayout();
			this.mainTabControl.SuspendLayout();
			this.SuspendLayout();
			// 
			// activityTab
			// 
			this.activityTab.Controls.Add(this.permissionLabel);
			this.activityTab.Controls.Add(this.activityTreeView);
			this.activityTab.Controls.Add(this.splitContainer1);
			this.activityTab.Location = new System.Drawing.Point(4, 22);
			this.activityTab.Name = "activityTab";
			this.activityTab.Padding = new System.Windows.Forms.Padding(3);
			this.activityTab.Size = new System.Drawing.Size(319, 252);
			this.activityTab.TabIndex = 2;
			this.activityTab.Text = "Activities";
			this.activityTab.UseVisualStyleBackColor = true;
			// 
			// permissionLabel
			// 
			this.permissionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.permissionLabel.Location = new System.Drawing.Point(89, 63);
			this.permissionLabel.Name = "permissionLabel";
			this.permissionLabel.Size = new System.Drawing.Size(145, 20);
			this.permissionLabel.TabIndex = 7;
			this.permissionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// activityTreeView
			// 
			this.activityTreeView.Dock = System.Windows.Forms.DockStyle.Fill;
			this.activityTreeView.Location = new System.Drawing.Point(3, 3);
			this.activityTreeView.Name = "activityTreeView";
			this.activityTreeView.Size = new System.Drawing.Size(313, 140);
			this.activityTreeView.TabIndex = 0;
			this.activityTreeView.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.activityTreeView_AfterSelect);
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.splitContainer1.Location = new System.Drawing.Point(3, 143);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.viewStatisticsButton);
			this.splitContainer1.Panel1.Controls.Add(this.confirmationLabel);
			this.splitContainer1.Panel1.Controls.Add(this.selectedActivityLabel);
			this.splitContainer1.Panel1.Controls.Add(this.recordButton);
			this.splitContainer1.Panel1.Controls.Add(this.timeUnitComboBox);
			this.splitContainer1.Panel1.Controls.Add(this.timeSpentNumericUpDown);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.activityNameBox);
			this.splitContainer1.Panel2.Controls.Add(this.createActivityButton);
			this.splitContainer1.Panel2.Controls.Add(this.deleteActivityButton);
			this.splitContainer1.Size = new System.Drawing.Size(313, 106);
			this.splitContainer1.SplitterDistance = 75;
			this.splitContainer1.TabIndex = 1;
			// 
			// viewStatisticsButton
			// 
			this.viewStatisticsButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.viewStatisticsButton.Location = new System.Drawing.Point(58, 47);
			this.viewStatisticsButton.Name = "viewStatisticsButton";
			this.viewStatisticsButton.Size = new System.Drawing.Size(208, 25);
			this.viewStatisticsButton.TabIndex = 7;
			this.viewStatisticsButton.Text = "View Statistics";
			this.viewStatisticsButton.UseVisualStyleBackColor = true;
			this.viewStatisticsButton.Click += new System.EventHandler(this.viewStatisticsButton_Click);
			// 
			// confirmationLabel
			// 
			this.confirmationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.confirmationLabel.AutoSize = true;
			this.confirmationLabel.Location = new System.Drawing.Point(271, 26);
			this.confirmationLabel.Name = "confirmationLabel";
			this.confirmationLabel.Size = new System.Drawing.Size(29, 13);
			this.confirmationLabel.TabIndex = 8;
			this.confirmationLabel.Text = "Sent";
			this.confirmationLabel.Visible = false;
			// 
			// selectedActivityLabel
			// 
			this.selectedActivityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.selectedActivityLabel.Location = new System.Drawing.Point(5, 4);
			this.selectedActivityLabel.Name = "selectedActivityLabel";
			this.selectedActivityLabel.Size = new System.Drawing.Size(303, 14);
			this.selectedActivityLabel.TabIndex = 7;
			this.selectedActivityLabel.Text = "Selected: None";
			this.selectedActivityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// recordButton
			// 
			this.recordButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.recordButton.Location = new System.Drawing.Point(188, 21);
			this.recordButton.Name = "recordButton";
			this.recordButton.Size = new System.Drawing.Size(77, 22);
			this.recordButton.TabIndex = 6;
			this.recordButton.Text = "Record";
			this.recordButton.UseVisualStyleBackColor = true;
			this.recordButton.Click += new System.EventHandler(this.recordButton_Click);
			// 
			// timeUnitComboBox
			// 
			this.timeUnitComboBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.timeUnitComboBox.FormattingEnabled = true;
			this.timeUnitComboBox.Items.AddRange(new object[] {
            "Seconds",
            "Minutes",
            "Hours"});
			this.timeUnitComboBox.Location = new System.Drawing.Point(121, 21);
			this.timeUnitComboBox.Name = "timeUnitComboBox";
			this.timeUnitComboBox.Size = new System.Drawing.Size(61, 21);
			this.timeUnitComboBox.TabIndex = 4;
			this.timeUnitComboBox.SelectedIndexChanged += new System.EventHandler(this.timeUnitComboBox_SelectedIndexChanged);
			// 
			// timeSpentNumericUpDown
			// 
			this.timeSpentNumericUpDown.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.timeSpentNumericUpDown.Location = new System.Drawing.Point(58, 21);
			this.timeSpentNumericUpDown.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.timeSpentNumericUpDown.Name = "timeSpentNumericUpDown";
			this.timeSpentNumericUpDown.Size = new System.Drawing.Size(55, 20);
			this.timeSpentNumericUpDown.TabIndex = 5;
			// 
			// activityNameBox
			// 
			this.activityNameBox.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.activityNameBox.Location = new System.Drawing.Point(5, 4);
			this.activityNameBox.Name = "activityNameBox";
			this.activityNameBox.Size = new System.Drawing.Size(177, 20);
			this.activityNameBox.TabIndex = 11;
			// 
			// createActivityButton
			// 
			this.createActivityButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.createActivityButton.Location = new System.Drawing.Point(186, 2);
			this.createActivityButton.Name = "createActivityButton";
			this.createActivityButton.Size = new System.Drawing.Size(68, 23);
			this.createActivityButton.TabIndex = 10;
			this.createActivityButton.Text = "Create";
			this.createActivityButton.UseVisualStyleBackColor = true;
			this.createActivityButton.Click += new System.EventHandler(this.createActivityButton_Click);
			// 
			// deleteActivityButton
			// 
			this.deleteActivityButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteActivityButton.Location = new System.Drawing.Point(255, 2);
			this.deleteActivityButton.Name = "deleteActivityButton";
			this.deleteActivityButton.Size = new System.Drawing.Size(53, 23);
			this.deleteActivityButton.TabIndex = 9;
			this.deleteActivityButton.Text = "Delete";
			this.deleteActivityButton.UseVisualStyleBackColor = true;
			this.deleteActivityButton.Click += new System.EventHandler(this.deleteActivityButton_Click);
			// 
			// groupsTab
			// 
			this.groupsTab.Controls.Add(this.splitContainer);
			this.groupsTab.Location = new System.Drawing.Point(4, 22);
			this.groupsTab.Name = "groupsTab";
			this.groupsTab.Padding = new System.Windows.Forms.Padding(3);
			this.groupsTab.Size = new System.Drawing.Size(319, 252);
			this.groupsTab.TabIndex = 1;
			this.groupsTab.Text = "Groups";
			this.groupsTab.UseVisualStyleBackColor = true;
			// 
			// splitContainer
			// 
			this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer.IsSplitterFixed = true;
			this.splitContainer.Location = new System.Drawing.Point(3, 3);
			this.splitContainer.Name = "splitContainer";
			// 
			// splitContainer.Panel1
			// 
			this.splitContainer.Panel1.Controls.Add(this.createGroupButton);
			this.splitContainer.Panel1.Controls.Add(this.label1);
			this.splitContainer.Panel1.Controls.Add(this.groupSearchBox);
			this.splitContainer.Panel1.Controls.Add(this.allGroupsListBox);
			// 
			// splitContainer.Panel2
			// 
			this.splitContainer.Panel2.Controls.Add(this.deleteGroupButton);
			this.splitContainer.Panel2.Controls.Add(this.selectedGroupLabel);
			this.splitContainer.Panel2.Controls.Add(this.subscribedGroupsListBox);
			this.splitContainer.Panel2.Controls.Add(this.label2);
			this.splitContainer.Size = new System.Drawing.Size(313, 246);
			this.splitContainer.SplitterDistance = 153;
			this.splitContainer.TabIndex = 0;
			// 
			// createGroupButton
			// 
			this.createGroupButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.createGroupButton.Location = new System.Drawing.Point(27, 223);
			this.createGroupButton.Name = "createGroupButton";
			this.createGroupButton.Size = new System.Drawing.Size(101, 20);
			this.createGroupButton.TabIndex = 4;
			this.createGroupButton.Text = "Create";
			this.createGroupButton.UseVisualStyleBackColor = true;
			this.createGroupButton.Click += new System.EventHandler(this.createGroupButton_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(2, 1);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(63, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "All groups";
			// 
			// groupSearchBox
			// 
			this.groupSearchBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.groupSearchBox.Location = new System.Drawing.Point(-1, 17);
			this.groupSearchBox.Name = "groupSearchBox";
			this.groupSearchBox.Size = new System.Drawing.Size(153, 20);
			this.groupSearchBox.TabIndex = 3;
			this.groupSearchBox.TextChanged += new System.EventHandler(this.groupSearchBox_TextChanged);
			// 
			// allGroupsListBox
			// 
			this.allGroupsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.allGroupsListBox.FormattingEnabled = true;
			this.allGroupsListBox.Location = new System.Drawing.Point(-1, 36);
			this.allGroupsListBox.Name = "allGroupsListBox";
			this.allGroupsListBox.Size = new System.Drawing.Size(153, 186);
			this.allGroupsListBox.TabIndex = 2;
			this.allGroupsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.allGroupsListBox_MouseDoubleClick);
			// 
			// deleteGroupButton
			// 
			this.deleteGroupButton.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
			this.deleteGroupButton.Location = new System.Drawing.Point(26, 223);
			this.deleteGroupButton.Name = "deleteGroupButton";
			this.deleteGroupButton.Size = new System.Drawing.Size(101, 20);
			this.deleteGroupButton.TabIndex = 5;
			this.deleteGroupButton.Text = "Delete";
			this.deleteGroupButton.UseVisualStyleBackColor = true;
			this.deleteGroupButton.Click += new System.EventHandler(this.deleteGroupButton_Click);
			// 
			// selectedGroupLabel
			// 
			this.selectedGroupLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.selectedGroupLabel.Location = new System.Drawing.Point(6, 17);
			this.selectedGroupLabel.Name = "selectedGroupLabel";
			this.selectedGroupLabel.Size = new System.Drawing.Size(144, 16);
			this.selectedGroupLabel.TabIndex = 5;
			this.selectedGroupLabel.Text = "Selected: None";
			this.selectedGroupLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// subscribedGroupsListBox
			// 
			this.subscribedGroupsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.subscribedGroupsListBox.FormattingEnabled = true;
			this.subscribedGroupsListBox.Location = new System.Drawing.Point(-1, 36);
			this.subscribedGroupsListBox.Name = "subscribedGroupsListBox";
			this.subscribedGroupsListBox.Size = new System.Drawing.Size(156, 186);
			this.subscribedGroupsListBox.TabIndex = 3;
			this.subscribedGroupsListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.subscribedGroupsListBox_MouseClick);
			this.subscribedGroupsListBox.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.subscribedGroupsListBox_MouseDoubleClick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(3, 1);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(112, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Subscribed groups";
			// 
			// profileTab
			// 
			this.profileTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.profileTab.Controls.Add(this.profileTabControl);
			this.profileTab.Location = new System.Drawing.Point(4, 22);
			this.profileTab.Name = "profileTab";
			this.profileTab.Padding = new System.Windows.Forms.Padding(3);
			this.profileTab.Size = new System.Drawing.Size(319, 252);
			this.profileTab.TabIndex = 0;
			this.profileTab.Text = "Profile";
			this.profileTab.UseVisualStyleBackColor = true;
			// 
			// profileTabControl
			// 
			this.profileTabControl.Controls.Add(this.tabPage1);
			this.profileTabControl.Controls.Add(this.registerTabPage);
			this.profileTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.profileTabControl.Location = new System.Drawing.Point(3, 3);
			this.profileTabControl.Name = "profileTabControl";
			this.profileTabControl.SelectedIndex = 0;
			this.profileTabControl.Size = new System.Drawing.Size(313, 246);
			this.profileTabControl.TabIndex = 0;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.infoLabel);
			this.tabPage1.Controls.Add(this.logoutButton);
			this.tabPage1.Controls.Add(this.loginButton);
			this.tabPage1.Controls.Add(this.label4);
			this.tabPage1.Controls.Add(this.passwordTextBox);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.usernameTextBox);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(305, 220);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Login";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// infoLabel
			// 
			this.infoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.infoLabel.Location = new System.Drawing.Point(71, 180);
			this.infoLabel.Name = "infoLabel";
			this.infoLabel.Size = new System.Drawing.Size(158, 16);
			this.infoLabel.TabIndex = 6;
			this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// logoutButton
			// 
			this.logoutButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.logoutButton.Location = new System.Drawing.Point(154, 133);
			this.logoutButton.Name = "logoutButton";
			this.logoutButton.Size = new System.Drawing.Size(75, 23);
			this.logoutButton.TabIndex = 5;
			this.logoutButton.Text = "Logout";
			this.logoutButton.UseVisualStyleBackColor = true;
			this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
			// 
			// loginButton
			// 
			this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.loginButton.Location = new System.Drawing.Point(71, 133);
			this.loginButton.Name = "loginButton";
			this.loginButton.Size = new System.Drawing.Size(75, 23);
			this.loginButton.TabIndex = 4;
			this.loginButton.Text = "Login";
			this.loginButton.UseVisualStyleBackColor = true;
			this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(68, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 13);
			this.label4.TabIndex = 3;
			this.label4.Text = "Password";
			// 
			// passwordTextBox
			// 
			this.passwordTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.passwordTextBox.Location = new System.Drawing.Point(129, 97);
			this.passwordTextBox.Name = "passwordTextBox";
			this.passwordTextBox.Size = new System.Drawing.Size(100, 20);
			this.passwordTextBox.TabIndex = 2;
			this.passwordTextBox.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(68, 68);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(55, 13);
			this.label3.TabIndex = 1;
			this.label3.Text = "Username";
			// 
			// usernameTextBox
			// 
			this.usernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.usernameTextBox.Location = new System.Drawing.Point(129, 65);
			this.usernameTextBox.Name = "usernameTextBox";
			this.usernameTextBox.Size = new System.Drawing.Size(100, 20);
			this.usernameTextBox.TabIndex = 0;
			// 
			// registerTabPage
			// 
			this.registerTabPage.Controls.Add(this.rInfoLabel);
			this.registerTabPage.Controls.Add(this.registerButton);
			this.registerTabPage.Controls.Add(this.rPassword2TextBox);
			this.registerTabPage.Controls.Add(this.rPassword1TextBox);
			this.registerTabPage.Controls.Add(this.rEmailTextBox);
			this.registerTabPage.Controls.Add(this.rUsernameTextBox);
			this.registerTabPage.Controls.Add(this.label8);
			this.registerTabPage.Controls.Add(this.label7);
			this.registerTabPage.Controls.Add(this.label6);
			this.registerTabPage.Controls.Add(this.label5);
			this.registerTabPage.Location = new System.Drawing.Point(4, 22);
			this.registerTabPage.Name = "registerTabPage";
			this.registerTabPage.Padding = new System.Windows.Forms.Padding(3);
			this.registerTabPage.Size = new System.Drawing.Size(305, 220);
			this.registerTabPage.TabIndex = 1;
			this.registerTabPage.Text = "Register";
			this.registerTabPage.UseVisualStyleBackColor = true;
			// 
			// rInfoLabel
			// 
			this.rInfoLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rInfoLabel.Location = new System.Drawing.Point(69, 180);
			this.rInfoLabel.Name = "rInfoLabel";
			this.rInfoLabel.Size = new System.Drawing.Size(158, 16);
			this.rInfoLabel.TabIndex = 11;
			this.rInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// registerButton
			// 
			this.registerButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.registerButton.Location = new System.Drawing.Point(69, 138);
			this.registerButton.Name = "registerButton";
			this.registerButton.Size = new System.Drawing.Size(158, 23);
			this.registerButton.TabIndex = 10;
			this.registerButton.Text = "Register";
			this.registerButton.UseVisualStyleBackColor = true;
			this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
			// 
			// rPassword2TextBox
			// 
			this.rPassword2TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rPassword2TextBox.Location = new System.Drawing.Point(127, 105);
			this.rPassword2TextBox.Name = "rPassword2TextBox";
			this.rPassword2TextBox.Size = new System.Drawing.Size(100, 20);
			this.rPassword2TextBox.TabIndex = 9;
			this.rPassword2TextBox.UseSystemPasswordChar = true;
			// 
			// rPassword1TextBox
			// 
			this.rPassword1TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rPassword1TextBox.Location = new System.Drawing.Point(127, 79);
			this.rPassword1TextBox.Name = "rPassword1TextBox";
			this.rPassword1TextBox.Size = new System.Drawing.Size(100, 20);
			this.rPassword1TextBox.TabIndex = 8;
			this.rPassword1TextBox.UseSystemPasswordChar = true;
			// 
			// rEmailTextBox
			// 
			this.rEmailTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rEmailTextBox.Location = new System.Drawing.Point(127, 53);
			this.rEmailTextBox.Name = "rEmailTextBox";
			this.rEmailTextBox.Size = new System.Drawing.Size(100, 20);
			this.rEmailTextBox.TabIndex = 7;
			// 
			// rUsernameTextBox
			// 
			this.rUsernameTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.rUsernameTextBox.Location = new System.Drawing.Point(127, 27);
			this.rUsernameTextBox.Name = "rUsernameTextBox";
			this.rUsernameTextBox.Size = new System.Drawing.Size(100, 20);
			this.rUsernameTextBox.TabIndex = 6;
			// 
			// label8
			// 
			this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(68, 82);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(53, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Password";
			// 
			// label7
			// 
			this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(68, 108);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(53, 13);
			this.label7.TabIndex = 4;
			this.label7.Text = "Password";
			// 
			// label6
			// 
			this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(89, 56);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(32, 13);
			this.label6.TabIndex = 3;
			this.label6.Text = "Email";
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(66, 30);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(55, 13);
			this.label5.TabIndex = 2;
			this.label5.Text = "Username";
			// 
			// mainTabControl
			// 
			this.mainTabControl.Controls.Add(this.profileTab);
			this.mainTabControl.Controls.Add(this.groupsTab);
			this.mainTabControl.Controls.Add(this.activityTab);
			this.mainTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.mainTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mainTabControl.Location = new System.Drawing.Point(0, 0);
			this.mainTabControl.Name = "mainTabControl";
			this.mainTabControl.SelectedIndex = 0;
			this.mainTabControl.Size = new System.Drawing.Size(327, 278);
			this.mainTabControl.TabIndex = 0;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(327, 278);
			this.Controls.Add(this.mainTabControl);
			this.Name = "MainForm";
			this.Text = "Modus Tempus";
			this.activityTab.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			this.splitContainer1.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.timeSpentNumericUpDown)).EndInit();
			this.groupsTab.ResumeLayout(false);
			this.splitContainer.Panel1.ResumeLayout(false);
			this.splitContainer.Panel1.PerformLayout();
			this.splitContainer.Panel2.ResumeLayout(false);
			this.splitContainer.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
			this.splitContainer.ResumeLayout(false);
			this.profileTab.ResumeLayout(false);
			this.profileTabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.registerTabPage.ResumeLayout(false);
			this.registerTabPage.PerformLayout();
			this.mainTabControl.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabPage activityTab;
		private System.Windows.Forms.TabPage groupsTab;
		private System.Windows.Forms.TabPage profileTab;
		private System.Windows.Forms.TabControl mainTabControl;
		private System.Windows.Forms.SplitContainer splitContainer;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox groupSearchBox;
		private System.Windows.Forms.ListBox allGroupsListBox;
		private System.Windows.Forms.ListBox subscribedGroupsListBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TreeView activityTreeView;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.Button recordButton;
		private System.Windows.Forms.NumericUpDown timeSpentNumericUpDown;
		private System.Windows.Forms.ComboBox timeUnitComboBox;
		private System.Windows.Forms.Button viewStatisticsButton;
		private System.Windows.Forms.TabControl profileTabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.Button logoutButton;
		private System.Windows.Forms.Button loginButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox passwordTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox usernameTextBox;
		private System.Windows.Forms.TabPage registerTabPage;
		private System.Windows.Forms.Label infoLabel;
		private System.Windows.Forms.Label selectedGroupLabel;
		private System.Windows.Forms.Label selectedActivityLabel;
		private System.Windows.Forms.Label confirmationLabel;
		private System.Windows.Forms.Button createGroupButton;
		private System.Windows.Forms.Button deleteGroupButton;
		private System.Windows.Forms.TextBox rPassword2TextBox;
		private System.Windows.Forms.TextBox rPassword1TextBox;
		private System.Windows.Forms.TextBox rEmailTextBox;
		private System.Windows.Forms.TextBox rUsernameTextBox;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button registerButton;
		private System.Windows.Forms.Label rInfoLabel;
		private System.Windows.Forms.Label permissionLabel;
		private System.Windows.Forms.Button createActivityButton;
		private System.Windows.Forms.Button deleteActivityButton;
		private System.Windows.Forms.TextBox activityNameBox;
	}
}