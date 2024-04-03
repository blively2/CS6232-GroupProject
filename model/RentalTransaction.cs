using System;
using System.Collections.Generic;

namespace SofaSoGood.Model
{
    public class RentalTransaction
    {
        /// <summary>
        /// Gets or sets the rental transaction identifier.
        /// </summary>
        public int RentalTransactionID { get; set; }

        /// <summary>
        /// Gets or sets the member identifier.
        /// </summary>
        public int MemberID { get; set; }

        /// <summary>
        /// Gets or sets the employee identifier.
        /// </summary>
        public int EmployeeID { get; set; }

        /// <summary>
        /// Gets or sets the rental date.
        /// </summary>
        public DateTime RentalDate { get; set; }

        /// <summary>
        /// Gets or sets the due date.
        /// </summary>
        public DateTime DueDate { get; set; }

        /// <summary>
        /// Gets or sets the total cost.
        /// </summary>
        public decimal TotalCost { get; set; }

        /// <summary>
        /// Gets or sets the rental items.
        /// </summary>
        public List<RentalItem> RentalItems { get; set; }
    }

}