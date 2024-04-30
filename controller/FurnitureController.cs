using SofaSoGood.DAL;
using SofaSoGood.Model;
using System.Collections.Generic;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// This class is the controller for furniture.
    /// </summary>
    public class FurnitureController
    {
        private readonly FurnitureDAL furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the <see cref="FurnitureController"/> class.
        /// </summary>
        public FurnitureController()
        {
            furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// Searches the furniture by identifier.
        /// </summary>
        /// <param name="furnitureID">The furniture identifier.</param>
        /// <returns></returns>
        public Furniture GetFurnitureByID(int furnitureID)
        {
            return furnitureDAL.GetFurnitureByID(furnitureID);
        }

        /// <summary>
        /// Gets the furniture categories.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureCategories()
        {
            return furnitureDAL.GetFurnitureByCategory();
        }

        /// <summary>
        /// Searches the furniture by category.
        /// </summary>
        /// <param name="categoryName">Name of the category.</param>
        /// <returns></returns>
        public List<Furniture> SearchFurnitureByCategory(string categoryName)
        {
            return furnitureDAL.GetFurnitureByCategoryName(categoryName);
        }

        /// <summary>
        /// Gets the furniture styles.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureStyles()
        {
            return furnitureDAL.GetFurnitureStyles();
        }

        /// <summary>
        /// Searches the furniture by style.
        /// </summary>
        /// <param name="categoryName">Name of the category.</param>
        /// <returns></returns>
        public List<Furniture> SearchFurnitureByStyle(string styleName)
        {
            return furnitureDAL.GetFurnitureByStyleName(styleName);
        }
    }
}
