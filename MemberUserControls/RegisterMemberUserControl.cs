using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using SofaSoGood.Controller;
using SofaSoGood.Model;

namespace SofaSoGood
{
    /// <summary>
    /// UserControl for Register Customers in the database.
    /// Has an MemberController instance to interact with the DB.
    /// </summary>
    public partial class RegisterMemberUserControl : UserControl
    {
        private readonly MemberController memberController;

        /// <summary>
        /// Constructor for RegisterMemberUserControl.
        /// Initializes the controller and the component for the UI.
        /// </summary>
        public RegisterMemberUserControl()
        {
            InitializeComponent();
            memberController = new MemberController();
            InitializeGenderComboBox();
            InitializeStateComboBox();
        }

        /// <summary>
        /// Handles the Click event of the AddMemberButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void AddMemberButton_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs())
            {
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
                    confirmationAlertLabel.ForeColor = Color.Green;
                    confirmationAlertLabel.Text = "Member registered successfully!";
                    ShowSuccessDialog(newMemberId);
                    ClearForm();
                }
                else
                {
                    confirmationAlertLabel.ForeColor = Color.Red;
                    confirmationAlertLabel.Text = "Failed to register member.";
                }
            }
            catch (Exception ex)
            {
                confirmationAlertLabel.ForeColor = Color.Red;
                confirmationAlertLabel.Text = "An error occurred: " + ex.Message;
            }
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            firstNameAlertLabel.Text = string.Empty;
        }

        /// <summary>
        /// Validates the inputs.
        /// </summary>
        /// <returns></returns>
        private bool ValidateInputs()
        {
            bool isValid = true;

            firstNameAlertLabel.Text = "";
            lastNameAlertLabel.Text = "";
            genderAlertLabel.Text = "";
            birthDateAlertLabel.Text = "";
            addressOneAlertLabel.Text = "";
            addressTwoAlertLabel.Text = "";
            cityAlertLabel.Text = "";
            stateAlertLabel.Text = "";
            zipAlertLabel.Text = "";
            phoneAlertLabel.Text = "";

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                firstNameAlertLabel.Text = "First Name required.";
                isValid = false;
            }
            else if (firstNameTextBox.Text.Length > 200)
            {
                firstNameAlertLabel.Text = "First Name cannot exceed 200 characters.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameAlertLabel.Text = "Last Name required.";
                isValid = false;
            }
            else if (lastNameTextBox.Text.Length > 200)
            {
                lastNameAlertLabel.Text = "Last Name cannot exceed 200 characters.";
                isValid = false;
            }

            if (genderComboBox.SelectedIndex == -1)
            {
                genderAlertLabel.Text = "Gender selection required.";
                isValid = false;
            }

            if (dateOfBirthDatePicker.Value >= DateTime.Now)
            {
                birthDateAlertLabel.Text = "Date of Birth \n must be in past.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                addressOneAlertLabel.Text = "Address 1 required.";
                isValid = false;
            }
            else if (address1TextBox.Text.Length > 150)
            {
                addressOneAlertLabel.Text = "Address 1 cannot exceed 150 characters.";
                isValid = false;
            }

            if (address2TextBox.Text.Length > 150)
            {
                addressTwoAlertLabel.Text = "Address 2 cannot exceed \n 150 characters.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityAlertLabel.Text = "City required.";
                isValid = false;
            }
            else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z\s]+$") || cityTextBox.Text.Length > 45)
            {
                cityAlertLabel.Text = "City must be alphabetical \n and not exceed 45 characters.";
                isValid = false;
            }

            if (stateComboBox.SelectedIndex == -1)
            {
                stateAlertLabel.Text = "State selection required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(zipTextBox.Text) || !Regex.IsMatch(zipTextBox.Text, @"^\d{5}$"))
            {
                zipAlertLabel.Text = "Valid 5-digit Zip code required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(contactPhoneTextBox.Text) || !Regex.IsMatch(contactPhoneTextBox.Text, @"^\d{10}$"))
            {
                phoneAlertLabel.Text = "Valid 10-digit Contact Phone \n number required.";
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Clears the form.
        /// </summary>
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

        /// <summary>
        /// Initializes the gender ComboBox.
        /// </summary>
        private void InitializeGenderComboBox()
        {
            genderComboBox.Items.Add("Male");
            genderComboBox.Items.Add("Female");
            genderComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Initializes the state ComboBox.
        /// </summary>
        private void InitializeStateComboBox()
        {
            var states = new List<string> { "AL", "AK", "AZ", "AR", "CA", "CO", "CT", "DE", "FL", "GA", "HI", "ID", "IL",
                "IN", "IA", "KS", "KY", "LA", "ME", "MD", "MA", "MI", "MN", "MS", "MO", "MT", "NE", "NV", "NH", "NJ", "NM",
                "NY", "NC", "ND", "OH", "OK", "OR", "PA", "RI", "SC", "SD", "TN", "TX", "UT", "VT", "VA", "WA", "WV", "WI", "WY" };
            stateComboBox.Items.AddRange(states.ToArray());
            stateComboBox.SelectedIndex = -1;
        }

        /// <summary>
        /// Handles the TextChanged event of the Input control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Input_TextChanged(object sender, EventArgs e)
        {
            firstNameAlertLabel.Text = "";
            lastNameAlertLabel.Text = "";
            genderAlertLabel.Text = "";
            birthDateAlertLabel.Text = "";
            addressOneAlertLabel.Text = "";
            addressTwoAlertLabel.Text = "";
            cityAlertLabel.Text = "";
            stateAlertLabel.Text = "";
            zipAlertLabel.Text = "";
            phoneAlertLabel.Text = "";

        }

        /// <summary>
        /// Handles the Changed event of the Input control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Input_Changed(object sender, EventArgs e)
        {
            firstNameAlertLabel.Text = "";
            lastNameAlertLabel.Text = "";
            genderAlertLabel.Text = "";
            birthDateAlertLabel.Text = "";
            addressOneAlertLabel.Text = "";
            addressTwoAlertLabel.Text = "";
            cityAlertLabel.Text = "";
            stateAlertLabel.Text = "";
            zipAlertLabel.Text = "";
            phoneAlertLabel.Text = "";
        }

        /// <summary>
        /// Shows the success dialog.
        /// </summary>
        /// <param name="memberId">The member identifier.</param>
        private void ShowSuccessDialog(int memberId)
        {
            string message = $"Member registered successfully! Member ID: {memberId}";
            string title = "Registration Successful";
            MessageBoxButtons buttons = MessageBoxButtons.OK;
            MessageBox.Show(message, title, buttons);
        }
    }
}
