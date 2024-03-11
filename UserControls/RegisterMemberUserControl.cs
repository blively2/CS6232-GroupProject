using System;
using System.Drawing;
using System.Windows.Forms;
using SofaSoGood.Controller;
using SofaSoGood.Model;

namespace SofaSoGood
{
    public partial class RegisterMemberUserControl : UserControl
    {
        private MemberController memberController;

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

                if (memberController.AddMember(member))
                {
                    registerMemberAlertLabel.ForeColor = Color.Green;
                    registerMemberAlertLabel.Text = "Member registered successfully!";
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
    }
}
