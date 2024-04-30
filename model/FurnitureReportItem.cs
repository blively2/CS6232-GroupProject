namespace SofaSoGood.Model
{
    /// <summary>
    ///  Class to define Furniture report
    /// </summary>
    public class FurnitureReportItem
    {
        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureID { get; set; }

        /// <summary>
        /// Gets or sets the name of the category.
        /// </summary>
        /// <value>
        /// The name of the category.
        /// </value>
        public string CategoryName { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the rental transactions count.
        /// </summary>
        /// <value>
        /// The rental transactions count.
        /// </value>
        public int RentalTransactionsCount { get; set; }

        /// <summary>
        /// Gets or sets the total rental transactions.
        /// </summary>
        /// <value>
        /// The total rental transactions.
        /// </value>
        public int TotalRentalTransactions { get; set; }

        /// <summary>
        /// Gets or sets the percentage of rentals.
        /// </summary>
        /// <value>
        /// The percentage of rentals.
        /// </value>
        public decimal PercentageOfRentals { get; set; }

        /// <summary>
        /// Gets or sets the percentage18 to29.
        /// </summary>
        /// <value>
        /// The percentage18 to29.
        /// </value>
        public decimal Percentage18To29 { get; set; }

        /// <summary>
        /// Gets or sets the percentage outside18 to29.
        /// </summary>
        /// <value>
        /// The percentage outside18 to29.
        /// </value>
        public decimal PercentageOutside18To29 { get; set; }
    }
}
