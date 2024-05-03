using SofaSoGood.Controller;
using SofaSoGood.Model;
using SofaSoGood.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    public partial class ReturnFurnitureUserControl : UserControl
    {

        private LoginForm LoginForm;
        private RentalController RentalController;
        private ReturnController ReturnController;
        private SearchMemberUserControl SearchMemberUserControl;
        private BuildReturnUserControl BuildReturnUserControl;
        public ReturnFurnitureUserControl()
        {
            InitializeComponent();
            this.RentalController = new RentalController();
            this.ReturnController = new ReturnController();
            SelectedFurnitureDataGridView.ContextMenuStrip = SelectedFurnitureMenuStrip;
            ReturnDateTextBox.Text = DateTime.Now.ToString("d");
            CheckIfMemberAndFurniturePopulated();
            FormatSelectedMemberAndFurnitureListView();
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void CheckIfMemberAndFurniturePopulated()
        {
            bool memberPopulated = this.SelectedMemberListView.Items.Count > 0;
            bool furniturePopulated = this.SelectedFurnitureDataGridView.Rows.Count > 0;

            this.SelectedMemberListView.BackColor = !memberPopulated ? Color.LightGray : SystemColors.Window;
            this.SelectedFurnitureDataGridView.BackColor = !furniturePopulated ? Color.LightGray : SystemColors.Window;

            this.SelectedMemberLabel.Text = memberPopulated ? "" : "Please select a member in the Search Member tab.";
            this.SelectedFurnitureLabel.Text = furniturePopulated ? "Click AmountToReturn to Edit Quantities, Right Click to Remove" : "Please select furniture to return.";

            if (memberPopulated && furniturePopulated)
            {
                this.ReturnFurnitureButton.Enabled = true;
            }
            else 
            {
                this.ReturnFurnitureButton.Enabled = false;
            }
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
            }
            FormatSelectedMemberAndFurnitureListView();
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
                newRow.Cells["RentalTransactionID"].Value = furniture.RentalTransactionID;
                newRow.Cells["RentalItemID"].Value = furniture.RentalItemID;
                newRow.Cells["FurnitureName"].Value = furniture.Name;
                newRow.Cells["FurnitureCategory"].Value = furniture.CategoryName;
                newRow.Cells["FurnitureStyle"].Value = furniture.StyleName;
                newRow.Cells["Description"].Value = furniture.Description;
                newRow.Cells["RentalDate"].Value = furniture.RentalDate.ToString("d");
                newRow.Cells["DueDate"].Value = furniture.DueDate.ToString("d");
                newRow.Cells["AmountRented"].Value = furniture.AmountRented;
                newRow.Cells["AmountToReturn"].Value = "1";
            }
            this.FormatSelectedMemberAndFurnitureListView();
            CalculateTotals();
        }

        private void SelectedFurnitureDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dataGridView = (DataGridView)sender;

            if (dataGridView.Columns[e.ColumnIndex].Name == "AmountToReturn")
            {
                int amountToReturn;
                bool isValidNumber = int.TryParse(e.FormattedValue.ToString(), out amountToReturn);

                int amountRented = (int)dataGridView.Rows[e.RowIndex].Cells["AmountRented"].Value;
                CalculateTotals();

                if (!isValidNumber || amountToReturn > amountRented || amountToReturn <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show($"Amount to return must be a positive number and cannot exceed the amount rented ({amountRented}).", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnFurnitureButtonClick(object sender, EventArgs e)
        {
            if (!ConfirmReturnTransaction()) 
            {
                return;
            }
            DateTime returnDate = DateTime.Now;
            List<ReturnItem> returnItems = new List<ReturnItem>();

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                int rentalItemID = Convert.ToInt32(row.Cells["RentalItemID"].Value);
                int quantityReturned = Convert.ToInt32(row.Cells["AmountToReturn"].Value);
                int furnitureID = Convert.ToInt32(row.Cells["FurnitureID"].Value);
                decimal dailyRate = this.RentalController.GetFurnitureDailyRate(Convert.ToInt32(row.Cells["FurnitureID"].Value));
                DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);

                ReturnItem returnItem = new ReturnItem
                {
                    RentalItemID = rentalItemID,
                    FurnitureID = furnitureID,
                    QuantityReturned = quantityReturned
                };
                returnItems.Add(returnItem);
            }

            ReturnTransaction returnTransaction = new ReturnTransaction
            {
                EmployeeID = this.LoginForm.LoggedInEmployee.EmployeeID,
                MemberID = this.SearchMemberUserControl.SelectedMember.MemberID,
                ReturnDate = returnDate,
                ReturnItems = returnItems
            };

            this.ReturnController.ProcessReturn(returnTransaction);
            var returnForm = new ReturnForm(returnTransaction);
            returnForm.ShowDialog();
            SelectedFurnitureDataGridView.Rows.Clear();
            SearchMemberUserControl.BuildReturnUserControl.DisplaySelectedMemberAndUpdateCurrentlyRentedFurniture(SearchMemberUserControl.SelectedMember);
            SearchMemberUserControl.UpdateHistory();
            CalculateTotals();
            CheckIfMemberAndFurniturePopulated();
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void SetLoginForm(LoginForm loginForm)
        {
            this.LoginForm = loginForm;
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void SetSearchMemberUserControl(SearchMemberUserControl searchMemberUserControl)
        {
            this.SearchMemberUserControl = searchMemberUserControl;
        }

        /// <summary>
        /// Checks if both member and furniture are populated and adjusts control accessibility accordingly.
        /// </summary>
        public void SetBuildReturnUserControl(BuildReturnUserControl buildReturnUserControl)
        {
            this.BuildReturnUserControl = buildReturnUserControl;
        }

        private void CalculateTotals()
        {
            decimal totalFine = 0m;
            decimal totalRefund = 0m;
            decimal netAmount = 0m;

            DateTime returnDate = DateTime.Now;

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                if (row.Cells["AmountToReturn"].Value != null && int.TryParse(row.Cells["AmountToReturn"].Value.ToString(), out int amountToReturn))
                {
                    int furnitureId = Convert.ToInt32(row.Cells["FurnitureID"].Value);
                    DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);
                    DateTime rentalDate = Convert.ToDateTime(row.Cells["RentalDate"].Value);
                    decimal dailyRate = this.RentalController.GetFurnitureDailyRate(furnitureId);

                    int daysLate = (returnDate - dueDate).Days;
                    int daysEarly = (dueDate - returnDate).Days;

                    if (daysLate > 0)
                    {
                        decimal fineAmount = dailyRate * amountToReturn * daysLate;
                        totalFine += fineAmount;
                    }
                    else if (daysEarly > 0)
                    {
                        decimal refundAmount = dailyRate * amountToReturn * daysEarly;
                        totalRefund += refundAmount;
                    }
                }
            }

            netAmount = totalFine - totalRefund;

            FineTextBox.Text = totalFine.ToString("C");
            RefundTextBox.Text = totalRefund.ToString("C");
            TotalTextBox.Text = Math.Abs(netAmount).ToString("C");

            if (netAmount > 0)
            {
                TotalTextBox.BackColor = Color.Red;
            }
            else if (netAmount < 0)
            {
                TotalTextBox.BackColor = Color.LightGreen;
            }
            else
            {
                TotalTextBox.BackColor = Color.LightGray;
            }
        }

        private void SelectedFurnitureDataGridViewCellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            CalculateTotals();
        }

        /// <summary>
        /// Asks the User to confirm the transaction before proceeding.
        /// </summary>
        /// <returns>boolean for confirmation</returns>
        private bool ConfirmReturnTransaction()
        {
            string confirmationMessage = "Confirm return of the following items:\n";

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                string itemName = row.Cells["FurnitureName"].Value.ToString();
                int quantity = Convert.ToInt32(row.Cells["AmountToReturn"].Value);
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

        private void RemoveMenuItemClick(object sender, EventArgs e)
        {
            if (SelectedFurnitureDataGridView.SelectedRows.Count == 1)
            {
                var selectedRow = SelectedFurnitureDataGridView.SelectedRows[0];
                int furnitureIdToRemove = Convert.ToInt32(selectedRow.Cells["FurnitureID"].Value);
                int rentalTransactionIdToRemove = Convert.ToInt32(selectedRow.Cells["RentalTransactionID"].Value);

                SelectedFurnitureDataGridView.Rows.Remove(selectedRow);
                this.BuildReturnUserControl.RemoveFurnitureItem(furnitureIdToRemove, rentalTransactionIdToRemove);
            }
            this.CheckIfMemberAndFurniturePopulated();
            CalculateTotals();
        }
    }
    }
