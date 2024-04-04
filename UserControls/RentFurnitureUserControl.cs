using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Renting Furniture.
    /// Has a reference to the SearchFurnitureUserControl.
    /// </summary>
    public partial class RentFurnitureUserControl : UserControl
    {

        /// <summary>
        /// Field to hold reference to the SearchFurnitureUserControl.
        /// </summary>
        private SearchFurnitureUserControl SearchFurnitureUserControl;

        /// <summary>
        /// Constructor for RentFurnitureUserControl.
        /// Initializes components, formats the list views, and checks if member and furniture are populated.
        /// </summary>
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this.FormatSelectedMemberAndFurnitureListView();
            this.SelectedFurnitureListView.ContextMenuStrip = this.RightClickMenuStrip;
            this.CheckIfMemberAndFurniturePopulated();
            this.DateAlertLabel.Text = string.Empty;
        }

        /// <summary>
        /// Displays the selected member information in the ListView.
        /// </summary>
        /// <param name="SelectedMember">The selected member.</param>
        public void DisplaySelectedMember(Member SelectedMember)
        {
            if (SelectedMember != null)
            {
                SelectedMemberListView.Items.Clear();
                ListViewItem item = new ListViewItem(SelectedMember.MemberID.ToString());
                item.SubItems.Add(SelectedMember.FirstName ?? string.Empty);
                item.SubItems.Add(SelectedMember.LastName ?? string.Empty);
                item.SubItems.Add(SelectedMember.Gender ?? string.Empty);
                item.SubItems.Add(SelectedMember.DateOfBirth.ToShortDateString());
                item.SubItems.Add(SelectedMember.Address1 ?? string.Empty);
                item.SubItems.Add(SelectedMember.Address2 ?? string.Empty);
                item.SubItems.Add(SelectedMember.City ?? string.Empty);
                item.SubItems.Add(SelectedMember.State ?? string.Empty);
                item.SubItems.Add(SelectedMember.Zip ?? string.Empty);
                item.SubItems.Add(SelectedMember.ContactPhone ?? string.Empty);
                SelectedMemberListView.Items.Add(item);
                this.UseSearchMemberFunctionalityLabel.Text = "";
            }
            else 
            { 
                SelectedMemberListView.Items.Clear(); 
            }
            this.FormatSelectedMemberAndFurnitureListView();
        }

        /// <summary>
        /// Displays the selected furniture items in the ListView.
        /// </summary>
        /// <param name="selectedFurniture">List of selected furniture.</param>
        public void DisplaySelectedFurniture(List<Furniture> selectedFurniture)
        {
            SelectedFurnitureListView.Items.Clear();

            if (selectedFurniture != null && selectedFurniture.Count > 0)
            {
                foreach (var furniture in selectedFurniture)
                {
                    ListViewItem item = new ListViewItem(furniture.FurnitureID.ToString());
                    item.SubItems.Add(furniture.Name ?? string.Empty);
                    item.SubItems.Add(furniture.CategoryName ?? string.Empty);
                    item.SubItems.Add(furniture.StyleName ?? string.Empty);
                    item.SubItems.Add(furniture.Description ?? string.Empty);
                    item.SubItems.Add(furniture.RentalRatePerDay.ToString("C"));
                    item.SubItems.Add(furniture.InStockQuantity.ToString());
                    item.SubItems.Add(furniture.TotalQuantity.ToString());
                    SelectedFurnitureListView.Items.Add(item);
                    this.UseSearchFurnitureFunctionalityLabel.Text = "";
                }
            }
            this.FormatSelectedMemberAndFurnitureListView();
        }

        /// <summary>
        /// Programmatically formats the list views for selected member and furniture.
        /// </summary>
        private void FormatSelectedMemberAndFurnitureListView()
        {
            foreach (ColumnHeader column in SelectedMemberListView.Columns)
            {
                column.Width = -2;
            }

            foreach (ColumnHeader column in SelectedFurnitureListView.Columns)
            {
                column.Width = -2;
            }

            SelectedFurnitureListView.Refresh();
            SelectedMemberListView.Refresh();
            this.CheckIfMemberAndFurniturePopulated();
        }

        /// <summary>
        /// Removes a selected item from the ListView when the context menu option is clicked.
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// </summary>
        private void RemoveFurnitureToolStripMenuItemClick(object sender, EventArgs e)
        {
            if (SelectedFurnitureListView.SelectedItems.Count > 0)
            {
                int furnitureID = int.Parse(SelectedFurnitureListView.SelectedItems[0].Text);
                this.SearchFurnitureUserControl.RemoveFurnitureItem(furnitureID);
                this.SelectedFurnitureListView.Items.Remove(SelectedFurnitureListView.SelectedItems[0]);
                this.SelectedFurnitureListView.Refresh();
            }

            if (SelectedFurnitureListView.SelectedItems.Count == 0)
            {
                this.UseSearchFurnitureFunctionalityLabel.Text = "Use the Search Furniture Tab and Double Click to Select Furniture";
            }

            this.CheckIfMemberAndFurniturePopulated();
        }

        /// <summary>
        /// Sets the reference to the SearchFurnitureUserControl.
        /// </summary>
        /// <param name="searchFurnitureUserControl">The SearchFurnitureUserControl instance.</param>
        public void SetSearchFurnitureUserControl(SearchFurnitureUserControl searchFurnitureUserControl)
        {
            this.SearchFurnitureUserControl = searchFurnitureUserControl;
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void CheckIfMemberAndFurniturePopulated()
        {
            System.Diagnostics.Debug.WriteLine(this.SelectedFurnitureListView.Items.Count);
            System.Diagnostics.Debug.WriteLine(this.SelectedMemberListView.Items.Count);
            if (this.SelectedFurnitureListView.Items.Count > 0 && this.SelectedMemberListView.Items.Count > 0)
            {
                this.StartDatePicker.Enabled = true;
                this.EndDatePicker.Enabled = true;
                this.RentFurnitureButton.Enabled = true;
            }
            else if (this.SelectedFurnitureListView.Items.Count == 0 || this.SelectedMemberListView.Items.Count == 0)
            {
                this.StartDatePicker.Enabled = false;
                this.EndDatePicker.Enabled = false;
                this.RentFurnitureButton.Enabled = false;
            }
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// </summary>
        private void RentFurnitureButtonClick(object sender, EventArgs e)
        {
            this.ValidateRentalDates();
        }

        /// <summary>
        /// Validates the start and end dates for the furniture rental.
        /// </summary>
        /// <returns>True if the dates are valid, otherwise false.</returns>
        private bool ValidateRentalDates()
        {
            bool isValid = true;

            if (this.StartDatePicker.Value.Date < DateTime.Now.Date)
            {
                isValid = false;
                this.DateAlertLabel.Text = "Start date cannot be in the past.";
            }

            if (this.EndDatePicker.Value.Date <= this.StartDatePicker.Value.Date)
            {
                isValid = false;
                this.DateAlertLabel.Text = "End date must be after the start date.";
            }

            return isValid;
        }

        /// <summary>
        /// Clears the date alert label when the date picker is interacted with.
        /// </summary>
        private void DatePickerDropDown(object sender, EventArgs e)
        {
            this.DateAlertLabel.Text = string.Empty;
        }
    }
}
