using SofaSoGood.Controller;
using SofaSoGood.Model;
using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Searching Customers in the database.
    /// Has an CustomerController instance to interact with the DB.
    /// </summary>
    public partial class SearchMemberUserControl : UserControl
    {
        private readonly MemberController memberController;

        /// <summary>
        /// Constructor for SearchCustomerUserControl.
        /// Initializes the controller and the component for the UI.
        /// </summary>
        public SearchMemberUserControl()
        {
            InitializeComponent();
            memberController = new MemberController();
            MemberIDWarningLabel.Text = string.Empty;
            phoneWarningLabel.Text = string.Empty;
            nameWarningLabel.Text = string.Empty;
            memberListView.Hide();
        }

        /// <summary>
        /// Searched a Member based on the MemberID input from the user.
        /// </summary>
        private void SearchByMemberIDButtonClick(object sender, System.EventArgs e)
        {
            bool isNumeric = int.TryParse(MemberIDTextBox.Text, out int customerID);
            if (isNumeric)
            {
                Member member = memberController.GetMemberById(customerID);
                if (member != null)
                {
                    this.DisplayFoundMember(member);
                }
                else
                {
                    MemberIDWarningLabel.Text = "No Member found";
                }
            }
            else
            {
                MemberIDWarningLabel.Text = "Invalid Customer ID";
            }
        }

        /// <summary>
        /// Searched a Member based on the contactPhone input from the user.
        /// </summary>
        private void SearchByPhoneButtonClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || !Regex.IsMatch(phoneTextBox.Text, @"^\d{10}$"))
            {
                phoneWarningLabel.Text = "Invalid Phone";
            }
            else
            {
                Member member = memberController.GetMemberByPhone(phoneTextBox.Text);
                if (member != null)
                {
                    this.DisplayFoundMember(member);
                }
                else
                {
                    phoneWarningLabel.Text = "No Member found.";
                }
            }
        }

        /// <summary>
        /// Searched a Member based on the FirstName and LastName input from the user.
        /// </summary>
        private void SearchByNameButtonClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                nameWarningLabel.Text = "Please enter both first and last name";
            }
            else
            {
                Member member = memberController.GetMemberByName(firstNameTextBox.Text, lastNameTextBox.Text);
                if (member != null)
                {
                    this.DisplayFoundMember(member);
                }
                else
                {
                    nameWarningLabel.Text = "No Member found";
                }
            }
        }

        /// <summary>
        /// Displays a found Member in the ListView.
        /// </summary>
        private void DisplayFoundMember(Member member)
        {
            memberListView.Items.Clear();
            ListViewItem item = new ListViewItem(member.MemberID.ToString());
            item.SubItems.Add(member.FirstName ?? string.Empty);
            item.SubItems.Add(member.LastName ?? string.Empty);
            item.SubItems.Add(member.Gender ?? string.Empty);
            item.SubItems.Add(member.DateOfBirth.ToShortDateString());
            item.SubItems.Add(member.Address1 ?? string.Empty);
            item.SubItems.Add(member.Address2 ?? string.Empty);
            item.SubItems.Add(member.City ?? string.Empty);
            item.SubItems.Add(member.State ?? string.Empty);
            item.SubItems.Add(member.Zip ?? string.Empty);
            item.SubItems.Add(member.ContactPhone ?? string.Empty);
            memberListView.Items.Add(item);

            foreach (ColumnHeader column in memberListView.Columns)
            {
                column.Width = -2;
            }

            memberListView.Refresh();
            memberListView.Show();
        }

        /// <summary>
        /// Clears error messages when any text field is changed.
        /// </summary>
        private void TextChangedAnyField(object sender, EventArgs e)
        {
            MemberIDWarningLabel.Text = string.Empty;
            phoneWarningLabel.Text = string.Empty;
            nameWarningLabel.Text = string.Empty;
        }
    }
}