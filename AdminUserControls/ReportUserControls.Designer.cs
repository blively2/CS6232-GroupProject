namespace SofaSoGood.AdminUserControls
{
    partial class ReportUserControls
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
            this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.rentedFromLabel = new System.Windows.Forms.Label();
            this.popularLabel = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.rentedToLabel = new System.Windows.Forms.Label();
            this.reportButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.furnitureListView = new System.Windows.Forms.ListView();
            this.FurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalNumberOfReantalTransations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalNumberOfAllFurnitureRentalTransations = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentageOfTransaction = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentageOfMemberAgeInRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PercentageOfMemberAgeOutRange = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // dateOfBirthDatePicker
            // 
            this.dateOfBirthDatePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateOfBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDatePicker.Location = new System.Drawing.Point(123, 84);
            this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            this.dateOfBirthDatePicker.Size = new System.Drawing.Size(154, 35);
            this.dateOfBirthDatePicker.TabIndex = 6;
            // 
            // rentedFromLabel
            // 
            this.rentedFromLabel.AutoSize = true;
            this.rentedFromLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedFromLabel.Location = new System.Drawing.Point(21, 90);
            this.rentedFromLabel.Name = "rentedFromLabel";
            this.rentedFromLabel.Size = new System.Drawing.Size(160, 29);
            this.rentedFromLabel.TabIndex = 7;
            this.rentedFromLabel.Text = "Rented From:";
            // 
            // popularLabel
            // 
            this.popularLabel.AutoSize = true;
            this.popularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.popularLabel.Location = new System.Drawing.Point(245, 18);
            this.popularLabel.Name = "popularLabel";
            this.popularLabel.Size = new System.Drawing.Size(423, 40);
            this.popularLabel.TabIndex = 5;
            this.popularLabel.Text = "Popular Furniture Report ";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(418, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(154, 35);
            this.dateTimePicker1.TabIndex = 8;
            // 
            // rentedToLabel
            // 
            this.rentedToLabel.AutoSize = true;
            this.rentedToLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rentedToLabel.Location = new System.Drawing.Point(316, 90);
            this.rentedToLabel.Name = "rentedToLabel";
            this.rentedToLabel.Size = new System.Drawing.Size(133, 29);
            this.rentedToLabel.TabIndex = 9;
            this.rentedToLabel.Text = "Rented To:";
            // 
            // reportButton
            // 
            this.reportButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.reportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.reportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportButton.Location = new System.Drawing.Point(596, 84);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(182, 35);
            this.reportButton.TabIndex = 11;
            this.reportButton.Text = "Report";
            this.reportButton.UseVisualStyleBackColor = false;
            // 
            // clearButton
            // 
            this.clearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearButton.Location = new System.Drawing.Point(794, 84);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(173, 35);
            this.clearButton.TabIndex = 12;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // furnitureListView
            // 
            this.furnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FurnitureID,
            this.FurnitureCategory,
            this.FurnitureName,
            this.FurnitureStyle,
            this.TotalNumberOfReantalTransations,
            this.TotalNumberOfAllFurnitureRentalTransations,
            this.PercentageOfTransaction,
            this.PercentageOfMemberAgeInRange,
            this.PercentageOfMemberAgeOutRange});
            this.furnitureListView.FullRowSelect = true;
            this.furnitureListView.HideSelection = false;
            this.furnitureListView.Location = new System.Drawing.Point(0, 156);
            this.furnitureListView.Name = "furnitureListView";
            this.furnitureListView.Size = new System.Drawing.Size(970, 239);
            this.furnitureListView.TabIndex = 49;
            this.furnitureListView.UseCompatibleStateImageBehavior = false;
            this.furnitureListView.View = System.Windows.Forms.View.Details;
            // 
            // FurnitureID
            // 
            this.FurnitureID.Text = "Furniture ID";
            this.FurnitureID.Width = 90;
            // 
            // FurnitureName
            // 
            this.FurnitureName.DisplayIndex = 1;
            this.FurnitureName.Text = "Furniture Name";
            this.FurnitureName.Width = 90;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.DisplayIndex = 2;
            this.FurnitureCategory.Text = "Furniture Category";
            this.FurnitureCategory.Width = 120;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.Text = "Furniture Style";
            this.FurnitureStyle.Width = 90;
            // 
            // TotalNumberOfReantalTransations
            // 
            this.TotalNumberOfReantalTransations.Text = "Total Number of Reantal Transations";
            this.TotalNumberOfReantalTransations.Width = 120;
            // 
            // TotalNumberOfAllFurnitureRentalTransations
            // 
            this.TotalNumberOfAllFurnitureRentalTransations.Text = "Total Number of all Furniture Rental Transations";
            this.TotalNumberOfAllFurnitureRentalTransations.Width = 90;
            // 
            // PercentageOfTransaction
            // 
            this.PercentageOfTransaction.Text = "Percentage of Transaction";
            this.PercentageOfTransaction.Width = 90;
            // 
            // PercentageOfMemberAgeInRange
            // 
            this.PercentageOfMemberAgeInRange.Text = "Percentage of Member\'s Age (18-29)";
            this.PercentageOfMemberAgeInRange.Width = 90;
            // 
            // PercentageOfMemberAgeOutRange
            // 
            this.PercentageOfMemberAgeOutRange.Text = "Percentage of Member\'s Age (29+)";
            // 
            // ReportUserControls
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.furnitureListView);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.rentedToLabel);
            this.Controls.Add(this.dateOfBirthDatePicker);
            this.Controls.Add(this.rentedFromLabel);
            this.Controls.Add(this.popularLabel);
            this.Name = "ReportUserControls";
            this.Size = new System.Drawing.Size(970, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
        private System.Windows.Forms.Label rentedFromLabel;
        private System.Windows.Forms.Label popularLabel;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label rentedToLabel;
        private System.Windows.Forms.Button reportButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.ListView furnitureListView;
        private System.Windows.Forms.ColumnHeader FurnitureID;
        private System.Windows.Forms.ColumnHeader FurnitureName;
        private System.Windows.Forms.ColumnHeader FurnitureCategory;
        private System.Windows.Forms.ColumnHeader FurnitureStyle;
        private System.Windows.Forms.ColumnHeader TotalNumberOfReantalTransations;
        private System.Windows.Forms.ColumnHeader TotalNumberOfAllFurnitureRentalTransations;
        private System.Windows.Forms.ColumnHeader PercentageOfTransaction;
        private System.Windows.Forms.ColumnHeader PercentageOfMemberAgeInRange;
        private System.Windows.Forms.ColumnHeader PercentageOfMemberAgeOutRange;
    }
}
