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
            this.SelectAMemberLabel = new System.Windows.Forms.Label();
            this.MemberID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Gender = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DateOfBirth = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.City = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.State = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Zip = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectedMemberListView = new System.Windows.Forms.ListView();
            this.CurrentlyRentedFurnitureLabel = new System.Windows.Forms.Label();
            this.ItemsToReturnLabel = new System.Windows.Forms.Label();
            this.CurrentlyRentedFurnitureListView = new System.Windows.Forms.ListView();
            this.FurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentalTransactionID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentalItemID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.DueDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.AmountRented = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // BuildReturnTitleLabel
            // 
            this.BuildReturnTitleLabel.AutoSize = true;
            this.BuildReturnTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.BuildReturnTitleLabel.Location = new System.Drawing.Point(231, 6);
            this.BuildReturnTitleLabel.Name = "BuildReturnTitleLabel";
            this.BuildReturnTitleLabel.Size = new System.Drawing.Size(257, 29);
            this.BuildReturnTitleLabel.TabIndex = 3;
            this.BuildReturnTitleLabel.Text = "Currently Rented Items";
            // 
            // SelectAMemberLabel
            // 
            this.SelectAMemberLabel.AutoSize = true;
            this.SelectAMemberLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectAMemberLabel.Location = new System.Drawing.Point(2, 34);
            this.SelectAMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectAMemberLabel.Name = "SelectAMemberLabel";
            this.SelectAMemberLabel.Size = new System.Drawing.Size(93, 13);
            this.SelectAMemberLabel.TabIndex = 36;
            this.SelectAMemberLabel.Text = "Selected Member:";
            // 
            // MemberID
            // 
            this.MemberID.Text = "MemberID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            // 
            // Gender
            // 
            this.Gender.Text = "Gender";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.Text = "DateOfBirth";
            // 
            // Address1
            // 
            this.Address1.Text = "Address1";
            // 
            // Address2
            // 
            this.Address2.Text = "Address2";
            // 
            // City
            // 
            this.City.Text = "City";
            // 
            // State
            // 
            this.State.Text = "State";
            // 
            // Zip
            // 
            this.Zip.Text = "Zip";
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            // 
            // SelectedMemberListView
            // 
            this.SelectedMemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.MemberID,
            this.FirstName,
            this.LastName,
            this.Gender,
            this.DateOfBirth,
            this.Address1,
            this.Address2,
            this.City,
            this.State,
            this.Zip,
            this.Phone});
            this.SelectedMemberListView.FullRowSelect = true;
            this.SelectedMemberListView.HideSelection = false;
            this.SelectedMemberListView.Location = new System.Drawing.Point(0, 49);
            this.SelectedMemberListView.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedMemberListView.MultiSelect = false;
            this.SelectedMemberListView.Name = "SelectedMemberListView";
            this.SelectedMemberListView.Size = new System.Drawing.Size(648, 41);
            this.SelectedMemberListView.TabIndex = 37;
            this.SelectedMemberListView.UseCompatibleStateImageBehavior = false;
            this.SelectedMemberListView.View = System.Windows.Forms.View.Details;
            // 
            // CurrentlyRentedFurnitureLabel
            // 
            this.CurrentlyRentedFurnitureLabel.AutoSize = true;
            this.CurrentlyRentedFurnitureLabel.ForeColor = System.Drawing.Color.Black;
            this.CurrentlyRentedFurnitureLabel.Location = new System.Drawing.Point(2, 114);
            this.CurrentlyRentedFurnitureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CurrentlyRentedFurnitureLabel.Name = "CurrentlyRentedFurnitureLabel";
            this.CurrentlyRentedFurnitureLabel.Size = new System.Drawing.Size(125, 13);
            this.CurrentlyRentedFurnitureLabel.TabIndex = 38;
            this.CurrentlyRentedFurnitureLabel.Text = "Please Select a Member.";
            // 
            // ItemsToReturnLabel
            // 
            this.ItemsToReturnLabel.AutoSize = true;
            this.ItemsToReturnLabel.ForeColor = System.Drawing.Color.Black;
            this.ItemsToReturnLabel.Location = new System.Drawing.Point(244, 248);
            this.ItemsToReturnLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ItemsToReturnLabel.Name = "ItemsToReturnLabel";
            this.ItemsToReturnLabel.Size = new System.Drawing.Size(142, 13);
            this.ItemsToReturnLabel.TabIndex = 50;
            this.ItemsToReturnLabel.Text = "Selected Items For Return: 0";
            // 
            // CurrentlyRentedFurnitureListView
            // 
            this.CurrentlyRentedFurnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FurnitureID,
            this.RentalTransactionID,
            this.RentalItemID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.DueDate,
            this.AmountRented});
            this.CurrentlyRentedFurnitureListView.FullRowSelect = true;
            this.CurrentlyRentedFurnitureListView.HideSelection = false;
            this.CurrentlyRentedFurnitureListView.Location = new System.Drawing.Point(0, 129);
            this.CurrentlyRentedFurnitureListView.Margin = new System.Windows.Forms.Padding(2);
            this.CurrentlyRentedFurnitureListView.MultiSelect = false;
            this.CurrentlyRentedFurnitureListView.Name = "CurrentlyRentedFurnitureListView";
            this.CurrentlyRentedFurnitureListView.Size = new System.Drawing.Size(648, 119);
            this.CurrentlyRentedFurnitureListView.TabIndex = 51;
            this.CurrentlyRentedFurnitureListView.UseCompatibleStateImageBehavior = false;
            this.CurrentlyRentedFurnitureListView.View = System.Windows.Forms.View.Details;
            this.CurrentlyRentedFurnitureListView.DoubleClick += new System.EventHandler(this.CurrentlyRentedFurnitureListViewDoubleClick);
            // 
            // FurnitureID
            // 
            this.FurnitureID.Text = "FurnitureID";
            this.FurnitureID.Width = 90;
            // 
            // RentalTransactionID
            // 
            this.RentalTransactionID.Text = "RentalTransactionID";
            // 
            // RentalItemID
            // 
            this.RentalItemID.Text = "RentalItemID";
            // 
            // FurnitureName
            // 
            this.FurnitureName.Text = "Name";
            this.FurnitureName.Width = 90;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.Text = "Category";
            this.FurnitureCategory.Width = 120;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.Text = "Style";
            this.FurnitureStyle.Width = 90;
            // 
            // Description
            // 
            this.Description.Text = "Description";
            this.Description.Width = 120;
            // 
            // DueDate
            // 
            this.DueDate.Text = "DueDate";
            this.DueDate.Width = 90;
            // 
            // AmountRented
            // 
            this.AmountRented.Text = "AmountRented";
            // 
            // BuildReturnUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.CurrentlyRentedFurnitureListView);
            this.Controls.Add(this.ItemsToReturnLabel);
            this.Controls.Add(this.CurrentlyRentedFurnitureLabel);
            this.Controls.Add(this.SelectedMemberListView);
            this.Controls.Add(this.SelectAMemberLabel);
            this.Controls.Add(this.BuildReturnTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "BuildReturnUserControl";
            this.Size = new System.Drawing.Size(644, 277);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BuildReturnTitleLabel;
        private System.Windows.Forms.Label SelectAMemberLabel;
        private System.Windows.Forms.ColumnHeader MemberID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Gender;
        private System.Windows.Forms.ColumnHeader DateOfBirth;
        private System.Windows.Forms.ColumnHeader Address1;
        private System.Windows.Forms.ColumnHeader Address2;
        private System.Windows.Forms.ColumnHeader City;
        private System.Windows.Forms.ColumnHeader State;
        private System.Windows.Forms.ColumnHeader Zip;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ListView SelectedMemberListView;
        private System.Windows.Forms.Label CurrentlyRentedFurnitureLabel;
        private System.Windows.Forms.Label ItemsToReturnLabel;
        private System.Windows.Forms.ListView CurrentlyRentedFurnitureListView;
        private System.Windows.Forms.ColumnHeader FurnitureID;
        private System.Windows.Forms.ColumnHeader RentalTransactionID;
        private System.Windows.Forms.ColumnHeader RentalItemID;
        private System.Windows.Forms.ColumnHeader FurnitureName;
        private System.Windows.Forms.ColumnHeader FurnitureCategory;
        private System.Windows.Forms.ColumnHeader FurnitureStyle;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader DueDate;
        private System.Windows.Forms.ColumnHeader AmountRented;
    }
}
