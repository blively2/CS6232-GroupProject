namespace SofaSoGood.View
{
    partial class MainDashboard
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
            this.MainDashboardTabControl = new System.Windows.Forms.TabControl();
            this.MainTabPage = new System.Windows.Forms.TabPage();
            this.RegisterCustomerTabPage = new System.Windows.Forms.TabPage();
            this.EditCustomerTabPage = new System.Windows.Forms.TabPage();
            this.SearchCustomerTabPage = new System.Windows.Forms.TabPage();
            this.WelcomeUserLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MainDashboardTabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.MainTabPage);
            this.MainDashboardTabControl.Controls.Add(this.RegisterCustomerTabPage);
            this.MainDashboardTabControl.Controls.Add(this.EditCustomerTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchCustomerTabPage);
            this.MainDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.MainDashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(784, 435);
            this.MainDashboardTabControl.TabIndex = 0;
            // 
            // MainTabPage
            // 
            this.MainTabPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MainTabPage.Location = new System.Drawing.Point(4, 33);
            this.MainTabPage.Name = "MainTabPage";
            this.MainTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.MainTabPage.Size = new System.Drawing.Size(776, 398);
            this.MainTabPage.TabIndex = 0;
            this.MainTabPage.Text = "Main";
            this.MainTabPage.UseVisualStyleBackColor = true;
            // 
            // RegisterCustomerTabPage
            // 
            this.RegisterCustomerTabPage.Location = new System.Drawing.Point(4, 33);
            this.RegisterCustomerTabPage.Name = "RegisterCustomerTabPage";
            this.RegisterCustomerTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RegisterCustomerTabPage.Size = new System.Drawing.Size(776, 398);
            this.RegisterCustomerTabPage.TabIndex = 1;
            this.RegisterCustomerTabPage.Text = "Registration";
            this.RegisterCustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // EditCustomerTabPage
            // 
            this.EditCustomerTabPage.Location = new System.Drawing.Point(4, 33);
            this.EditCustomerTabPage.Name = "EditCustomerTabPage";
            this.EditCustomerTabPage.Size = new System.Drawing.Size(776, 398);
            this.EditCustomerTabPage.TabIndex = 2;
            this.EditCustomerTabPage.Text = "Edit Customer";
            this.EditCustomerTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchCustomerTabPage
            // 
            this.SearchCustomerTabPage.Location = new System.Drawing.Point(4, 33);
            this.SearchCustomerTabPage.Name = "SearchCustomerTabPage";
            this.SearchCustomerTabPage.Size = new System.Drawing.Size(776, 398);
            this.SearchCustomerTabPage.TabIndex = 3;
            this.SearchCustomerTabPage.Text = "Search Customer";
            this.SearchCustomerTabPage.UseVisualStyleBackColor = true;
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
            this.LogoutLinkLabel.Location = new System.Drawing.Point(708, 434);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(72, 25);
            this.LogoutLinkLabel.TabIndex = 2;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabelClicked);
            // 
            // MainDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.LogoutLinkLabel);
            this.Controls.Add(this.WelcomeUserLabel);
            this.Controls.Add(this.MainDashboardTabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sofa So Good FMS";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainDashboardFormClose);
            this.MainDashboardTabControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl MainDashboardTabControl;
        private System.Windows.Forms.TabPage MainTabPage;
        private System.Windows.Forms.TabPage RegisterCustomerTabPage;
        private System.Windows.Forms.Label WelcomeUserLabel;
        private System.Windows.Forms.LinkLabel LogoutLinkLabel;
        private System.Windows.Forms.TabPage EditCustomerTabPage;
        private System.Windows.Forms.TabPage SearchCustomerTabPage;
    }
}