using SofaSoGood.Controller;
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
    public partial class RentalHistoryUserControl : UserControl
    {
        private RentalController rentalController;

        public RentalHistoryUserControl()
        {
            InitializeComponent();
            InitializeDataGridView();
            rentalController = new RentalController();
        }

        private void InitializeDataGridView()
        {
            rentalHistoryDataGridView.Columns.Add("RentalTransactionID", "Transaction ID");
            rentalHistoryDataGridView.Columns.Add("RentalDate", "Rental Date");
            rentalHistoryDataGridView.Columns.Add("DueDate", "Due Date");
            rentalHistoryDataGridView.Columns.Add("TotalCost", "Total Cost");

            rentalHistoryDataGridView.Columns["RentalDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            rentalHistoryDataGridView.Columns["DueDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            rentalHistoryDataGridView.Columns["TotalCost"].DefaultCellStyle.Format = "C2";

            rentalHistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public void LoadRentalHistory(int memberId)
        {
            rentalHistoryDataGridView.Rows.Clear();

            var rentalHistory = rentalController.GetRentalHistoryByMemberId(memberId);

            if (rentalHistory.Count > 0)
            {
                foreach (var transaction in rentalHistory)
                {
                    rentalHistoryDataGridView.Rows.Add(transaction.RentalTransactionID,
                                                   transaction.RentalDate.ToString("yyyy-MM-dd"),
                                                   transaction.DueDate.ToString("yyyy-MM-dd"),
                                                   transaction.TotalCost.ToString("C2"));
                }
            }
            else
            {
                MessageBox.Show($"No rental history found for Member ID: {memberId}", "Rental History Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void searchHistoryButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(memberIdTextBox.Text, out int memberId))
            {
                LoadRentalHistory(memberId);
            }
            else
            {
                MessageBox.Show("Please enter a valid Member ID.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                rentalHistoryDataGridView.Rows.Clear();
            }
        }

        private void clearSearchButton_Click(object sender, EventArgs e)
        {
            ClearHistoryForm();
        }

        private void ClearHistoryForm()
        {
            rentalHistoryDataGridView.Rows.Clear();

            memberIdTextBox.Clear();

            errorMessageLabel.Text = "";
        }
    }
}
