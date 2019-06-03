namespace TrackerUI
{
    partial class TournamentViewerForm
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
            this.BTNScore = new System.Windows.Forms.Button();
            this.LBLVersus = new System.Windows.Forms.Label();
            this.TeamTwoScoreValue = new System.Windows.Forms.TextBox();
            this.LBLTeamTwoScore = new System.Windows.Forms.Label();
            this.TeamTwoName = new System.Windows.Forms.Label();
            this.TeamOneScoreValue = new System.Windows.Forms.TextBox();
            this.LBLTeamOneScore = new System.Windows.Forms.Label();
            this.TeamOneName = new System.Windows.Forms.Label();
            this.matchupListBox = new System.Windows.Forms.ListBox();
            this.UnplayedOnlyCheckedbox = new System.Windows.Forms.CheckBox();
            this.RoundDropDown = new System.Windows.Forms.ComboBox();
            this.LBLRound = new System.Windows.Forms.Label();
            this.LBLTournamentName = new System.Windows.Forms.Label();
            this.LBLHeader = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BTNScore
            // 
            this.BTNScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNScore.Location = new System.Drawing.Point(728, 325);
            this.BTNScore.Name = "BTNScore";
            this.BTNScore.Size = new System.Drawing.Size(128, 62);
            this.BTNScore.TabIndex = 27;
            this.BTNScore.Text = "Score";
            this.BTNScore.UseVisualStyleBackColor = true;
            // 
            // LBLVersus
            // 
            this.LBLVersus.AutoSize = true;
            this.LBLVersus.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLVersus.Location = new System.Drawing.Point(531, 325);
            this.LBLVersus.Name = "LBLVersus";
            this.LBLVersus.Size = new System.Drawing.Size(70, 37);
            this.LBLVersus.TabIndex = 26;
            this.LBLVersus.Text = "-VS-";
            // 
            // TeamTwoScoreValue
            // 
            this.TeamTwoScoreValue.Location = new System.Drawing.Point(538, 445);
            this.TeamTwoScoreValue.Name = "TeamTwoScoreValue";
            this.TeamTwoScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamTwoScoreValue.TabIndex = 25;
            // 
            // LBLTeamTwoScore
            // 
            this.LBLTeamTwoScore.AutoSize = true;
            this.LBLTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLTeamTwoScore.Location = new System.Drawing.Point(449, 445);
            this.LBLTeamTwoScore.Name = "LBLTeamTwoScore";
            this.LBLTeamTwoScore.Size = new System.Drawing.Size(82, 37);
            this.LBLTeamTwoScore.TabIndex = 24;
            this.LBLTeamTwoScore.Text = "Score";
            // 
            // TeamTwoName
            // 
            this.TeamTwoName.AutoSize = true;
            this.TeamTwoName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamTwoName.Location = new System.Drawing.Point(449, 398);
            this.TeamTwoName.Name = "TeamTwoName";
            this.TeamTwoName.Size = new System.Drawing.Size(171, 37);
            this.TeamTwoName.TabIndex = 23;
            this.TeamTwoName.Text = "<Team Two>";
            // 
            // TeamOneScoreValue
            // 
            this.TeamOneScoreValue.Location = new System.Drawing.Point(538, 255);
            this.TeamOneScoreValue.Name = "TeamOneScoreValue";
            this.TeamOneScoreValue.Size = new System.Drawing.Size(100, 35);
            this.TeamOneScoreValue.TabIndex = 22;
            // 
            // LBLTeamOneScore
            // 
            this.LBLTeamOneScore.AutoSize = true;
            this.LBLTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLTeamOneScore.Location = new System.Drawing.Point(449, 255);
            this.LBLTeamOneScore.Name = "LBLTeamOneScore";
            this.LBLTeamOneScore.Size = new System.Drawing.Size(82, 37);
            this.LBLTeamOneScore.TabIndex = 21;
            this.LBLTeamOneScore.Text = "Score";
            // 
            // TeamOneName
            // 
            this.TeamOneName.AutoSize = true;
            this.TeamOneName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TeamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.TeamOneName.Location = new System.Drawing.Point(449, 208);
            this.TeamOneName.Name = "TeamOneName";
            this.TeamOneName.Size = new System.Drawing.Size(165, 37);
            this.TeamOneName.TabIndex = 20;
            this.TeamOneName.Text = "<team one>";
            // 
            // matchupListBox
            // 
            this.matchupListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.matchupListBox.FormattingEnabled = true;
            this.matchupListBox.ItemHeight = 30;
            this.matchupListBox.Location = new System.Drawing.Point(21, 208);
            this.matchupListBox.Name = "matchupListBox";
            this.matchupListBox.Size = new System.Drawing.Size(361, 272);
            this.matchupListBox.TabIndex = 19;
            // 
            // UnplayedOnlyCheckedbox
            // 
            this.UnplayedOnlyCheckedbox.AutoSize = true;
            this.UnplayedOnlyCheckedbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UnplayedOnlyCheckedbox.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UnplayedOnlyCheckedbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.UnplayedOnlyCheckedbox.Location = new System.Drawing.Point(129, 141);
            this.UnplayedOnlyCheckedbox.Name = "UnplayedOnlyCheckedbox";
            this.UnplayedOnlyCheckedbox.Size = new System.Drawing.Size(209, 41);
            this.UnplayedOnlyCheckedbox.TabIndex = 18;
            this.UnplayedOnlyCheckedbox.Text = "Unplayed Only";
            this.UnplayedOnlyCheckedbox.UseVisualStyleBackColor = true;
            // 
            // RoundDropDown
            // 
            this.RoundDropDown.FormattingEnabled = true;
            this.RoundDropDown.Location = new System.Drawing.Point(129, 74);
            this.RoundDropDown.Name = "RoundDropDown";
            this.RoundDropDown.Size = new System.Drawing.Size(253, 38);
            this.RoundDropDown.TabIndex = 17;
            // 
            // LBLRound
            // 
            this.LBLRound.AutoSize = true;
            this.LBLRound.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLRound.Location = new System.Drawing.Point(14, 75);
            this.LBLRound.Name = "LBLRound";
            this.LBLRound.Size = new System.Drawing.Size(94, 37);
            this.LBLRound.TabIndex = 16;
            this.LBLRound.Text = "Round";
            // 
            // LBLTournamentName
            // 
            this.LBLTournamentName.AutoSize = true;
            this.LBLTournamentName.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLTournamentName.Location = new System.Drawing.Point(232, 9);
            this.LBLTournamentName.Name = "LBLTournamentName";
            this.LBLTournamentName.Size = new System.Drawing.Size(150, 50);
            this.LBLTournamentName.TabIndex = 15;
            this.LBLTournamentName.Text = "<none>";
            // 
            // LBLHeader
            // 
            this.LBLHeader.AutoSize = true;
            this.LBLHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLHeader.Location = new System.Drawing.Point(12, 9);
            this.LBLHeader.Name = "LBLHeader";
            this.LBLHeader.Size = new System.Drawing.Size(214, 50);
            this.LBLHeader.TabIndex = 14;
            this.LBLHeader.Text = "Tournament:";
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 582);
            this.Controls.Add(this.BTNScore);
            this.Controls.Add(this.LBLVersus);
            this.Controls.Add(this.TeamTwoScoreValue);
            this.Controls.Add(this.LBLTeamTwoScore);
            this.Controls.Add(this.TeamTwoName);
            this.Controls.Add(this.TeamOneScoreValue);
            this.Controls.Add(this.LBLTeamOneScore);
            this.Controls.Add(this.TeamOneName);
            this.Controls.Add(this.matchupListBox);
            this.Controls.Add(this.UnplayedOnlyCheckedbox);
            this.Controls.Add(this.RoundDropDown);
            this.Controls.Add(this.LBLRound);
            this.Controls.Add(this.LBLTournamentName);
            this.Controls.Add(this.LBLHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNScore;
        private System.Windows.Forms.Label LBLVersus;
        private System.Windows.Forms.TextBox TeamTwoScoreValue;
        private System.Windows.Forms.Label LBLTeamTwoScore;
        private System.Windows.Forms.Label TeamTwoName;
        private System.Windows.Forms.TextBox TeamOneScoreValue;
        private System.Windows.Forms.Label LBLTeamOneScore;
        private System.Windows.Forms.Label TeamOneName;
        private System.Windows.Forms.ListBox matchupListBox;
        private System.Windows.Forms.CheckBox UnplayedOnlyCheckedbox;
        private System.Windows.Forms.ComboBox RoundDropDown;
        private System.Windows.Forms.Label LBLRound;
        private System.Windows.Forms.Label LBLTournamentName;
        private System.Windows.Forms.Label LBLHeader;
    }
}