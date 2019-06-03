namespace TrackerUI
{
    partial class TournamentDashboardForm
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
            this.LoadExistingTournamentDropDown = new System.Windows.Forms.ComboBox();
            this.LBLLoadExistingTournament = new System.Windows.Forms.Label();
            this.BTNLoadTournament = new System.Windows.Forms.Button();
            this.BTNCreateTournament = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LBLHeader
            // 
            this.LBLHeader.AutoSize = true;
            this.LBLHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLHeader.Location = new System.Drawing.Point(137, 31);
            this.LBLHeader.Name = "LBLHeader";
            this.LBLHeader.Size = new System.Drawing.Size(385, 50);
            this.LBLHeader.TabIndex = 27;
            this.LBLHeader.Text = "Tournament Dashboard";
            // 
            // LoadExistingTournamentDropDown
            // 
            this.LoadExistingTournamentDropDown.FormattingEnabled = true;
            this.LoadExistingTournamentDropDown.Location = new System.Drawing.Point(155, 142);
            this.LoadExistingTournamentDropDown.Name = "LoadExistingTournamentDropDown";
            this.LoadExistingTournamentDropDown.Size = new System.Drawing.Size(349, 38);
            this.LoadExistingTournamentDropDown.TabIndex = 34;
            // 
            // LBLLoadExistingTournament
            // 
            this.LBLLoadExistingTournament.AutoSize = true;
            this.LBLLoadExistingTournament.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBLLoadExistingTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.LBLLoadExistingTournament.Location = new System.Drawing.Point(168, 102);
            this.LBLLoadExistingTournament.Name = "LBLLoadExistingTournament";
            this.LBLLoadExistingTournament.Size = new System.Drawing.Size(322, 37);
            this.LBLLoadExistingTournament.TabIndex = 33;
            this.LBLLoadExistingTournament.Text = "Load Existing Tournament";
            // 
            // BTNLoadTournament
            // 
            this.BTNLoadTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNLoadTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNLoadTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNLoadTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNLoadTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNLoadTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNLoadTournament.Location = new System.Drawing.Point(232, 197);
            this.BTNLoadTournament.Name = "BTNLoadTournament";
            this.BTNLoadTournament.Size = new System.Drawing.Size(194, 41);
            this.BTNLoadTournament.TabIndex = 35;
            this.BTNLoadTournament.Text = "Load Tournament";
            this.BTNLoadTournament.UseVisualStyleBackColor = true;
            // 
            // BTNCreateTournament
            // 
            this.BTNCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.BTNCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.BTNCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.BTNCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BTNCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.BTNCreateTournament.Location = new System.Drawing.Point(209, 274);
            this.BTNCreateTournament.Name = "BTNCreateTournament";
            this.BTNCreateTournament.Size = new System.Drawing.Size(241, 72);
            this.BTNCreateTournament.TabIndex = 41;
            this.BTNCreateTournament.Text = "Create Tournament";
            this.BTNCreateTournament.UseVisualStyleBackColor = true;
            // 
            // TournamentDashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(652, 396);
            this.Controls.Add(this.BTNCreateTournament);
            this.Controls.Add(this.BTNLoadTournament);
            this.Controls.Add(this.LoadExistingTournamentDropDown);
            this.Controls.Add(this.LBLLoadExistingTournament);
            this.Controls.Add(this.LBLHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentDashboardForm";
            this.Text = "Tournament Dashboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LBLHeader;
        private System.Windows.Forms.ComboBox LoadExistingTournamentDropDown;
        private System.Windows.Forms.Label LBLLoadExistingTournament;
        private System.Windows.Forms.Button BTNLoadTournament;
        private System.Windows.Forms.Button BTNCreateTournament;
    }
}