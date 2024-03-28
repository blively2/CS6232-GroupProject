using SofaSoGood.Controller;
using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Editing Customers in the database.
    /// Has an MemberController instance to interact with the DB.
    /// </summary>
    public partial class EditMemberUserControl : UserControl
    {
        private readonly MemberController memberController;
        private Member originalMember = null;

        /// <summary>
        /// Constructor for EditCustomerUserControl.
        /// Initializes the controller and the component for the UI.
        /// </summary>
        public EditMemberUserControl()
        {
            InitializeComponent();
            memberController = new MemberController();
            InitializeGenderComboBox();
            InitializeStateComboBox();
            DisableEditableFields();
        }

        /// <summary>
        /// Initializes the gender ComboBox.
        /// </summary>
        private void InitializeGenderComboBox()
        {
            genderComboBox.Items.Clear();                             
            genderComboBox.Items.Add("Male"); 
            genderComboBox.Items.Add("Female");
        }

        /// <summary>
        /// Disables the editable fields.
        /// </summary>
        private void DisableEditableFields()
        {
            firstNameTextBox.ReadOnly = true;
            lastNameTextBox.ReadOnly = true;
            genderComboBox.Enabled = false;
            dateOfBirthDatePicker.Enabled = false;
            address1TextBox.ReadOnly = true;
            address2TextBox.ReadOnly = true;
            cityTextBox.ReadOnly = true;
            stateComboBox.Enabled = false;
            zipTextBox.ReadOnly = true;
            contactTextBox.ReadOnly = true;
        }

        /// <summary>
        /// Handles the Click event of the GetMemberButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void GetMemberButton_Click(object sender, System.EventArgs e)
        {
            invalidInputLabel.Text = "";
            invalidMemberIDLabel.Text = " ";
            if (!int.TryParse(memberIDTextBox.Text, out int memberId))
            {
                invalidMemberIDLabel.ForeColor = Color.Red;
                invalidMemberIDLabel.Text = "Please enter a valid Member ID.";
                return;
            }

            var member = memberController.GetMemberById(memberId);
            originalMember = memberController.GetMemberById(memberId);
            if (member != null)
            {

                firstNameTextBox.Text = member.FirstName;
                lastNameTextBox.Text = member.LastName;
                genderComboBox.SelectedItem = member.Gender == "M" ? "Male" : "Female";
                dateOfBirthDatePicker.Value = member.DateOfBirth;
                address1TextBox.Text = member.Address1;
                address2TextBox.Text = member.Address2 ?? "";
                cityTextBox.Text = member.City;
                stateComboBox.SelectedItem = member.State;
                zipTextBox.Text = member.Zip;
                contactTextBox.Text = member.ContactPhone;

                EnableEditableFields();
            }
            else
            {
                invalidMemberIDLabel.ForeColor = Color.Red;
                invalidMemberIDLabel.Text = "Member not found.";
            }
        }

        /// <summary>
        /// Enables the editable fields.
        /// </summary>
        private void EnableEditableFields()
        {
            firstNameTextBox.ReadOnly = false;
            lastNameTextBox.ReadOnly = false;
            dateOfBirthDatePicker.Enabled = true;
            address1TextBox.ReadOnly = false;
            address2TextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            stateComboBox.Enabled = true;
            zipTextBox.ReadOnly = false;
            contactTextBox.ReadOnly = false;
        }

        private bool ValidateInputs()
        {
            bool isValid = true;
            ResetValidationMessages();

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                firstNameAlertLabel.Text = "First Name is required.";
                isValid = false;
            }
            else if (firstNameTextBox.Text.Length > 200)
            {
                firstNameAlertLabel.Text = "First Name cannot exceed 200 characters.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                lastNameAlertLabel.Text = "Last Name is required.";
                isValid = false;
            }
            else if (lastNameTextBox.Text.Length > 200)
            {
                lastNameAlertLabel.Text = "Last Name cannot exceed 200 characters.";
                isValid = false;
            }

            if (genderComboBox.SelectedIndex == -1)
            {
                genderAlertLabel.Text = "Gender selection is required.";
                isValid = false;
            }

            if (dateOfBirthDatePicker.Value >= DateTime.Now)
            {
                birthDateAlertLabel.Text = "Date of Birth must be in the past.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                addressOneAlertLabel.Text = "Address 1 is required.";
                isValid = false;
            }
            else if (address1TextBox.Text.Length > 150)
            {
                addressOneAlertLabel.Text = "Address 1 cannot exceed 150 characters.";
                isValid = false;
            }

            if (address2TextBox.Text.Length > 150)
            {
                addressTwoAlertLabel.Text = "Address 2 cannot \n exceed 150 characters.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                cityAlertLabel.Text = "City is required.";
                isValid = false;
            }
            else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z\s]+$") || cityTextBox.Text.Length > 45)
            {
                cityAlertLabel.Text = "City must be alphabetical \n and cannot exceed 45 characters.";
                isValid = false;
            }

            if (stateComboBox.SelectedIndex == -1)
            {
                stateAlertLabel.Text = "State selection is required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(zipTextBox.Text) || !Regex.IsMatch(zipTextBox.Text, @"^\d{5}$"))
            {
                zipAlertLabel.Text = "A valid 5-digit \n Zip code required.";
                isValid = false;
            }

            if (string.IsNullOrWhiteSpace(contactTextBox.Text) || !Regex.IsMatch(contactTextBox.Text, @"^\d{10}$"))
            {
                phoneAlertLabel.Text = "A valid 10-digit Contact \n Phone number is required.";
                isValid = false;
            }

            return isValid;
        }

        /// <summary>
        /// Handles the Click event of the UpdateMemberButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void UpdateMemberButton_Click(object sender, System.EventArgs e)
        {
            if (!ValidateInputs())
            {
                return;
            }

            if (!int.TryParse(memberIDTextBox.Text, out int memberId))
            {
                invalidMemberIDLabel.Text = "Invalid Member ID.";
                return;
            }

            var updatedMember = new Member
            {
                MemberID = memberId,
                FirstName = firstNameTextBox.Text,
                LastName = lastNameTextBox.Text,
                Gender = genderComboBox.SelectedItem.ToString()[0].ToString(),
                DateOfBirth = dateOfBirthDatePicker.Value,
                Address1 = address1TextBox.Text,
                Address2 = address2TextBox.Text,
                City = cityTextBox.Text,
                State = stateComboBox.SelectedItem.ToString(),
                Zip = zipTextBox.Text,
                ContactPhone = contactTextBox.Text
            };

            if (originalMember == null || MemberHasChanged(originalMember, updatedMember))
            {
                int result = memberController.UpdateMember(updatedMember);
                switch (result)
                {
                    case 1:
                        invalidInputLabel.ForeColor = Color.Green;
                        invalidInputLabel.Text = "Member updated successfully.";
                        break;
                    case -1:
                        invalidInputLabel.ForeColor = Color.Orange;
                        invalidInputLabel.Text = "No changes were made.";
                        break;
                    default:
                        invalidInputLabel.ForeColor = Color.Red;
                        invalidInputLabel.Text = "Failed to update member.";
                        break;
                }
            }
            else
            {
                invalidInputLabel.ForeColor = Color.Orange;
                invalidInputLabel.Text = "No changes were made.";
            }
        }

        private bool MemberHasChanged(Member original, Member updated)
        {
            bool address2Changed = (original.Address2 ?? "") != (updated.Address2 ?? "");

            return !string.Equals(original.FirstName, updated.FirstName, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(original.LastName, updated.LastName, StringComparison.OrdinalIgnoreCase) ||
                   original.Gender != updated.Gender ||
                   original.DateOfBirth.Date != updated.DateOfBirth.Date ||
                   !string.Equals(original.Address1?.Trim(), updated.Address1?.Trim(), StringComparison.OrdinalIgnoreCase) ||
                   address2Changed ||
                   !string.Equals(original.City?.Trim(), updated.City?.Trim(), StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(original.State, updated.State, StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(original.Zip?.Trim(), updated.Zip?.Trim(), StringComparison.OrdinalIgnoreCase) ||
                   !string.Equals(original.ContactPhone?.Trim(), updated.ContactPhone?.Trim(), StringComparison.OrdinalIgnoreCase);
        }

        /// <summary>
        /// Handles the TextChanged event of the MemberIDTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MemberIDTextBox_TextChanged(object sender, System.EventArgs e)
        {
            invalidInputLabel.Text = "";
            ClearForm();
            DisableEditableFields();
        }

        private void Input_TextChanged(object sender, EventArgs e)
        {
            ResetValidationMessages();

        }

        /// <summary>
        /// Handles the Changed event of the Input control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void Input_Changed(object sender, EventArgs e)
        {
            ResetValidationMessages();
        }

        private void ResetValidationMessages()
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
            contactTextBox.Clear();
            invalidInputLabel.Text = "";
            invalidMemberIDLabel.Text = "";
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
            memberIDTextBox.Clear();
            invalidInputLabel.Text = string.Empty;
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
        }
    }
}
