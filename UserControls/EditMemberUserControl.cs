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
                genderComboBox.SelectedItem = member.Gender;
                dateOfBirthDatePicker.Value = member.DateOfBirth;
                address1TextBox.Text = member.Address1;
                address2TextBox.Text = member.Address2 ?? "";
                cityTextBox.Text = member.City;
                stateTextBox.Text = member.State;
                zipTextBox.Text = member.Zip;
                contactTextBox.Text = member.ContactPhone;
            }
            else
            {
                MessageBox.Show("Member not found.");
            }
        }
    }
}
