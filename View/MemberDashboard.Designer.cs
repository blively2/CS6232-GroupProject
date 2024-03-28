namespace SofaSoGood.View
{
    partial class MemberDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemberDashboard));
            this.MainDashboardTabControl = new System.Windows.Forms.TabControl();
            this.RegisterMemberTabPage = new System.Windows.Forms.TabPage();
            this.EditMemberTabPage = new System.Windows.Forms.TabPage();
            this.SearchMemberTabPage = new System.Windows.Forms.TabPage();
            this.WelcomeUserLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MemberRegistrationUserControl = new SofaSoGood.RegisterMemberUserControl();
            this.EditMemberUserControl = new SofaSoGood.UserControls.EditMemberUserControl();
            this.SearchMemberUserControl = new SofaSoGood.UserControls.SearchMemberUserControl();
            this.MainDashboardTabControl.SuspendLayout();
            this.RegisterMemberTabPage.SuspendLayout();
            this.EditMemberTabPage.SuspendLayout();
            this.SearchMemberTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.RegisterMemberTabPage);
            this.MainDashboardTabControl.Controls.Add(this.EditMemberTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchMemberTabPage);
            this.MainDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(980, 435);
            this.MainDashboardTabControl.TabIndex = 0;
            // 
            // RegisterMemberTabPage
            // 
            this.RegisterMemberTabPage.Controls.Add(this.MemberRegistrationUserControl);
            this.RegisterMemberTabPage.Location = new System.Drawing.Point(4, 29);
            this.RegisterMemberTabPage.Name = "RegisterMemberTabPage";
            this.RegisterMemberTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterMemberTabPage.Size = new System.Drawing.Size(972, 402);
            this.RegisterMemberTabPage.TabIndex = 1;
            this.RegisterMemberTabPage.Text = "Register Member";
            this.RegisterMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // EditMemberTabPage
            // 
            this.EditMemberTabPage.Controls.Add(this.EditMemberUserControl);
            this.EditMemberTabPage.Location = new System.Drawing.Point(4, 29);
            this.EditMemberTabPage.Name = "EditMemberTabPage";
            this.EditMemberTabPage.Size = new System.Drawing.Size(972, 402);
            this.EditMemberTabPage.TabIndex = 2;
            this.EditMemberTabPage.Text = "Edit Member";
            this.EditMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchMemberTabPage
            // 
            this.SearchMemberTabPage.Controls.Add(this.SearchMemberUserControl);
            this.SearchMemberTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchMemberTabPage.Name = "SearchMemberTabPage";
            this.SearchMemberTabPage.Size = new System.Drawing.Size(972, 402);
            this.SearchMemberTabPage.TabIndex = 3;
            this.SearchMemberTabPage.Text = "Search Member";
            this.SearchMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // WelcomeUserLabel
            // 
            this.WelcomeUserLabel.AutoSize = true;
            this.WelcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WelcomeUserLabel.Location = new System.Drawing.Point(7, 434);
            this.WelcomeUserLabel.Name = "WelcomeUserLabel";
            this.WelcomeUserLabel.Size = new System.Drawing.Size(143, 25);
            this.WelcomeUserLabel.TabIndex = 1;
            this.WelcomeUserLabel.Text = "Welcome, user";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogoutLinkLabel.Location = new System.Drawing.Point(904, 434);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(72, 25);
            this.LogoutLinkLabel.TabIndex = 2;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabelClicked);
            // 
            // MemberRegistrationUserControl
            // 
            this.MemberRegistrationUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberRegistrationUserControl.Location = new System.Drawing.Point(3, 3);
            this.MemberRegistrationUserControl.Name = "MemberRegistrationUserControl";
            this.MemberRegistrationUserControl.Size = new System.Drawing.Size(966, 396);
            this.MemberRegistrationUserControl.TabIndex = 0;
            // 
            // EditMemberUserControl
            // 
            this.EditMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditMemberUserControl.Location = new System.Drawing.Point(0, 0);
            this.EditMemberUserControl.Name = "EditMemberUserControl";
            this.EditMemberUserControl.Size = new System.Drawing.Size(972, 402);
            this.EditMemberUserControl.TabIndex = 0;
            // 
            // SearchMemberUserControl
            // 
            this.SearchMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchMemberUserControl.Location = new System.Drawing.Point(0, 0);
            this.SearchMemberUserControl.Name = "SearchMemberUserControl";
            this.SearchMemberUserControl.Size = new System.Drawing.Size(972, 402);
            this.SearchMemberUserControl.TabIndex = 0;
            // 
            // MemberDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.WelcomeUserLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofa So Good FMS - Member Management";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboardFormClose);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.RegisterMemberTabPage.ResumeLayout(false);
            this.EditMemberTabPage.ResumeLayout(false);
            this.SearchMemberTabPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage RegisterMemberTabPage;
        private System.Windows.Forms.Label WelcomeUserLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.TabPage EditMemberTabPage;
        private System.Windows.Forms.TabPage SearchMemberTabPage;
        private RegisterMemberUserControl MemberRegistrationUserControl;
        private UserControls.EditMemberUserControl EditMemberUserControl;
        private UserControls.SearchMemberUserControl SearchMemberUserControl;
    }
}