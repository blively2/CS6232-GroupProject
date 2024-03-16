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
            customerIDWarningLabel.Text = string.Empty;
            phoneWarningLabel.Text = string.Empty;
            nameWarningLabel.Text = string.Empty;
        }

        private void SearchByMemberIDButtonClick(object sender, System.EventArgs e)
        {
            bool isNumeric = int.TryParse(customerIDTextBox.Text, out int customerID);

            if (isNumeric)
            {
                this.DisplayFoundMember(memberController.GetMemberById(customerID));
            }
            else
            {
                customerIDWarningLabel.Text = "Invalid Customer ID";
            }
        }

        private void SearchByPhoneButtonClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(phoneTextBox.Text) || !Regex.IsMatch(phoneTextBox.Text, @"^\d{10}$"))
            {
                phoneWarningLabel.Text += "Invalid Phone";
            }
            else
            {
                this.DisplayFoundMember(memberController.GetMemberByPhone(phoneTextBox.Text));
            }
        }

        private void SearchByNameButtonClick(object sender, System.EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(firstNameTextBox.Text) || string.IsNullOrWhiteSpace(lastNameTextBox.Text))
            {
                nameWarningLabel.Text = "Invalid Name";
            }
            else
            {
                this.DisplayFoundMember(memberController.GetMemberByName(firstNameTextBox.Text, lastNameTextBox.Text));
            }
        }

        private void DisplayFoundMember(Member member)
        {
            MemberListView.Items.Clear();
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
            MemberListView.Items.Add(item);

            foreach (ColumnHeader column in MemberListView.Columns)
            {
                column.Width = -2;
            }

            MemberListView.Refresh();
        }
    }
}