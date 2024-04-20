using SofaSoGood.Controller;
using SofaSoGood.Model;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;

namespace SofaSoGood.UserControls
{
    public partial class BuildReturnUserControl : UserControl
    {

        private RentalController rentalController;
        private ReturnController returnController;

        public BuildReturnUserControl()
        {
            this.rentalController = new RentalController();
            this.returnController = new ReturnController();
            InitializeComponent();
            FormatSelectedMemberAndFurnitureListView();
            CheckIfMemberAndFurniturePopulated();
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

            foreach (ColumnHeader column in CurrentlyRentedFurnitureListView.Columns)
            {
                column.Width = -2;
            }

            SelectedMemberListView.Refresh();
            this.CheckIfMemberAndFurniturePopulated();
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void CheckIfMemberAndFurniturePopulated()
        {
            bool memberPopulated = this.SelectedMemberListView.Items.Count > 0;
            bool furniturePopulated = this.CurrentlyRentedFurnitureListView.Items.Count > 0;

            this.SelectedMemberListView.BackColor = !memberPopulated ? Color.LightGray : SystemColors.Window;
            this.CurrentlyRentedFurnitureListView.BackColor = !furniturePopulated ? Color.LightGray : SystemColors.Window;

            this.SelectAMemberLabel.Text = memberPopulated ? "Selected Member: " : "Please select a member.";
            this.CurrentlyRentedFurnitureLabel.Text = furniturePopulated ? "Double Click an item to add it to a return." : "No rented furniture for selected member.";
        }

        /// <summary>
        /// Displays the selected member information in the ListView.
        /// </summary>
        /// <param name="SelectedMember">The selected member.</param>
        public void DisplaySelectedMemberAndUpdateCurrentlyRentedFurniture(Member SelectedMember)
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

                List<CurrentlyRentedFurnitureInformation> currentlyRentedFurniture = this.rentalController.GetCurrentlyRentedFurnitureByMemberID(SelectedMember.MemberID);
                if (currentlyRentedFurniture.Count > 0) {
                    foreach (var furniture in currentlyRentedFurniture)
                    {
                        var furnitureItem = new ListViewItem(furniture.FurnitureID.ToString());
                        furnitureItem.SubItems.AddRange(new string[]
                        {
                    furniture.FurnitureName,
                    furniture.FurnitureCategory,
                    furniture.FurnitureStyle,
                    furniture.Description,
                    furniture.RentalRatePerDay.ToString("C"),
                    furniture.AmountRented.ToString()
                        });
                        CurrentlyRentedFurnitureListView.Items.Add(furnitureItem);
                    }
                } 
                else 
                { 
                    CurrentlyRentedFurnitureListView.Items.Clear();
                }
            }
            else
            {
                SelectedMemberListView.Items.Clear();
                CurrentlyRentedFurnitureListView.Items.Clear();
            }
            this.FormatSelectedMemberAndFurnitureListView();
        }
    }
}
