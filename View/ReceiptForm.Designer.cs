namespace SofaSoGood.View
{
    partial class ReceiptForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReceiptForm));
            this.TransactionIDLabel = new System.Windows.Forms.Label();
            this.MemberLabel = new System.Windows.Forms.Label();
            this.MemberListView = new System.Windows.Forms.ListView();
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
            this.FurnitureDataGridView = new System.Windows.Forms.DataGridView();
            this.ItemsLabel = new System.Windows.Forms.Label();
            this.DueDateLabel = new System.Windows.Forms.Label();
            this.TotalCostLabel = new System.Windows.Forms.Label();
            this.RentedByLabel = new System.Windows.Forms.Label();
            this.RentalDateLabel = new System.Windows.Forms.Label();
            this.FurnitureID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureCategory = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FurnitureStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RentalRatePerDay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QuantityReturned = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TransactionIDLabel
            // 
            this.TransactionIDLabel.AutoSize = true;
            this.TransactionIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TransactionIDLabel.Location = new System.Drawing.Point(12, 9);
            this.TransactionIDLabel.Name = "TransactionIDLabel";
            this.TransactionIDLabel.Size = new System.Drawing.Size(188, 36);
            this.TransactionIDLabel.TabIndex = 0;
            this.TransactionIDLabel.Text = "Transaction#";
            // 
            // MemberLabel
            // 
            this.MemberLabel.AutoSize = true;
            this.MemberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MemberLabel.Location = new System.Drawing.Point(12, 34);
            this.MemberLabel.Name = "MemberLabel";
            this.MemberLabel.Size = new System.Drawing.Size(130, 36);
            this.MemberLabel.TabIndex = 1;
            this.MemberLabel.Text = "Member:";
            // 
            // MemberListView
            // 
            this.MemberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.MemberListView.FullRowSelect = true;
            this.MemberListView.HideSelection = false;
            this.MemberListView.Location = new System.Drawing.Point(2, 62);
            this.MemberListView.MultiSelect = false;
            this.MemberListView.Name = "MemberListView";
            this.MemberListView.Size = new System.Drawing.Size(746, 61);
            this.MemberListView.TabIndex = 34;
            this.MemberListView.UseCompatibleStateImageBehavior = false;
            this.MemberListView.View = System.Windows.Forms.View.Details;
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
            // FurnitureDataGridView
            // 
            this.FurnitureDataGridView.AllowUserToAddRows = false;
            this.FurnitureDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FurnitureDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FurnitureID,
            this.FurnitureName,
            this.FurnitureCategory,
            this.FurnitureStyle,
            this.Description,
            this.RentalRatePerDay,
            this.Quantity,
            this.QuantityReturned});
            this.FurnitureDataGridView.Location = new System.Drawing.Point(2, 154);
            this.FurnitureDataGridView.MultiSelect = false;
            this.FurnitureDataGridView.Name = "FurnitureDataGridView";
            this.FurnitureDataGridView.RowHeadersWidth = 62;
            this.FurnitureDataGridView.RowTemplate.Height = 28;
            this.FurnitureDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.FurnitureDataGridView.Size = new System.Drawing.Size(746, 234);
            this.FurnitureDataGridView.TabIndex = 58;
            // 
            // ItemsLabel
            // 
            this.ItemsLabel.AutoSize = true;
            this.ItemsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ItemsLabel.Location = new System.Drawing.Point(12, 126);
            this.ItemsLabel.Name = "ItemsLabel";
            this.ItemsLabel.Size = new System.Drawing.Size(93, 36);
            this.ItemsLabel.TabIndex = 59;
            this.ItemsLabel.Text = "Items:";
            // 
            // DueDateLabel
            // 
            this.DueDateLabel.AutoSize = true;
            this.DueDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.DueDateLabel.Location = new System.Drawing.Point(12, 391);
            this.DueDateLabel.Name = "DueDateLabel";
            this.DueDateLabel.Size = new System.Drawing.Size(146, 36);
            this.DueDateLabel.TabIndex = 60;
            this.DueDateLabel.Text = "Due Date:";
            // 
            // TotalCostLabel
            // 
            this.TotalCostLabel.AutoSize = true;
            this.TotalCostLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.TotalCostLabel.Location = new System.Drawing.Point(558, 391);
            this.TotalCostLabel.Name = "TotalCostLabel";
            this.TotalCostLabel.Size = new System.Drawing.Size(158, 36);
            this.TotalCostLabel.TabIndex = 61;
            this.TotalCostLabel.Text = "Total Cost:";
            // 
            // RentedByLabel
            // 
            this.RentedByLabel.AutoSize = true;
            this.RentedByLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RentedByLabel.Location = new System.Drawing.Point(12, 427);
            this.RentedByLabel.Name = "RentedByLabel";
            this.RentedByLabel.Size = new System.Drawing.Size(162, 36);
            this.RentedByLabel.TabIndex = 62;
            this.RentedByLabel.Text = "Rented By:";
            // 
            // RentalDateLabel
            // 
            this.RentalDateLabel.AutoSize = true;
            this.RentalDateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.RentalDateLabel.Location = new System.Drawing.Point(251, 391);
            this.RentalDateLabel.Name = "RentalDateLabel";
            this.RentalDateLabel.Size = new System.Drawing.Size(178, 36);
            this.RentalDateLabel.TabIndex = 63;
            this.RentalDateLabel.Text = "Rental Date:";
            // 
            // FurnitureID
            // 
            this.FurnitureID.HeaderText = "ID";
            this.FurnitureID.MinimumWidth = 8;
            this.FurnitureID.Name = "FurnitureID";
            this.FurnitureID.ReadOnly = true;
            this.FurnitureID.Width = 150;
            // 
            // FurnitureName
            // 
            this.FurnitureName.HeaderText = "Name";
            this.FurnitureName.MinimumWidth = 8;
            this.FurnitureName.Name = "FurnitureName";
            this.FurnitureName.ReadOnly = true;
            this.FurnitureName.Width = 150;
            // 
            // FurnitureCategory
            // 
            this.FurnitureCategory.HeaderText = "Category";
            this.FurnitureCategory.MinimumWidth = 8;
            this.FurnitureCategory.Name = "FurnitureCategory";
            this.FurnitureCategory.ReadOnly = true;
            this.FurnitureCategory.Width = 150;
            // 
            // FurnitureStyle
            // 
            this.FurnitureStyle.HeaderText = "Style";
            this.FurnitureStyle.MinimumWidth = 8;
            this.FurnitureStyle.Name = "FurnitureStyle";
            this.FurnitureStyle.ReadOnly = true;
            this.FurnitureStyle.Width = 150;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.MinimumWidth = 8;
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            this.Description.Width = 150;
            // 
            // RentalRatePerDay
            // 
            this.RentalRatePerDay.HeaderText = "RentalRatePerDay";
            this.RentalRatePerDay.MinimumWidth = 8;
            this.RentalRatePerDay.Name = "RentalRatePerDay";
            this.RentalRatePerDay.ReadOnly = true;
            this.RentalRatePerDay.Width = 150;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 8;
            this.Quantity.Name = "Quantity";
            this.Quantity.ReadOnly = true;
            this.Quantity.Width = 150;
            // 
            // QuantityReturned
            // 
            this.QuantityReturned.HeaderText = "QuantityReturned";
            this.QuantityReturned.MinimumWidth = 8;
            this.QuantityReturned.Name = "QuantityReturned";
            this.QuantityReturned.ReadOnly = true;
            this.QuantityReturned.Width = 150;
            // 
            // ReceiptForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(750, 461);
            this.Controls.Add(this.RentalDateLabel);
            this.Controls.Add(this.RentedByLabel);
            this.Controls.Add(this.TotalCostLabel);
            this.Controls.Add(this.DueDateLabel);
            this.Controls.Add(this.ItemsLabel);
            this.Controls.Add(this.FurnitureDataGridView);
            this.Controls.Add(this.MemberListView);
            this.Controls.Add(this.MemberLabel);
            this.Controls.Add(this.TransactionIDLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReceiptForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            ((System.ComponentModel.ISupportInitialize)(this.FurnitureDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TransactionIDLabel;
        private System.Windows.Forms.Label MemberLabel;
        private System.Windows.Forms.ListView MemberListView;
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
        private System.Windows.Forms.DataGridView FurnitureDataGridView;
        private System.Windows.Forms.Label ItemsLabel;
        private System.Windows.Forms.Label DueDateLabel;
        private System.Windows.Forms.Label TotalCostLabel;
        private System.Windows.Forms.Label RentedByLabel;
        private System.Windows.Forms.Label RentalDateLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureCategory;
        private System.Windows.Forms.DataGridViewTextBoxColumn FurnitureStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.DataGridViewTextBoxColumn RentalRatePerDay;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.DataGridViewTextBoxColumn QuantityReturned;
    }
}