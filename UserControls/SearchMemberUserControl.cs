using SofaSoGood.Controller;
using SofaSoGood.Model;
using System;
using System.Collections.Generic;
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
            bool isNumeric = int.TryParse(memberIDTextBox.Text, out int customerID);
            if (isNumeric)
            {
                var member = memberController.GetMemberById(customerID);
                if (member != null)
                {
                    List<Member> members = new List<Member> { member };
                    this.DisplayFoundMembers(members);
                }
                else
                {
                    MemberIDWarningLabel.Text = "No Members found";
                }
            }
            else
            {
                MemberIDWarningLabel.Text = "Invalid Member ID";
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
                List<Member> members = memberController.GetMemberByPhone(phoneTextBox.Text);
                if (members.Count > 0)
                {
                    this.DisplayFoundMembers(members);
                }
                else
                {
                    phoneWarningLabel.Text = "No Members found.";
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
                nameWarningLabel.Text = "Fill both fields";
            }
            else
            {
                List<Member> members = memberController.GetMemberByName(firstNameTextBox.Text, lastNameTextBox.Text);
                if (members != null && members.Count > 0)
                {
                    this.DisplayFoundMembers(members);
                }
                else
                {
                    nameWarningLabel.Text = "No Members found";
                }
            }
        }

        /// <summary>
        /// Displays a found Member in the ListView.
        /// </summary>
        private void DisplayFoundMembers(List<Member> members)
        {
            memberListView.Items.Clear();

            foreach (Member member in members)
            {
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
            }

            foreach (ColumnHeader column in memberListView.Columns)
            {
                column.Width = -2;
            }

            memberListView.Visible = members.Count > 0;

            memberListView.Refresh();
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButtonClick(object sender, EventArgs e)
        {
            memberIDTextBox.Clear();
            phoneTextBox.Clear();
            firstNameTextBox.Clear();
            lastNameTextBox.Clear();
            MemberIDWarningLabel.Text = string.Empty;
            phoneWarningLabel.Text = string.Empty;
            nameWarningLabel.Text = string.Empty;
            memberListView.Items.Clear();
            memberListView.Hide();
        }

        /// <summary>
        /// Handles the TextChanged event of the MemberIDTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void MemberIDTextBoxClicked(object sender, EventArgs e)
        {
            ClearFieldsExcept("memberID");
            MemberIDWarningLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the TextChanged event of the PhoneTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void PhoneTextBoxTextClicked(object sender, EventArgs e)
        {
            ClearFieldsExcept("phone");
            phoneWarningLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the TextChanged event of the NameTextBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void NameTextBoxClicked(object sender, EventArgs e)
        {
            ClearFieldsExcept("name");
            nameWarningLabel.Text = string.Empty;
        }

        /// <summary>
        /// Clears the fields except.
        /// </summary>
        /// <param name="field">The field.</param>
        private void ClearFieldsExcept(string field)
        {
            memberListView.Hide();
            if (field != "memberID") memberIDTextBox.Clear();
            if (field != "phone") phoneTextBox.Clear();
            if (field != "name")
            {
                firstNameTextBox.Clear();
                lastNameTextBox.Clear();
            }
        }
    }
}