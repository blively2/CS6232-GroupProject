using SofaSoGood.Controller;
using SofaSoGood.DAL;
using SofaSoGood.Model;
using SofaSoGood.View;
using System;
using System.CodeDom;
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
    public partial class ReturnFurnitureUserControl : UserControl
    {

        private LoginForm LoginForm;
        private RentalController RentalController;
        private ReturnController ReturnController;
        private SearchMemberUserControl SearchMemberUserControl;
        public ReturnFurnitureUserControl()
        {
            InitializeComponent();
            this.RentalController = new RentalController();
            this.ReturnController = new ReturnController();
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

            this.SelectedMemberLabel.Text = memberPopulated ? "" : "Please select a member.";
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
                newRow.Cells["DueDate"].Value = furniture.DueDate.ToString("d");
                newRow.Cells["AmountRented"].Value = furniture.AmountRented;
                newRow.Cells["AmountToReturn"].Value = "1";
            }
            this.FormatSelectedMemberAndFurnitureListView();
        }

        private void SelectedFurnitureDataGridView_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            var dataGridView = (DataGridView)sender;

            if (dataGridView.Columns[e.ColumnIndex].Name == "AmountToReturn")
            {
                int amountToReturn;
                bool isValidNumber = int.TryParse(e.FormattedValue.ToString(), out amountToReturn);

                int amountRented = (int)dataGridView.Rows[e.RowIndex].Cells["AmountRented"].Value;

                if (!isValidNumber || amountToReturn > amountRented || amountToReturn <= 0)
                {
                    e.Cancel = true;
                    MessageBox.Show($"Amount to return must be a positive number and cannot exceed the amount rented ({amountRented}).", "Invalid Entry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ReturnFurnitureButtonClick(object sender, EventArgs e)
        {
            DateTime returnDate = DateTime.Now;
            List<ReturnItem> returnItems = new List<ReturnItem>();

            foreach (DataGridViewRow row in SelectedFurnitureDataGridView.Rows)
            {
                int rentalItemID = Convert.ToInt32(row.Cells["RentalItemID"].Value);
                int quantityReturned = Convert.ToInt32(row.Cells["AmountToReturn"].Value);
                decimal dailyRate = this.RentalController.GetFurnitureDailyRate(Convert.ToInt32(row.Cells["FurnitureID"].Value));
                DateTime dueDate = Convert.ToDateTime(row.Cells["DueDate"].Value);

                // Create a ReturnItem object and add it to the list
                ReturnItem returnItem = new ReturnItem
                {
                    RentalItemID = rentalItemID,
                    QuantityReturned = quantityReturned
                };
                returnItems.Add(returnItem);
            }

            // Create the ReturnTransaction object
            ReturnTransaction returnTransaction = new ReturnTransaction
            {
                EmployeeID = this.LoginForm.LoggedInEmployee.EmployeeID,
                MemberID = this.SearchMemberUserControl.SelectedMember.MemberID,
                ReturnDate = returnDate,
                ReturnItems = returnItems
            };

            this.ReturnController.ProcessReturn(returnTransaction);
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
    }
}
