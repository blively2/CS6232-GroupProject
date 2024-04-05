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
            this.UseSearchFurnitureFunctionalityLabel = new System.Windows.Forms.Label();
            this.DateAlertLabel = new System.Windows.Forms.Label();
            this.StartDatePicker = new System.Windows.Forms.DateTimePicker();
            this.StartDateLabel = new System.Windows.Forms.Label();
            this.EndDatePicker = new System.Windows.Forms.DateTimePicker();
            this.EndDateLabel = new System.Windows.Forms.Label();
            this.RentFurnitureButton = new System.Windows.Forms.Button();
            this.SelectedFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRatePerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.InStockQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TotalQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountToRent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SelectedFurnitureMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.RemoveMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TaxTextBox = new System.Windows.Forms.TextBox();
            this.CostTextBox = new System.Windows.Forms.TextBox();
            this.TotalTextBox = new System.Windows.Forms.TextBox();
            this.TaxLabel = new System.Windows.Forms.Label();
            this.CostLabe = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFurnitureDataGridView)).BeginInit();
            this.SelectedFurnitureMenuStrip.SuspendLayout();
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
            this.StartDatePicker.ValueChanged += new System.EventHandler(this.StartDatePickerValueChanged);
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
            this.EndDatePicker.ValueChanged += new System.EventHandler(this.EndDatePickerValueChanged);
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
            this.RentFurnitureButton.Location = new System.Drawing.Point(770, 324);
            this.RentFurnitureButton.Name = "RentFurnitureButton";
            this.RentFurnitureButton.Size = new System.Drawing.Size(169, 36);
            this.RentFurnitureButton.TabIndex = 56;
            this.RentFurnitureButton.Text = "Rent";
            this.RentFurnitureButton.UseVisualStyleBackColor = true;
            this.RentFurnitureButton.Click += new System.EventHandler(this.RentFurnitureButtonClick);
            // 
            // SelectedFurnitureDataGridView
            // 
            this.SelectedFurnitureDataGridView.AllowUserToAddRows = false;
            this.SelectedFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FurnitureID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.RentalRatePerDay,
            this.InStockQuantity,
            this.TotalQuantity,
            this.AmountToRent});
            this.SelectedFurnitureDataGridView.Location = new System.Drawing.Point(0, 179);
            this.SelectedFurnitureDataGridView.MultiSelect = false;
            this.SelectedFurnitureDataGridView.Name = "SelectedFurnitureDataGridView";
            this.SelectedFurnitureDataGridView.RowTemplate.Height = 28;
            this.SelectedFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedFurnitureDataGridView.Size = new System.Drawing.Size(970, 110);
            this.SelectedFurnitureDataGridView.TabIndex = 57;
            this.SelectedFurnitureDataGridView.CellBeginEdit += new System.Windows.Forms.DataGridViewCellCancelEventHandler(this.SelectedFurnitureDataGridViewCellBeginEdit);
            this.SelectedFurnitureDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SelectedFurnitureDataGridViewCellValidating);
            this.SelectedFurnitureDataGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.SelectedFurnitureDataGridViewCellValueChanged);
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "ID";
            this.FurnitureID.Name = "FurnitureID";
            // 
            // FurnitureName
            // 
            this.FurnitureName.HeaderText = "Name";
            this.FurnitureName.Name = "FurnitureName";
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.HeaderText = "Category";
            this.FurnitureCategory.Name = "FurnitureCategory";
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.HeaderText = "Style";
            this.FurnitureStyle.Name = "FurnitureStyle";
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            // 
            // RentalRatePerDay
            // 
            this.RentalRatePerDay.HeaderText = "RentalRatePerDay";
            this.RentalRatePerDay.Name = "RentalRatePerDay";
            // 
            // InStockQuantity
            // 
            this.InStockQuantity.HeaderText = "InStockQuantity";
            this.InStockQuantity.Name = "InStockQuantity";
            // 
            // TotalQuantity
            // 
            this.TotalQuantity.HeaderText = "TotalQuantity";
            this.TotalQuantity.Name = "TotalQuantity";
            // 
            // AmountToRent
            // 
            this.AmountToRent.HeaderText = "AmountToRent";
            this.AmountToRent.Name = "AmountToRent";
            // 
            // SelectedFurnitureMenuStrip
            // 
            this.SelectedFurnitureMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RemoveMenuItem});
            this.SelectedFurnitureMenuStrip.Name = "SelectedFurnitureMenuStrip";
            this.SelectedFurnitureMenuStrip.Size = new System.Drawing.Size(145, 26);
            // 
            // RemoveMenuItem
            // 
            this.RemoveMenuItem.Name = "RemoveMenuItem";
            this.RemoveMenuItem.Size = new System.Drawing.Size(144, 22);
            this.RemoveMenuItem.Text = "Remove Item";
            this.RemoveMenuItem.Click += new System.EventHandler(this.RemoveMenuItemClick);
            // 
            // TaxTextBox
            // 
            this.TaxTextBox.Location = new System.Drawing.Point(593, 326);
            this.TaxTextBox.Name = "TaxTextBox";
            this.TaxTextBox.ReadOnly = true;
            this.TaxTextBox.Size = new System.Drawing.Size(100, 26);
            this.TaxTextBox.TabIndex = 58;
            // 
            // CostTextBox
            // 
            this.CostTextBox.Location = new System.Drawing.Point(593, 294);
            this.CostTextBox.Name = "CostTextBox";
            this.CostTextBox.ReadOnly = true;
            this.CostTextBox.Size = new System.Drawing.Size(100, 26);
            this.CostTextBox.TabIndex = 59;
            // 
            // TotalTextBox
            // 
            this.TotalTextBox.Location = new System.Drawing.Point(593, 358);
            this.TotalTextBox.Name = "TotalTextBox";
            this.TotalTextBox.ReadOnly = true;
            this.TotalTextBox.Size = new System.Drawing.Size(100, 26);
            this.TotalTextBox.TabIndex = 60;
            // 
            // TaxLabel
            // 
            this.TaxLabel.AutoSize = true;
            this.TaxLabel.Location = new System.Drawing.Point(549, 329);
            this.TaxLabel.Name = "TaxLabel";
            this.TaxLabel.Size = new System.Drawing.Size(38, 20);
            this.TaxLabel.TabIndex = 61;
            this.TaxLabel.Text = "Tax:";
            // 
            // CostLabe
            // 
            this.CostLabe.AutoSize = true;
            this.CostLabe.Location = new System.Drawing.Point(541, 297);
            this.CostLabe.Name = "CostLabe";
            this.CostLabe.Size = new System.Drawing.Size(46, 20);
            this.CostLabe.TabIndex = 62;
            this.CostLabe.Text = "Cost:";
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.Location = new System.Drawing.Point(539, 361);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(48, 20);
            this.TotalLabel.TabIndex = 63;
            this.TotalLabel.Text = "Total:";
            // 
            // RentFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.CostLabe);
            this.Controls.Add(this.TaxLabel);
            this.Controls.Add(this.TotalTextBox);
            this.Controls.Add(this.CostTextBox);
            this.Controls.Add(this.TaxTextBox);
            this.Controls.Add(this.SelectedFurnitureDataGridView);
            this.Controls.Add(this.RentFurnitureButton);
            this.Controls.Add(this.EndDatePicker);
            this.Controls.Add(this.EndDateLabel);
            this.Controls.Add(this.DateAlertLabel);
            this.Controls.Add(this.StartDatePicker);
            this.Controls.Add(this.StartDateLabel);
            this.Controls.Add(this.UseSearchFurnitureFunctionalityLabel);
            this.Controls.Add(this.UseSearchMemberFunctionalityLabel);
            this.Controls.Add(this.TitleLabel);
            this.Controls.Add(this.SelectedMemberListView);
            this.Name = "RentFurnitureUserControl";
            this.Size = new System.Drawing.Size(970, 398);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFurnitureDataGridView)).EndInit();
            this.SelectedFurnitureMenuStrip.ResumeLayout(false);
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
        private System.Windows.Forms.Label UseSearchFurnitureFunctionalityLabel;
        private System.Windows.Forms.Label DateAlertLabel;
        private System.Windows.Forms.DateTimePicker StartDatePicker;
        private System.Windows.Forms.Label StartDateLabel;
        private System.Windows.Forms.DateTimePicker EndDatePicker;
        private System.Windows.Forms.Label EndDateLabel;
        private System.Windows.Forms.Button RentFurnitureButton;
        private System.Windows.Forms.DataGridView SelectedFurnitureDataGridView;
        private System.Windows.Forms.ContextMenuStrip SelectedFurnitureMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem RemoveMenuItem;
        private System.Windows.Forms.TextBox TaxTextBox;
        private System.Windows.Forms.TextBox CostTextBox;
        private System.Windows.Forms.TextBox TotalTextBox;
        private System.Windows.Forms.Label TaxLabel;
        private System.Windows.Forms.Label CostLabe;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRatePerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn InStockQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn TotalQuantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountToRent;
    }
}
