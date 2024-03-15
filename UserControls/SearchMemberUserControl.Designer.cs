namespace SofaSoGood.UserControls
{
    partial class SearchMemberUserControl
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
            this.searchMemberLabel = new System.Windows.Forms.Label();
            this.searchMemberTextBox = new System.Windows.Forms.TextBox();
            this.searchMemberButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleLabel.Location = new System.Drawing.Point(269, 23);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(273, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Search Member";
            // 
            // searchMemberLabel
            // 
            this.searchMemberLabel.AutoSize = true;
            this.searchMemberLabel.Location = new System.Drawing.Point(62, 96);
            this.searchMemberLabel.Name = "searchMemberLabel";
            this.searchMemberLabel.Size = new System.Drawing.Size(85, 13);
            this.searchMemberLabel.TabIndex = 2;
            this.searchMemberLabel.Text = "Search Member:";
            // 
            // searchMemberTextBox
            // 
            this.searchMemberTextBox.Location = new System.Drawing.Point(215, 96);
            this.searchMemberTextBox.Name = "searchMemberTextBox";
            this.searchMemberTextBox.Size = new System.Drawing.Size(171, 20);
            this.searchMemberTextBox.TabIndex = 15;
            // 
            // searchMemberButton
            // 
            this.searchMemberButton.Location = new System.Drawing.Point(410, 88);
            this.searchMemberButton.Name = "searchMemberButton";
            this.searchMemberButton.Size = new System.Drawing.Size(144, 35);
            this.searchMemberButton.TabIndex = 16;
            this.searchMemberButton.Text = "Search Member";
            this.searchMemberButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(576, 85);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(153, 35);
            this.clearButton.TabIndex = 17;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(172, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(505, 25);
            this.label1.TabIndex = 18;
            this.label1.Text = "Can Search By First and Last Name/ Contact/ MemberID";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(29, 140);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(717, 232);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SearchMemberUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.searchMemberButton);
            this.Controls.Add(this.searchMemberTextBox);
            this.Controls.Add(this.searchMemberLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "SearchMemberUserControl";
            this.Size = new System.Drawing.Size(776, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label searchMemberLabel;
        private System.Windows.Forms.TextBox searchMemberTextBox;
        private System.Windows.Forms.Button searchMemberButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
    }
}
