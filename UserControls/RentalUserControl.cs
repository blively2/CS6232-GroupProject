using System;
using System.Collections.Generic;
using System.Windows.Forms;
using SofaSoGood.Controller;
using SofaSoGood.Model;

namespace SofaSoGood.UserControls
{
    public partial class RentalUserControl : UserControl
    {
        private readonly RentalController rentalController;
        private readonly FurnitureController furnitureController;
        private RentalTransaction currentRentalTransaction;

        public RentalUserControl()
        {
            InitializeComponent();
            rentalController = new RentalController();
            furnitureController = new FurnitureController();
            InitializeFurnitureComboBox();
            ClearForm();
        }

        private void InitializeFurnitureComboBox()
        {
            var furniture = furnitureController.GetAllFurniture();
            if (furniture != null)
            {
                furnitureComboBox.DataSource = furniture;
                furnitureComboBox.DisplayMember = "Name";
                furnitureComboBox.ValueMember = "FurnitureID";
                furnitureComboBox.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show("Error retrieving furniture list.");
            }
        }

        private void AddItemButton_Click(object sender, EventArgs e)
        {
            if (ValidateRentalItem())
            {
                int furnitureId = Convert.ToInt32(furnitureComboBox.SelectedValue);
                int quantity = Convert.ToInt32(quantityTextBox.Text);

                var rentalItem = new RentalItem
                {
                    RentalItemID = currentRentalTransaction.RentalItems.Count + 1,
                    RentalTransactionID = currentRentalTransaction.RentalTransactionID,
                    FurnitureID = furnitureId,
                    Quantity = quantity,
                    DailyRate = furnitureController.GetFurnitureDailyRate(furnitureId)
                };

                currentRentalTransaction.RentalItems.Add(rentalItem);
                UpdateRentalItemGrid();
                ClearRentalItemForm();
            }
        }

        private void RemoveItemButton_Click(object sender, EventArgs e)
        {
            if (rentalItemsDataGridView.SelectedRows.Count > 0 && rentalItemsDataGridView.SelectedRows[0].Index != -1)
            {
                int selectedIndex = rentalItemsDataGridView.SelectedRows[0].Index;
                currentRentalTransaction.RentalItems.RemoveAt(selectedIndex);
                UpdateRentalItemGrid();
            }
            else
            {
                MessageBox.Show("Please select an item to remove.");
            }
        }

        private void SubmitOrderButton_Click(object sender, EventArgs e)
        {
            if (ValidateRentalTransaction())
            {
                currentRentalTransaction.MemberID = Convert.ToInt32(memberIdTextBox.Text);
                currentRentalTransaction.EmployeeID = Convert.ToInt32(employeeIdTextBox.Text);
                currentRentalTransaction.TotalCost = CalculateTotalCost();

                rentalController.CreateRentalTransaction(currentRentalTransaction);
                MessageBox.Show("Rental transaction submitted successfully!");
                ClearForm();
            }
        }

        private bool ValidateRentalItem()
        {
            if (furnitureComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a furniture item.");
                return false;
            }

            if (!int.TryParse(quantityTextBox.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return false;
            }

            return true;
        }

        private bool ValidateRentalTransaction()
        {
            if (!int.TryParse(memberIdTextBox.Text, out int memberId))
            {
                MessageBox.Show("Please enter a valid member ID.");
                return false;
            }

            if (!int.TryParse(employeeIdTextBox.Text, out int employeeId))
            {
                MessageBox.Show("Please enter a valid employee ID.");
                return false;
            }

            if (currentRentalTransaction.RentalItems.Count == 0)
            {
                MessageBox.Show("Please add at least one rental item.");
                return false;
            }

            return true;
        }

        private void UpdateRentalItemGrid()
        {
            rentalItemsDataGridView.DataSource = null;
            if (currentRentalTransaction.RentalItems.Count > 0)
            {
                rentalItemsDataGridView.DataSource = currentRentalTransaction.RentalItems;
            }
            rentalItemsDataGridView.ClearSelection();
        }

        private decimal CalculateTotalCost()
        {
            decimal totalCost = 0;
            foreach (var item in currentRentalTransaction.RentalItems)
            {
                totalCost += item.Quantity * item.DailyRate;
            }
            return totalCost;
        }

        private void ClearRentalItemForm()
        {
            furnitureComboBox.SelectedIndex = -1;
            quantityTextBox.Clear();
        }

        private void ClearForm()
        {
            try
            {
                currentRentalTransaction = new RentalTransaction
                {
                    RentalTransactionID = rentalController.GetNextRentalTransactionID(),
                    RentalDate = DateTime.Now,
                    DueDate = DateTime.Now.AddDays(7),
                    RentalItems = new List<RentalItem>()
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to initialize the form. Error: {ex.Message}");
                return;
            }
            memberIdTextBox.Clear();
            employeeIdTextBox.Clear();
            ClearRentalItemForm();
            UpdateRentalItemGrid();
        }
    }
}