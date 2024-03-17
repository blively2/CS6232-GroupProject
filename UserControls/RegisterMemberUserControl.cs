using System;
using System.Collections.Generic;
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
            InitializeStateComboBox();
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
                    State = stateComboBox.SelectedItem.ToString(),
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
            registerMemberAlertLabel.Text = "";

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                registerMemberAlertLabel.Text += "First Name is required.\n";
                return false;
            }
            else if (firstNameTextBox.Text.Length > 200)
            {
                registerMemberAlertLabel.Text += "First Name cannot exceed 200 characters.\n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                registerMemberAlertLabel.Text += "Last Name is required.\n";
                return false;
            }
            else if (lastNameTextBox.Text.Length > 200)
            {
                registerMemberAlertLabel.Text += "Last Name cannot exceed 200 characters.\n";
                return false;
            }

            if (genderComboBox.SelectedIndex == -1)
            {
                registerMemberAlertLabel.Text += "Gender selection is required.\n";
                return false;
            }

            if (dateOfBirthDatePicker.Value >= DateTime.Now)
            {
                registerMemberAlertLabel.Text += "Date of Birth must be in the past.\n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                registerMemberAlertLabel.Text += "Address 1 is required.\n";
                return false;
            }
            else if (address1TextBox.Text.Length > 150)
            {
                registerMemberAlertLabel.Text += "Address 1 cannot exceed 150 characters.\n";
                return false;
            }
            
            if (address2TextBox.Text.Length > 150)
            {
                registerMemberAlertLabel.Text += "Address 2 cannot exceed 150 characters.\n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                registerMemberAlertLabel.Text += "City is required.\n";
                return false;
            }
            else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z\s]+$") || cityTextBox.Text.Length > 45)
            {
                registerMemberAlertLabel.Text += "City must be alphabetical and cannot exceed 45 characters.\n";
                return false;
            }

            if (stateComboBox.SelectedIndex == -1)
            {
                registerMemberAlertLabel.Text += "State selection is required.\n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(zipTextBox.Text) || !Regex.IsMatch(zipTextBox.Text, @"^\d{5}$"))
            {
                registerMemberAlertLabel.Text += "A valid 5-digit Zip code is required.\n";
                return false;
            }

            if (string.IsNullOrWhiteSpace(contactPhoneTextBox.Text) || !Regex.IsMatch(contactPhoneTextBox.Text, @"^\d{10}$"))
            {
                registerMemberAlertLabel.Text += "A valid 10-digit Contact Phone number is required.\n";
                return false;
            }

            return registerMemberAlertLabel.Text == "";
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
            stateComboBox.SelectedIndex = -1;
            zipTextBox.Clear();
            contactPhoneTextBox.Clear();
        }

        private void InitializeGenderComboBox()
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = -1;
        }

        private void InitializeStateComboBox()
        {
            var states = new List<string> { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL",
                "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM",
                "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            stateComboBox.Items.AddRange(states.ToArray());
            stateComboBox.SelectedIndex = -1;
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
