using System.Windows.Forms;
using SofaSoGood.Model;
using System.Collections.Generic;
using SofaSoGood.UserControls;

namespace SofaSoGood.View
{
    /// <summary>
    /// MainDashboard is primary form for Sofa So Good's Furniture Management System.
    /// </summary>
    public partial class MemberDashboard : Form
    {
        /// <summary>
        /// Accessible instance of the LoginForm passed into MainDashboard.
        /// </summary>
        private readonly LoginForm LoginForm;

        /// <summary>
        /// Initializes a new instance of the MainDashboard.
        /// Uses the LoginForm as a component
        /// </summary>
        public MemberDashboard(LoginForm LoginForm)
        {
            InitializeComponent();
            this.LoginForm = LoginForm;
            this.SearchMemberUserControl.SetMemberDashboard(this);
            this.SearchMemberUserControl.SetRentFurnitureUserControl(this.RentFurnitureUserControl);
            this.SearchFurnitureUserControl.SetMemberDashboard(this);
            this.SearchFurnitureUserControl.SetRentFurnitureUserControl(this.RentFurnitureUserControl);
            this.RentFurnitureUserControl.SetLoginForm(this.LoginForm);
            this.RentFurnitureUserControl.SetSearchFurnitureUserControl(this.SearchFurnitureUserControl);
            this.RentFurnitureUserControl.SetSearchMemberUserControl(this.SearchMemberUserControl);
        }

        /// <summary>
        /// Logs the User out of the MainDashboard and shows the component LoginForm.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the FormClosed event.</param>
        private void LogoutLabelClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            this.LoginForm.Show();
        }

        /// <summary>
        /// Sets the current user label to welcome them to the application.
        /// </summary>
        /// <param name="CurrentUser">The current user.</param>
        public void SetCurrentUserLabel(string CurrentUser)
        {
            this.WelcomeUserLabel.Text = "Welcome, " + CurrentUser;
        }

        /// <summary>
        /// Ensures that the application exits properly when closed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the FormClosed event.</param>
        private void MainDashboardFormClose(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// Ensures that the application exits properly when closed.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">Provides data for the FormClosed event.</param>
        public void SelectedMemberChanged(Member ChosenMember)
        {
            if (ChosenMember == null)
            {
                MemberSelectedLabel.Text = "Member Selected: None";
            }
            else
            {
                MemberSelectedLabel.Text = "Member Selected: " + ChosenMember.FirstName + " " + ChosenMember.LastName;
            }
        }

        /// <summary>
        /// Ensures that the application exits properly when closed.
        /// </summary>
        /// <param name="FurnitureItems">Accepts a List<Furniture> to reflect changes to item counts.</param>
        public void SelectedFurnitureChanged(List<Furniture> FurnitureItems)
        {
                ItemsAmountLabel.Text = "Items: " + FurnitureItems.Count;
        }

        /// <summary>
        /// Invokes the method to populate the edit member form with the selected member's data.
        /// This method is intended to be called when a member is selected from a list, 
        /// preparing the EditMemberUserControl for data editing.
        /// </summary>
        /// <param name="selectedMember">The member selected from the list, whose data will be displayed on the form for editing.</param>
        public void PopulateEditMemberForm(Member selectedMember)
        {
            EditMemberUserControl.PopulateMemberData(selectedMember);
        }
    }
}
