namespace SofaSoGood.UserControls
{
    partial class BuildReturnUserControl
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
            this.BuildReturnTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BuildReturnTitleLabel
            // 
            this.BuildReturnTitleLabel.AutoSize = true;
            this.BuildReturnTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BuildReturnTitleLabel.Location = new System.Drawing.Point(346, 10);
            this.BuildReturnTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BuildReturnTitleLabel.Name = "BuildReturnTitleLabel";
            this.BuildReturnTitleLabel.Size = new System.Drawing.Size(257, 29);
            this.BuildReturnTitleLabel.TabIndex = 3;
            this.BuildReturnTitleLabel.Text = "Currently Rented Items";
            // 
            // BuildReturnUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BuildReturnTitleLabel);
            this.Name = "BuildReturnUserControl";
            this.Size = new System.Drawing.Size(966, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuildReturnTitleLabel;
    }
}
