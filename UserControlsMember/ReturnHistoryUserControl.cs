using SofaSoGood.Controller;
using SofaSoGood.Model;
using SofaSoGood.View;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// User control for return history 
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReturnHistoryUserControl : UserControl
    {
        private readonly ReturnController returnController;
        private readonly MemberController memberController;
        public ReturnHistoryUserControl()
        {
            InitializeComponent();
            InitializeDataGridView();
            returnController = new ReturnController();
            memberController = new MemberController();
        }

        /// <summary>
        /// Sets up columns and their formatting in the DataGridView for displaying rental transactions.
        /// </summary>
        private void InitializeDataGridView()
        {
            ReturnHistoryDataGridView.Columns.Add("ReturnTransactionID", "Transaction ID");
            ReturnHistoryDataGridView.Columns.Add("ReturnDate", "Return Date");
            ReturnHistoryDataGridView.Columns.Add("ReturnAmount", "Return Amount");
            ReturnHistoryDataGridView.Columns.Add("FineAmount", "Fine Amount");

            ReturnHistoryDataGridView.Columns["ReturnDate"].DefaultCellStyle.Format = "yyyy-MM-dd";
            ReturnHistoryDataGridView.Columns["ReturnAmount"].DefaultCellStyle.Format = "C2";
            ReturnHistoryDataGridView.Columns["FineAmount"].DefaultCellStyle.Format = "C2";

            ReturnHistoryDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        /// <summary>
        /// Loads and displays the rental history for a specified member ID.
        /// </summary>
        /// <param name="memberId">The member ID whose rental history is to be displayed.</param>
        public void LoadReturnHistory(int memberId)
        {
            errorMessageLabel.Text = "";
            ReturnHistoryDataGridView.Rows.Clear();

            var returnHistory = returnController.GetReturnHistoryByMemberId(memberId);
            var member = memberController.GetMemberById(memberId);

            if (returnHistory.Count > 0)
            {
                if (member != null)
                {
                    viewedMemberLabel.Text = $"Viewing returns for: {member.FirstName} {member.LastName}";
                }

                foreach (var transaction in returnHistory)
                {
                    ReturnHistoryDataGridView.Rows.Add(
                        transaction.ReturnTransactionID,
                        transaction.ReturnDate.ToString("yyyy-MM-dd"),
                        transaction.ReturnAmount.ToString("C2"),
                        transaction.FineAmount.ToString("C2")
                    );
                }
            }
            else
            {
                errorMessageLabel.Text = $"No return history found for Member ID: {memberId}";
                errorMessageLabel.ForeColor = Color.Red;
                viewedMemberLabel.Text = "";
            }
        }

        /// <summary>
        /// Handles the click event on the search history button to initiate the rental history search.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void SearchHistoryButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(memberIdTextBox.Text, out int memberId))
            {
                LoadReturnHistory(memberId);
            }
            else
            {
                errorMessageLabel.Text = "Please enter a valid Member ID.";
                errorMessageLabel.ForeColor = Color.Red;
                ReturnHistoryDataGridView.Rows.Clear();
                viewedMemberLabel.Text = "";
            }
        }

        /// <summary>
        /// Handles the click event on the clear search button to reset the form.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void ClearSearchButton_Click(object sender, EventArgs e)
        {
            ClearHistoryForm();
        }

        /// <summary>
        /// Clears the history form and resets it to its initial state.
        /// </summary>
        private void ClearHistoryForm()
        {
            ReturnHistoryDataGridView.Rows.Clear();
            memberIdTextBox.Clear();
            errorMessageLabel.Text = "";
            viewedMemberLabel.Text = "";
        }

        /// <summary>
        /// Handles changes in the text of the member ID text box, clearing the error message if any text is present.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void MemberIdTextBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(errorMessageLabel.Text))
            {
                errorMessageLabel.Text = "";
            }
        }

        /// <summary>
        /// Double clicking a transaction in Rental History displays the itemized ReceiptForm
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void RentalHistoryDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var row = ReturnHistoryDataGridView.Rows[e.RowIndex];
                int returnTransactionID = Convert.ToInt32(row.Cells["ReturnTransactionID"].Value);
                ReturnTransaction TransactionToDisplay = this.returnController.GetReturnTransaction(returnTransactionID);

                var returnForm = new ReturnForm(TransactionToDisplay);
                returnForm.ShowDialog();
            }
        }
    }
}