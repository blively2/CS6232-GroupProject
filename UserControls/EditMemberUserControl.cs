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
            genderComboBox.Enabled = true;
            dateOfBirthDatePicker.Enabled = true;
            address1TextBox.ReadOnly = false;
            address2TextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            stateComboBox.Enabled = true;
            zipTextBox.ReadOnly = false;
            contactTextBox.ReadOnly = false;
        }

        /// <summary>
        /// Handles the Click event of the UpdateMemberButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void UpdateMemberButton_Click(object sender, System.EventArgs e)
        {
            invalidInputLabel.Text = "";
            invalidInputLabel.ForeColor = Color.Red;

            if (string.IsNullOrEmpty(memberIDTextBox.Text))
            {
                invalidInputLabel.Text = "Please enter MemberID";
                return;
            }

            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text))
            {
                invalidInputLabel.Text += "First Name is required.\n";
                return;
            }
            else if (firstNameTextBox.Text.Length > 200)
            {
                invalidInputLabel.Text += "First Name cannot exceed 200 characters.\n";
                return;
            }

            if (string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                invalidInputLabel.Text += "Last Name is required.\n";
                return;
            }
            else if (lastNameTextBox.Text.Length > 200)
            {
                invalidInputLabel.Text += "Last Name cannot exceed 200 characters.\n";
                return;
            }

            if (genderComboBox.SelectedIndex == -1)
            {
                invalidInputLabel.Text += "Gender selection is required.\n";
                return;
            }

            if (dateOfBirthDatePicker.Value >= DateTime.Now)
            {
                invalidInputLabel.Text += "Date of Birth must be in the past.\n";
                return;
            }

            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                invalidInputLabel.Text += "Address 1 cannot be empty.";
                return;
            }
            else if (address1TextBox.Text.Length > 150)
            {
                invalidInputLabel.Text += "Address 1 cannot exceed 150 characters.\n";
                return;
            }

            if (address2TextBox.Text.Length > 150)
            {
                invalidInputLabel.Text += "Address 2 cannot exceed 150 characters.\n";
                return;
            }

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                invalidInputLabel.Text += "City cannot be empty. \n";
                return;

            } 
            else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z\s]+$")) 
            {
                invalidInputLabel.Text += "City must be alphabetical. \n";
                return;
            }
            else if (cityTextBox.Text.Length > 45)
            {
                invalidInputLabel.Text += "City cannot exceed 45 characters.\n";
                return;
            }

            if (stateComboBox.SelectedIndex == -1)
            {
                invalidInputLabel.Text += "State selection is required.\n";
                return;
            }

            if (string.IsNullOrWhiteSpace(zipTextBox.Text) || !Regex.IsMatch(zipTextBox.Text, @"^\d{5}$"))
            {
                invalidInputLabel.Text += "5-digit Zip code is required.";
                return;
            }

            if (string.IsNullOrWhiteSpace(contactTextBox.Text) || !Regex.IsMatch(contactTextBox.Text, @"^\d{10}$"))
            {
                invalidInputLabel.Text += "10-digit Contact number is required.";
                return;
            }

            if (!string.IsNullOrEmpty(invalidInputLabel.Text))
            {
                return;
            }

            var updatedMember = new Member
            {
                MemberID = int.Parse(memberIDTextBox.Text),
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

            var result = memberController.UpdateMember(updatedMember);
            if (result == 1)
            {
                invalidInputLabel.ForeColor = Color.Green;
                invalidInputLabel.Text = "Member updated.";
            }
            else
            {
                invalidInputLabel.ForeColor = Color.Orange;
                invalidInputLabel.Text = "No changes made.";
            }
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
