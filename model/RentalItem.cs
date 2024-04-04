namespace SofaSoGood.Model
{
    /// <summary>
    /// Class to define RentalItem programmatically.
    /// </summary>
    public class RentalItem
    {
        /// <summary>
        /// Gets or sets the rental item identifier.
        /// </summary>
        public int RentalItemID { get; set; }

        /// <summary>
        /// Gets or sets the rental transaction identifier.
        /// </summary>
        public int RentalTransactionID { get; set; }

        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        public int FurnitureID { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the daily rate.
        /// </summary>
        public decimal DailyRate { get; set; }
    }
}