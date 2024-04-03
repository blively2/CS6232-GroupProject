namespace SofaSoGood.UserControls
{
    partial class SearchFurnitureUserControl
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
            this.furnitureIDLabel = new System.Windows.Forms.Label();
            this.furnitureCategoryLabel = new System.Windows.Forms.Label();
            this.furnitureStyleLabel = new System.Windows.Forms.Label();
            this.catogeryComboBox = new System.Windows.Forms.ComboBox();
            this.styleComboBox = new System.Windows.Forms.ComboBox();
            this.furnitureListView = new System.Windows.Forms.ListView();
            this.FurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentalRatePerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.searchButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.warningLabel = new System.Windows.Forms.Label();
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
            this.furnitureIDTextBox.Location = new System.Drawing.Point(504, 72);
            this.furnitureIDTextBox.Name = "furnitureIDTextBox";
            this.furnitureIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.furnitureIDTextBox.TabIndex = 21;
            // 
            // furnitureIDLabel
            // 
            this.furnitureIDLabel.AutoSize = true;
            this.furnitureIDLabel.Location = new System.Drawing.Point(226, 79);
            this.furnitureIDLabel.Name = "furnitureIDLabel";
            this.furnitureIDLabel.Size = new System.Drawing.Size(65, 13);
            this.furnitureIDLabel.TabIndex = 23;
            this.furnitureIDLabel.Text = "Furniture ID:";
            // 
            // furnitureCategoryLabel
            // 
            this.furnitureCategoryLabel.AutoSize = true;
            this.furnitureCategoryLabel.Location = new System.Drawing.Point(226, 118);
            this.furnitureCategoryLabel.Name = "furnitureCategoryLabel";
            this.furnitureCategoryLabel.Size = new System.Drawing.Size(96, 13);
            this.furnitureCategoryLabel.TabIndex = 26;
            this.furnitureCategoryLabel.Text = "Furniture Category:";
            // 
            // furnitureStyleLabel
            // 
            this.furnitureStyleLabel.AutoSize = true;
            this.furnitureStyleLabel.Location = new System.Drawing.Point(226, 158);
            this.furnitureStyleLabel.Name = "furnitureStyleLabel";
            this.furnitureStyleLabel.Size = new System.Drawing.Size(77, 13);
            this.furnitureStyleLabel.TabIndex = 29;
            this.furnitureStyleLabel.Text = "Furniture Style:";
            // 
            // catogeryComboBox
            // 
            this.catogeryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.catogeryComboBox.FormattingEnabled = true;
            this.catogeryComboBox.Location = new System.Drawing.Point(504, 115);
            this.catogeryComboBox.Name = "catogeryComboBox";
            this.catogeryComboBox.Size = new System.Drawing.Size(171, 21);
            this.catogeryComboBox.TabIndex = 46;
            // 
            // styleComboBox
            // 
            this.styleComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleComboBox.FormattingEnabled = true;
            this.styleComboBox.Location = new System.Drawing.Point(504, 155);
            this.styleComboBox.Name = "styleComboBox";
            this.styleComboBox.Size = new System.Drawing.Size(171, 21);
            this.styleComboBox.TabIndex = 47;
            // 
            // furnitureListView
            // 
            this.furnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FurnitureID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.RentalRatePerDay,
            this.InStockQuantity,
            this.TotalQuantity});
            this.furnitureListView.HideSelection = false;
            this.furnitureListView.Location = new System.Drawing.Point(0, 285);
            this.furnitureListView.Name = "furnitureListView";
            this.furnitureListView.Size = new System.Drawing.Size(970, 110);
            this.furnitureListView.TabIndex = 48;
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
            // searchButton
            // 
            this.searchButton.AutoSize = true;
            this.searchButton.Location = new System.Drawing.Point(303, 211);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 49;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.AutoSize = true;
            this.clearButton.Location = new System.Drawing.Point(527, 211);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(75, 23);
            this.clearButton.TabIndex = 50;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // warningLabel
            // 
            this.warningLabel.AutoSize = true;
            this.warningLabel.Location = new System.Drawing.Point(360, 249);
            this.warningLabel.Name = "warningLabel";
            this.warningLabel.Size = new System.Drawing.Size(0, 13);
            this.warningLabel.TabIndex = 51;
            // 
            // SearchFurnitureUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.warningLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.furnitureListView);
            this.Controls.Add(this.styleComboBox);
            this.Controls.Add(this.catogeryComboBox);
            this.Controls.Add(this.furnitureStyleLabel);
            this.Controls.Add(this.furnitureCategoryLabel);
            this.Controls.Add(this.furnitureIDTextBox);
            this.Controls.Add(this.furnitureIDLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SearchFurnitureUserControl";
            this.Size = new System.Drawing.Size(970, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.TextBox furnitureIDTextBox;
        private System.Windows.Forms.Label furnitureIDLabel;
        private System.Windows.Forms.Label furnitureCategoryLabel;
        private System.Windows.Forms.Label furnitureStyleLabel;
        private System.Windows.Forms.ComboBox catogeryComboBox;
        private System.Windows.Forms.ComboBox styleComboBox;
        private System.Windows.Forms.ListView furnitureListView;
        private System.Windows.Forms.ColumnHeader FurnitureID;
        private System.Windows.Forms.ColumnHeader FurnitureName;
        private System.Windows.Forms.ColumnHeader FurnitureCategory;
        private System.Windows.Forms.ColumnHeader FurnitureStyle;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader RentalRatePerDay;
        private System.Windows.Forms.ColumnHeader InStockQuantity;
        private System.Windows.Forms.ColumnHeader TotalQuantity;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label warningLabel;
    }
}
