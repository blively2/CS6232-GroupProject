namespace SofaSoGood.UserControls
{
    partial class SearchFurniture
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.furnitureIDTextBox = new System.Windows.Forms.TextBox();
            this.searchByFurnitureIDButton = new System.Windows.Forms.Button();
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.searchByCategoryButton = new System.Windows.Forms.Button();
            this.furnitureCategoryLabel = new System.Windows.Forms.Label();
            this.styleButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.FurnitureIDWarningLabel = new System.Windows.Forms.Label();
            this.catogeryWarningLabel = new System.Windows.Forms.Label();
            this.styleWarningLabel = new System.Windows.Forms.Label();
            this.categoryComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.memberListView = new System.Windows.Forms.ListView();
            this.FurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentalRatePerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleLabel.Location = new System.Drawing.Point(356, 19);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(285, 40);
            this.TitleLabel.TabIndex = 1;
            this.TitleLabel.Text = "Search Furniture";
            // 
            // furnitureIDTextBox
            // 
            this.furnitureIDTextBox.Location = new System.Drawing.Point(278, 76);
            this.furnitureIDTextBox.Name = "furnitureIDTextBox";
            this.furnitureIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.furnitureIDTextBox.TabIndex = 21;
            // 
            // searchByFurnitureIDButton
            // 
            this.searchByFurnitureIDButton.Location = new System.Drawing.Point(455, 76);
            this.searchByFurnitureIDButton.Name = "searchByFurnitureIDButton";
            this.searchByFurnitureIDButton.Size = new System.Drawing.Size(200, 30);
            this.searchByFurnitureIDButton.TabIndex = 22;
            this.searchByFurnitureIDButton.Text = "By Furniture ID";
            this.searchByFurnitureIDButton.UseVisualStyleBackColor = true;
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Location = new System.Drawing.Point(124, 83);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(65, 13);
            this.furnitureIDLabel.TabIndex = 23;
            this.furnitureIDLabel.Text = "Furniture ID:";
            // 
            // searchByCategoryButton
            // 
            this.searchByCategoryButton.Location = new System.Drawing.Point(455, 118);
            this.searchByCategoryButton.Name = "searchByCategoryButton";
            this.searchByCategoryButton.Size = new System.Drawing.Size(200, 30);
            this.searchByCategoryButton.TabIndex = 25;
            this.searchByCategoryButton.Text = "By Furniture Category";
            this.searchByCategoryButton.UseVisualStyleBackColor = true;
            // 
            // furnitureCategoryLabel
            // 
            this.furnitureCategoryLabel.AutoSize = true;
            this.furnitureCategoryLabel.Location = new System.Drawing.Point(124, 118);
            this.furnitureCategoryLabel.Name = "furnitureCategoryLabel";
            this.furnitureCategoryLabel.Size = new System.Drawing.Size(96, 13);
            this.furnitureCategoryLabel.TabIndex = 26;
            this.furnitureCategoryLabel.Text = "Furniture Category:";
            // 
            // styleButton
            // 
            this.styleButton.Location = new System.Drawing.Point(455, 158);
            this.styleButton.Name = "styleButton";
            this.styleButton.Size = new System.Drawing.Size(200, 30);
            this.styleButton.TabIndex = 28;
            this.styleButton.Text = "By Furniture Style";
            this.styleButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 29;
            this.label1.Text = "Furniture Style:";
            // 
            // FurnitureIDWarningLabel
            // 
            this.FurnitureIDWarningLabel.AutoSize = true;
            this.FurnitureIDWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.FurnitureIDWarningLabel.Location = new System.Drawing.Point(708, 83);
            this.FurnitureIDWarningLabel.Name = "FurnitureIDWarningLabel";
            this.FurnitureIDWarningLabel.Size = new System.Drawing.Size(93, 13);
            this.FurnitureIDWarningLabel.TabIndex = 30;
            this.FurnitureIDWarningLabel.Text = "Invalid FurnitureID";
            // 
            // catogeryWarningLabel
            // 
            this.catogeryWarningLabel.AutoSize = true;
            this.catogeryWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.catogeryWarningLabel.Location = new System.Drawing.Point(708, 121);
            this.catogeryWarningLabel.Name = "catogeryWarningLabel";
            this.catogeryWarningLabel.Size = new System.Drawing.Size(124, 13);
            this.catogeryWarningLabel.TabIndex = 31;
            this.catogeryWarningLabel.Text = "Invalid FurnitureCategory";
            // 
            // styleWarningLabel
            // 
            this.styleWarningLabel.AutoSize = true;
            this.styleWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.styleWarningLabel.Location = new System.Drawing.Point(708, 158);
            this.styleWarningLabel.Name = "styleWarningLabel";
            this.styleWarningLabel.Size = new System.Drawing.Size(64, 13);
            this.styleWarningLabel.TabIndex = 32;
            this.styleWarningLabel.Text = "Invalid Style";
            // 
            // categoryComboBox
            // 
            this.categoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.categoryComboBox.FormattingEnabled = true;
            this.categoryComboBox.Location = new System.Drawing.Point(278, 118);
            this.categoryComboBox.Name = "categoryComboBox";
            this.categoryComboBox.Size = new System.Drawing.Size(171, 21);
            this.categoryComboBox.TabIndex = 46;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(278, 158);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(171, 21);
            this.styleComboBox.TabIndex = 47;
            // 
            // memberListView
            // 
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FurnitureID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.RentalRatePerDay,
            this.InStockQuantity,
            this.TotalQuantity});
            this.memberListView.HideSelection = false;
            this.memberListView.Location = new System.Drawing.Point(0, 285);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(970, 110);
            this.memberListView.TabIndex = 48;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
            // 
            // FurnitureID
            // 
            this.FurnitureID.Text = "Furniture ID";
            this.FurnitureID.Width = 90;
            // 
            // FurnitureName
            // 
            this.FurnitureName.Text = "Furniture Name";
            this.FurnitureName.Width = 90;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.Text = "Furniture Category";
            this.FurnitureCategory.Width = 120;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.Text = "Furniture Style";
            this.FurnitureStyle.Width = 90;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 120;
            // 
            // RentalRatePerDay
            // 
            this.RentalRatePerDay.Text = "Rental Rate Per Day";
            this.RentalRatePerDay.Width = 90;
            // 
            // InStockQuantity
            // 
            this.InStockQuantity.Text = "In Stock Quantity";
            this.InStockQuantity.Width = 90;
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.Text = "Total Quantity";
            this.TotalQuantity.Width = 90;
            // 
            // SearchFurniture
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.memberListView);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.categoryComboBox);
            this.Controls.Add(this.styleWarningLabel);
            this.Controls.Add(this.catogeryWarningLabel);
            this.Controls.Add(this.FurnitureIDWarningLabel);
            this.Controls.Add(this.styleButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchByCategoryButton);
            this.Controls.Add(this.furnitureCategoryLabel);
            this.Controls.Add(this.furnitureIDTextBox);
            this.Controls.Add(this.searchByFurnitureIDButton);
            this.Controls.Add(this.furnitureIDLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SearchFurniture";
            this.Size = new System.Drawing.Size(970, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox furnitureIDTextBox;
        private System.Windows.Forms.Button searchByFurnitureIDButton;
        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.Button searchByCategoryButton;
        private System.Windows.Forms.Label furnitureCategoryLabel;
        private System.Windows.Forms.Button styleButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label FurnitureIDWarningLabel;
        private System.Windows.Forms.Label catogeryWarningLabel;
        private System.Windows.Forms.Label styleWarningLabel;
        private System.Windows.Forms.ComboBox categoryComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.ListView memberListView;
        private System.Windows.Forms.ColumnHeader FurnitureID;
        private System.Windows.Forms.ColumnHeader FurnitureName;
        private System.Windows.Forms.ColumnHeader FurnitureCategory;
        private System.Windows.Forms.ColumnHeader FurnitureStyle;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader RentalRatePerDay;
        private System.Windows.Forms.ColumnHeader InStockQuantity;
        private System.Windows.Forms.ColumnHeader TotalQuantity;
    }
}
