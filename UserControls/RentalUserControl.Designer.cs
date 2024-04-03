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
            this.furnitureComboBox = new System.Windows.Forms.ComboBox();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.addItemButton = new System.Windows.Forms.Button();
            this.rentalItemsDataGridView = new System.Windows.Forms.DataGridView();
            this.removeItemButton = new System.Windows.Forms.Button();
            this.employeeIdTextBox = new System.Windows.Forms.TextBox();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.submitOrderButton = new System.Windows.Forms.Button();
            this.furnitureLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.employeeIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // furnitureComboBox
            // 
            this.furnitureComboBox.FormattingEnabled = true;
            this.furnitureComboBox.Location = new System.Drawing.Point(65, 64);
            this.furnitureComboBox.Name = "furnitureComboBox";
            this.furnitureComboBox.Size = new System.Drawing.Size(121, 21);
            this.furnitureComboBox.TabIndex = 0;
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(247, 64);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(100, 20);
            this.quantityTextBox.TabIndex = 1;
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(353, 64);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(75, 23);
            this.addItemButton.TabIndex = 2;
            this.addItemButton.Text = "add";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // rentalItemsDataGridView
            // 
            this.rentalItemsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.rentalItemsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalItemsDataGridView.Location = new System.Drawing.Point(0, 153);
            this.rentalItemsDataGridView.Name = "rentalItemsDataGridView";
            this.rentalItemsDataGridView.ReadOnly = true;
            this.rentalItemsDataGridView.Size = new System.Drawing.Size(799, 153);
            this.rentalItemsDataGridView.TabIndex = 3;
            // 
            // removeItemButton
            // 
            this.removeItemButton.Location = new System.Drawing.Point(434, 64);
            this.removeItemButton.Name = "removeItemButton";
            this.removeItemButton.Size = new System.Drawing.Size(75, 23);
            this.removeItemButton.TabIndex = 4;
            this.removeItemButton.Text = "remove";
            this.removeItemButton.UseVisualStyleBackColor = true;
            this.removeItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // employeeIdTextBox
            // 
            this.employeeIdTextBox.Location = new System.Drawing.Point(434, 90);
            this.employeeIdTextBox.Name = "employeeIdTextBox";
            this.employeeIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.employeeIdTextBox.TabIndex = 5;
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.Location = new System.Drawing.Point(247, 90);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberIdTextBox.TabIndex = 6;
            // 
            // submitOrderButton
            // 
            this.submitOrderButton.Location = new System.Drawing.Point(546, 113);
            this.submitOrderButton.Name = "submitOrderButton";
            this.submitOrderButton.Size = new System.Drawing.Size(75, 23);
            this.submitOrderButton.TabIndex = 7;
            this.submitOrderButton.Text = "submit";
            this.submitOrderButton.UseVisualStyleBackColor = true;
            this.submitOrderButton.Click += new System.EventHandler(this.SubmitOrderButton_Click);
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
            this.Controls.Add(this.submitOrderButton);
            this.Controls.Add(this.memberIdTextBox);
            this.Controls.Add(this.employeeIdTextBox);
            this.Controls.Add(this.removeItemButton);
            this.Controls.Add(this.rentalItemsDataGridView);
            this.Controls.Add(this.addItemButton);
            this.Controls.Add(this.quantityTextBox);
            this.Controls.Add(this.furnitureComboBox);
            this.Name = "RentalUserControl";
            this.Size = new System.Drawing.Size(799, 306);
            ((System.ComponentModel.ISupportInitialize)(this.rentalItemsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox furnitureComboBox;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.DataGridView rentalItemsDataGridView;
        private System.Windows.Forms.Button removeItemButton;
        private System.Windows.Forms.TextBox employeeIdTextBox;
        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.Button submitOrderButton;
        private System.Windows.Forms.Label furnitureLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.Label employeeIdLabel;
    }
}
