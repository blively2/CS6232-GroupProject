namespace SofaSoGood.UserControls
{
    partial class RentFurnitureUserControl
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
            this.components = new System.ComponentModel.Container();
            this.SelectedMemberListView = new System.Windows.Forms.ListView();
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
            this.TitleLabel = new System.Windows.Forms.Label();
            this.UseSearchMemberFunctionalityLabel = new System.Windows.Forms.Label();
            this.SelectedFurnitureListView = new System.Windows.Forms.ListView();
            this.FurnitureID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureCategory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FurnitureStyle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Description = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RentalRatePerDay = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InStockQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TotalQuantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightClickMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UseSearchFurnitureFunctionalityLabel = new System.Windows.Forms.Label();
            this.DateAlertLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.RentFurnitureButton = new System.Windows.Forms.Button();
            this.RightClickMenuStrip.SuspendLayout();
            this.SuspendLayout();
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
            this.SelectedMemberListView.Location = new System.Drawing.Point(0, 60);
            this.SelectedMemberListView.MultiSelect = false;
            this.SelectedMemberListView.Name = "SelectedMemberListView";
            this.SelectedMemberListView.Size = new System.Drawing.Size(970, 61);
            this.SelectedMemberListView.TabIndex = 33;
            this.SelectedMemberListView.UseCompatibleStateImageBehavior = false;
            this.SelectedMemberListView.View = System.Windows.Forms.View.Details;
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
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleLabel.Location = new System.Drawing.Point(387, 0);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(165, 29);
            this.TitleLabel.TabIndex = 34;
            this.TitleLabel.Text = "Rent Furniture";
            // 
            // UseSearchMemberFunctionalityLabel
            // 
            this.UseSearchMemberFunctionalityLabel.AutoSize = true;
            this.UseSearchMemberFunctionalityLabel.ForeColor = System.Drawing.Color.Black;
            this.UseSearchMemberFunctionalityLabel.Location = new System.Drawing.Point(4, 124);
            this.UseSearchMemberFunctionalityLabel.Name = "UseSearchMemberFunctionalityLabel";
            this.UseSearchMemberFunctionalityLabel.Size = new System.Drawing.Size(478, 20);
            this.UseSearchMemberFunctionalityLabel.TabIndex = 35;
            this.UseSearchMemberFunctionalityLabel.Text = "Use the Search Member Tab and Double Click to Select a Member";
            // 
            // SelectedFurnitureListView
            // 
            this.SelectedFurnitureListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FurnitureID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.RentalRatePerDay,
            this.InStockQuantity,
            this.TotalQuantity});
            this.SelectedFurnitureListView.FullRowSelect = true;
            this.SelectedFurnitureListView.HideSelection = false;
            this.SelectedFurnitureListView.Location = new System.Drawing.Point(0, 179);
            this.SelectedFurnitureListView.Name = "SelectedFurnitureListView";
            this.SelectedFurnitureListView.Size = new System.Drawing.Size(970, 110);
            this.SelectedFurnitureListView.TabIndex = 49;
            this.SelectedFurnitureListView.UseCompatibleStateImageBehavior = false;
            this.SelectedFurnitureListView.View = System.Windows.Forms.View.Details;
            // 
            // FurnitureID
            // 
            this.FurnitureID.Text = "Furniture ID";
            this.FurnitureID.Width = 90;
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
            // RentalRatePerDay
            // 
            this.RentalRatePerDay.Text = "Rate Per Day";
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
            // RightClickMenuStrip
            // 
            this.RightClickMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeItemToolStripMenuItem});
            this.RightClickMenuStrip.Name = "contextMenuStrip1";
            this.RightClickMenuStrip.Size = new System.Drawing.Size(145, 26);
            // 
            // removeItemToolStripMenuItem
            // 
            this.removeItemToolStripMenuItem.Name = "removeItemToolStripMenuItem";
            this.removeItemToolStripMenuItem.Size = new System.Drawing.Size(144, 22);
            this.removeItemToolStripMenuItem.Text = "Remove Item";
            this.removeItemToolStripMenuItem.Click += new System.EventHandler(this.RemoveItemToolStripMenuItemClick);
            // 
            // UseSearchFurnitureFunctionalityLabel
            // 
            this.UseSearchFurnitureFunctionalityLabel.AutoSize = true;
            this.UseSearchFurnitureFunctionalityLabel.ForeColor = System.Drawing.Color.Black;
            this.UseSearchFurnitureFunctionalityLabel.Location = new System.Drawing.Point(3, 292);
            this.UseSearchFurnitureFunctionalityLabel.Name = "UseSearchFurnitureFunctionalityLabel";
            this.UseSearchFurnitureFunctionalityLabel.Size = new System.Drawing.Size(477, 20);
            this.UseSearchFurnitureFunctionalityLabel.TabIndex = 50;
            this.UseSearchFurnitureFunctionalityLabel.Text = "Use the Search Furniture Tab and Double Click to Select Furniture";
            // 
            // DateAlertLabel
            // 
            this.DateAlertLabel.AutoSize = true;
            this.DateAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.DateAlertLabel.Location = new System.Drawing.Point(252, 327);
            this.DateAlertLabel.Name = "DateAlertLabel";
            this.DateAlertLabel.Size = new System.Drawing.Size(97, 20);
            this.DateAlertLabel.TabIndex = 53;
            this.DateAlertLabel.Text = "Invalid Date!";
            // 
            // StartDatePicker
            // 
            this.StartDatePicker.Enabled = false;
            this.StartDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDatePicker.Location = new System.Drawing.Point(97, 327);
            this.StartDatePicker.Name = "StartDatePicker";
            this.StartDatePicker.Size = new System.Drawing.Size(149, 26);
            this.StartDatePicker.TabIndex = 52;
            this.StartDatePicker.DropDown += new System.EventHandler(this.DatePickerDropDown);
            // 
            // StartDateLabel
            // 
            this.StartDateLabel.AutoSize = true;
            this.StartDateLabel.Location = new System.Drawing.Point(4, 332);
            this.StartDateLabel.Name = "StartDateLabel";
            this.StartDateLabel.Size = new System.Drawing.Size(87, 20);
            this.StartDateLabel.TabIndex = 51;
            this.StartDateLabel.Text = "Start Date:";
            // 
            // EndDatePicker
            // 
            this.EndDatePicker.Enabled = false;
            this.EndDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDatePicker.Location = new System.Drawing.Point(97, 359);
            this.EndDatePicker.Name = "EndDatePicker";
            this.EndDatePicker.Size = new System.Drawing.Size(149, 26);
            this.EndDatePicker.TabIndex = 55;
            this.EndDatePicker.DropDown += new System.EventHandler(this.DatePickerDropDown);
            // 
            // EndDateLabel
            // 
            this.EndDateLabel.AutoSize = true;
            this.EndDateLabel.Location = new System.Drawing.Point(4, 364);
            this.EndDateLabel.Name = "EndDateLabel";
            this.EndDateLabel.Size = new System.Drawing.Size(81, 20);
            this.EndDateLabel.TabIndex = 54;
            this.EndDateLabel.Text = "End Date:";
            // 
            // RentFurnitureButton
            // 
            this.RentFurnitureButton.Enabled = false;
            this.RentFurnitureButton.Location = new System.Drawing.Point(645, 324);
            this.RentFurnitureButton.Name = "RentFurnitureButton";
            this.RentFurnitureButton.Size = new System.Drawing.Size(169, 36);
            this.RentFurnitureButton.TabIndex = 56;
            this.RentFurnitureButton.Text = "Rent";
            this.RentFurnitureButton.UseVisualStyleBackColor = true;
            this.RentFurnitureButton.Click += new System.EventHandler(this.RentFurnitureButtonClick);
            // 
            // RentFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RentFurnitureButton);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.DateAlertLabel);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.UseSearchFurnitureFunctionalityLabel);
            this.Controls.Add(this.SelectedFurnitureListView);
            this.Controls.Add(this.UseSearchMemberFunctionalityLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SelectedMemberListView);
            this.Name = "RentFurnitureUserControl";
            this.Size = new System.Drawing.Size(970, 398);
            this.RightClickMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView SelectedMemberListView;
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
        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label UseSearchMemberFunctionalityLabel;
        private System.Windows.Forms.ListView SelectedFurnitureListView;
        private System.Windows.Forms.ColumnHeader FurnitureID;
        private System.Windows.Forms.ColumnHeader FurnitureName;
        private System.Windows.Forms.ColumnHeader FurnitureCategory;
        private System.Windows.Forms.ColumnHeader FurnitureStyle;
        private System.Windows.Forms.ColumnHeader Description;
        private System.Windows.Forms.ColumnHeader RentalRatePerDay;
        private System.Windows.Forms.ColumnHeader InStockQuantity;
        private System.Windows.Forms.ColumnHeader TotalQuantity;
        private System.Windows.Forms.ContextMenuStrip RightClickMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem removeItemToolStripMenuItem;
        private System.Windows.Forms.Label UseSearchFurnitureFunctionalityLabel;
        private System.Windows.Forms.Label DateAlertLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button RentFurnitureButton;
    }
}
