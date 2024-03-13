using SofaSoGood.Controller;
using SofaSoGood.Model;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Editing Customers in the database.
    /// Has an CustomerController instance to interact with the DB.
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
            DisableEditableFields();
            memberIDTextBox.TextChanged += MemberIDTextBox_TextChanged;
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
            stateTextBox.ReadOnly = true;
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
                genderComboBox.SelectedItem = member.Gender == "Male" ? "Male" : "Female";
                dateOfBirthDatePicker.Value = member.DateOfBirth;
                address1TextBox.Text = member.Address1;
                address2TextBox.Text = member.Address2 ?? "";
                cityTextBox.Text = member.City;
                stateTextBox.Text = member.State;
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
            address1TextBox.ReadOnly = false;
            address2TextBox.ReadOnly = false;
            cityTextBox.ReadOnly = false;
            stateTextBox.ReadOnly = false;
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
            invalidInputLabel.Text = "";

            if (string.IsNullOrWhiteSpace(address1TextBox.Text))
            {
                invalidInputLabel.Text += "Address 1 cannot be empty.";
            }

            if (string.IsNullOrWhiteSpace(cityTextBox.Text))
            {
                invalidInputLabel.Text += "City cannot be empty. \n";

            } else if (!Regex.IsMatch(cityTextBox.Text, @"^[a-zA-Z\s]+$")) 
            {
                invalidInputLabel.Text += "City must be alphabetical. \n";
            }

            if (string.IsNullOrWhiteSpace(stateTextBox.Text))
            {
                invalidInputLabel.Text += "State cannot be empty. \n";

            } else if (!Regex.IsMatch(stateTextBox.Text, @"^[a-zA-Z\s]+$"))
            {
                invalidInputLabel.Text += "State must be alphabetical. \n";
            }

            if (string.IsNullOrWhiteSpace(zipTextBox.Text) || !Regex.IsMatch(zipTextBox.Text, @"^\d{5}$"))
            {
                invalidInputLabel.Text += "5-digit Zip code is required.";
            }

            if (string.IsNullOrWhiteSpace(contactTextBox.Text) || !Regex.IsMatch(contactTextBox.Text, @"^\d{10}$"))
            {
                invalidInputLabel.Text += "10-digit Contact number is required.";
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
                State = stateTextBox.Text,
                Zip = zipTextBox.Text,
                ContactPhone = contactTextBox.Text
            };

            var result = memberController.UpdateMember(updatedMember);
            if (result == -1)
            {
                invalidInputLabel.ForeColor = Color.Orange;
                invalidInputLabel.Text = "No changes made.";
            }
            else if (result == 0)
            {
                invalidInputLabel.ForeColor = Color.Red;
                invalidInputLabel.Text = "Update failed.";
            }
            else
            {
                invalidInputLabel.ForeColor = Color.Green;
                invalidInputLabel.Text = "Member updated successfully.";
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
            firstNameTextBox.Text = "";
            lastNameTextBox.Text = "";
            genderComboBox.SelectedIndex = -1;
            dateOfBirthDatePicker.Value = DateTime.Now;
            address1TextBox.Text = "";
            address2TextBox.Text = "";
            cityTextBox.Text = "";
            stateTextBox.Text = "";
            zipTextBox.Text = "";
            contactTextBox.Text = "";
            invalidInputLabel.Text = "";
        }
    }
}
