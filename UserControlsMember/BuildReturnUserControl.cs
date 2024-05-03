using SofaSoGood.Controller;
using SofaSoGood.Model;
using System.Drawing;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;


namespace SofaSoGood.UserControls
{
    /// <summary>
    /// User control for Build Return
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class BuildReturnUserControl : UserControl
    {

        private RentalController rentalController;
        private ReturnController returnController;
        public List<Furniture> returnFurnitureList;
        private ReturnFurnitureUserControl ReturnFurnitureUserControl;

        /// <summary>
        /// Initializes a new instance of the <see cref="BuildReturnUserControl"/> class.
        /// </summary>
        public BuildReturnUserControl()
        {
            this.rentalController = new RentalController();
            this.returnController = new ReturnController();
            this.returnFurnitureList = new List<Furniture>();
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

            this.SelectAMemberLabel.Text = memberPopulated ? "Selected Member: " : "Please select a member in the Search Member tab.";
            this.CurrentlyRentedFurnitureLabel.Text = furniturePopulated ? "Double Click an item to add it to a return." : "No rented furniture for selected member.";
        }

        /// <summary>
        /// Displays the selected member information and their currently rented furniture in the ListView.
        /// </summary>
        /// <param name="SelectedMember">The selected member.</param>
        public void DisplaySelectedMemberAndUpdateCurrentlyRentedFurniture(Member SelectedMember)
        {
            if (SelectedMember != null)
            {
                returnFurnitureList.Clear();
                CurrentlyRentedFurnitureListView.Items.Clear();
                SelectedMemberListView.Items.Clear();
                this.UpdateItemsToReturnLabel();
                ListViewItem item = new ListViewItem(SelectedMember.MemberID.ToString());
                item.SubItems.Add(SelectedMember.FirstName ?? string.Empty);
                item.SubItems.Add(SelectedMember.LastName ?? string.Empty);
                item.SubItems.Add(SelectedMember.Gender ?? string.Empty);
                item.SubItems.Add(SelectedMember.DateOfBirth.ToString("d"));
                item.SubItems.Add(SelectedMember.Address1 ?? string.Empty);
                item.SubItems.Add(SelectedMember.Address2 ?? string.Empty);
                item.SubItems.Add(SelectedMember.City ?? string.Empty);
                item.SubItems.Add(SelectedMember.State ?? string.Empty);
                item.SubItems.Add(SelectedMember.Zip ?? string.Empty);
                item.SubItems.Add(SelectedMember.ContactPhone ?? string.Empty);
                SelectedMemberListView.Items.Add(item);

                List<Furniture> currentlyRentedFurniture = this.rentalController.GetCurrentlyRentedFurnitureByMemberID(SelectedMember.MemberID);
                if (currentlyRentedFurniture.Count > 0) {
                    foreach (var furniture in currentlyRentedFurniture)
                    {
                        var furnitureItem = new ListViewItem(furniture.FurnitureID.ToString());
                        furnitureItem.SubItems.AddRange(new string[]
                        {
                            furniture.RentalTransactionID.ToString(),
                            furniture.RentalItemID.ToString(),
                            furniture.Name,
                            furniture.CategoryName,
                            furniture.StyleName,
                            furniture.Description,
                            furniture.RentalDate.ToShortDateString(),
                            furniture.DueDate.ToShortDateString(),
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
            this.UpdateReturnFurnitureUserControl();
            this.FormatSelectedMemberAndFurnitureListView();
        }

        /// <summary>
        /// Currentlies the rented furniture ListView double click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void CurrentlyRentedFurnitureListViewDoubleClick(object sender, System.EventArgs e)
        {
            if (CurrentlyRentedFurnitureListView.SelectedItems.Count == 1)
            {
                ListViewItem selectedItem = CurrentlyRentedFurnitureListView.SelectedItems[0];
                int furnitureID = int.Parse(selectedItem.Text);
                int rentalTransactionID = int.Parse(selectedItem.SubItems[1].Text);

                if (returnFurnitureList.Any(f => f.FurnitureID == furnitureID && f.RentalTransactionID == rentalTransactionID))
                {
                    ItemsToReturnLabel.Text = "This rental furniture is already selected for return.";
                    return;
                }

                Furniture chosenFurniture = new Furniture
                {
                    FurnitureID = furnitureID,
                    RentalTransactionID = int.Parse(selectedItem.SubItems[1].Text),
                    RentalItemID = int.Parse(selectedItem.SubItems[2].Text),
                    Name = selectedItem.SubItems[3].Text,
                    CategoryName = selectedItem.SubItems[4].Text,
                    StyleName = selectedItem.SubItems[5].Text,
                    Description = selectedItem.SubItems[6].Text,
                    RentalDate = System.DateTime.Parse(selectedItem.SubItems[7].Text),
                    DueDate = System.DateTime.Parse(selectedItem.SubItems[8].Text),
                    AmountRented = int.Parse(selectedItem.SubItems[9].Text)
                };

                returnFurnitureList.Add(chosenFurniture);
            }
            this.UpdateReturnFurnitureUserControl();
            this.UpdateItemsToReturnLabel();
        }

        /// <summary>
        /// Programmatically formats the list views for selected member and furniture.
        /// </summary>
        private void UpdateItemsToReturnLabel()
        {
            ItemsToReturnLabel.Text = "Selected Items for Return: " + returnFurnitureList.Count.ToString();
        }

        /// <summary>
        /// Programmatically formats the list views for selected member and furniture.
        /// </summary>
        public void SetReturnFurnitureUserControl(ReturnFurnitureUserControl returnFurnitureUserControl)
        {
            this.ReturnFurnitureUserControl = returnFurnitureUserControl;
        }

        /// <summary>
        /// Programmatically formats the list views for selected member and furniture.
        /// </summary>
        private void UpdateReturnFurnitureUserControl()
        {
            this.ReturnFurnitureUserControl.DisplaySelectedFurniture(this.returnFurnitureList);
        }

        /// <summary>
        /// Removes a furniture item from SelectedFurniture by ID. Updates the count in MemberDashboard.
        /// </summary>
        /// <param name="furnitureID">ID of furniture item to remove..</param>
        public void RemoveFurnitureItem(int furnitureID, int rentalTransactionID)
        {
            returnFurnitureList.RemoveAll(f => f.FurnitureID == furnitureID && f.RentalTransactionID == rentalTransactionID);
            UpdateItemsToReturnLabel();
        }
    }
}
