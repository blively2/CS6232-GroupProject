namespace SofaSoGood.UserControls
{
    partial class ReturnFurnitureUserControl
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
            this.ReturnFurnitureTitleLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ReturnFurnitureTitleLabel
            // 
            this.ReturnFurnitureTitleLabel.AutoSize = true;
            this.ReturnFurnitureTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ReturnFurnitureTitleLabel.Location = new System.Drawing.Point(376, 11);
            this.ReturnFurnitureTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ReturnFurnitureTitleLabel.Name = "ReturnFurnitureTitleLabel";
            this.ReturnFurnitureTitleLabel.Size = new System.Drawing.Size(186, 29);
            this.ReturnFurnitureTitleLabel.TabIndex = 4;
            this.ReturnFurnitureTitleLabel.Text = "Return Furniture";
            // 
            // ReturnFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReturnFurnitureTitleLabel);
            this.Name = "ReturnFurnitureUserControl";
            this.Size = new System.Drawing.Size(966, 426);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnFurnitureTitleLabel;
    }
}
