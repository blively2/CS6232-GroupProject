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
            var categories = furnitureController.GetFurnitureCategories();
            categoryComboBox.DataSource = categories;

            var styles = furnitureController.GetFurnitureStyles();
            styleComboBox.DataSource = styles;
        }

        /// <summary>
        /// Handles the Click event of the SearchByCategoryButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchByCategoryButton_Click(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByCategory(selectedCategory);
            furnitureListView.Items.Clear();
            foreach (var furniture in furnitureList)
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
        }


        /// <summary>
        /// Handles the Click event of the SearchByFurnitureIDButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchByFurnitureIDButton_Click(object sender, EventArgs e)
        {

            if (int.TryParse(furnitureIDTextBox.Text, out int furnitureID))
            {
                FurnitureController controller = new FurnitureController();
                Furniture furniture = controller.SearchFurnitureByID(furnitureID);
                if (furniture != null)
                {
                    furnitureListView.Items.Clear();
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
                else
                {
                    furnitureIDWarningLabel.ForeColor = Color.Red;
                    furnitureIDWarningLabel.Text = "Furniture not found.";
                    return;
                }
            }
            else
            {
                furnitureIDWarningLabel.ForeColor = Color.Red;
                furnitureIDWarningLabel.Text = "Try Furniture ID as a digit";
                return;
            }

        }

        private void StyleButton_Click(object sender, EventArgs e)
        {
            string selectedCategory = categoryComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByCategory(selectedCategory);
            furnitureListView.Items.Clear(); 
            foreach (var furniture in furnitureList)
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

        }

        private void SearchByStyleButton_Click(object sender, EventArgs e)
        {
            string selectedStyle = styleComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByStyle(selectedStyle);
            furnitureListView.Items.Clear();
            foreach (var furniture in furnitureList)
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

        }
    }

}
