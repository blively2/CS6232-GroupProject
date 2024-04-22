using SofaSoGood.Controller;
using SofaSoGood.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SofaSoGood.View
{
    /// <summary>
    /// ReceiptForm that displays after a successful transaction and when doubleclicking order history.
    /// </summary>
    public partial class ReturnForm : Form
    {
        private ReturnTransaction returnTransaction;
        private MemberController memberController;
        private RentalController rentalController;
        private FurnitureController furnitureController;
        private EmployeeController employeeController;
        private Employee ReturnedByEmployee;

        /// <summary>
        /// Constructs a new ReceiptForm.
        /// </summary>
        public ReturnForm(ReturnTransaction returnTransaction)
        {
            InitializeComponent();
            this.returnTransaction = returnTransaction;
            this.memberController = new MemberController();
            this.rentalController = new RentalController();
            this.furnitureController = new FurnitureController();
            this.employeeController = new EmployeeController();
            TransactionIDLabel.Text = "Transaction Number: " + this.returnTransaction.ReturnTransactionID.ToString();
            this.PopulateMemberListView();
            this.DisplayFurniture(this.returnTransaction.ReturnItems);
            this.ReturnedByEmployee = this.employeeController.GetEmployeeByEmployeeID(returnTransaction.EmployeeID);
            ReturnDateLabel.Text = "Return Date: " + this.returnTransaction.ReturnDate.ToShortDateString();
            ReturnAmountCostLabel.Text = "Refund Amount: $" + this.returnTransaction.ReturnAmount.ToString();
            FineAmountLabel.Text = "Fine Amount: $" + this.returnTransaction.FineAmount.ToString();
            ReturnedByLabel.Text = "Rented By: " + this.ReturnedByEmployee.FirstName + ReturnedByEmployee.LastName;
        }

        /// <summary>
        /// Populates the Member for the Receipt.
        /// </summary>
        private void PopulateMemberListView()
        {
            Member member = this.memberController.GetMemberById(this.returnTransaction.MemberID);
            if (member != null)
            {
                MemberListView.Items.Clear();
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
                MemberListView.Items.Add(item);
            }
            this.FormatMemberAndFurniture();
        }

        /// <summary>
        /// Displays the selected furniture items in the ListView.
        /// </summary>
        /// <param name="selectedFurniture">List of selected furniture.</param>
        public void DisplayFurniture(List<ReturnItem> ReturnItems)
        {
            FurnitureDataGridView.Rows.Clear();

            foreach (var returnItem in ReturnItems)
            {
                int furnitureID = rentalController.GetFurnitureIdByRentalItemId(returnItem.RentalItemID);
                Furniture furniture = furnitureController.GetFurnitureByID(furnitureID);
                int index = FurnitureDataGridView.Rows.Add();
                DataGridViewRow newRow = FurnitureDataGridView.Rows[index];
                newRow.Cells["FurnitureID"].Value = furniture.FurnitureID;
                newRow.Cells["FurnitureName"].Value = furniture.Name;
                newRow.Cells["FurnitureCategory"].Value = furniture.CategoryName;
                newRow.Cells["FurnitureStyle"].Value = furniture.StyleName;
                newRow.Cells["Description"].Value = furniture.Description;
                newRow.Cells["RentalRatePerDay"].Value = furniture.RentalRatePerDay.ToString("C");
                newRow.Cells["Quantity"].Value = returnItem.QuantityReturned;
            }
        }

        /// <summary>
        /// Programmatically formats the list views for selected member and furniture.
        /// </summary>
        private void FormatMemberAndFurniture()
        {
            foreach (ColumnHeader column in MemberListView.Columns)
            {
                column.Width = -2;
            }

            foreach (DataGridViewColumn column in FurnitureDataGridView.Columns)
            {
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }

            FurnitureDataGridView.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
            FurnitureDataGridView.Refresh();
            MemberListView.Refresh();
        }
    }
}
