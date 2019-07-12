namespace TrackerUI
{
    partial class CreateTeamForm
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
            this.TeamNameValue = new System.Windows.Forms.TextBox();
            this.LBLTeamName = new System.Windows.Forms.Label();
            this.LBLHeader = new System.Windows.Forms.Label();
            this.BTNAddTeamMember = new System.Windows.Forms.Button();
            this.SelectTeamMemberDropDown = new System.Windows.Forms.ComboBox();
            this.LBLSelectTeamMember = new System.Windows.Forms.Label();
            this.AddNewMemberGroupBox = new System.Windows.Forms.GroupBox();
            this.BTNCreateMember = new System.Windows.Forms.Button();
            this.MobileValue = new System.Windows.Forms.TextBox();
            this.LBLMobile = new System.Windows.Forms.Label();
            this.EmailValue = new System.Windows.Forms.TextBox();
            this.LBLEmail = new System.Windows.Forms.Label();
            this.LastNameValue = new System.Windows.Forms.TextBox();
            this.LBLLastName = new System.Windows.Forms.Label();
            this.FirstNameValue = new System.Windows.Forms.TextBox();
            this.LBLFirstName = new System.Windows.Forms.Label();
            this.TeamMembersListBox = new System.Windows.Forms.ListBox();
            this.BTNRemoveSelectedMember = new System.Windows.Forms.Button();
            this.BTNCreateTeam = new System.Windows.Forms.Button();
            this.AddNewMemberGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TeamNameValue
            // 
            this.TeamNameValue.Location = new System.Drawing.Point(51, 144);
            this.TeamNameValue.Name = "TeamNameValue";
            this.TeamNameValue.Size = new System.Drawing.Size(346, 35);
            this.TeamNameValue.TabIndex = 27;
            // 
            // LBLTeamName
            // 
            this.LBLTeamName.AutoSize = true;
            this.LBLTeamName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTeamName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLTeamName.Location = new System.Drawing.Point(47, 104);
            this.LBLTeamName.Name = "LBLTeamName";
            this.LBLTeamName.Size = new System.Drawing.Size(157, 37);
            this.LBLTeamName.TabIndex = 26;
            this.LBLTeamName.Text = "Team Name";
            // 
            // LBLHeader
            // 
            this.LBLHeader.AutoSize = true;
            this.LBLHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLHeader.Location = new System.Drawing.Point(22, 28);
            this.LBLHeader.Name = "LBLHeader";
            this.LBLHeader.Size = new System.Drawing.Size(213, 50);
            this.LBLHeader.TabIndex = 25;
            this.LBLHeader.Text = "Create Team";
            // 
            // BTNAddTeamMember
            // 
            this.BTNAddTeamMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNAddTeamMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNAddTeamMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNAddTeamMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAddTeamMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNAddTeamMember.Location = new System.Drawing.Point(123, 299);
            this.BTNAddTeamMember.Name = "BTNAddTeamMember";
            this.BTNAddTeamMember.Size = new System.Drawing.Size(184, 52);
            this.BTNAddTeamMember.TabIndex = 33;
            this.BTNAddTeamMember.Text = "Add Member";
            this.BTNAddTeamMember.UseVisualStyleBackColor = true;
            this.BTNAddTeamMember.Click += new System.EventHandler(this.BTNAddTeamMember_Click);
            // 
            // SelectTeamMemberDropDown
            // 
            this.SelectTeamMemberDropDown.FormattingEnabled = true;
            this.SelectTeamMemberDropDown.Location = new System.Drawing.Point(48, 238);
            this.SelectTeamMemberDropDown.Name = "SelectTeamMemberDropDown";
            this.SelectTeamMemberDropDown.Size = new System.Drawing.Size(349, 38);
            this.SelectTeamMemberDropDown.TabIndex = 32;
            // 
            // LBLSelectTeamMember
            // 
            this.LBLSelectTeamMember.AutoSize = true;
            this.LBLSelectTeamMember.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSelectTeamMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLSelectTeamMember.Location = new System.Drawing.Point(44, 198);
            this.LBLSelectTeamMember.Name = "LBLSelectTeamMember";
            this.LBLSelectTeamMember.Size = new System.Drawing.Size(263, 37);
            this.LBLSelectTeamMember.TabIndex = 31;
            this.LBLSelectTeamMember.Text = "Select Team Member";
            // 
            // AddNewMemberGroupBox
            // 
            this.AddNewMemberGroupBox.Controls.Add(this.BTNCreateMember);
            this.AddNewMemberGroupBox.Controls.Add(this.MobileValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LBLMobile);
            this.AddNewMemberGroupBox.Controls.Add(this.EmailValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LBLEmail);
            this.AddNewMemberGroupBox.Controls.Add(this.LastNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LBLLastName);
            this.AddNewMemberGroupBox.Controls.Add(this.FirstNameValue);
            this.AddNewMemberGroupBox.Controls.Add(this.LBLFirstName);
            this.AddNewMemberGroupBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.AddNewMemberGroupBox.Location = new System.Drawing.Point(31, 371);
            this.AddNewMemberGroupBox.Name = "AddNewMemberGroupBox";
            this.AddNewMemberGroupBox.Size = new System.Drawing.Size(366, 283);
            this.AddNewMemberGroupBox.TabIndex = 34;
            this.AddNewMemberGroupBox.TabStop = false;
            this.AddNewMemberGroupBox.Text = "Add New Member";
            // 
            // BTNCreateMember
            // 
            this.BTNCreateMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNCreateMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNCreateMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNCreateMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreateMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreateMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNCreateMember.Location = new System.Drawing.Point(97, 219);
            this.BTNCreateMember.Name = "BTNCreateMember";
            this.BTNCreateMember.Size = new System.Drawing.Size(182, 42);
            this.BTNCreateMember.TabIndex = 34;
            this.BTNCreateMember.Text = "Create Member";
            this.BTNCreateMember.UseVisualStyleBackColor = true;
            this.BTNCreateMember.Click += new System.EventHandler(this.BTNCreateMember_Click);
            // 
            // MobileValue
            // 
            this.MobileValue.Location = new System.Drawing.Point(156, 175);
            this.MobileValue.Name = "MobileValue";
            this.MobileValue.Size = new System.Drawing.Size(204, 35);
            this.MobileValue.TabIndex = 30;
            // 
            // LBLMobile
            // 
            this.LBLMobile.AutoSize = true;
            this.LBLMobile.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLMobile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLMobile.Location = new System.Drawing.Point(6, 175);
            this.LBLMobile.Name = "LBLMobile";
            this.LBLMobile.Size = new System.Drawing.Size(101, 37);
            this.LBLMobile.TabIndex = 29;
            this.LBLMobile.Text = "Mobile";
            // 
            // EmailValue
            // 
            this.EmailValue.Location = new System.Drawing.Point(156, 129);
            this.EmailValue.Name = "EmailValue";
            this.EmailValue.Size = new System.Drawing.Size(204, 35);
            this.EmailValue.TabIndex = 28;
            // 
            // LBLEmail
            // 
            this.LBLEmail.AutoSize = true;
            this.LBLEmail.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLEmail.Location = new System.Drawing.Point(6, 126);
            this.LBLEmail.Name = "LBLEmail";
            this.LBLEmail.Size = new System.Drawing.Size(82, 37);
            this.LBLEmail.TabIndex = 27;
            this.LBLEmail.Text = "Email";
            // 
            // LastNameValue
            // 
            this.LastNameValue.Location = new System.Drawing.Point(156, 81);
            this.LastNameValue.Name = "LastNameValue";
            this.LastNameValue.Size = new System.Drawing.Size(204, 35);
            this.LastNameValue.TabIndex = 26;
            // 
            // LBLLastName
            // 
            this.LBLLastName.AutoSize = true;
            this.LBLLastName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLastName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLLastName.Location = new System.Drawing.Point(6, 78);
            this.LBLLastName.Name = "LBLLastName";
            this.LBLLastName.Size = new System.Drawing.Size(142, 37);
            this.LBLLastName.TabIndex = 25;
            this.LBLLastName.Text = "Last Name";
            // 
            // FirstNameValue
            // 
            this.FirstNameValue.Location = new System.Drawing.Point(156, 34);
            this.FirstNameValue.Name = "FirstNameValue";
            this.FirstNameValue.Size = new System.Drawing.Size(204, 35);
            this.FirstNameValue.TabIndex = 24;
            // 
            // LBLFirstName
            // 
            this.LBLFirstName.AutoSize = true;
            this.LBLFirstName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLFirstName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLFirstName.Location = new System.Drawing.Point(6, 31);
            this.LBLFirstName.Name = "LBLFirstName";
            this.LBLFirstName.Size = new System.Drawing.Size(144, 37);
            this.LBLFirstName.TabIndex = 23;
            this.LBLFirstName.Text = "First Name";
            // 
            // TeamMembersListBox
            // 
            this.TeamMembersListBox.FormattingEnabled = true;
            this.TeamMembersListBox.ItemHeight = 30;
            this.TeamMembersListBox.Location = new System.Drawing.Point(504, 140);
            this.TeamMembersListBox.Name = "TeamMembersListBox";
            this.TeamMembersListBox.Size = new System.Drawing.Size(326, 514);
            this.TeamMembersListBox.TabIndex = 35;
            // 
            // BTNRemoveSelectedMember
            // 
            this.BTNRemoveSelectedMember.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNRemoveSelectedMember.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNRemoveSelectedMember.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNRemoveSelectedMember.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNRemoveSelectedMember.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNRemoveSelectedMember.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNRemoveSelectedMember.Location = new System.Drawing.Point(843, 299);
            this.BTNRemoveSelectedMember.Name = "BTNRemoveSelectedMember";
            this.BTNRemoveSelectedMember.Size = new System.Drawing.Size(128, 81);
            this.BTNRemoveSelectedMember.TabIndex = 38;
            this.BTNRemoveSelectedMember.Text = "Remove Selected";
            this.BTNRemoveSelectedMember.UseVisualStyleBackColor = true;
            this.BTNRemoveSelectedMember.Click += new System.EventHandler(this.BTNRemoveSelectedMember_Click);
            // 
            // BTNCreateTeam
            // 
            this.BTNCreateTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNCreateTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNCreateTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNCreateTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreateTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreateTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNCreateTeam.Location = new System.Drawing.Point(356, 677);
            this.BTNCreateTeam.Name = "BTNCreateTeam";
            this.BTNCreateTeam.Size = new System.Drawing.Size(241, 72);
            this.BTNCreateTeam.TabIndex = 39;
            this.BTNCreateTeam.Text = "Create Team";
            this.BTNCreateTeam.UseVisualStyleBackColor = true;
            this.BTNCreateTeam.Click += new System.EventHandler(this.BTNCreateTeam_Click);
            // 
            // CreateTeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(983, 777);
            this.Controls.Add(this.BTNCreateTeam);
            this.Controls.Add(this.BTNRemoveSelectedMember);
            this.Controls.Add(this.TeamMembersListBox);
            this.Controls.Add(this.AddNewMemberGroupBox);
            this.Controls.Add(this.BTNAddTeamMember);
            this.Controls.Add(this.SelectTeamMemberDropDown);
            this.Controls.Add(this.LBLSelectTeamMember);
            this.Controls.Add(this.TeamNameValue);
            this.Controls.Add(this.LBLTeamName);
            this.Controls.Add(this.LBLHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTeamForm";
            this.Text = "Create Team";
            this.AddNewMemberGroupBox.ResumeLayout(false);
            this.AddNewMemberGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TeamNameValue;
        private System.Windows.Forms.Label LBLTeamName;
        private System.Windows.Forms.Label LBLHeader;
        private System.Windows.Forms.Button BTNAddTeamMember;
        private System.Windows.Forms.ComboBox SelectTeamMemberDropDown;
        private System.Windows.Forms.Label LBLSelectTeamMember;
        private System.Windows.Forms.GroupBox AddNewMemberGroupBox;
        private System.Windows.Forms.Button BTNCreateMember;
        private System.Windows.Forms.TextBox MobileValue;
        private System.Windows.Forms.Label LBLMobile;
        private System.Windows.Forms.TextBox EmailValue;
        private System.Windows.Forms.Label LBLEmail;
        private System.Windows.Forms.TextBox LastNameValue;
        private System.Windows.Forms.Label LBLLastName;
        private System.Windows.Forms.TextBox FirstNameValue;
        private System.Windows.Forms.Label LBLFirstName;
        private System.Windows.Forms.ListBox TeamMembersListBox;
        private System.Windows.Forms.Button BTNRemoveSelectedMember;
        private System.Windows.Forms.Button BTNCreateTeam;
    }
}