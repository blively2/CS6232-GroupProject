using System;
using System.Collections.Generic;

namespace SofaSoGood.Model
{
    /// <summary>
    /// Class to define return transaction
    /// </summary>
    public class ReturnTransaction
    {
        /// <summary>
        /// Gets or sets the return transaction identifier.
        /// </summary>
        /// <value>
        /// The return transaction identifier.
        /// </value>
        public int ReturnTransactionID { get; set; }
        
        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        /// <value>
        /// The employee identifier.
        /// </value>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        /// <value>
        /// The member identifier.
        /// </value>
        public int MemberID { get; set; }

        /// <summary>
        /// Gets or sets the return date.
        /// </summary>
        /// <value>
        /// The return date.
        /// </value>
        public DateTime ReturnDate { get; set; }

        /// <summary>
        /// Gets or sets the return amount.
        /// </summary>
        /// <value>
        /// The return amount.
        /// </value>
        public decimal ReturnAmount { get; set; }

        /// <summary>
        /// Gets or sets the fine amount.
        /// </summary>
        /// <value>
        /// The fine amount.
        /// </value>
        public decimal FineAmount { get; set; }

        /// <summary>
        /// Gets or sets the return items.
        /// </summary>
        /// <value>
        /// The return items.
        /// </value>
        public List<ReturnItem> ReturnItems { get; set; } = new List<ReturnItem>();

    }
}
