namespace SofaSoGood.Model
{
    /// <summary>
    ///  Class to define return item
    /// </summary>
    public class ReturnItem
    {
        /// <summary>
        /// Gets or sets the return item identifier.
        /// </summary>
        /// <value>
        /// The return item identifier.
        /// </value>
        public int ReturnItemID { get; set; }

        /// <summary>
        /// Gets or sets the return transaction identifier.
        /// </summary>
        /// <value>
        /// The return transaction identifier.
        /// </value>
        public int ReturnTransactionID { get; set; }

        /// <summary>
        /// Gets or sets the rental item identifier.
        /// </summary>
        /// <value>
        /// The rental item identifier.
        /// </value>
        public int RentalItemID { get; set; }

        /// <summary>
        /// Gets or sets the furniture identifier.
        /// </summary>
        /// <value>
        /// The furniture identifier.
        /// </value>
        public int FurnitureID { get; set; }

        /// <summary>
        /// Gets or sets the quantity returned.
        /// </summary>
        /// <value>
        /// The quantity returned.
        /// </value>
        public int QuantityReturned { get; set; }
    }
}
