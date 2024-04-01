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
    public partial class SearchFurniture : UserControl
    {
        private readonly FurnitureController furnitureController;
        /// <summary>
        /// Initializes a new instance of the <see cref="SearchFurniture"/> class.
        /// </summary>
        public SearchFurniture()
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
    }

}
