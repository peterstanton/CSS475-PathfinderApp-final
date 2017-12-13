namespace Forms_Csharp_app {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.UPD_Update = new System.Windows.Forms.Button();
            this.PINPOINT_ID = new System.Windows.Forms.TextBox();
            this.UPD_Description = new System.Windows.Forms.RichTextBox();
            this.UPD_PinpointID = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.GLOBAL_LIST_USERS = new System.Windows.Forms.Button();
            this.GLOBAL_USER_INFO = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.GLOBAL_USER_ID = new System.Windows.Forms.TextBox();
            this.UPD_Box = new System.Windows.Forms.GroupBox();
            this.UPD_ListPinpoints = new System.Windows.Forms.Button();
            this.userBox = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.UA_CreateUser = new System.Windows.Forms.Button();
            this.UA_FetchUserRatings = new System.Windows.Forms.Button();
            this.UA_FetchRank = new System.Windows.Forms.Button();
            this.UA_isAdminCheck = new System.Windows.Forms.CheckBox();
            this.UA_LnameBox = new System.Windows.Forms.TextBox();
            this.UA_LnameLabel = new System.Windows.Forms.Label();
            this.UA_FnameBox = new System.Windows.Forms.TextBox();
            this.UA_FnameLabel = new System.Windows.Forms.Label();
            this.UA_UserIDLabel = new System.Windows.Forms.Label();
            this.UA_UserIDBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.MI_GroupBox = new System.Windows.Forms.GroupBox();
            this.MA_LandscapeID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.MA_FindPolys = new System.Windows.Forms.Button();
            this.MI_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.G_Top5 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.UPD_Box.SuspendLayout();
            this.userBox.SuspendLayout();
            this.MI_GroupBox.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // UPD_Update
            // 
            this.UPD_Update.Location = new System.Drawing.Point(8, 18);
            this.UPD_Update.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPD_Update.Name = "UPD_Update";
            this.UPD_Update.Size = new System.Drawing.Size(92, 28);
            this.UPD_Update.TabIndex = 0;
            this.UPD_Update.Text = "Update!";
            this.UPD_Update.UseVisualStyleBackColor = true;
            this.UPD_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // PINPOINT_ID
            // 
            this.PINPOINT_ID.Location = new System.Drawing.Point(191, 21);
            this.PINPOINT_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PINPOINT_ID.Name = "PINPOINT_ID";
            this.PINPOINT_ID.Size = new System.Drawing.Size(89, 22);
            this.PINPOINT_ID.TabIndex = 3;
            // 
            // UPD_Description
            // 
            this.UPD_Description.Location = new System.Drawing.Point(8, 50);
            this.UPD_Description.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPD_Description.Name = "UPD_Description";
            this.UPD_Description.Size = new System.Drawing.Size(401, 86);
            this.UPD_Description.TabIndex = 5;
            this.UPD_Description.Text = "";
            // 
            // UPD_PinpointID
            // 
            this.UPD_PinpointID.AutoSize = true;
            this.UPD_PinpointID.Location = new System.Drawing.Point(108, 25);
            this.UPD_PinpointID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UPD_PinpointID.Name = "UPD_PinpointID";
            this.UPD_PinpointID.Size = new System.Drawing.Size(80, 17);
            this.UPD_PinpointID.TabIndex = 7;
            this.UPD_PinpointID.Text = "Pinpoint ID:";
            this.UPD_PinpointID.Click += new System.EventHandler(this.label2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.GLOBAL_LIST_USERS);
            this.groupBox1.Controls.Add(this.GLOBAL_USER_INFO);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.GLOBAL_USER_ID);
            this.groupBox1.Location = new System.Drawing.Point(-3, -2);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1051, 48);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GLOBAL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GLOBAL_LIST_USERS
            // 
            this.GLOBAL_LIST_USERS.Location = new System.Drawing.Point(239, 14);
            this.GLOBAL_LIST_USERS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GLOBAL_LIST_USERS.Name = "GLOBAL_LIST_USERS";
            this.GLOBAL_LIST_USERS.Size = new System.Drawing.Size(125, 28);
            this.GLOBAL_LIST_USERS.TabIndex = 9;
            this.GLOBAL_LIST_USERS.Text = "List Users";
            this.GLOBAL_LIST_USERS.UseVisualStyleBackColor = true;
            this.GLOBAL_LIST_USERS.Click += new System.EventHandler(this.GLOBAL_LIST_USERS_Click);
            // 
            // GLOBAL_USER_INFO
            // 
            this.GLOBAL_USER_INFO.AutoSize = true;
            this.GLOBAL_USER_INFO.Location = new System.Drawing.Point(393, 20);
            this.GLOBAL_USER_INFO.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GLOBAL_USER_INFO.Name = "GLOBAL_USER_INFO";
            this.GLOBAL_USER_INFO.Size = new System.Drawing.Size(144, 17);
            this.GLOBAL_USER_INFO.TabIndex = 10;
            this.GLOBAL_USER_INFO.Text = "<selected_user_info>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "USER_ID:";
            // 
            // GLOBAL_USER_ID
            // 
            this.GLOBAL_USER_ID.Location = new System.Drawing.Point(97, 16);
            this.GLOBAL_USER_ID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.GLOBAL_USER_ID.Name = "GLOBAL_USER_ID";
            this.GLOBAL_USER_ID.Size = new System.Drawing.Size(132, 22);
            this.GLOBAL_USER_ID.TabIndex = 9;
            this.GLOBAL_USER_ID.TextChanged += new System.EventHandler(this.GLOBAL_USER_ID_TextChanged);
            // 
            // UPD_Box
            // 
            this.UPD_Box.Controls.Add(this.UPD_ListPinpoints);
            this.UPD_Box.Controls.Add(this.UPD_Update);
            this.UPD_Box.Controls.Add(this.UPD_PinpointID);
            this.UPD_Box.Controls.Add(this.UPD_Description);
            this.UPD_Box.Controls.Add(this.PINPOINT_ID);
            this.UPD_Box.Location = new System.Drawing.Point(9, 53);
            this.UPD_Box.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPD_Box.Name = "UPD_Box";
            this.UPD_Box.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPD_Box.Size = new System.Drawing.Size(419, 146);
            this.UPD_Box.TabIndex = 9;
            this.UPD_Box.TabStop = false;
            this.UPD_Box.Text = "Update Pinpoint Description";
            // 
            // UPD_ListPinpoints
            // 
            this.UPD_ListPinpoints.Location = new System.Drawing.Point(285, 18);
            this.UPD_ListPinpoints.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPD_ListPinpoints.Name = "UPD_ListPinpoints";
            this.UPD_ListPinpoints.Size = new System.Drawing.Size(125, 28);
            this.UPD_ListPinpoints.TabIndex = 8;
            this.UPD_ListPinpoints.Text = "List Pinpoints";
            this.UPD_ListPinpoints.UseVisualStyleBackColor = true;
            this.UPD_ListPinpoints.Click += new System.EventHandler(this.UPD_ListPinpoints_Click);
            // 
            // userBox
            // 
            this.userBox.Controls.Add(this.button5);
            this.userBox.Controls.Add(this.UA_CreateUser);
            this.userBox.Controls.Add(this.UA_FetchUserRatings);
            this.userBox.Controls.Add(this.UA_FetchRank);
            this.userBox.Controls.Add(this.UA_isAdminCheck);
            this.userBox.Controls.Add(this.UA_LnameBox);
            this.userBox.Controls.Add(this.UA_LnameLabel);
            this.userBox.Controls.Add(this.UA_FnameBox);
            this.userBox.Controls.Add(this.UA_FnameLabel);
            this.userBox.Controls.Add(this.UA_UserIDLabel);
            this.userBox.Controls.Add(this.UA_UserIDBox);
            this.userBox.Location = new System.Drawing.Point(436, 53);
            this.userBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBox.Name = "userBox";
            this.userBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userBox.Size = new System.Drawing.Size(612, 84);
            this.userBox.TabIndex = 10;
            this.userBox.TabStop = false;
            this.userBox.Text = "User Actions";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(504, 47);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(100, 28);
            this.button5.TabIndex = 12;
            this.button5.Text = "+5 Score";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // UA_CreateUser
            // 
            this.UA_CreateUser.Location = new System.Drawing.Point(351, 47);
            this.UA_CreateUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_CreateUser.Name = "UA_CreateUser";
            this.UA_CreateUser.Size = new System.Drawing.Size(145, 28);
            this.UA_CreateUser.TabIndex = 9;
            this.UA_CreateUser.Text = "Create New User";
            this.UA_CreateUser.UseVisualStyleBackColor = true;
            this.UA_CreateUser.Click += new System.EventHandler(this.UA_CreateUser_Click);
            // 
            // UA_FetchUserRatings
            // 
            this.UA_FetchUserRatings.Location = new System.Drawing.Point(156, 47);
            this.UA_FetchUserRatings.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_FetchUserRatings.Name = "UA_FetchUserRatings";
            this.UA_FetchUserRatings.Size = new System.Drawing.Size(187, 28);
            this.UA_FetchUserRatings.TabIndex = 8;
            this.UA_FetchUserRatings.Text = "Fetch User_Rating\'s";
            this.UA_FetchUserRatings.UseVisualStyleBackColor = true;
            this.UA_FetchUserRatings.Click += new System.EventHandler(this.UA_FetchUserRatings_Click);
            // 
            // UA_FetchRank
            // 
            this.UA_FetchRank.Location = new System.Drawing.Point(8, 47);
            this.UA_FetchRank.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_FetchRank.Name = "UA_FetchRank";
            this.UA_FetchRank.Size = new System.Drawing.Size(140, 28);
            this.UA_FetchRank.TabIndex = 7;
            this.UA_FetchRank.Text = "Fetch User Rank";
            this.UA_FetchRank.UseVisualStyleBackColor = true;
            this.UA_FetchRank.Click += new System.EventHandler(this.UA_FetchRank_Click);
            // 
            // UA_isAdminCheck
            // 
            this.UA_isAdminCheck.AutoSize = true;
            this.UA_isAdminCheck.Location = new System.Drawing.Point(484, 17);
            this.UA_isAdminCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_isAdminCheck.Name = "UA_isAdminCheck";
            this.UA_isAdminCheck.Size = new System.Drawing.Size(87, 21);
            this.UA_isAdminCheck.TabIndex = 6;
            this.UA_isAdminCheck.Text = "isAdmin?";
            this.UA_isAdminCheck.UseVisualStyleBackColor = true;
            // 
            // UA_LnameBox
            // 
            this.UA_LnameBox.Location = new System.Drawing.Point(381, 15);
            this.UA_LnameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_LnameBox.Name = "UA_LnameBox";
            this.UA_LnameBox.Size = new System.Drawing.Size(93, 22);
            this.UA_LnameBox.TabIndex = 5;
            // 
            // UA_LnameLabel
            // 
            this.UA_LnameLabel.AutoSize = true;
            this.UA_LnameLabel.Location = new System.Drawing.Point(329, 18);
            this.UA_LnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UA_LnameLabel.Name = "UA_LnameLabel";
            this.UA_LnameLabel.Size = new System.Drawing.Size(55, 17);
            this.UA_LnameLabel.TabIndex = 4;
            this.UA_LnameLabel.Text = "Lname:";
            // 
            // UA_FnameBox
            // 
            this.UA_FnameBox.Location = new System.Drawing.Point(227, 15);
            this.UA_FnameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_FnameBox.Name = "UA_FnameBox";
            this.UA_FnameBox.Size = new System.Drawing.Size(93, 22);
            this.UA_FnameBox.TabIndex = 3;
            // 
            // UA_FnameLabel
            // 
            this.UA_FnameLabel.AutoSize = true;
            this.UA_FnameLabel.Location = new System.Drawing.Point(173, 18);
            this.UA_FnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UA_FnameLabel.Name = "UA_FnameLabel";
            this.UA_FnameLabel.Size = new System.Drawing.Size(55, 17);
            this.UA_FnameLabel.TabIndex = 2;
            this.UA_FnameLabel.Text = "Fname:";
            // 
            // UA_UserIDLabel
            // 
            this.UA_UserIDLabel.AutoSize = true;
            this.UA_UserIDLabel.Location = new System.Drawing.Point(9, 18);
            this.UA_UserIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UA_UserIDLabel.Name = "UA_UserIDLabel";
            this.UA_UserIDLabel.Size = new System.Drawing.Size(59, 17);
            this.UA_UserIDLabel.TabIndex = 1;
            this.UA_UserIDLabel.Text = "User ID:";
            // 
            // UA_UserIDBox
            // 
            this.UA_UserIDBox.Location = new System.Drawing.Point(71, 15);
            this.UA_UserIDBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UA_UserIDBox.Name = "UA_UserIDBox";
            this.UA_UserIDBox.Size = new System.Drawing.Size(93, 22);
            this.UA_UserIDBox.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(8, 180);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(183, 28);
            this.button3.TabIndex = 7;
            this.button3.Text = "Refresh Map List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(199, 180);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(212, 28);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show Landscapes";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MI_GroupBox
            // 
            this.MI_GroupBox.Controls.Add(this.MA_LandscapeID);
            this.MI_GroupBox.Controls.Add(this.label2);
            this.MI_GroupBox.Controls.Add(this.MA_FindPolys);
            this.MI_GroupBox.Controls.Add(this.MI_listBox);
            this.MI_GroupBox.Controls.Add(this.button2);
            this.MI_GroupBox.Controls.Add(this.button3);
            this.MI_GroupBox.Location = new System.Drawing.Point(9, 207);
            this.MI_GroupBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MI_GroupBox.Name = "MI_GroupBox";
            this.MI_GroupBox.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MI_GroupBox.Size = new System.Drawing.Size(419, 252);
            this.MI_GroupBox.TabIndex = 11;
            this.MI_GroupBox.TabStop = false;
            this.MI_GroupBox.Text = "Map Actions";
            // 
            // MA_LandscapeID
            // 
            this.MA_LandscapeID.Location = new System.Drawing.Point(285, 218);
            this.MA_LandscapeID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MA_LandscapeID.Name = "MA_LandscapeID";
            this.MA_LandscapeID.Size = new System.Drawing.Size(125, 22);
            this.MA_LandscapeID.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 222);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Landscape ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MA_FindPolys
            // 
            this.MA_FindPolys.Location = new System.Drawing.Point(7, 215);
            this.MA_FindPolys.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MA_FindPolys.Name = "MA_FindPolys";
            this.MA_FindPolys.Size = new System.Drawing.Size(172, 28);
            this.MA_FindPolys.TabIndex = 13;
            this.MA_FindPolys.Text = "Find Landscape Polys";
            this.MA_FindPolys.UseVisualStyleBackColor = true;
            this.MA_FindPolys.Click += new System.EventHandler(this.MA_FindPolys_Click);
            // 
            // MI_listBox
            // 
            this.MI_listBox.FormattingEnabled = true;
            this.MI_listBox.ItemHeight = 16;
            this.MI_listBox.Location = new System.Drawing.Point(8, 23);
            this.MI_listBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MI_listBox.Name = "MI_listBox";
            this.MI_listBox.Size = new System.Drawing.Size(401, 148);
            this.MI_listBox.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.G_Top5);
            this.groupBox2.Location = new System.Drawing.Point(9, 466);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(1039, 63);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Actions";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(635, 23);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(196, 28);
            this.button6.TabIndex = 12;
            this.button6.Text = "Delete User\'s Ratings (troll)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(420, 23);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get Top Pinpoints!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(225, 23);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(187, 28);
            this.button7.TabIndex = 11;
            this.button7.Text = "List User_Ratings";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(839, 23);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(192, 28);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close Editor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // G_Top5
            // 
            this.G_Top5.Location = new System.Drawing.Point(7, 23);
            this.G_Top5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.G_Top5.Name = "G_Top5";
            this.G_Top5.Size = new System.Drawing.Size(211, 28);
            this.G_Top5.TabIndex = 7;
            this.G_Top5.Text = "Get Top 5 Users";
            this.G_Top5.UseVisualStyleBackColor = true;
            this.G_Top5.Click += new System.EventHandler(this.G_Top5_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms_Csharp_app.Properties.Resources.UI;
            this.pictureBox1.Location = new System.Drawing.Point(436, 144);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 315);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 538);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MI_GroupBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.UPD_Box);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Pathfinder";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.UPD_Box.ResumeLayout(false);
            this.UPD_Box.PerformLayout();
            this.userBox.ResumeLayout(false);
            this.userBox.PerformLayout();
            this.MI_GroupBox.ResumeLayout(false);
            this.MI_GroupBox.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UPD_Update;
        private System.Windows.Forms.TextBox PINPOINT_ID;
        private System.Windows.Forms.RichTextBox UPD_Description;
        private System.Windows.Forms.Label UPD_PinpointID;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox GLOBAL_USER_ID;
        private System.Windows.Forms.GroupBox UPD_Box;
        private System.Windows.Forms.Label GLOBAL_USER_INFO;
        private System.Windows.Forms.Button GLOBAL_LIST_USERS;
        private System.Windows.Forms.Button UPD_ListPinpoints;
        private System.Windows.Forms.GroupBox userBox;
        private System.Windows.Forms.Button UA_CreateUser;
        private System.Windows.Forms.Button UA_FetchUserRatings;
        private System.Windows.Forms.Button UA_FetchRank;
        private System.Windows.Forms.CheckBox UA_isAdminCheck;
        private System.Windows.Forms.TextBox UA_LnameBox;
        private System.Windows.Forms.Label UA_LnameLabel;
        private System.Windows.Forms.TextBox UA_FnameBox;
        private System.Windows.Forms.Label UA_FnameLabel;
        private System.Windows.Forms.Label UA_UserIDLabel;
        private System.Windows.Forms.TextBox UA_UserIDBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox MI_GroupBox;
        private System.Windows.Forms.ListBox MI_listBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button G_Top5;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox MA_LandscapeID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button MA_FindPolys;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

