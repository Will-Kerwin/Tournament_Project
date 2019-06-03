namespace TrackerUI
{
    partial class CreateTournamentForm
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
            this.LBLHeader = new System.Windows.Forms.Label();
            this.TournamentNameValue = new System.Windows.Forms.TextBox();
            this.LBLTournamentName = new System.Windows.Forms.Label();
            this.EntryFeeValue = new System.Windows.Forms.TextBox();
            this.LBLEntryFee = new System.Windows.Forms.Label();
            this.SelectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.LBLSelectTeam = new System.Windows.Forms.Label();
            this.CreateNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.BTNAddTeam = new System.Windows.Forms.Button();
            this.BTNCreatePrize = new System.Windows.Forms.Button();
            this.tournamentPlayersListBox = new System.Windows.Forms.ListBox();
            this.LBLTournamentPlayers = new System.Windows.Forms.Label();
            this.BTNDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.BTNDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.LBLPrizes = new System.Windows.Forms.Label();
            this.PrizesListBox = new System.Windows.Forms.ListBox();
            this.BTNCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLHeader
            // 
            this.LBLHeader.AutoSize = true;
            this.LBLHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLHeader.Location = new System.Drawing.Point(36, 26);
            this.LBLHeader.Name = "LBLHeader";
            this.LBLHeader.Size = new System.Drawing.Size(317, 50);
            this.LBLHeader.TabIndex = 15;
            this.LBLHeader.Text = "Create Tournament";
            // 
            // TournamentNameValue
            // 
            this.TournamentNameValue.Location = new System.Drawing.Point(52, 137);
            this.TournamentNameValue.Name = "TournamentNameValue";
            this.TournamentNameValue.Size = new System.Drawing.Size(308, 35);
            this.TournamentNameValue.TabIndex = 24;
            // 
            // LBLTournamentName
            // 
            this.LBLTournamentName.AutoSize = true;
            this.LBLTournamentName.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLTournamentName.Location = new System.Drawing.Point(48, 97);
            this.LBLTournamentName.Name = "LBLTournamentName";
            this.LBLTournamentName.Size = new System.Drawing.Size(236, 37);
            this.LBLTournamentName.TabIndex = 23;
            this.LBLTournamentName.Text = "Tournament Name";
            // 
            // EntryFeeValue
            // 
            this.EntryFeeValue.Location = new System.Drawing.Point(184, 200);
            this.EntryFeeValue.Name = "EntryFeeValue";
            this.EntryFeeValue.Size = new System.Drawing.Size(100, 35);
            this.EntryFeeValue.TabIndex = 26;
            this.EntryFeeValue.Text = "0";
            // 
            // LBLEntryFee
            // 
            this.LBLEntryFee.AutoSize = true;
            this.LBLEntryFee.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLEntryFee.Location = new System.Drawing.Point(48, 197);
            this.LBLEntryFee.Name = "LBLEntryFee";
            this.LBLEntryFee.Size = new System.Drawing.Size(125, 37);
            this.LBLEntryFee.TabIndex = 25;
            this.LBLEntryFee.Text = "Entry Fee";
            // 
            // SelectTeamDropDown
            // 
            this.SelectTeamDropDown.FormattingEnabled = true;
            this.SelectTeamDropDown.Location = new System.Drawing.Point(52, 284);
            this.SelectTeamDropDown.Name = "SelectTeamDropDown";
            this.SelectTeamDropDown.Size = new System.Drawing.Size(308, 38);
            this.SelectTeamDropDown.TabIndex = 28;
            // 
            // LBLSelectTeam
            // 
            this.LBLSelectTeam.AutoSize = true;
            this.LBLSelectTeam.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLSelectTeam.Location = new System.Drawing.Point(48, 244);
            this.LBLSelectTeam.Name = "LBLSelectTeam";
            this.LBLSelectTeam.Size = new System.Drawing.Size(156, 37);
            this.LBLSelectTeam.TabIndex = 27;
            this.LBLSelectTeam.Text = "Select Team";
            // 
            // CreateNewTeamLink
            // 
            this.CreateNewTeamLink.AutoSize = true;
            this.CreateNewTeamLink.Location = new System.Drawing.Point(232, 250);
            this.CreateNewTeamLink.Name = "CreateNewTeamLink";
            this.CreateNewTeamLink.Size = new System.Drawing.Size(121, 30);
            this.CreateNewTeamLink.TabIndex = 29;
            this.CreateNewTeamLink.TabStop = true;
            this.CreateNewTeamLink.Text = "Create New";
            // 
            // BTNAddTeam
            // 
            this.BTNAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNAddTeam.Location = new System.Drawing.Point(108, 354);
            this.BTNAddTeam.Name = "BTNAddTeam";
            this.BTNAddTeam.Size = new System.Drawing.Size(176, 48);
            this.BTNAddTeam.TabIndex = 30;
            this.BTNAddTeam.Text = "Add Team";
            this.BTNAddTeam.UseVisualStyleBackColor = true;
            // 
            // BTNCreatePrize
            // 
            this.BTNCreatePrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNCreatePrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNCreatePrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNCreatePrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreatePrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreatePrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNCreatePrize.Location = new System.Drawing.Point(108, 432);
            this.BTNCreatePrize.Name = "BTNCreatePrize";
            this.BTNCreatePrize.Size = new System.Drawing.Size(176, 48);
            this.BTNCreatePrize.TabIndex = 31;
            this.BTNCreatePrize.Text = "Create Prize";
            this.BTNCreatePrize.UseVisualStyleBackColor = true;
            // 
            // tournamentPlayersListBox
            // 
            this.tournamentPlayersListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tournamentPlayersListBox.FormattingEnabled = true;
            this.tournamentPlayersListBox.ItemHeight = 30;
            this.tournamentPlayersListBox.Location = new System.Drawing.Point(468, 142);
            this.tournamentPlayersListBox.Name = "tournamentPlayersListBox";
            this.tournamentPlayersListBox.Size = new System.Drawing.Size(361, 152);
            this.tournamentPlayersListBox.TabIndex = 32;
            // 
            // LBLTournamentPlayers
            // 
            this.LBLTournamentPlayers.AutoSize = true;
            this.LBLTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLTournamentPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLTournamentPlayers.Location = new System.Drawing.Point(461, 97);
            this.LBLTournamentPlayers.Name = "LBLTournamentPlayers";
            this.LBLTournamentPlayers.Size = new System.Drawing.Size(198, 37);
            this.LBLTournamentPlayers.TabIndex = 33;
            this.LBLTournamentPlayers.Text = "Teams / Players";
            // 
            // BTNDeleteSelectedPlayer
            // 
            this.BTNDeleteSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNDeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNDeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNDeleteSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDeleteSelectedPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDeleteSelectedPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNDeleteSelectedPlayer.Location = new System.Drawing.Point(869, 177);
            this.BTNDeleteSelectedPlayer.Name = "BTNDeleteSelectedPlayer";
            this.BTNDeleteSelectedPlayer.Size = new System.Drawing.Size(128, 83);
            this.BTNDeleteSelectedPlayer.TabIndex = 34;
            this.BTNDeleteSelectedPlayer.Text = "Delete Selected";
            this.BTNDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // BTNDeleteSelectedPrize
            // 
            this.BTNDeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNDeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNDeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNDeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNDeleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNDeleteSelectedPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNDeleteSelectedPrize.Location = new System.Drawing.Point(869, 390);
            this.BTNDeleteSelectedPrize.Name = "BTNDeleteSelectedPrize";
            this.BTNDeleteSelectedPrize.Size = new System.Drawing.Size(128, 81);
            this.BTNDeleteSelectedPrize.TabIndex = 37;
            this.BTNDeleteSelectedPrize.Text = "Delete Selected";
            this.BTNDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // LBLPrizes
            // 
            this.LBLPrizes.AutoSize = true;
            this.LBLPrizes.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLPrizes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLPrizes.Location = new System.Drawing.Point(461, 312);
            this.LBLPrizes.Name = "LBLPrizes";
            this.LBLPrizes.Size = new System.Drawing.Size(198, 37);
            this.LBLPrizes.TabIndex = 36;
            this.LBLPrizes.Text = "Teams / Players";
            // 
            // PrizesListBox
            // 
            this.PrizesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PrizesListBox.FormattingEnabled = true;
            this.PrizesListBox.ItemHeight = 30;
            this.PrizesListBox.Location = new System.Drawing.Point(468, 354);
            this.PrizesListBox.Name = "PrizesListBox";
            this.PrizesListBox.Size = new System.Drawing.Size(361, 152);
            this.PrizesListBox.TabIndex = 35;
            // 
            // BTNCreateTournament
            // 
            this.BTNCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNCreateTournament.Location = new System.Drawing.Point(408, 531);
            this.BTNCreateTournament.Name = "BTNCreateTournament";
            this.BTNCreateTournament.Size = new System.Drawing.Size(241, 72);
            this.BTNCreateTournament.TabIndex = 38;
            this.BTNCreateTournament.Text = "Create Tournament";
            this.BTNCreateTournament.UseVisualStyleBackColor = true;
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1036, 625);
            this.Controls.Add(this.BTNCreateTournament);
            this.Controls.Add(this.BTNDeleteSelectedPrize);
            this.Controls.Add(this.LBLPrizes);
            this.Controls.Add(this.PrizesListBox);
            this.Controls.Add(this.BTNDeleteSelectedPlayer);
            this.Controls.Add(this.LBLTournamentPlayers);
            this.Controls.Add(this.tournamentPlayersListBox);
            this.Controls.Add(this.BTNCreatePrize);
            this.Controls.Add(this.BTNAddTeam);
            this.Controls.Add(this.CreateNewTeamLink);
            this.Controls.Add(this.SelectTeamDropDown);
            this.Controls.Add(this.LBLSelectTeam);
            this.Controls.Add(this.EntryFeeValue);
            this.Controls.Add(this.LBLEntryFee);
            this.Controls.Add(this.TournamentNameValue);
            this.Controls.Add(this.LBLTournamentName);
            this.Controls.Add(this.LBLHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.Load += new System.EventHandler(this.CreateTournamentForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHeader;
        private System.Windows.Forms.TextBox TournamentNameValue;
        private System.Windows.Forms.Label LBLTournamentName;
        private System.Windows.Forms.TextBox EntryFeeValue;
        private System.Windows.Forms.Label LBLEntryFee;
        private System.Windows.Forms.ComboBox SelectTeamDropDown;
        private System.Windows.Forms.Label LBLSelectTeam;
        private System.Windows.Forms.LinkLabel CreateNewTeamLink;
        private System.Windows.Forms.Button BTNAddTeam;
        private System.Windows.Forms.Button BTNCreatePrize;
        private System.Windows.Forms.ListBox tournamentPlayersListBox;
        private System.Windows.Forms.Label LBLTournamentPlayers;
        private System.Windows.Forms.Button BTNDeleteSelectedPlayer;
        private System.Windows.Forms.Button BTNDeleteSelectedPrize;
        private System.Windows.Forms.Label LBLPrizes;
        private System.Windows.Forms.ListBox PrizesListBox;
        private System.Windows.Forms.Button BTNCreateTournament;
    }
}