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
            comboFurniture.DataSource = furnitureController.GetAllFurniture();
            comboFurniture.DisplayMember = "Name";
            comboFurniture.ValueMember = "FurnitureID";
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            if (ValidateRentalItem())
            {
                int furnitureId = Convert.ToInt32(comboFurniture.SelectedValue);
                int quantity = Convert.ToInt32(txtQuantity.Text);

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

        private void btnRemoveItem_Click(object sender, EventArgs e)
        {
            if (currentRentalTransaction.RentalItems.Count > 0 && dgvRentalItems.SelectedRows.Count > 0)
            {
                int selectedIndex = dgvRentalItems.SelectedRows[0].Index;
                currentRentalTransaction.RentalItems.RemoveAt(selectedIndex);
                UpdateRentalItemGrid();
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (ValidateRentalTransaction())
            {
                currentRentalTransaction.MemberID = Convert.ToInt32(txtMemberId.Text);
                currentRentalTransaction.EmployeeID = Convert.ToInt32(txtEmployeeId.Text);
                currentRentalTransaction.TotalCost = CalculateTotalCost();

                rentalController.CreateRentalTransaction(currentRentalTransaction);
                MessageBox.Show("Rental transaction submitted successfully!");
                ClearForm();
            }
        }

        private bool ValidateRentalItem()
        {
            if (comboFurniture.SelectedIndex == -1)
            {
                MessageBox.Show("Please select a furniture item.");
                return false;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return false;
            }

            return true;
        }

        private bool ValidateRentalTransaction()
        {
            if (!int.TryParse(txtMemberId.Text, out int memberId))
            {
                MessageBox.Show("Please enter a valid member ID.");
                return false;
            }

            if (!int.TryParse(txtEmployeeId.Text, out int employeeId))
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
            dgvRentalItems.DataSource = null;
            dgvRentalItems.DataSource = currentRentalTransaction.RentalItems;
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
            comboFurniture.SelectedIndex = -1;
            txtQuantity.Clear();
        }

        private void ClearForm()
        {
            currentRentalTransaction = new RentalTransaction
            {
                RentalTransactionID = rentalController.GetNextRentalTransactionID(),
                RentalDate = DateTime.Now,
                DueDate = DateTime.Now.AddDays(7),
                RentalItems = new List<RentalItem>()
            };

            txtMemberId.Clear();
            txtEmployeeId.Clear();
            ClearRentalItemForm();
            UpdateRentalItemGrid();
        }
    }
}