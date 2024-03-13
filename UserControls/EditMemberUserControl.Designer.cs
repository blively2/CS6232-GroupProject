namespace SofaSoGood.UserControls
{
    partial class EditMemberUserControl
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
            this.firstNameLabel = new System.Windows.Forms.Label();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameLabel = new System.Windows.Forms.Label();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.genderLabel = new System.Windows.Forms.Label();
            this.genderComboBox = new System.Windows.Forms.ComboBox();
            this.dateOfBirthLabel = new System.Windows.Forms.Label();
            this.dateOfBirthDatePicker = new System.Windows.Forms.DateTimePicker();
            this.address1Label = new System.Windows.Forms.Label();
            this.address1TextBox = new System.Windows.Forms.TextBox();
            this.address2Label = new System.Windows.Forms.Label();
            this.address2TextBox = new System.Windows.Forms.TextBox();
            this.cityLabel = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateLabel = new System.Windows.Forms.Label();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.addMemberButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.invalidMemberIDLabel = new System.Windows.Forms.Label();
            this.invalidInputLabel = new System.Windows.Forms.Label();
            this.getMemberButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleLabel.Location = new System.Drawing.Point(278, 16);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(221, 40);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Edit Member";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(44, 104);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(60, 13);
            this.firstNameLabel.TabIndex = 3;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(171, 104);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.firstNameTextBox.TabIndex = 15;
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(43, 150);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(61, 13);
            this.lastNameLabel.TabIndex = 16;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(171, 150);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(171, 20);
            this.lastNameTextBox.TabIndex = 17;
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(48, 198);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(45, 13);
            this.genderLabel.TabIndex = 18;
            this.genderLabel.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(171, 190);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(171, 21);
            this.genderComboBox.TabIndex = 23;
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(44, 245);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(69, 13);
            this.dateOfBirthLabel.TabIndex = 24;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirthDatePicker
            // 
            this.dateOfBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDatePicker.Location = new System.Drawing.Point(171, 239);
            this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            this.dateOfBirthDatePicker.Size = new System.Drawing.Size(171, 20);
            this.dateOfBirthDatePicker.TabIndex = 25;
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(44, 288);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(57, 13);
            this.address1Label.TabIndex = 26;
            this.address1Label.Text = "Address 1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(171, 285);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(171, 20);
            this.address1TextBox.TabIndex = 27;
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(374, 104);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(57, 13);
            this.address2Label.TabIndex = 28;
            this.address2Label.Text = "Address 2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(491, 97);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(163, 20);
            this.address2TextBox.TabIndex = 29;
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(376, 147);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(27, 13);
            this.cityLabel.TabIndex = 30;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(491, 140);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(163, 20);
            this.cityTextBox.TabIndex = 31;
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(376, 190);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(35, 13);
            this.stateLabel.TabIndex = 32;
            this.stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.Location = new System.Drawing.Point(491, 190);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(163, 20);
            this.stateTextBox.TabIndex = 33;
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(378, 239);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(25, 13);
            this.zipLabel.TabIndex = 34;
            this.zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(491, 236);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(163, 20);
            this.zipTextBox.TabIndex = 35;
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(376, 292);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(47, 13);
            this.contactLabel.TabIndex = 36;
            this.contactLabel.Text = "Contact:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(491, 281);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(163, 20);
            this.contactTextBox.TabIndex = 37;
            // 
            // addMemberButton
            // 
            this.addMemberButton.Location = new System.Drawing.Point(51, 340);
            this.addMemberButton.Name = "addMemberButton";
            this.addMemberButton.Size = new System.Drawing.Size(199, 36);
            this.addMemberButton.TabIndex = 38;
            this.addMemberButton.Text = "Update Member";
            this.addMemberButton.UseVisualStyleBackColor = true;
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(504, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(150, 36);
            this.clearButton.TabIndex = 39;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Location = new System.Drawing.Point(48, 62);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(59, 13);
            this.memberIDLabel.TabIndex = 40;
            this.memberIDLabel.Text = "MemberID:";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(171, 62);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(171, 20);
            this.memberIDTextBox.TabIndex = 41;
            // 
            // invalidMemberIDLabel
            // 
            this.invalidMemberIDLabel.AutoSize = true;
            this.invalidMemberIDLabel.Location = new System.Drawing.Point(514, 65);
            this.invalidMemberIDLabel.Name = "invalidMemberIDLabel";
            this.invalidMemberIDLabel.Size = new System.Drawing.Size(87, 13);
            this.invalidMemberIDLabel.TabIndex = 42;
            this.invalidMemberIDLabel.Text = "InvalidMemberID";
            // 
            // invalidInputLabel
            // 
            this.invalidInputLabel.AutoSize = true;
            this.invalidInputLabel.Location = new System.Drawing.Point(282, 352);
            this.invalidInputLabel.Name = "invalidInputLabel";
            this.invalidInputLabel.Size = new System.Drawing.Size(87, 13);
            this.invalidInputLabel.TabIndex = 43;
            this.invalidInputLabel.Text = "invalidInputLabel";
            // 
            // getMemberButton
            // 
            this.getMemberButton.Location = new System.Drawing.Point(379, 59);
            this.getMemberButton.Name = "getMemberButton";
            this.getMemberButton.Size = new System.Drawing.Size(74, 29);
            this.getMemberButton.TabIndex = 44;
            this.getMemberButton.Text = "Get";
            this.getMemberButton.UseVisualStyleBackColor = true;
            this.getMemberButton.Click += new System.EventHandler(this.GetMemberButton_Click);
            // 
            // EditMemberUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.getMemberButton);
            this.Controls.Add(this.invalidInputLabel);
            this.Controls.Add(this.invalidMemberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.addMemberButton);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.cityLabel);
            this.Controls.Add(this.address2TextBox);
            this.Controls.Add(this.address2Label);
            this.Controls.Add(this.address1TextBox);
            this.Controls.Add(this.address1Label);
            this.Controls.Add(this.dateOfBirthDatePicker);
            this.Controls.Add(this.dateOfBirthLabel);
            this.Controls.Add(this.genderComboBox);
            this.Controls.Add(this.genderLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(this.lastNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Controls.Add(this.firstNameLabel);
            this.Controls.Add(this.TitleLabel);
            this.Name = "EditMemberUserControl";
            this.Size = new System.Drawing.Size(776, 398);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TitleLabel;
        private System.Windows.Forms.Label firstNameLabel;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.Label lastNameLabel;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.Label genderLabel;
        private System.Windows.Forms.ComboBox genderComboBox;
        private System.Windows.Forms.Label dateOfBirthLabel;
        private System.Windows.Forms.DateTimePicker dateOfBirthDatePicker;
        private System.Windows.Forms.Label address1Label;
        private System.Windows.Forms.TextBox address1TextBox;
        private System.Windows.Forms.Label address2Label;
        private System.Windows.Forms.TextBox address2TextBox;
        private System.Windows.Forms.Label cityLabel;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button addMemberButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Label invalidMemberIDLabel;
        private System.Windows.Forms.Label invalidInputLabel;
        private System.Windows.Forms.Button getMemberButton;
    }
}
