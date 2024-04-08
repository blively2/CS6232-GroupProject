using System.Windows.Forms;

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
            this.MemberRegistrationUserControl = new SofaSoGood.RegisterMemberUserControl();
            this.EditMemberTabPage = new System.Windows.Forms.TabPage();
            this.EditMemberUserControl = new SofaSoGood.UserControls.EditMemberUserControl();
            this.SearchMemberTabPage = new System.Windows.Forms.TabPage();
            this.SearchMemberUserControl = new SofaSoGood.UserControls.SearchMemberUserControl();
            this.SearchFurnitureTabPage = new System.Windows.Forms.TabPage();
            this.SearchFurnitureUserControl = new SofaSoGood.UserControls.SearchFurnitureUserControl();
            this.RentFurnitureTabPage = new System.Windows.Forms.TabPage();
            this.RentFurnitureUserControl = new SofaSoGood.UserControls.RentFurnitureUserControl();
            this.rentalHistoryTabPage = new System.Windows.Forms.TabPage();
            this.rentalHistoryUserControl = new SofaSoGood.UserControls.RentalHistoryUserControl();
            this.WelcomeUserLabel = new System.Windows.Forms.Label();
            this.LogoutLinkLabel = new System.Windows.Forms.LinkLabel();
            this.MemberSelectedLabel = new System.Windows.Forms.Label();
            this.ItemsAmountLabel = new System.Windows.Forms.Label();
            this.MainDashboardTabControl.SuspendLayout();
            this.RegisterMemberTabPage.SuspendLayout();
            this.EditMemberTabPage.SuspendLayout();
            this.SearchMemberTabPage.SuspendLayout();
            this.SearchFurnitureTabPage.SuspendLayout();
            this.RentFurnitureTabPage.SuspendLayout();
            this.rentalHistoryTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainDashboardTabControl
            // 
            this.MainDashboardTabControl.Controls.Add(this.RegisterMemberTabPage);
            this.MainDashboardTabControl.Controls.Add(this.EditMemberTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchMemberTabPage);
            this.MainDashboardTabControl.Controls.Add(this.SearchFurnitureTabPage);
            this.MainDashboardTabControl.Controls.Add(this.RentFurnitureTabPage);
            this.MainDashboardTabControl.Controls.Add(this.rentalHistoryTabPage);
            this.MainDashboardTabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainDashboardTabControl.Location = new System.Drawing.Point(0, 0);
            this.MainDashboardTabControl.Name = "MainDashboardTabControl";
            this.MainDashboardTabControl.SelectedIndex = 0;
            this.MainDashboardTabControl.Size = new System.Drawing.Size(980, 435);
            this.MainDashboardTabControl.TabIndex = 0;
            this.MainDashboardTabControl.TabStop = false;
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
            // MemberRegistrationUserControl
            // 
            this.MemberRegistrationUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MemberRegistrationUserControl.Location = new System.Drawing.Point(3, 3);
            this.MemberRegistrationUserControl.Name = "MemberRegistrationUserControl";
            this.MemberRegistrationUserControl.Size = new System.Drawing.Size(966, 396);
            this.MemberRegistrationUserControl.TabIndex = 0;
            // 
            // EditMemberTabPage
            // 
            this.EditMemberTabPage.Controls.Add(this.EditMemberUserControl);
            this.EditMemberTabPage.Location = new System.Drawing.Point(4, 29);
            this.EditMemberTabPage.Name = "EditMemberTabPage";
            this.EditMemberTabPage.Size = new System.Drawing.Size(192, 67);
            this.EditMemberTabPage.TabIndex = 2;
            this.EditMemberTabPage.Text = "Edit Member";
            this.EditMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // EditMemberUserControl
            // 
            this.EditMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditMemberUserControl.Location = new System.Drawing.Point(0, 0);
            this.EditMemberUserControl.Name = "EditMemberUserControl";
            this.EditMemberUserControl.Size = new System.Drawing.Size(192, 67);
            this.EditMemberUserControl.TabIndex = 0;
            // 
            // SearchMemberTabPage
            // 
            this.SearchMemberTabPage.Controls.Add(this.SearchMemberUserControl);
            this.SearchMemberTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchMemberTabPage.Name = "SearchMemberTabPage";
            this.SearchMemberTabPage.Size = new System.Drawing.Size(192, 67);
            this.SearchMemberTabPage.TabIndex = 3;
            this.SearchMemberTabPage.Text = "Search Member";
            this.SearchMemberTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchMemberUserControl
            // 
            this.SearchMemberUserControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchMemberUserControl.Location = new System.Drawing.Point(0, 0);
            this.SearchMemberUserControl.Name = "SearchMemberUserControl";
            this.SearchMemberUserControl.Size = new System.Drawing.Size(192, 67);
            this.SearchMemberUserControl.TabIndex = 0;
            // 
            // SearchFurnitureTabPage
            // 
            this.SearchFurnitureTabPage.Controls.Add(this.SearchFurnitureUserControl);
            this.SearchFurnitureTabPage.Location = new System.Drawing.Point(4, 29);
            this.SearchFurnitureTabPage.Name = "SearchFurnitureTabPage";
            this.SearchFurnitureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.SearchFurnitureTabPage.Size = new System.Drawing.Size(192, 67);
            this.SearchFurnitureTabPage.TabIndex = 4;
            this.SearchFurnitureTabPage.Text = "Search Furniture";
            this.SearchFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // SearchFurnitureUserControl
            // 
            this.SearchFurnitureUserControl.Location = new System.Drawing.Point(0, 3);
            this.SearchFurnitureUserControl.Name = "SearchFurnitureUserControl";
            this.SearchFurnitureUserControl.Size = new System.Drawing.Size(972, 394);
            this.SearchFurnitureUserControl.TabIndex = 0;
            // 
            // RentFurnitureTabPage
            // 
            this.RentFurnitureTabPage.Controls.Add(this.RentFurnitureUserControl);
            this.RentFurnitureTabPage.Location = new System.Drawing.Point(4, 29);
            this.RentFurnitureTabPage.Name = "RentFurnitureTabPage";
            this.RentFurnitureTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.RentFurnitureTabPage.Size = new System.Drawing.Size(192, 67);
            this.RentFurnitureTabPage.TabIndex = 5;
            this.RentFurnitureTabPage.Text = "Rent Furniture";
            this.RentFurnitureTabPage.UseVisualStyleBackColor = true;
            // 
            // RentFurnitureUserControl
            // 
            this.RentFurnitureUserControl.Location = new System.Drawing.Point(0, 0);
            this.RentFurnitureUserControl.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.RentFurnitureUserControl.Name = "RentFurnitureUserControl";
            this.RentFurnitureUserControl.Size = new System.Drawing.Size(970, 398);
            this.RentFurnitureUserControl.TabIndex = 0;
            // 
            // rentalHistoryTabPage
            // 
            this.rentalHistoryTabPage.Controls.Add(this.rentalHistoryUserControl);
            this.rentalHistoryTabPage.Location = new System.Drawing.Point(4, 29);
            this.rentalHistoryTabPage.Name = "rentalHistoryTabPage";
            this.rentalHistoryTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.rentalHistoryTabPage.Size = new System.Drawing.Size(972, 402);
            this.rentalHistoryTabPage.TabIndex = 6;
            this.rentalHistoryTabPage.Text = "Rental History";
            this.rentalHistoryTabPage.UseVisualStyleBackColor = true;
            // 
            // rentalHistoryUserControl
            // 
            this.rentalHistoryUserControl.Location = new System.Drawing.Point(0, 3);
            this.rentalHistoryUserControl.Name = "rentalHistoryUserControl";
            this.rentalHistoryUserControl.Size = new System.Drawing.Size(969, 399);
            this.rentalHistoryUserControl.TabIndex = 0;
            // 
            // WelcomeUserLabel
            // 
            this.WelcomeUserLabel.AutoSize = true;
            this.WelcomeUserLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.WelcomeUserLabel.Location = new System.Drawing.Point(7, 434);
            this.WelcomeUserLabel.Name = "WelcomeUserLabel";
            this.WelcomeUserLabel.Size = new System.Drawing.Size(143, 25);
            this.WelcomeUserLabel.TabIndex = 0;
            this.WelcomeUserLabel.Text = "Welcome, user";
            // 
            // LogoutLinkLabel
            // 
            this.LogoutLinkLabel.AutoSize = true;
            this.LogoutLinkLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LogoutLinkLabel.Location = new System.Drawing.Point(904, 434);
            this.LogoutLinkLabel.Name = "LogoutLinkLabel";
            this.LogoutLinkLabel.Size = new System.Drawing.Size(72, 25);
            this.LogoutLinkLabel.TabIndex = 0;
            this.LogoutLinkLabel.TabStop = true;
            this.LogoutLinkLabel.Text = "Logout";
            this.LogoutLinkLabel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LogoutLabelClicked);
            // 
            // MemberSelectedLabel
            // 
            this.MemberSelectedLabel.AutoSize = true;
            this.MemberSelectedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.MemberSelectedLabel.Location = new System.Drawing.Point(400, 438);
            this.MemberSelectedLabel.Name = "MemberSelectedLabel";
            this.MemberSelectedLabel.Size = new System.Drawing.Size(180, 20);
            this.MemberSelectedLabel.TabIndex = 1;
            this.MemberSelectedLabel.Text = "Member Selected: None";
            // 
            // ItemsAmountLabel
            // 
            this.ItemsAmountLabel.AutoSize = true;
            this.ItemsAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ItemsAmountLabel.Location = new System.Drawing.Point(747, 438);
            this.ItemsAmountLabel.Name = "ItemsAmountLabel";
            this.ItemsAmountLabel.Size = new System.Drawing.Size(95, 20);
            this.ItemsAmountLabel.TabIndex = 2;
            this.ItemsAmountLabel.Text = "Items: None";
            // 
            // MemberDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.ItemsAmountLabel);
            this.Controls.Add(this.MemberSelectedLabel);
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
            this.SearchFurnitureTabPage.ResumeLayout(false);
            this.RentFurnitureTabPage.ResumeLayout(false);
            this.rentalHistoryTabPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabPage SearchFurnitureTabPage;
        private UserControls.SearchFurnitureUserControl SearchFurnitureUserControl;
        private System.Windows.Forms.TabPage RentFurnitureTabPage;
        private UserControls.RentFurnitureUserControl RentFurnitureUserControl;
        private System.Windows.Forms.Label MemberSelectedLabel;
        private System.Windows.Forms.Label ItemsAmountLabel;
        private TabPage rentalHistoryTabPage;
        private UserControls.RentalHistoryUserControl rentalHistoryUserControl;
    }
}