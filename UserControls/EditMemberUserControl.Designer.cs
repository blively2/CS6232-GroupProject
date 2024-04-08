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
            this.zipLabel = new System.Windows.Forms.Label();
            this.zipTextBox = new System.Windows.Forms.TextBox();
            this.contactLabel = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.updateMemberButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.memberIDLabel = new System.Windows.Forms.Label();
            this.memberIDTextBox = new System.Windows.Forms.TextBox();
            this.invalidMemberIDLabel = new System.Windows.Forms.Label();
            this.invalidInputLabel = new System.Windows.Forms.Label();
            this.getMemberButton = new System.Windows.Forms.Button();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.addressOneAlertLabel = new System.Windows.Forms.Label();
            this.genderAlertLabel = new System.Windows.Forms.Label();
            this.birthDateAlertLabel = new System.Windows.Forms.Label();
            this.lastNameAlertLabel = new System.Windows.Forms.Label();
            this.firstNameAlertLabel = new System.Windows.Forms.Label();
            this.addressTwoAlertLabel = new System.Windows.Forms.Label();
            this.phoneAlertLabel = new System.Windows.Forms.Label();
            this.zipAlertLabel = new System.Windows.Forms.Label();
            this.stateAlertLabel = new System.Windows.Forms.Label();
            this.cityAlertLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TitleLabel
            // 
            this.TitleLabel.AutoSize = true;
            this.TitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.TitleLabel.Location = new System.Drawing.Point(379, 12);
            this.TitleLabel.Name = "TitleLabel";
            this.TitleLabel.Size = new System.Drawing.Size(151, 29);
            this.TitleLabel.TabIndex = 0;
            this.TitleLabel.Text = "Edit Member";
            // 
            // firstNameLabel
            // 
            this.firstNameLabel.AutoSize = true;
            this.firstNameLabel.Location = new System.Drawing.Point(14, 104);
            this.firstNameLabel.Name = "firstNameLabel";
            this.firstNameLabel.Size = new System.Drawing.Size(90, 20);
            this.firstNameLabel.TabIndex = 0;
            this.firstNameLabel.Text = "First Name:";
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.Location = new System.Drawing.Point(133, 104);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(149, 26);
            this.firstNameTextBox.TabIndex = 2;
            this.firstNameTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // lastNameLabel
            // 
            this.lastNameLabel.AutoSize = true;
            this.lastNameLabel.Location = new System.Drawing.Point(13, 150);
            this.lastNameLabel.Name = "lastNameLabel";
            this.lastNameLabel.Size = new System.Drawing.Size(90, 20);
            this.lastNameLabel.TabIndex = 0;
            this.lastNameLabel.Text = "Last Name:";
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.Location = new System.Drawing.Point(133, 150);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(149, 26);
            this.lastNameTextBox.TabIndex = 3;
            this.lastNameTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // genderLabel
            // 
            this.genderLabel.AutoSize = true;
            this.genderLabel.Location = new System.Drawing.Point(14, 195);
            this.genderLabel.Name = "genderLabel";
            this.genderLabel.Size = new System.Drawing.Size(67, 20);
            this.genderLabel.TabIndex = 0;
            this.genderLabel.Text = "Gender:";
            // 
            // genderComboBox
            // 
            this.genderComboBox.Enabled = false;
            this.genderComboBox.FormattingEnabled = true;
            this.genderComboBox.Location = new System.Drawing.Point(133, 192);
            this.genderComboBox.Name = "genderComboBox";
            this.genderComboBox.Size = new System.Drawing.Size(149, 28);
            this.genderComboBox.TabIndex = 4;
            this.genderComboBox.TextChanged += new System.EventHandler(this.Input_Changed);
            // 
            // dateOfBirthLabel
            // 
            this.dateOfBirthLabel.AutoSize = true;
            this.dateOfBirthLabel.Location = new System.Drawing.Point(13, 243);
            this.dateOfBirthLabel.Name = "dateOfBirthLabel";
            this.dateOfBirthLabel.Size = new System.Drawing.Size(103, 20);
            this.dateOfBirthLabel.TabIndex = 0;
            this.dateOfBirthLabel.Text = "Date of Birth:";
            // 
            // dateOfBirthDatePicker
            // 
            this.dateOfBirthDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateOfBirthDatePicker.Location = new System.Drawing.Point(133, 237);
            this.dateOfBirthDatePicker.Name = "dateOfBirthDatePicker";
            this.dateOfBirthDatePicker.Size = new System.Drawing.Size(149, 26);
            this.dateOfBirthDatePicker.TabIndex = 5;
            this.dateOfBirthDatePicker.ValueChanged += new System.EventHandler(this.Input_Changed);
            // 
            // address1Label
            // 
            this.address1Label.AutoSize = true;
            this.address1Label.Location = new System.Drawing.Point(14, 288);
            this.address1Label.Name = "address1Label";
            this.address1Label.Size = new System.Drawing.Size(85, 20);
            this.address1Label.TabIndex = 0;
            this.address1Label.Text = "Address 1:";
            // 
            // address1TextBox
            // 
            this.address1TextBox.Location = new System.Drawing.Point(133, 285);
            this.address1TextBox.Name = "address1TextBox";
            this.address1TextBox.Size = new System.Drawing.Size(149, 26);
            this.address1TextBox.TabIndex = 6;
            this.address1TextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // address2Label
            // 
            this.address2Label.AutoSize = true;
            this.address2Label.Location = new System.Drawing.Point(506, 104);
            this.address2Label.Name = "address2Label";
            this.address2Label.Size = new System.Drawing.Size(85, 20);
            this.address2Label.TabIndex = 0;
            this.address2Label.Text = "Address 2:";
            // 
            // address2TextBox
            // 
            this.address2TextBox.Location = new System.Drawing.Point(623, 97);
            this.address2TextBox.Name = "address2TextBox";
            this.address2TextBox.Size = new System.Drawing.Size(144, 26);
            this.address2TextBox.TabIndex = 7;
            this.address2TextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // cityLabel
            // 
            this.cityLabel.AutoSize = true;
            this.cityLabel.Location = new System.Drawing.Point(508, 147);
            this.cityLabel.Name = "cityLabel";
            this.cityLabel.Size = new System.Drawing.Size(39, 20);
            this.cityLabel.TabIndex = 0;
            this.cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.Location = new System.Drawing.Point(623, 140);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(144, 26);
            this.cityTextBox.TabIndex = 8;
            this.cityTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(508, 190);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(52, 20);
            this.stateLabel.TabIndex = 0;
            this.stateLabel.Text = "State:";
            // 
            // zipLabel
            // 
            this.zipLabel.AutoSize = true;
            this.zipLabel.Location = new System.Drawing.Point(510, 239);
            this.zipLabel.Name = "zipLabel";
            this.zipLabel.Size = new System.Drawing.Size(35, 20);
            this.zipLabel.TabIndex = 0;
            this.zipLabel.Text = "Zip:";
            // 
            // zipTextBox
            // 
            this.zipTextBox.Location = new System.Drawing.Point(623, 236);
            this.zipTextBox.Name = "zipTextBox";
            this.zipTextBox.Size = new System.Drawing.Size(144, 26);
            this.zipTextBox.TabIndex = 10;
            this.zipTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // contactLabel
            // 
            this.contactLabel.AutoSize = true;
            this.contactLabel.Location = new System.Drawing.Point(508, 292);
            this.contactLabel.Name = "contactLabel";
            this.contactLabel.Size = new System.Drawing.Size(69, 20);
            this.contactLabel.TabIndex = 0;
            this.contactLabel.Text = "Contact:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(623, 289);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(144, 26);
            this.contactTextBox.TabIndex = 11;
            this.contactTextBox.TextChanged += new System.EventHandler(this.Input_TextChanged);
            // 
            // updateMemberButton
            // 
            this.updateMemberButton.Location = new System.Drawing.Point(113, 340);
            this.updateMemberButton.Name = "updateMemberButton";
            this.updateMemberButton.Size = new System.Drawing.Size(169, 36);
            this.updateMemberButton.TabIndex = 12;
            this.updateMemberButton.Text = "Update Member";
            this.updateMemberButton.UseVisualStyleBackColor = true;
            this.updateMemberButton.Click += new System.EventHandler(this.UpdateMemberButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(623, 340);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(122, 36);
            this.clearButton.TabIndex = 13;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // memberIDLabel
            // 
            this.memberIDLabel.AutoSize = true;
            this.memberIDLabel.Location = new System.Drawing.Point(13, 65);
            this.memberIDLabel.Name = "memberIDLabel";
            this.memberIDLabel.Size = new System.Drawing.Size(88, 20);
            this.memberIDLabel.TabIndex = 0;
            this.memberIDLabel.Text = "MemberID:";
            // 
            // memberIDTextBox
            // 
            this.memberIDTextBox.Location = new System.Drawing.Point(133, 62);
            this.memberIDTextBox.Name = "memberIDTextBox";
            this.memberIDTextBox.Size = new System.Drawing.Size(149, 26);
            this.memberIDTextBox.TabIndex = 0;
            this.memberIDTextBox.TextChanged += new System.EventHandler(this.MemberIDTextBox_TextChanged);
            // 
            // invalidMemberIDLabel
            // 
            this.invalidMemberIDLabel.AutoSize = true;
            this.invalidMemberIDLabel.Location = new System.Drawing.Point(368, 62);
            this.invalidMemberIDLabel.Name = "invalidMemberIDLabel";
            this.invalidMemberIDLabel.Size = new System.Drawing.Size(0, 20);
            this.invalidMemberIDLabel.TabIndex = 42;
            // 
            // invalidInputLabel
            // 
            this.invalidInputLabel.AutoSize = true;
            this.invalidInputLabel.Location = new System.Drawing.Point(328, 352);
            this.invalidInputLabel.Name = "invalidInputLabel";
            this.invalidInputLabel.Size = new System.Drawing.Size(0, 20);
            this.invalidInputLabel.TabIndex = 43;
            // 
            // getMemberButton
            // 
            this.getMemberButton.Location = new System.Drawing.Point(288, 54);
            this.getMemberButton.Name = "getMemberButton";
            this.getMemberButton.Size = new System.Drawing.Size(74, 29);
            this.getMemberButton.TabIndex = 1;
            this.getMemberButton.Text = "Get";
            this.getMemberButton.UseVisualStyleBackColor = true;
            this.getMemberButton.Click += new System.EventHandler(this.GetMemberButton_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(623, 187);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(144, 28);
            this.stateComboBox.TabIndex = 9;
            this.stateComboBox.TextChanged += new System.EventHandler(this.Input_Changed);
            // 
            // addressOneAlertLabel
            // 
            this.addressOneAlertLabel.AutoSize = true;
            this.addressOneAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressOneAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.addressOneAlertLabel.Location = new System.Drawing.Point(288, 292);
            this.addressOneAlertLabel.Name = "addressOneAlertLabel";
            this.addressOneAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.addressOneAlertLabel.TabIndex = 50;
            // 
            // genderAlertLabel
            // 
            this.genderAlertLabel.AutoSize = true;
            this.genderAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.genderAlertLabel.Location = new System.Drawing.Point(288, 193);
            this.genderAlertLabel.Name = "genderAlertLabel";
            this.genderAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.genderAlertLabel.TabIndex = 49;
            // 
            // birthDateAlertLabel
            // 
            this.birthDateAlertLabel.AutoSize = true;
            this.birthDateAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.birthDateAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.birthDateAlertLabel.Location = new System.Drawing.Point(288, 236);
            this.birthDateAlertLabel.Name = "birthDateAlertLabel";
            this.birthDateAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.birthDateAlertLabel.TabIndex = 48;
            // 
            // lastNameAlertLabel
            // 
            this.lastNameAlertLabel.AutoSize = true;
            this.lastNameAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lastNameAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.lastNameAlertLabel.Location = new System.Drawing.Point(288, 150);
            this.lastNameAlertLabel.Name = "lastNameAlertLabel";
            this.lastNameAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.lastNameAlertLabel.TabIndex = 47;
            // 
            // firstNameAlertLabel
            // 
            this.firstNameAlertLabel.AutoSize = true;
            this.firstNameAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.firstNameAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.firstNameAlertLabel.Location = new System.Drawing.Point(288, 104);
            this.firstNameAlertLabel.Name = "firstNameAlertLabel";
            this.firstNameAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.firstNameAlertLabel.TabIndex = 46;
            // 
            // addressTwoAlertLabel
            // 
            this.addressTwoAlertLabel.AutoSize = true;
            this.addressTwoAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addressTwoAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.addressTwoAlertLabel.Location = new System.Drawing.Point(773, 95);
            this.addressTwoAlertLabel.Name = "addressTwoAlertLabel";
            this.addressTwoAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.addressTwoAlertLabel.TabIndex = 55;
            // 
            // phoneAlertLabel
            // 
            this.phoneAlertLabel.AutoSize = true;
            this.phoneAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.phoneAlertLabel.Location = new System.Drawing.Point(773, 288);
            this.phoneAlertLabel.Name = "phoneAlertLabel";
            this.phoneAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.phoneAlertLabel.TabIndex = 54;
            // 
            // zipAlertLabel
            // 
            this.zipAlertLabel.AutoSize = true;
            this.zipAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.zipAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.zipAlertLabel.Location = new System.Drawing.Point(773, 232);
            this.zipAlertLabel.Name = "zipAlertLabel";
            this.zipAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.zipAlertLabel.TabIndex = 53;
            // 
            // stateAlertLabel
            // 
            this.stateAlertLabel.AutoSize = true;
            this.stateAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.stateAlertLabel.Location = new System.Drawing.Point(773, 193);
            this.stateAlertLabel.Name = "stateAlertLabel";
            this.stateAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.stateAlertLabel.TabIndex = 52;
            // 
            // cityAlertLabel
            // 
            this.cityAlertLabel.AutoSize = true;
            this.cityAlertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cityAlertLabel.ForeColor = System.Drawing.Color.Red;
            this.cityAlertLabel.Location = new System.Drawing.Point(773, 142);
            this.cityAlertLabel.Name = "cityAlertLabel";
            this.cityAlertLabel.Size = new System.Drawing.Size(0, 20);
            this.cityAlertLabel.TabIndex = 51;
            // 
            // EditMemberUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.addressTwoAlertLabel);
            this.Controls.Add(this.phoneAlertLabel);
            this.Controls.Add(this.zipAlertLabel);
            this.Controls.Add(this.stateAlertLabel);
            this.Controls.Add(this.cityAlertLabel);
            this.Controls.Add(this.addressOneAlertLabel);
            this.Controls.Add(this.genderAlertLabel);
            this.Controls.Add(this.birthDateAlertLabel);
            this.Controls.Add(this.lastNameAlertLabel);
            this.Controls.Add(this.firstNameAlertLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(this.getMemberButton);
            this.Controls.Add(this.invalidInputLabel);
            this.Controls.Add(this.invalidMemberIDLabel);
            this.Controls.Add(this.memberIDTextBox);
            this.Controls.Add(this.memberIDLabel);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.updateMemberButton);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.contactLabel);
            this.Controls.Add(this.zipTextBox);
            this.Controls.Add(this.zipLabel);
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
            this.Size = new System.Drawing.Size(970, 398);
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
        private System.Windows.Forms.Label zipLabel;
        private System.Windows.Forms.TextBox zipTextBox;
        private System.Windows.Forms.Label contactLabel;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button updateMemberButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Label memberIDLabel;
        private System.Windows.Forms.TextBox memberIDTextBox;
        private System.Windows.Forms.Label invalidMemberIDLabel;
        private System.Windows.Forms.Label invalidInputLabel;
        private System.Windows.Forms.Button getMemberButton;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.Label addressOneAlertLabel;
        private System.Windows.Forms.Label genderAlertLabel;
        private System.Windows.Forms.Label birthDateAlertLabel;
        private System.Windows.Forms.Label lastNameAlertLabel;
        private System.Windows.Forms.Label firstNameAlertLabel;
        private System.Windows.Forms.Label addressTwoAlertLabel;
        private System.Windows.Forms.Label phoneAlertLabel;
        private System.Windows.Forms.Label zipAlertLabel;
        private System.Windows.Forms.Label stateAlertLabel;
        private System.Windows.Forms.Label cityAlertLabel;
    }
}
