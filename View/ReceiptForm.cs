using SofaSoGood.Controller;
using SofaSoGood.Model;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SofaSoGood.View
{
    public partial class ReceiptForm : Form
    {
        private RentalTransaction rentalTransaction;
        private MemberController memberController;
        private FurnitureController furnitureController;
        public ReceiptForm(RentalTransaction rentalTransaction)
        {
            InitializeComponent();
            this.rentalTransaction = rentalTransaction;
            this.memberController = new MemberController();
            this.furnitureController = new FurnitureController();
            TransactionIDLabel.Text = "Transaction Number: " + this.rentalTransaction.RentalTransactionID.ToString();
            this.PopulateMemberListView();
            this.DisplayFurniture(this.rentalTransaction.RentalItems);
            DueDateLabel.Text = "Due Date: " + this.rentalTransaction.DueDate.ToShortDateString();
            TotalCostLabel.Text = "Total Cost: $" + this.rentalTransaction.TotalCost.ToString();
        }

        private void PopulateMemberListView()
        {
            Member member = this.memberController.GetMemberById(this.rentalTransaction.MemberID);
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
        public void DisplayFurniture(List<RentalItem> RentalItems)
        {
            FurnitureDataGridView.Rows.Clear();

            foreach (var rentalItem in RentalItems)
            {
                Furniture furniture = this.furnitureController.GetFurnitureByID(rentalItem.FurnitureID);
                int index = FurnitureDataGridView.Rows.Add();
                DataGridViewRow newRow = FurnitureDataGridView.Rows[index];
                newRow.Cells["FurnitureID"].Value = furniture.FurnitureID;
                newRow.Cells["FurnitureName"].Value = furniture.Name;
                newRow.Cells["FurnitureCategory"].Value = furniture.CategoryName;
                newRow.Cells["FurnitureStyle"].Value = furniture.StyleName;
                newRow.Cells["Description"].Value = furniture.Description;
                newRow.Cells["RentalRatePerDay"].Value = furniture.RentalRatePerDay.ToString("C");
                newRow.Cells["Quantity"].Value = rentalItem.Quantity;
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
