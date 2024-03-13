using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SofaSoGood.Controller;
using SofaSoGood.Model;

namespace SofaSoGood
{
    public partial class RegisterMemberUserControl : UserControl
    {
        private readonly MemberController memberController;

        public RegisterMemberUserControl()
        {
            InitializeComponent();
            memberController = new MemberController();
            InitializeGenderComboBox();
        }

        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
                registerMemberAlertLabel.ForeColor = Color.Red;
                return;
            }

            try
            {
                var member = new Member
                {
                    FirstName = firstNameTextBox.Text,
                    LastName = lastNameTextBox.Text,
                    Gender = genderComboBox.SelectedItem.ToString(),
                    DateOfBirth = dateOfBirthDatePicker.Value,
                    Address1 = address1TextBox.Text,
                    Address2 = address2TextBox.Text,
                    City = cityTextBox.Text,
                    State = stateTextBox.Text,
                    Zip = zipTextBox.Text,
                    ContactPhone = contactPhoneTextBox.Text
                };

                int newMemberId = memberController.AddMember(member);
                if (newMemberId > 0)
                {
                    registerMemberAlertLabel.ForeColor = Color.Green;
                    registerMemberAlertLabel.Text = "Member registered successfully!";
                    ShowSuccessDialog(newMemberId);
                    ClearForm();
                }
                else
                {
                    registerMemberAlertLabel.ForeColor = Color.Red;
                    registerMemberAlertLabel.Text = "Failed to register member.";
                }
            }
            catch (Exception ex)
            {
                registerMemberAlertLabel.ForeColor = Color.Red;
                registerMemberAlertLabel.Text = "An error occurred: " + ex.Message;
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            registerMemberAlertLabel.Text = string.Empty;
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                registerMemberAlertLabel.Text = "First Name is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                registerMemberAlertLabel.Text = "Last Name is required.";
                return false;
            }
            if (genderComboBox.SelectedIndex == -1)
            {
                registerMemberAlertLabel.Text = "Gender selection is required.";
                return false;
            }
            if (dateOfBirthDatePicker.Value >= DateTime.Now)
            {
                registerMemberAlertLabel.Text = "Date of Birth must be in the past.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                registerMemberAlertLabel.Text = "Address 1 is required.";
                return false;
            }
            if (string.IsNullOrWhiteSpace(address2TextBox.Text))
            {
                registerMemberAlertLabel.Text = "Address 2 is required.";
                return false;
            }
        
            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                registerMemberAlertLabel.Text += "City cannot be empty. \n";
                return false;

            }
            else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z\s]+$"))
            {
                registerMemberAlertLabel.Text += "City must be alphabetical. \n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(stateTextBox.Text))
            {
                registerMemberAlertLabel.Text += "State cannot be empty. \n";
                return false;

            }
            else if (!Regex.IsMatch(stateTextBox.Text, @"^[a-zA-Z\s]+$"))
            {
                registerMemberAlertLabel.Text += "State must be alphabetical. \n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(zipTextBox.Text) || !Regex.IsMatch(zipTextBox.Text, @"^\d{5}$"))
            {
                registerMemberAlertLabel.Text = "A valid 5-digit Zip code is required.";
                return false;
            }

            if (string.IsNullOrWhiteSpace(contactPhoneTextBox.Text) || contactPhoneTextBox.Text.Length != 10)
            {
                registerMemberAlertLabel.Text = "A valid 10-digit Contact Phone number is required.";
                return false;
            }
            registerMemberAlertLabel.Text = "";
            return true;
        }

        private void ClearForm()
        {
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            genderComboBox.SelectedIndex = -1;
            dateOfBirthDatePicker.Value = DateTime.Now;
            address1TextBox.Clear();
            address2TextBox.Clear();
            cityTextBox.Clear();
            stateTextBox.Clear();
            zipTextBox.Clear();
            contactPhoneTextBox.Clear();
        }

        private void InitializeGenderComboBox()
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = -1;
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            registerMemberAlertLabel.Text = "";
        }

        private void Input_Changed(object sender, EventArgs e)
        {
            registerMemberAlertLabel.Text = "";
        }

        private void ShowSuccessDialog(int memberId)
        {
            string message = $"Member registered successfully! Member ID: {memberId}";
            string title = "Registration Successful";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            DialogResult result = MessageBox.Show(message, title, buttons);
        }
    }
}
