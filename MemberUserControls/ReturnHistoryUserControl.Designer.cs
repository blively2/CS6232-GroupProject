namespace SofaSoGood.UserControls
{
    partial class ReturnHistoryUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ReturnHistoryTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnHistoryTitleLabel
            // 
            this.ReturnHistoryTitleLabel.AutoSize = true;
            this.ReturnHistoryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ReturnHistoryTitleLabel.Location = new System.Drawing.Point(380, 10);
            this.ReturnHistoryTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReturnHistoryTitleLabel.Name = "ReturnHistoryTitleLabel";
            this.ReturnHistoryTitleLabel.Size = new System.Drawing.Size(164, 29);
            this.ReturnHistoryTitleLabel.TabIndex = 4;
            this.ReturnHistoryTitleLabel.Text = "Return History";
            // 
            // ReturnHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReturnHistoryTitleLabel);
            this.Name = "ReturnHistoryUserControl";
            this.Size = new System.Drawing.Size(966, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnHistoryTitleLabel;
    }
}
