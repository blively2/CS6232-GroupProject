using SofaSoGood.Controller;
using System;using System.Windows.Forms;
using SofaSoGood.Model;
using System.Collections.Generic;
namespace SofaSoGood.AdminUserControls
{
    /// <summary>
    /// User Control for report
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class ReportUserControls : UserControl
    {
        private readonly AdminController adminController;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReportUserControls"/> class.
        /// </summary>
        public ReportUserControls()
        {
            InitializeComponent();
            this.adminController = new AdminController();
            this.dateWarningLabel.Text = string.Empty;
        }

        /// <summary>
        /// Handles the Click event of the ReportButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ReportButton_Click(object sender, EventArgs e)
        {
            if (dateOfBirthDatePicker.Value > dateTimePicker1.Value)
            {
                dateWarningLabel.Text = "The Rented From date must be before the Rented To date.";
                furnitureListView.Items.Clear();
            }
            else
            {
                dateWarningLabel.Text = "";
                DateTime startDate = dateOfBirthDatePicker.Value;
                DateTime endDate = dateTimePicker1.Value;
                var reportData = adminController.FetchPopularFurniture(startDate, endDate);
                PopulateListView(reportData);
            }
        }

        private void PopulateListView(List<FurnitureReportItem> data)
        {
            furnitureListView.Items.Clear();

            if (data.Count == 0)
            {
                this.dateWarningLabel.Text = "No record found";
            }
            else
            {
                foreach (var item in data)
                {
                    ListViewItem listViewItem = new ListViewItem(item.FurnitureID.ToString());
                    listViewItem.SubItems.Add(item.CategoryName);
                    listViewItem.SubItems.Add(item.Name);
                    listViewItem.SubItems.Add(item.RentalTransactionsCount.ToString());
                    listViewItem.SubItems.Add(item.TotalRentalTransactions.ToString());
                    listViewItem.SubItems.Add(item.PercentageOfRentals.ToString("0.##"));
                    listViewItem.SubItems.Add(item.Percentage18To29.ToString("0.##"));
                    listViewItem.SubItems.Add(item.PercentageOutside18To29.ToString("0.##"));
                    furnitureListView.Items.Add(listViewItem);
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the Clear button control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            furnitureListView.Items.Clear();
            dateWarningLabel.Text = "";
            dateOfBirthDatePicker.Value = DateTime.Today;
            dateTimePicker1.Value = DateTime.Today;
        }

    }
}