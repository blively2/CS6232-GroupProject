using SofaSoGood.Controller;
using SofaSoGood.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace SofaSoGood.UserControls
{
    /// <summary>
    /// UserControl for Search Furniture in the database.
    /// Has an FurnitureController instance to interact with the DB.
    /// </summary>
    /// <seealso cref="System.Windows.Forms.UserControl" />
    public partial class SearchFurnitureUserControl : UserControl
    {
        private readonly FurnitureController furnitureController;
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFurnitureUserControl"/> class.
        /// </summary>
        public SearchFurnitureUserControl()
        {
            InitializeComponent();
            furnitureController = new FurnitureController();
            PopulateCategoryAndStyleComboboxes();
        }

        /// <summary>
        /// Populates the category and style comboboxes.
        /// </summary>
        private void PopulateCategoryAndStyleComboboxes()
        {
            catogeryComboBox.DataSource = null;
            catogeryComboBox.Items.Clear();
            catogeryComboBox.Items.Insert(0, "-- Select Category --");
            catogeryComboBox.SelectedIndex = 0;

            var categories = furnitureController.GetFurnitureCategories();
            foreach (var category in categories)
            {
                catogeryComboBox.Items.Add(category);
            }

            styleComboBox.DataSource = null;
            styleComboBox.Items.Clear();
            styleComboBox.Items.Insert(0, "-- Select Style --");
            styleComboBox.SelectedIndex = 0;

            var styles = furnitureController.GetFurnitureStyles();
            foreach (var style in styles)
            {
                styleComboBox.Items.Add(style);
            }
        }

        /// <summary>
        /// Adds the furniture to list.
        /// </summary>
        /// <param name="furniture">The furniture.</param>
        private void AddFurnitureToList(Furniture furniture)
        {
            ListViewItem item = new ListViewItem(furniture.FurnitureID.ToString());
            item.SubItems.Add(furniture.Name);
            item.SubItems.Add(furniture.CategoryName);
            item.SubItems.Add(furniture.StyleName);
            item.SubItems.Add(furniture.Description);
            item.SubItems.Add(furniture.RentalRatePerDay.ToString("C"));
            item.SubItems.Add(furniture.InStockQuantity.ToString());
            item.SubItems.Add(furniture.TotalQuantity.ToString());
            furnitureListView.Items.Add(item);
        }

        /// <summary>
        /// Handles the Click event of the SearchButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchButton_Click(object sender, EventArgs e)
        {
            warningLabel.Visible = false;

            if (!string.IsNullOrWhiteSpace(furnitureIDTextBox.Text))
            {
                SearchByFurnitureID();
            }
            else if (catogeryComboBox.SelectedIndex > 0)
            {
                SearchByCategory();
            }
            else if (styleComboBox.SelectedIndex > 0)
            {
                SearchByStyle();
            }
            else 
            {
                warningLabel.ForeColor = Color.Red;
                warningLabel.Text = "Please select ID/Catogery/Style";
                warningLabel.Visible = true;
            }
        }

        /// <summary>
        /// Clears the form.
        /// </summary>
        private void ClearForm()
        {

            furnitureIDTextBox.Clear();
            catogeryComboBox.SelectedIndex = 0;
            styleComboBox.SelectedIndex = 0;
            furnitureListView.Items.Clear();
            warningLabel.Text = "";
            furnitureIDTextBox.Enabled = true;
            catogeryComboBox.Enabled = true;
            styleComboBox.Enabled = true;

        }

        /// <summary>
        /// Searches the by furniture identifier.
        /// </summary>
        private void SearchByFurnitureID()
        {
            
            int.TryParse(furnitureIDTextBox.Text, out int furnitureID);
            var furniture = furnitureController.SearchFurnitureByID(furnitureID);
            if (furniture != null)
            {
                furnitureListView.Items.Clear();
                AddFurnitureToList(furniture);
            }
            else
            {
                warningLabel.ForeColor = Color.Red;
                warningLabel.Text = "Furniture not found";
                warningLabel.Visible = true;
            }
            catogeryComboBox.SelectedIndex = 0;
            catogeryComboBox.Enabled = false;
            styleComboBox.SelectedIndex = 0;
            styleComboBox.Enabled = false;
        }

        /// <summary>
        /// Searches the by category.
        /// </summary>
        private void SearchByCategory()
        {
            string selectedCategory = catogeryComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByCategory(selectedCategory);
            furnitureListView.Items.Clear();

            foreach (var furniture in furnitureList)
            {
                AddFurnitureToList(furniture);
            }
            furnitureIDTextBox.Clear();
            furnitureIDTextBox.Enabled = false;
            styleComboBox.SelectedIndex = 0;
            styleComboBox.Enabled = false; 
        }

        /// <summary>
        /// Searches the by style.
        /// </summary>
        private void SearchByStyle()
        {
            string selectedStyle = styleComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByStyle(selectedStyle);
            furnitureListView.Items.Clear();

            foreach (var furniture in furnitureList)
            {
                AddFurnitureToList(furniture);
            }
            furnitureIDTextBox.Clear();
            furnitureIDTextBox.Enabled = false;
            catogeryComboBox.SelectedIndex = 0;
            catogeryComboBox.Enabled = false; 
        }

        /// <summary>
        /// Handles the Click event of the ClearButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void ClearButton_Click(object sender, EventArgs e)
        {
            ClearForm();
        }
    }

}
