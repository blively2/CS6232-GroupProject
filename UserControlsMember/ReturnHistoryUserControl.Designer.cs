namespace SofaSoGood.UserControls
{
    partial class ReturnHistoryUserControl
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
            this.ReturnHistoryTitleLabel = new System.Windows.Forms.Label();
            this.rentalHistoryInstructionLabel = new System.Windows.Forms.Label();
            this.viewedMemberLabel = new System.Windows.Forms.Label();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.searchHistoryButton = new System.Windows.Forms.Button();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.ReturnHistoryDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ReturnHistoryTitleLabel
            // 
            this.ReturnHistoryTitleLabel.AutoSize = true;
            this.ReturnHistoryTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.ReturnHistoryTitleLabel.Location = new System.Drawing.Point(232, 11);
            this.ReturnHistoryTitleLabel.Name = "ReturnHistoryTitleLabel";
            this.ReturnHistoryTitleLabel.Size = new System.Drawing.Size(223, 29);
            this.ReturnHistoryTitleLabel.TabIndex = 4;
            this.ReturnHistoryTitleLabel.Text = "View Return History";
            // 
            // rentalHistoryInstructionLabel
            // 
            this.rentalHistoryInstructionLabel.AutoSize = true;
            this.rentalHistoryInstructionLabel.Location = new System.Drawing.Point(116, 69);
            this.rentalHistoryInstructionLabel.Name = "rentalHistoryInstructionLabel";
            this.rentalHistoryInstructionLabel.Size = new System.Drawing.Size(174, 13);
            this.rentalHistoryInstructionLabel.TabIndex = 16;
            this.rentalHistoryInstructionLabel.Text = "Double Click Order to View Receipt";
            // 
            // viewedMemberLabel
            // 
            this.viewedMemberLabel.AutoSize = true;
            this.viewedMemberLabel.Location = new System.Drawing.Point(387, 48);
            this.viewedMemberLabel.Name = "viewedMemberLabel";
            this.viewedMemberLabel.Size = new System.Drawing.Size(0, 13);
            this.viewedMemberLabel.TabIndex = 15;
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(387, 48);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 13);
            this.errorMessageLabel.TabIndex = 14;
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(306, 43);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(75, 23);
            this.clearSearchButton.TabIndex = 12;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // searchHistoryButton
            // 
            this.searchHistoryButton.Location = new System.Drawing.Point(225, 43);
            this.searchHistoryButton.Name = "searchHistoryButton";
            this.searchHistoryButton.Size = new System.Drawing.Size(75, 23);
            this.searchHistoryButton.TabIndex = 11;
            this.searchHistoryButton.Text = "Search";
            this.searchHistoryButton.UseVisualStyleBackColor = true;
            this.searchHistoryButton.Click += new System.EventHandler(this.SearchHistoryButton_Click);
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Location = new System.Drawing.Point(51, 51);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(62, 13);
            this.memberIdLabel.TabIndex = 13;
            this.memberIdLabel.Text = "Member ID:";
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.Location = new System.Drawing.Point(119, 46);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(100, 20);
            this.memberIdTextBox.TabIndex = 9;
            this.memberIdTextBox.Click += new System.EventHandler(this.MemberIdTextBox_TextChanged);
            // 
            // ReturnHistoryDataGridView
            // 
            this.ReturnHistoryDataGridView.AllowUserToAddRows = false;
            this.ReturnHistoryDataGridView.AllowUserToDeleteRows = false;
            this.ReturnHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ReturnHistoryDataGridView.Location = new System.Drawing.Point(3, 91);
            this.ReturnHistoryDataGridView.MultiSelect = false;
            this.ReturnHistoryDataGridView.Name = "ReturnHistoryDataGridView";
            this.ReturnHistoryDataGridView.ReadOnly = true;
            this.ReturnHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ReturnHistoryDataGridView.Size = new System.Drawing.Size(638, 183);
            this.ReturnHistoryDataGridView.TabIndex = 10;
            this.ReturnHistoryDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RentalHistoryDataGridViewCellMouseDoubleClick);
            // 
            // ReturnHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.rentalHistoryInstructionLabel);
            this.Controls.Add(this.viewedMemberLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchHistoryButton);
            this.Controls.Add(this.memberIdLabel);
            this.Controls.Add(this.memberIdTextBox);
            this.Controls.Add(this.ReturnHistoryDataGridView);
            this.Controls.Add(this.ReturnHistoryTitleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ReturnHistoryUserControl";
            this.Size = new System.Drawing.Size(644, 277);
            ((System.ComponentModel.ISupportInitialize)(this.ReturnHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ReturnHistoryTitleLabel;
        private System.Windows.Forms.Label rentalHistoryInstructionLabel;
        private System.Windows.Forms.Label viewedMemberLabel;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Button searchHistoryButton;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.DataGridView ReturnHistoryDataGridView;
    }
}
