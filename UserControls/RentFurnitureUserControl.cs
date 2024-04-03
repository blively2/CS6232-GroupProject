using SofaSoGood.Model;
using SofaSoGood.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    public partial class RentFurnitureUserControl : UserControl
    {

        private SearchFurnitureUserControl SearchFurnitureUserControl;

        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this.FormatSelectedMemberAndFurnitureListView();
            this.SelectedFurnitureListView.ContextMenuStrip = this.RightClickMenuStrip;
            this.CheckIfMemberAndFurniturePopulated();
            this.DateAlertLabel.Text = string.Empty;
        }

        /// <summary>
        /// Displays a SelectedMember in the ListView.
        /// </summary>
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
        /// Displays a SelectedMember in the ListView.
        /// </summary>
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
        /// Formats the SelectedMember ListView programmatically.
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

        private void RemoveItemToolStripMenuItemClick(object sender, EventArgs e)
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

        public void SetSearchFurnitureUserControl(SearchFurnitureUserControl searchFurnitureUserControl)
        {
            this.SearchFurnitureUserControl = searchFurnitureUserControl;
        }

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

        private void RentFurnitureButtonClick(object sender, EventArgs e)
        {
            this.ValidateRentalDates();
        }

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

        private void DatePickerDropDown(object sender, EventArgs e)
        {
            this.DateAlertLabel.Text = string.Empty;
        }
    }
}
