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
            this.reportUserControls1 = new SofaSoGood.AdminUserControls.ReportUserControls();
            this.SuspendLayout();
            // 
            // reportUserControls1
            // 
            this.reportUserControls1.Location = new System.Drawing.Point(3, 24);
            this.reportUserControls1.Name = "reportUserControls1";
            this.reportUserControls1.Size = new System.Drawing.Size(984, 399);
            this.reportUserControls1.TabIndex = 0;
            // 
            // AdminDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(984, 461);
            this.Controls.Add(this.reportUserControls1);
            this.Name = "AdminDashboard";
            this.Text = "AdminDashboard";
            this.ResumeLayout(false);

        }

        #endregion

        private AdminUserControls.ReportUserControls reportUserControls1;
    }
}