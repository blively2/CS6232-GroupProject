using SofaSoGood.Controller;
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
        }

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
                MessageBox.Show("Please enter a valid Member ID.");
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
                MessageBox.Show("Member not found.");
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
    }
}
