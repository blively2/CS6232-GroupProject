using SofaSoGood.Controller;
using SofaSoGood.Model;
using SofaSoGood.View;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for searching furniture in the database.
    /// </summary>
    public partial class SearchFurnitureUserControl : UserControl
    {
        // FurnitureController instance for interacting with the database.
        private readonly FurnitureController furnitureController;
        // List<Furniture> Selected Furniture for Display outside of this control.
        public List<Furniture> SelectedFurniture;
        // Instance of MemberDashboard to reflect changes to Item counts in SelectedFurniture
        private MemberDashboard MemberDashboard;
        // Instance of RentFurnitureUserControl to reflect changes to SelectedFurniture in the transaction.
        private RentFurnitureUserControl RentFurnitureUserControl;

        /// <summary>
        /// Constructor initializes the UserControl, the FurnitureController,
        /// and populates comboboxes for categories and styles.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            furnitureController = new FurnitureController();
            PopulateCategoryAndStyleComboboxes();
            this.furnitureListView.Hide();
            SelectedFurniture = new List<Furniture>();
            this.categoryWarningLabel.Text = string.Empty;
            this.styleWarningLabel.Text = string.Empty;
        }

        /// <summary>
        /// Populates the category and style comboboxes with values
        /// retrieved from the FurnitureController.
        /// </summary>
        private void PopulateCategoryAndStyleComboboxes()
        {
            categoryComboBox.DataSource = furnitureController.GetFurnitureCategories();
            styleComboBox.DataSource = furnitureController.GetFurnitureStyles();
        }

        /// <summary>
        /// Event handler for clicking the Search By Category button.
        /// Retrieves a list of furniture matching the selected category and updates the ListView.
        /// </summary>
        private void SearchByCategoryButtonClick(object sender, EventArgs e)
        {
            var furnitureList = furnitureController.SearchFurnitureByCategory(categoryComboBox.SelectedItem.ToString());
            PopulateFurnitureListView(furnitureList);
        }

        /// <summary>
        /// Event handler for clicking the Search By Furniture ID button.
        /// Retrieves the furniture item matching the provided ID and updates the ListView.
        /// </summary>
        private void SearchByFurnitureIDButtonClick(object sender, EventArgs e)
        {
            if (int.TryParse(furnitureIDTextBox.Text, out int furnitureID))
            {
                var furniture = furnitureController.GetFurnitureByID(furnitureID);
                List<Furniture> furnitureList = furniture != null ? new List<Furniture> { furniture } : new List<Furniture>();
                PopulateFurnitureListView(furnitureList);
            }
            else
            {

                furnitureIDWarningLabel.ForeColor = Color.Red;
                furnitureIDWarningLabel.Text = "Try Furniture ID as a digit";
            }
        }

        /// <summary>
        /// Event handler for clicking the Search By Style button.
        /// Retrieves a list of furniture matching the selected style and updates the ListView.
        /// </summary>
        private void SearchByStyleButtonClick(object sender, EventArgs e)
        {
            var furnitureList = furnitureController.SearchFurnitureByStyle(styleComboBox.SelectedItem.ToString());
            PopulateFurnitureListView(furnitureList);
        }

        /// <summary>
        /// Populates the furniture ListView with items from the provided furniture list.
        /// Displays a message if no items were found.
        /// </summary>
        /// <param name="furnitureList">List of furniture items to display.</param>
        private void PopulateFurnitureListView(List<Furniture> furnitureList)
        {
            furnitureListView.Items.Clear();
            furnitureIDWarningLabel.Text = string.Empty;

            foreach (var furniture in furnitureList)
            {
                var item = new ListViewItem(furniture.FurnitureID.ToString());
                item.SubItems.AddRange(new string[]
                {
                    furniture.Name,
                    furniture.CategoryName,
                    furniture.StyleName,
                    furniture.Description,
                    furniture.RentalRatePerDay.ToString("C"),
                    furniture.InStockQuantity.ToString(),
                    furniture.TotalQuantity.ToString()
                });
                furnitureListView.Items.Add(item);
            }

            foreach (ColumnHeader column in this.furnitureListView.Columns)
            {
                column.Width = -2;
            }

            furnitureListView.Visible = furnitureList.Count > 0;

            furnitureListView.Refresh();

            if (furnitureListView.Items.Count == 0)
            {
                furnitureIDWarningLabel.ForeColor = Color.Red;
                furnitureIDWarningLabel.Text = "No matching furniture found.";
            }
        }

        /// <summary>
        /// Adds a searched then selected furniture item to SelectedFurniture, updates the item count in 
        /// MemberDashboard and the displayed list in RentFurnitureUserControl.
        /// Displays a message if furniture item has already been added.
        /// </summary>
        private void FurnitureListViewDoubleClick(object sender, EventArgs e)
        {
            if (furnitureListView.SelectedItems.Count == 1)
            {
                int furnitureID = int.Parse(furnitureListView.SelectedItems[0].Text);

                if (SelectedFurniture.Any(f => f.FurnitureID == furnitureID))
                {
                    furnitureIDWarningLabel.Text = "Furniture already selected!";
                    return;
                }

                Furniture chosenFurniture = furnitureController.GetFurnitureByID(furnitureID);
                if (chosenFurniture != null)
                {
                    furnitureIDWarningLabel.Text = "Furniture Selected!";
                    SelectedFurniture.Add(chosenFurniture);
                    this.MemberDashboard.SelectedFurnitureChanged(SelectedFurniture);
                    this.RentFurnitureUserControl.DisplaySelectedFurniture(SelectedFurniture);
                }
            }
        }

        /// <summary>
        /// Sets the MemberDashboard on load.
        /// </summary>
        /// <param name="Dashboard">Sets the MemberDashboard as an instance variable for updating the view..</param>
        public void SetMemberDashboard(MemberDashboard Dashboard)
        {
            this.MemberDashboard = Dashboard;
        }

        /// <summary>
        /// Sets the MemberDashboard on load.
        /// </summary>
        /// <param name="RentFurniture">Sets the RentFurnitureUserControl as an instance variable for updating its transaction.</param>
        public void SetRentFurnitureUserControl(RentFurnitureUserControl RentFurniture)
        {
            this.RentFurnitureUserControl = RentFurniture;
        }

        /// <summary>
        /// Removes a furniture item from SelectedFurniture by ID. Updates the count in MemberDashboard.
        /// </summary>
        /// <param name="furnitureID">ID of furniture item to remove..</param>
        public void RemoveFurnitureItem(int furnitureID)
        {
            SelectedFurniture.RemoveAll(f => f.FurnitureID == furnitureID);
            this.MemberDashboard.SelectedFurnitureChanged(this.SelectedFurniture);
        }

        /// <summary>
        /// Removes all furniture items from SelectedFurniture. Updates the count in MemberDashboard.
        /// </summary>
        /// <param name="furnitureID">ID of furniture item to remove..</param>
        public void ClearSelectedFurniture()
        {
            SelectedFurniture.Clear();
            this.MemberDashboard.SelectedFurnitureChanged(this.SelectedFurniture);
        }

        private void FurnitureIDTextBoxTextChanged(object sender, EventArgs e)
        {
            this.ClearFurnitureList();
        }

        private void CategoryComboBoxDropDown(object sender, EventArgs e)
        {
            this.ClearFurnitureList();
        }

        private void StyleComboBoxDropDown(object sender, EventArgs e)
        {
            this.ClearFurnitureList();
        }

        private void ClearFurnitureList()
        {
            this.furnitureListView.Hide();
        }
    }
}