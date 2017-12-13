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
            this.MI_listBox = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.G_Top5 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.MA_FindPolys = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.MA_LandscapeID = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
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
            this.UPD_Update.Location = new System.Drawing.Point(6, 15);
            this.UPD_Update.Name = "UPD_Update";
            this.UPD_Update.Size = new System.Drawing.Size(69, 23);
            this.UPD_Update.TabIndex = 0;
            this.UPD_Update.Text = "Update!";
            this.UPD_Update.UseVisualStyleBackColor = true;
            this.UPD_Update.Click += new System.EventHandler(this.button1_Click);
            // 
            // PINPOINT_ID
            // 
            this.PINPOINT_ID.Location = new System.Drawing.Point(143, 17);
            this.PINPOINT_ID.Name = "PINPOINT_ID";
            this.PINPOINT_ID.Size = new System.Drawing.Size(68, 20);
            this.PINPOINT_ID.TabIndex = 3;
            // 
            // UPD_Description
            // 
            this.UPD_Description.Location = new System.Drawing.Point(6, 41);
            this.UPD_Description.Name = "UPD_Description";
            this.UPD_Description.Size = new System.Drawing.Size(302, 71);
            this.UPD_Description.TabIndex = 5;
            this.UPD_Description.Text = "";
            // 
            // UPD_PinpointID
            // 
            this.UPD_PinpointID.AutoSize = true;
            this.UPD_PinpointID.Location = new System.Drawing.Point(81, 20);
            this.UPD_PinpointID.Name = "UPD_PinpointID";
            this.UPD_PinpointID.Size = new System.Drawing.Size(62, 13);
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
            this.groupBox1.Location = new System.Drawing.Point(-2, -2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 39);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "GLOBAL";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // GLOBAL_LIST_USERS
            // 
            this.GLOBAL_LIST_USERS.Location = new System.Drawing.Point(179, 11);
            this.GLOBAL_LIST_USERS.Name = "GLOBAL_LIST_USERS";
            this.GLOBAL_LIST_USERS.Size = new System.Drawing.Size(94, 23);
            this.GLOBAL_LIST_USERS.TabIndex = 9;
            this.GLOBAL_LIST_USERS.Text = "List Users";
            this.GLOBAL_LIST_USERS.UseVisualStyleBackColor = true;
            this.GLOBAL_LIST_USERS.Click += new System.EventHandler(this.GLOBAL_LIST_USERS_Click);
            // 
            // GLOBAL_USER_INFO
            // 
            this.GLOBAL_USER_INFO.AutoSize = true;
            this.GLOBAL_USER_INFO.Location = new System.Drawing.Point(295, 16);
            this.GLOBAL_USER_INFO.Name = "GLOBAL_USER_INFO";
            this.GLOBAL_USER_INFO.Size = new System.Drawing.Size(108, 13);
            this.GLOBAL_USER_INFO.TabIndex = 10;
            this.GLOBAL_USER_INFO.Text = "<selected_user_info>";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "USER_ID:";
            // 
            // GLOBAL_USER_ID
            // 
            this.GLOBAL_USER_ID.Location = new System.Drawing.Point(73, 13);
            this.GLOBAL_USER_ID.Name = "GLOBAL_USER_ID";
            this.GLOBAL_USER_ID.Size = new System.Drawing.Size(100, 20);
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
            this.UPD_Box.Location = new System.Drawing.Point(7, 43);
            this.UPD_Box.Name = "UPD_Box";
            this.UPD_Box.Size = new System.Drawing.Size(314, 119);
            this.UPD_Box.TabIndex = 9;
            this.UPD_Box.TabStop = false;
            this.UPD_Box.Text = "Update Pinpoint Description";
            // 
            // UPD_ListPinpoints
            // 
            this.UPD_ListPinpoints.Location = new System.Drawing.Point(214, 15);
            this.UPD_ListPinpoints.Name = "UPD_ListPinpoints";
            this.UPD_ListPinpoints.Size = new System.Drawing.Size(94, 23);
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
            this.userBox.Location = new System.Drawing.Point(327, 43);
            this.userBox.Name = "userBox";
            this.userBox.Size = new System.Drawing.Size(459, 68);
            this.userBox.TabIndex = 10;
            this.userBox.TabStop = false;
            this.userBox.Text = "User Actions";
            // 
            // UA_CreateUser
            // 
            this.UA_CreateUser.Location = new System.Drawing.Point(263, 38);
            this.UA_CreateUser.Name = "UA_CreateUser";
            this.UA_CreateUser.Size = new System.Drawing.Size(109, 23);
            this.UA_CreateUser.TabIndex = 9;
            this.UA_CreateUser.Text = "Create New User";
            this.UA_CreateUser.UseVisualStyleBackColor = true;
            this.UA_CreateUser.Click += new System.EventHandler(this.UA_CreateUser_Click);
            // 
            // UA_FetchUserRatings
            // 
            this.UA_FetchUserRatings.Location = new System.Drawing.Point(117, 38);
            this.UA_FetchUserRatings.Name = "UA_FetchUserRatings";
            this.UA_FetchUserRatings.Size = new System.Drawing.Size(140, 23);
            this.UA_FetchUserRatings.TabIndex = 8;
            this.UA_FetchUserRatings.Text = "Fetch User_Rating\'s";
            this.UA_FetchUserRatings.UseVisualStyleBackColor = true;
            this.UA_FetchUserRatings.Click += new System.EventHandler(this.UA_FetchUserRatings_Click);
            // 
            // UA_FetchRank
            // 
            this.UA_FetchRank.Location = new System.Drawing.Point(6, 38);
            this.UA_FetchRank.Name = "UA_FetchRank";
            this.UA_FetchRank.Size = new System.Drawing.Size(105, 23);
            this.UA_FetchRank.TabIndex = 7;
            this.UA_FetchRank.Text = "Fetch User Rank";
            this.UA_FetchRank.UseVisualStyleBackColor = true;
            this.UA_FetchRank.Click += new System.EventHandler(this.UA_FetchRank_Click);
            // 
            // UA_isAdminCheck
            // 
            this.UA_isAdminCheck.AutoSize = true;
            this.UA_isAdminCheck.Location = new System.Drawing.Point(363, 14);
            this.UA_isAdminCheck.Name = "UA_isAdminCheck";
            this.UA_isAdminCheck.Size = new System.Drawing.Size(68, 17);
            this.UA_isAdminCheck.TabIndex = 6;
            this.UA_isAdminCheck.Text = "isAdmin?";
            this.UA_isAdminCheck.UseVisualStyleBackColor = true;
            // 
            // UA_LnameBox
            // 
            this.UA_LnameBox.Location = new System.Drawing.Point(286, 12);
            this.UA_LnameBox.Name = "UA_LnameBox";
            this.UA_LnameBox.Size = new System.Drawing.Size(71, 20);
            this.UA_LnameBox.TabIndex = 5;
            // 
            // UA_LnameLabel
            // 
            this.UA_LnameLabel.AutoSize = true;
            this.UA_LnameLabel.Location = new System.Drawing.Point(247, 15);
            this.UA_LnameLabel.Name = "UA_LnameLabel";
            this.UA_LnameLabel.Size = new System.Drawing.Size(42, 13);
            this.UA_LnameLabel.TabIndex = 4;
            this.UA_LnameLabel.Text = "Lname:";
            // 
            // UA_FnameBox
            // 
            this.UA_FnameBox.Location = new System.Drawing.Point(170, 12);
            this.UA_FnameBox.Name = "UA_FnameBox";
            this.UA_FnameBox.Size = new System.Drawing.Size(71, 20);
            this.UA_FnameBox.TabIndex = 3;
            // 
            // UA_FnameLabel
            // 
            this.UA_FnameLabel.AutoSize = true;
            this.UA_FnameLabel.Location = new System.Drawing.Point(130, 15);
            this.UA_FnameLabel.Name = "UA_FnameLabel";
            this.UA_FnameLabel.Size = new System.Drawing.Size(42, 13);
            this.UA_FnameLabel.TabIndex = 2;
            this.UA_FnameLabel.Text = "Fname:";
            // 
            // UA_UserIDLabel
            // 
            this.UA_UserIDLabel.AutoSize = true;
            this.UA_UserIDLabel.Location = new System.Drawing.Point(7, 15);
            this.UA_UserIDLabel.Name = "UA_UserIDLabel";
            this.UA_UserIDLabel.Size = new System.Drawing.Size(46, 13);
            this.UA_UserIDLabel.TabIndex = 1;
            this.UA_UserIDLabel.Text = "User ID:";
            // 
            // UA_UserIDBox
            // 
            this.UA_UserIDBox.Location = new System.Drawing.Point(53, 12);
            this.UA_UserIDBox.Name = "UA_UserIDBox";
            this.UA_UserIDBox.Size = new System.Drawing.Size(71, 20);
            this.UA_UserIDBox.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(6, 146);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 23);
            this.button3.TabIndex = 7;
            this.button3.Text = "Refresh Map List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(159, 23);
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
            this.MI_GroupBox.Location = new System.Drawing.Point(7, 168);
            this.MI_GroupBox.Name = "MI_GroupBox";
            this.MI_GroupBox.Size = new System.Drawing.Size(314, 205);
            this.MI_GroupBox.TabIndex = 11;
            this.MI_GroupBox.TabStop = false;
            this.MI_GroupBox.Text = "Map Actions";
            // 
            // MI_listBox
            // 
            this.MI_listBox.FormattingEnabled = true;
            this.MI_listBox.Location = new System.Drawing.Point(6, 19);
            this.MI_listBox.Name = "MI_listBox";
            this.MI_listBox.Size = new System.Drawing.Size(302, 121);
            this.MI_listBox.TabIndex = 12;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.G_Top5);
            this.groupBox2.Location = new System.Drawing.Point(7, 379);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(779, 51);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Global Actions";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(629, 19);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(144, 23);
            this.button4.TabIndex = 8;
            this.button4.Text = "Close Editor";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // G_Top5
            // 
            this.G_Top5.Location = new System.Drawing.Point(5, 19);
            this.G_Top5.Name = "G_Top5";
            this.G_Top5.Size = new System.Drawing.Size(158, 23);
            this.G_Top5.TabIndex = 7;
            this.G_Top5.Text = "Get Top 5 Users";
            this.G_Top5.UseVisualStyleBackColor = true;
            this.G_Top5.Click += new System.EventHandler(this.G_Top5_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(169, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(140, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "List User_Ratings";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(378, 38);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "+5 Score";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // MA_FindPolys
            // 
            this.MA_FindPolys.Location = new System.Drawing.Point(5, 175);
            this.MA_FindPolys.Name = "MA_FindPolys";
            this.MA_FindPolys.Size = new System.Drawing.Size(129, 23);
            this.MA_FindPolys.TabIndex = 13;
            this.MA_FindPolys.Text = "Find Landscape Polys";
            this.MA_FindPolys.UseVisualStyleBackColor = true;
            this.MA_FindPolys.Click += new System.EventHandler(this.MA_FindPolys_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Landscape ID:";
            this.label2.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // MA_LandscapeID
            // 
            this.MA_LandscapeID.Location = new System.Drawing.Point(214, 177);
            this.MA_LandscapeID.Name = "MA_LandscapeID";
            this.MA_LandscapeID.Size = new System.Drawing.Size(95, 20);
            this.MA_LandscapeID.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Get Top Pinpoints!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(476, 19);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(147, 23);
            this.button6.TabIndex = 12;
            this.button6.Text = "Delete User\'s Ratings (troll)";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Forms_Csharp_app.Properties.Resources.UI;
            this.pictureBox1.Location = new System.Drawing.Point(327, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(453, 256);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(793, 437);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.MI_GroupBox);
            this.Controls.Add(this.userBox);
            this.Controls.Add(this.UPD_Box);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
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

