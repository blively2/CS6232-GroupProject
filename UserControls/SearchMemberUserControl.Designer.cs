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
            this.titleLabel = new System.Windows.Forms.Label();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.searchByMemberIDButton = new System.Windows.Forms.Button();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.customerIDLabel = new System.Windows.Forms.Label();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.searchByPhoneButton = new System.Windows.Forms.Button();
            this.searchByNameButton = new System.Windows.Forms.Button();
            this.MemberIDWarningLabel = new System.Windows.Forms.Label();
            this.phoneWarningLabel = new System.Windows.Forms.Label();
            this.nameWarningLabel = new System.Windows.Forms.Label();
            this.memberListView = new System.Windows.Forms.ListView();
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
            this.clearButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.titleLabel.Location = new System.Drawing.Point(244, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(273, 40);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Search Member";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(123, 110);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(171, 26);
            this.phoneTextBox.TabIndex = 26;
            this.phoneTextBox.TextChanged += new System.EventHandler(this.PhoneTextBoxTextChanged);
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(123, 70);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(171, 26);
            this.memberIDTextBox.TabIndex = 25;
            this.memberIDTextBox.TextChanged += new System.EventHandler(this.MemberIDTextBoxTextChanged);
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(123, 157);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(171, 26);
            this.firstNameTextBox.TabIndex = 24;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(123, 200);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(171, 26);
            this.lastNameTextBox.TabIndex = 23;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.NameTextBoxTextChanged);
            // 
            // searchByMemberIDButton
            // 
            this.searchByMemberIDButton.Location = new System.Drawing.Point(300, 70);
            this.searchByMemberIDButton.Name = "searchByMemberIDButton";
            this.searchByMemberIDButton.Size = new System.Drawing.Size(200, 30);
            this.searchByMemberIDButton.TabIndex = 22;
            this.searchByMemberIDButton.Text = "By Member ID";
            this.searchByMemberIDButton.UseVisualStyleBackColor = true;
            this.searchByMemberIDButton.Click += new System.EventHandler(this.SearchByMemberIDButtonClick);
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(47, 113);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(59, 20);
            this.phoneLabel.TabIndex = 21;
            this.phoneLabel.Text = "Phone:";
            // 
            // customerIDLabel
            // 
            this.customerIDLabel.AutoSize = true;
            this.customerIDLabel.Location = new System.Drawing.Point(3, 73);
            this.customerIDLabel.Name = "customerIDLabel";
            this.customerIDLabel.Size = new System.Drawing.Size(92, 20);
            this.customerIDLabel.TabIndex = 20;
            this.customerIDLabel.Text = "Member ID:";
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(16, 203);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 19;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(16, 160);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 18;
            this.firstNameLabel.Text = "First Name:";
            // 
            // searchByPhoneButton
            // 
            this.searchByPhoneButton.Location = new System.Drawing.Point(300, 110);
            this.searchByPhoneButton.Name = "searchByPhoneButton";
            this.searchByPhoneButton.Size = new System.Drawing.Size(200, 30);
            this.searchByPhoneButton.TabIndex = 27;
            this.searchByPhoneButton.Text = "By Phone";
            this.searchByPhoneButton.UseVisualStyleBackColor = true;
            this.searchByPhoneButton.Click += new System.EventHandler(this.SearchByPhoneButtonClick);
            // 
            // searchByNameButton
            // 
            this.searchByNameButton.Location = new System.Drawing.Point(300, 157);
            this.searchByNameButton.Name = "searchByNameButton";
            this.searchByNameButton.Size = new System.Drawing.Size(200, 30);
            this.searchByNameButton.TabIndex = 28;
            this.searchByNameButton.Text = "By Name";
            this.searchByNameButton.UseVisualStyleBackColor = true;
            this.searchByNameButton.Click += new System.EventHandler(this.SearchByNameButtonClick);
            // 
            // MemberIDWarningLabel
            // 
            this.MemberIDWarningLabel.AutoSize = true;
            this.MemberIDWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.MemberIDWarningLabel.Location = new System.Drawing.Point(506, 76);
            this.MemberIDWarningLabel.Name = "MemberIDWarningLabel";
            this.MemberIDWarningLabel.Size = new System.Drawing.Size(133, 20);
            this.MemberIDWarningLabel.TabIndex = 29;
            this.MemberIDWarningLabel.Text = "Invalid MemberID";
            // 
            // phoneWarningLabel
            // 
            this.phoneWarningLabel.AutoSize = true;
            this.phoneWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneWarningLabel.Location = new System.Drawing.Point(506, 116);
            this.phoneWarningLabel.Name = "phoneWarningLabel";
            this.phoneWarningLabel.Size = new System.Drawing.Size(108, 20);
            this.phoneWarningLabel.TabIndex = 30;
            this.phoneWarningLabel.Text = "Invalid Phone ";
            // 
            // nameWarningLabel
            // 
            this.nameWarningLabel.AutoSize = true;
            this.nameWarningLabel.ForeColor = System.Drawing.Color.Red;
            this.nameWarningLabel.Location = new System.Drawing.Point(506, 163);
            this.nameWarningLabel.Name = "nameWarningLabel";
            this.nameWarningLabel.Size = new System.Drawing.Size(100, 20);
            this.nameWarningLabel.TabIndex = 31;
            this.nameWarningLabel.Text = "Invalid Name";
            // 
            // memberListView
            // 
            this.memberListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
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
            this.memberListView.HideSelection = false;
            this.memberListView.Location = new System.Drawing.Point(0, 288);
            this.memberListView.Name = "memberListView";
            this.memberListView.Size = new System.Drawing.Size(776, 110);
            this.memberListView.TabIndex = 32;
            this.memberListView.UseCompatibleStateImageBehavior = false;
            this.memberListView.View = System.Windows.Forms.View.Details;
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
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(300, 198);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(200, 30);
            this.clearButton.TabIndex = 33;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButtonClick);
            // 
            // SearchMemberUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.memberListView);
            this.Controls.Add(this.nameWarningLabel);
            this.Controls.Add(this.phoneWarningLabel);
            this.Controls.Add(this.MemberIDWarningLabel);
            this.Controls.Add(this.searchByNameButton);
            this.Controls.Add(this.searchByPhoneButton);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.searchByMemberIDButton);
            this.Controls.Add(this.phoneLabel);
            this.Controls.Add(this.customerIDLabel);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.titleLabel);
            this.Name = "SearchMemberUserControl";
            this.Size = new System.Drawing.Size(776, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Button searchByMemberIDButton;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.Label customerIDLabel;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.Button searchByPhoneButton;
        private System.Windows.Forms.Button searchByNameButton;
        private System.Windows.Forms.Label MemberIDWarningLabel;
        private System.Windows.Forms.Label phoneWarningLabel;
        private System.Windows.Forms.Label nameWarningLabel;
        private System.Windows.Forms.ListView memberListView;
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
        private System.Windows.Forms.Button clearButton;
    }
}
