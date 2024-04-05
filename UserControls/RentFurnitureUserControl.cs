using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using SofaSoGood.Controller;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Renting Furniture.
    /// Has a reference to the SearchFurnitureUserControl.
    /// </summary>
    public partial class RentFurnitureUserControl : UserControl
    {

        // Field to hold reference to the SearchFurnitureUserControl.
        private SearchFurnitureUserControl SearchFurnitureUserControl;

        // Field to hold reference to the SearchFurnitureUserControl.
        private SearchMemberUserControl SearchMemberUserControl;

        // Instance of LoginForm to access LoggedInEmployee.
        private LoginForm LoginForm;

        // Instance of RentalController
        private RentalController rentalController;

        /// <summary>
        /// Constructor for RentFurnitureUserControl.
        /// Initializes components, formats the list views, and checks if member and furniture are populated.
        /// </summary>
        public RentFurnitureUserControl()
        {
            InitializeComponent();
            this.FormatSelectedMemberAndFurnitureListView();
            this.CheckIfMemberAndFurniturePopulated();
            this.DateAlertLabel.Text = string.Empty;
            SelectedFurnitureDataGridView.ContextMenuStrip = SelectedFurnitureMenuStrip;
            this.rentalController = new RentalController();
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
                this.SearchFurnitureUserControl.ClearSelectedFurniture();
                this.DisplaySelectedFurniture(this.SearchFurnitureUserControl.SelectedFurniture);
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
            SelectedFurnitureDataGridView.Rows.Clear();

            foreach (var furniture in selectedFurniture)
            {
                int index = SelectedFurnitureDataGridView.Rows.Add();
                DataGridViewRow newRow = SelectedFurnitureDataGridView.Rows[index];
                newRow.Cells["FurnitureID"].Value = furniture.FurnitureID;
                newRow.Cells["FurnitureName"].Value = furniture.Name;
                newRow.Cells["FurnitureCategory"].Value = furniture.CategoryName;
                newRow.Cells["FurnitureStyle"].Value = furniture.StyleName;
                newRow.Cells["Description"].Value = furniture.Description;
                newRow.Cells["RentalRatePerDay"].Value = furniture.RentalRatePerDay.ToString("C");
                newRow.Cells["InStockQuantity"].Value = furniture.InStockQuantity;
                newRow.Cells["TotalQuantity"].Value = furniture.TotalQuantity;
                newRow.Cells["AmountToRent"].Value = "1";
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

            foreach (DataGridViewColumn column in SelectedFurnitureDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            SelectedFurnitureDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            SelectedFurnitureDataGridView.Refresh();
            SelectedMemberListView.Refresh();
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
        /// Sets the reference to the SearchMemberUserControl.
        /// </summary>
        /// <param name="searchMemberUserControl">The SearchMemberUserControl instance.</param>
        public void SetSearchMemberUserControl(SearchMemberUserControl searchMemberUserControl)
        {
            this.SearchMemberUserControl = searchMemberUserControl;
        }

        /// <summary>
        /// Sets the reference to the SearchFurnitureUserControl.
        /// </summary>
        /// <param name="searchFurnitureUserControl">The SearchFurnitureUserControl instance.</param>
        public void SetLoginForm(LoginForm loginForm)
        {
            this.LoginForm = loginForm;
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void CheckIfMemberAndFurniturePopulated()
        {
            bool memberPopulated = this.SelectedMemberListView.Items.Count > 0;
            bool furniturePopulated = this.SelectedFurnitureDataGridView.Rows.Count > 0;

            this.StartDatePicker.Enabled = memberPopulated && furniturePopulated;
            this.EndDatePicker.Enabled = memberPopulated && furniturePopulated;
            this.RentFurnitureButton.Enabled = memberPopulated && furniturePopulated;

            this.SelectedMemberListView.BackColor = !memberPopulated ? Color.LightGray : SystemColors.Window;
            this.SelectedFurnitureDataGridView.BackColor = !furniturePopulated ? Color.LightGray : SystemColors.Window;

            this.UseSearchMemberFunctionalityLabel.Text = memberPopulated ? "" : "Please select a member.";
            this.UseSearchFurnitureFunctionalityLabel.Text = furniturePopulated ? "Click AmountToRent to Edit Quantities, Right Click to Remove" : "Please select furniture to rent.";
        }


        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        /// </summary>
        private void RentFurnitureButtonClick(object sender, EventArgs e)
        {
            if (!ValidateRentalDates() || !ConfirmRentalTransaction())
            {
                return;
            }

            List<RentalItem> RentalItems = new List<RentalItem>();

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                if (row.Cells["FurnitureID"].Value != null && row.Cells["AmountToRent"].Value != null && row.Cells["RentalRatePerDay"].Value != null)
                {
                    RentalItem item = new RentalItem
                    {
                        FurnitureID = Convert.ToInt32(row.Cells["FurnitureID"].Value),
                        Quantity = Convert.ToInt32(row.Cells["AmountToRent"].Value),
                        DailyRate = Convert.ToDecimal(row.Cells["RentalRatePerDay"].Value.ToString().Replace("$", ""))
                    };
                    TimeSpan rentalPeriod = EndDatePicker.Value.Date - StartDatePicker.Value.Date;
                    int rentalDays = rentalPeriod.Days + 1;

                    item.DailyRate = item.Quantity * item.DailyRate;

                    RentalItems.Add(item);
                }
            }

            RentalTransaction rentalTransaction = new RentalTransaction();
            rentalTransaction.MemberID = this.SearchMemberUserControl.SelectedMember.MemberID;
            rentalTransaction.EmployeeID = this.LoginForm.LoggedInEmployee.EmployeeID;
            rentalTransaction.RentalDate = StartDatePicker.Value.Date;
            rentalTransaction.DueDate = EndDatePicker.Value.Date;
            rentalTransaction.TotalCost = decimal.Parse(TotalTextBox.Text.Replace("$", ""));
            rentalTransaction.RentalItems = RentalItems;

            System.Diagnostics.Debug.WriteLine(rentalTransaction.MemberID);
            System.Diagnostics.Debug.WriteLine(rentalTransaction.EmployeeID);
            System.Diagnostics.Debug.WriteLine(rentalTransaction.RentalDate);
            System.Diagnostics.Debug.WriteLine(rentalTransaction.DueDate);
            System.Diagnostics.Debug.WriteLine(rentalTransaction.TotalCost);

            this.rentalController.CreateRentalTransaction(rentalTransaction);
        }

        /// <summary>
        /// Asks the User to confirm the transaction before proceeding.
        /// </summary>
        /// <returns></returns>
        private bool ConfirmRentalTransaction()
        {
            string confirmationMessage = "Confirm rental of the following items:\n";

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                string itemName = row.Cells["FurnitureName"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["AmountToRent"].Value);
                confirmationMessage += $"{quantity} x {itemName}\n";
            }

                string memberName = $"{this.SearchMemberUserControl.SelectedMember.FirstName} {this.SearchMemberUserControl.SelectedMember.LastName}";
                confirmationMessage += $"to {memberName} for ";

            string totalCost = TotalTextBox.Text;
            confirmationMessage += $"{totalCost}.";

            DialogResult dialogResult = MessageBox.Show(confirmationMessage, "Confirm Rental", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dialogResult == DialogResult.Yes)
            {
                return true;
            }
            return false;
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

            if (this.EndDatePicker.Value.Date < this.StartDatePicker.Value.Date)
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

        /// <summary>
        /// Captures the beginning of edits for AmountToRent.
        /// </summary>
        private void SelectedFurnitureDataGridViewCellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (SelectedFurnitureDataGridView.Columns[e.ColumnIndex].Name != "AmountToRent")
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Validates the entered value of AmountToRent
        /// </summary>
        private void SelectedFurnitureDataGridViewCellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (SelectedFurnitureDataGridView.Columns[e.ColumnIndex].Name == "AmountToRent")
            {
                if (!int.TryParse(e.FormattedValue.ToString(), out int newAmountToRent))
                {
                    MessageBox.Show("Please enter a valid number for the amount to rent.");
                    e.Cancel = true;
                }
                else
                {
                    int inStockQuantity = Convert.ToInt32(SelectedFurnitureDataGridView["InStockQuantity", e.RowIndex].Value);
                    if (newAmountToRent > inStockQuantity)
                    {
                        MessageBox.Show("The amount to rent cannot exceed the in-stock quantity.");
                        e.Cancel = true;
                    }
                    else if (newAmountToRent < 1)
                    {
                        MessageBox.Show("Positive Integers only.");
                        e.Cancel = true;
                    }
                }
            }
            else
            {
                SelectedFurnitureDataGridView.CancelEdit();
            }
        }

        /// <summary>
        /// Allows the user to right click a furniture item to remove.
        /// </summary>
        private void RemoveMenuItemClick(object sender, EventArgs e)
        {
            if (SelectedFurnitureDataGridView.SelectedRows.Count == 1)
            {
                var selectedRow = SelectedFurnitureDataGridView.SelectedRows[0];
                int furnitureIdToRemove = Convert.ToInt32(selectedRow.Cells["FurnitureID"].Value);

                SelectedFurnitureDataGridView.Rows.Remove(selectedRow);
                this.SearchFurnitureUserControl.RemoveFurnitureItem(furnitureIdToRemove);
            }
            this.CheckIfMemberAndFurniturePopulated();
            UpdateCostSummary();
        }

        /// <summary>
        /// Updates the cost for display.
        /// </summary>
        private void UpdateCostSummary()
        {
            decimal totalCost = 0m;
            const decimal taxRate = 0.07m;

            TimeSpan rentalPeriod = EndDatePicker.Value.Date - StartDatePicker.Value.Date;
            int rentalDays = Math.Max(1, rentalPeriod.Days + 1);

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                if (row.Cells["AmountToRent"].Value != null && row.Cells["RentalRatePerDay"].Value != null)
                {
                    int amountToRent = Convert.ToInt32(row.Cells["AmountToRent"].Value);
                    decimal rentalRatePerDay = Convert.ToDecimal(row.Cells["RentalRatePerDay"].Value.ToString().Replace("$", ""));
                    totalCost += (amountToRent * rentalRatePerDay) * rentalDays;
                }
            }

            decimal tax = totalCost * taxRate;
            decimal total = totalCost + tax;

            CostTextBox.Text = totalCost.ToString("C");
            TaxTextBox.Text = tax.ToString("C");
            TotalTextBox.Text = total.ToString("C");
        }

        /// <summary>
        /// Updates the cost summary when changes are made to AmountToRent
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectedFurnitureDataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
                UpdateCostSummary();
        }

        /// <summary>
        /// Updates the cost summary when changes are made to EndDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EndDatePickerValueChanged(object sender, EventArgs e)
        {
            UpdateCostSummary();
        }

        /// <summary>
        /// Updates the cost summary when changes are made to StartDate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StartDatePickerValueChanged(object sender, EventArgs e)
        {
            UpdateCostSummary();
        }
    }
}
