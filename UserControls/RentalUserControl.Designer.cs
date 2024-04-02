namespace SofaSoGood.UserControls
{
    partial class RentalUserControl
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
            this.comboFurniture = new System.Windows.Forms.ComboBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.dgvRentalItems = new System.Windows.Forms.DataGridView();
            this.btnRemoveItem = new System.Windows.Forms.Button();
            this.txtEmployeeId = new System.Windows.Forms.TextBox();
            this.txtMemberId = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.furnitureLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalItems)).BeginInit();
            this.SuspendLayout();
            // 
            // comboFurniture
            // 
            this.comboFurniture.FormattingEnabled = true;
            this.comboFurniture.Location = new System.Drawing.Point(65, 64);
            this.comboFurniture.Name = "comboFurniture";
            this.comboFurniture.Size = new System.Drawing.Size(121, 21);
            this.comboFurniture.TabIndex = 0;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(247, 64);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(100, 20);
            this.txtQuantity.TabIndex = 1;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(353, 64);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 23);
            this.btnAddItem.TabIndex = 2;
            this.btnAddItem.Text = "add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // dgvRentalItems
            // 
            this.dgvRentalItems.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvRentalItems.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentalItems.Location = new System.Drawing.Point(0, 153);
            this.dgvRentalItems.Name = "dgvRentalItems";
            this.dgvRentalItems.ReadOnly = true;
            this.dgvRentalItems.Size = new System.Drawing.Size(799, 153);
            this.dgvRentalItems.TabIndex = 3;
            // 
            // btnRemoveItem
            // 
            this.btnRemoveItem.Location = new System.Drawing.Point(434, 64);
            this.btnRemoveItem.Name = "btnRemoveItem";
            this.btnRemoveItem.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveItem.TabIndex = 4;
            this.btnRemoveItem.Text = "remove";
            this.btnRemoveItem.UseVisualStyleBackColor = true;
            this.btnRemoveItem.Click += new System.EventHandler(this.btnRemoveItem_Click);
            // 
            // txtEmployeeId
            // 
            this.txtEmployeeId.Location = new System.Drawing.Point(434, 90);
            this.txtEmployeeId.Name = "txtEmployeeId";
            this.txtEmployeeId.Size = new System.Drawing.Size(100, 20);
            this.txtEmployeeId.TabIndex = 5;
            // 
            // txtMemberId
            // 
            this.txtMemberId.Location = new System.Drawing.Point(247, 90);
            this.txtMemberId.Name = "txtMemberId";
            this.txtMemberId.Size = new System.Drawing.Size(100, 20);
            this.txtMemberId.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(546, 113);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // furnitureLabel
            // 
            this.furnitureLabel.AutoSize = true;
            this.furnitureLabel.Location = new System.Drawing.Point(8, 69);
            this.furnitureLabel.Name = "furnitureLabel";
            this.furnitureLabel.Size = new System.Drawing.Size(51, 13);
            this.furnitureLabel.TabIndex = 8;
            this.furnitureLabel.Text = "Furniture:";
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(197, 67);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(44, 13);
            this.quantityLabel.TabIndex = 9;
            this.quantityLabel.Text = "quantity";
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Location = new System.Drawing.Point(182, 93);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(59, 13);
            this.memberIdLabel.TabIndex = 10;
            this.memberIdLabel.Text = "Member ID";
            // 
            // employeeIdLabel
            // 
            this.employeeIdLabel.AutoSize = true;
            this.employeeIdLabel.Location = new System.Drawing.Point(361, 93);
            this.employeeIdLabel.Name = "employeeIdLabel";
            this.employeeIdLabel.Size = new System.Drawing.Size(67, 13);
            this.employeeIdLabel.TabIndex = 11;
            this.employeeIdLabel.Text = "employee Id:";
            // 
            // RentalUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.employeeIdLabel);
            this.Controls.Add(this.memberIdLabel);
            this.Controls.Add(this.quantityLabel);
            this.Controls.Add(this.furnitureLabel);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtMemberId);
            this.Controls.Add(this.txtEmployeeId);
            this.Controls.Add(this.btnRemoveItem);
            this.Controls.Add(this.dgvRentalItems);
            this.Controls.Add(this.btnAddItem);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.comboFurniture);
            this.Name = "RentalUserControl";
            this.Size = new System.Drawing.Size(799, 306);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentalItems)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboFurniture;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DataGridView dgvRentalItems;
        private System.Windows.Forms.Button btnRemoveItem;
        private System.Windows.Forms.TextBox txtEmployeeId;
        private System.Windows.Forms.TextBox txtMemberId;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label furnitureLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.Label employeeIdLabel;
    }
}
