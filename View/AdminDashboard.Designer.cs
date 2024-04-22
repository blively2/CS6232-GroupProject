namespace SofaSoGood.View
{
    partial class AdminDashboard
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
            this.AdminDashboardTabControl = new System.Windows.Forms.TabControl();
            this.reportTabPage = new System.Windows.Forms.TabPage();
            this.reportUserControls1 = new SofaSoGood.AdminUserControls.ReportUserControls();
            this.welcomeAdminLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.AdminDashboardTabControl.SuspendLayout();
            this.reportTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // AdminDashboardTabControl
            // 
            this.AdminDashboardTabControl.Controls.Add(this.reportTabPage);
            this.AdminDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminDashboardTabControl.Location = new System.Drawing.Point(-2, 1);
            this.AdminDashboardTabControl.Name = "AdminDashboardTabControl";
            this.AdminDashboardTabControl.SelectedIndex = 0;
            this.AdminDashboardTabControl.Size = new System.Drawing.Size(984, 419);
            this.AdminDashboardTabControl.TabIndex = 1;
            this.AdminDashboardTabControl.TabStop = false;
            // 
            // reportTabPage
            // 
            this.reportTabPage.Controls.Add(this.reportUserControls1);
            this.reportTabPage.Location = new System.Drawing.Point(4, 38);
            this.reportTabPage.Name = "reportTabPage";
            this.reportTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.reportTabPage.Size = new System.Drawing.Size(976, 377);
            this.reportTabPage.TabIndex = 9;
            this.reportTabPage.Text = "Report";
            this.reportTabPage.UseVisualStyleBackColor = true;
            // 
            // reportUserControls1
            // 
            this.reportUserControls1.Location = new System.Drawing.Point(0, -17);
            this.reportUserControls1.Name = "reportUserControls1";
            this.reportUserControls1.Size = new System.Drawing.Size(970, 398);
            this.reportUserControls1.TabIndex = 0;
            // 
            // welcomeAdminLabel
            // 
            this.welcomeAdminLabel.AutoSize = true;
            this.welcomeAdminLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.welcomeAdminLabel.Location = new System.Drawing.Point(12, 423);
            this.welcomeAdminLabel.Name = "welcomeAdminLabel";
            this.welcomeAdminLabel.Size = new System.Drawing.Size(234, 36);
            this.welcomeAdminLabel.TabIndex = 2;
            this.welcomeAdminLabel.Text = "Welcome, admin";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogoutLinkLabel.Location = new System.Drawing.Point(851, 423);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(108, 36);
            this.LogoutLinkLabel.TabIndex = 3;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLinkLabel_LinkClicked);
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.welcomeAdminLabel);
            this.Controls.Add(this.AdminDashboardTabControl);
            this.Name = "AdminDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminDashboard";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminFormClose);
            this.AdminDashboardTabControl.ResumeLayout(false);
            this.reportTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl AdminDashboardTabControl;
        private System.Windows.Forms.TabPage reportTabPage;
        private AdminUserControls.ReportUserControls reportUserControls1;
        private System.Windows.Forms.Label welcomeAdminLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
    }
}