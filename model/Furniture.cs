namespace SofaSoGood.Model
{
    /// <summary>
    /// Class to define Furniture programmatically.
    /// </summary>
    public class Furniture
    {
        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureID { get; set;}

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set;}

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>
        /// The name of the category.
        /// </value>
        public string CategoryName {  get; set;}

        /// <summary>
        /// Gets or sets the name of the style.
        /// </summary>
        /// <value>
        /// The name of the style.
        /// </value>
        public string StyleName { get; set;}

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description { get; set;}

        /// <summary>
        /// Gets or sets the rental rate per day.
        /// </summary>
        /// <value>
        /// The rental rate per day.
        /// </value>
        public double RentalRatePerDay { get; set;}

        /// <summary>
        /// Gets or sets the in stock quantity.
        /// </summary>
        /// <value>
        /// The in stock quantity.
        /// </value>
        public int InStockQuantity { get; set;}

        /// <summary>
        /// Gets or sets the total quantity.
        /// </summary>
        /// <value>
        /// The total quantity.
        /// </value>
        public int TotalQuantity { get; set;}
    }
}
