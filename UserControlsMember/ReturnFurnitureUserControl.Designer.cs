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
            this.SelectedMemberLabel = new System.Windows.Forms.Label();
            this.SelectedFurnitureLabel = new System.Windows.Forms.Label();
            this.SelectedFurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalTransactionID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountRented = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AmountToReturn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ReturnFurnitureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFurnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnFurnitureTitleLabel
            // 
            this.ReturnFurnitureTitleLabel.AutoSize = true;
            this.ReturnFurnitureTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ReturnFurnitureTitleLabel.Location = new System.Drawing.Point(251, 7);
            this.ReturnFurnitureTitleLabel.Name = "ReturnFurnitureTitleLabel";
            this.ReturnFurnitureTitleLabel.Size = new System.Drawing.Size(186, 29);
            this.ReturnFurnitureTitleLabel.TabIndex = 4;
            this.ReturnFurnitureTitleLabel.Text = "Return Furniture";
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
            this.SelectedMemberListView.Location = new System.Drawing.Point(2, 38);
            this.SelectedMemberListView.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedMemberListView.MultiSelect = false;
            this.SelectedMemberListView.Name = "SelectedMemberListView";
            this.SelectedMemberListView.Size = new System.Drawing.Size(642, 41);
            this.SelectedMemberListView.TabIndex = 38;
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
            // SelectedMemberLabel
            // 
            this.SelectedMemberLabel.AutoSize = true;
            this.SelectedMemberLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectedMemberLabel.Location = new System.Drawing.Point(2, 23);
            this.SelectedMemberLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedMemberLabel.Name = "SelectedMemberLabel";
            this.SelectedMemberLabel.Size = new System.Drawing.Size(93, 13);
            this.SelectedMemberLabel.TabIndex = 39;
            this.SelectedMemberLabel.Text = "Selected Member:";
            // 
            // SelectedFurnitureLabel
            // 
            this.SelectedFurnitureLabel.AutoSize = true;
            this.SelectedFurnitureLabel.ForeColor = System.Drawing.Color.Black;
            this.SelectedFurnitureLabel.Location = new System.Drawing.Point(2, 81);
            this.SelectedFurnitureLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.SelectedFurnitureLabel.Name = "SelectedFurnitureLabel";
            this.SelectedFurnitureLabel.Size = new System.Drawing.Size(98, 13);
            this.SelectedFurnitureLabel.TabIndex = 59;
            this.SelectedFurnitureLabel.Text = "Furniture to Return:";
            // 
            // SelectedFurnitureDataGridView
            // 
            this.SelectedFurnitureDataGridView.AllowUserToAddRows = false;
            this.SelectedFurnitureDataGridView.AllowUserToDeleteRows = false;
            this.SelectedFurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.SelectedFurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FurnitureID,
            this.RentalTransactionID,
            this.RentalItemID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.DueDate,
            this.AmountRented,
            this.AmountToReturn});
            this.SelectedFurnitureDataGridView.Location = new System.Drawing.Point(0, 96);
            this.SelectedFurnitureDataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedFurnitureDataGridView.MultiSelect = false;
            this.SelectedFurnitureDataGridView.Name = "SelectedFurnitureDataGridView";
            this.SelectedFurnitureDataGridView.RowTemplate.Height = 28;
            this.SelectedFurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.SelectedFurnitureDataGridView.Size = new System.Drawing.Size(644, 129);
            this.SelectedFurnitureDataGridView.TabIndex = 60;
            this.SelectedFurnitureDataGridView.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.SelectedFurnitureDataGridView_CellValidating);
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "FurnitureID";
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            // 
            // RentalTransactionID
            // 
            this.RentalTransactionID.HeaderText = "RentalTransactionID";
            this.RentalTransactionID.Name = "RentalTransactionID";
            this.RentalTransactionID.ReadOnly = true;
            // 
            // RentalItemID
            // 
            this.RentalItemID.HeaderText = "RentalItemID";
            this.RentalItemID.Name = "RentalItemID";
            this.RentalItemID.ReadOnly = true;
            // 
            // FurnitureName
            // 
            this.FurnitureName.HeaderText = "Name";
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.ReadOnly = true;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.HeaderText = "Category";
            this.FurnitureCategory.Name = "FurnitureCategory";
            this.FurnitureCategory.ReadOnly = true;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.HeaderText = "Style";
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.ReadOnly = true;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // DueDate
            // 
            this.DueDate.HeaderText = "DueDate";
            this.DueDate.Name = "DueDate";
            this.DueDate.ReadOnly = true;
            // 
            // AmountRented
            // 
            this.AmountRented.HeaderText = "AmountRented";
            this.AmountRented.Name = "AmountRented";
            this.AmountRented.ReadOnly = true;
            // 
            // AmountToReturn
            // 
            this.AmountToReturn.HeaderText = "AmountToReturn";
            this.AmountToReturn.Name = "AmountToReturn";
            // 
            // ReturnFurnitureButton
            // 
            this.ReturnFurnitureButton.Enabled = false;
            this.ReturnFurnitureButton.Location = new System.Drawing.Point(510, 238);
            this.ReturnFurnitureButton.Margin = new System.Windows.Forms.Padding(2);
            this.ReturnFurnitureButton.Name = "ReturnFurnitureButton";
            this.ReturnFurnitureButton.Size = new System.Drawing.Size(88, 23);
            this.ReturnFurnitureButton.TabIndex = 61;
            this.ReturnFurnitureButton.Text = "Return";
            this.ReturnFurnitureButton.UseVisualStyleBackColor = true;
            this.ReturnFurnitureButton.Click += new System.EventHandler(this.ReturnFurnitureButtonClick);
            // 
            // ReturnFurnitureUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ReturnFurnitureButton);
            this.Controls.Add(this.SelectedFurnitureDataGridView);
            this.Controls.Add(this.SelectedFurnitureLabel);
            this.Controls.Add(this.SelectedMemberLabel);
            this.Controls.Add(this.SelectedMemberListView);
            this.Controls.Add(this.ReturnFurnitureTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnFurnitureUserControl";
            this.Size = new System.Drawing.Size(644, 277);
            ((System.ComponentModel.ISupportInitialize)(this.SelectedFurnitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnFurnitureTitleLabel;
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
        private System.Windows.Forms.Label SelectedMemberLabel;
        private System.Windows.Forms.Label SelectedFurnitureLabel;
        private System.Windows.Forms.DataGridView SelectedFurnitureDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalTransactionID;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn DueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountRented;
        private System.Windows.Forms.DataGridViewTextBoxColumn AmountToReturn;
        private System.Windows.Forms.Button ReturnFurnitureButton;
    }
}
