namespace SofaSoGood.UserControls
{
    partial class RentalHistoryUserControl
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
            this.rentalHistoryDataGridView = new System.Windows.Forms.DataGridView();
            this.memberIdTextBox = new System.Windows.Forms.TextBox();
            this.rentalHistoryTitleLabel = new System.Windows.Forms.Label();
            this.memberIdLabel = new System.Windows.Forms.Label();
            this.searchHistoryButton = new System.Windows.Forms.Button();
            this.clearSearchButton = new System.Windows.Forms.Button();
            this.errorMessageLabel = new System.Windows.Forms.Label();
            this.viewedMemberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // rentalHistoryDataGridView
            // 
            this.rentalHistoryDataGridView.AllowUserToAddRows = false;
            this.rentalHistoryDataGridView.AllowUserToDeleteRows = false;
            this.rentalHistoryDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.rentalHistoryDataGridView.Location = new System.Drawing.Point(4, 112);
            this.rentalHistoryDataGridView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.rentalHistoryDataGridView.MultiSelect = false;
            this.rentalHistoryDataGridView.Name = "rentalHistoryDataGridView";
            this.rentalHistoryDataGridView.ReadOnly = true;
            this.rentalHistoryDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.rentalHistoryDataGridView.Size = new System.Drawing.Size(957, 303);
            this.rentalHistoryDataGridView.TabIndex = 0;
            this.rentalHistoryDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.RentalHistoryDataGridViewCellMouseDoubleClick);
            // 
            // memberIdTextBox
            // 
            this.memberIdTextBox.Location = new System.Drawing.Point(178, 65);
            this.memberIdTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.memberIdTextBox.Name = "memberIdTextBox";
            this.memberIdTextBox.Size = new System.Drawing.Size(148, 26);
            this.memberIdTextBox.TabIndex = 0;
            this.memberIdTextBox.TextChanged += new System.EventHandler(this.MemberIdTextBox_TextChanged);
            // 
            // rentalHistoryTitleLabel
            // 
            this.rentalHistoryTitleLabel.AutoSize = true;
            this.rentalHistoryTitleLabel.Location = new System.Drawing.Point(386, 20);
            this.rentalHistoryTitleLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rentalHistoryTitleLabel.Name = "rentalHistoryTitleLabel";
            this.rentalHistoryTitleLabel.Size = new System.Drawing.Size(147, 20);
            this.rentalHistoryTitleLabel.TabIndex = 2;
            this.rentalHistoryTitleLabel.Text = "View Rental History";
            // 
            // memberIdLabel
            // 
            this.memberIdLabel.AutoSize = true;
            this.memberIdLabel.Location = new System.Drawing.Point(76, 72);
            this.memberIdLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.memberIdLabel.Name = "memberIdLabel";
            this.memberIdLabel.Size = new System.Drawing.Size(92, 20);
            this.memberIdLabel.TabIndex = 3;
            this.memberIdLabel.Text = "Member ID:";
            // 
            // searchHistoryButton
            // 
            this.searchHistoryButton.Location = new System.Drawing.Point(338, 60);
            this.searchHistoryButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchHistoryButton.Name = "searchHistoryButton";
            this.searchHistoryButton.Size = new System.Drawing.Size(112, 35);
            this.searchHistoryButton.TabIndex = 1;
            this.searchHistoryButton.Text = "Search";
            this.searchHistoryButton.UseVisualStyleBackColor = true;
            this.searchHistoryButton.Click += new System.EventHandler(this.SearchHistoryButton_Click);
            // 
            // clearSearchButton
            // 
            this.clearSearchButton.Location = new System.Drawing.Point(459, 60);
            this.clearSearchButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clearSearchButton.Name = "clearSearchButton";
            this.clearSearchButton.Size = new System.Drawing.Size(112, 35);
            this.clearSearchButton.TabIndex = 2;
            this.clearSearchButton.Text = "Clear";
            this.clearSearchButton.UseVisualStyleBackColor = true;
            this.clearSearchButton.Click += new System.EventHandler(this.ClearSearchButton_Click);
            // 
            // errorMessageLabel
            // 
            this.errorMessageLabel.AutoSize = true;
            this.errorMessageLabel.Location = new System.Drawing.Point(580, 68);
            this.errorMessageLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorMessageLabel.Name = "errorMessageLabel";
            this.errorMessageLabel.Size = new System.Drawing.Size(0, 20);
            this.errorMessageLabel.TabIndex = 6;
            // 
            // viewedMemberLabel
            // 
            this.viewedMemberLabel.AutoSize = true;
            this.viewedMemberLabel.Location = new System.Drawing.Point(580, 68);
            this.viewedMemberLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.viewedMemberLabel.Name = "viewedMemberLabel";
            this.viewedMemberLabel.Size = new System.Drawing.Size(0, 20);
            this.viewedMemberLabel.TabIndex = 7;
            // 
            // RentalHistoryUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.viewedMemberLabel);
            this.Controls.Add(this.errorMessageLabel);
            this.Controls.Add(this.clearSearchButton);
            this.Controls.Add(this.searchHistoryButton);
            this.Controls.Add(this.memberIdLabel);
            this.Controls.Add(this.rentalHistoryTitleLabel);
            this.Controls.Add(this.memberIdTextBox);
            this.Controls.Add(this.rentalHistoryDataGridView);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "RentalHistoryUserControl";
            this.Size = new System.Drawing.Size(966, 426);
            ((System.ComponentModel.ISupportInitialize)(this.rentalHistoryDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView rentalHistoryDataGridView;
        private System.Windows.Forms.TextBox memberIdTextBox;
        private System.Windows.Forms.Label rentalHistoryTitleLabel;
        private System.Windows.Forms.Label memberIdLabel;
        private System.Windows.Forms.Button searchHistoryButton;
        private System.Windows.Forms.Button clearSearchButton;
        private System.Windows.Forms.Label errorMessageLabel;
        private System.Windows.Forms.Label viewedMemberLabel;
    }
}
