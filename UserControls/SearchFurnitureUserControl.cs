using SofaSoGood.Controller;
using SofaSoGood.Model;
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
        /// Handles the Click event of the SearchByCategoryButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchByCategoryButton_Click(object sender, EventArgs e)
        {
            if (catogeryComboBox.SelectedIndex <= 0)
            {
                catogeryWarningLabel.ForeColor = Color.Red;
                catogeryWarningLabel.Text = "Please select a category.";
                return;
            }

            string selectedCategory = catogeryComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByCategory(selectedCategory);
            furnitureListView.Items.Clear();
            foreach (var furniture in furnitureList)
            {
                this.AddFurnitureToList(furniture);
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
                    this.AddFurnitureToList(furniture);
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

        /// <summary>
        /// Handles the Click event of the SearchByStyleButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void SearchByStyleButton_Click(object sender, EventArgs e)
        {
            if (styleComboBox.SelectedIndex <= 0)
            {
                styleWarningLabel.ForeColor = Color.Red;
                styleWarningLabel.Text = "Please select a style";
                return;
            }

            string selectedStyle = styleComboBox.SelectedItem.ToString();
            var furnitureList = furnitureController.SearchFurnitureByStyle(selectedStyle);
            furnitureListView.Items.Clear();
            foreach (var furniture in furnitureList)
            {
                this.AddFurnitureToList(furniture);
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
    }

}
