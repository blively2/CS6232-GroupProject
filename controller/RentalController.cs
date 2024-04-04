﻿using System.Collections.Generic;
using SofaSoGood.DAL;
using SofaSoGood.Model;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// Manages rental transactions including creation and retrieval of rental data.
    /// </summary>
    public class RentalController
    {
        // Data access layer for rental transactions
        private readonly RentalDAL rentalDAL;
        // Data access layer for furniture
        private readonly FurnitureDAL furnitureDAL;

        /// <summary>
        /// Initializes a new instance of the RentalController class, creating data access layer instances.
        /// </summary>
        public RentalController()
        {
            rentalDAL = new RentalDAL();
            furnitureDAL = new FurnitureDAL();
        }

        /// <summary>
        /// Creates a new rental transaction in the database and updates the stock quantity of the rented furniture.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction to be created.</param>
        public void CreateRentalTransaction(RentalTransaction rentalTransaction)
        {
            rentalDAL.CreateRentalTransaction(rentalTransaction);

            foreach (var item in rentalTransaction.RentalItems)
            {
                furnitureDAL.UpdateStockQuantity(item.FurnitureID, item.Quantity);
            }
        }

        /// <summary>
        /// Retrieves a rental transaction from the database based on its ID.
        /// </summary>
        /// <param name="rentalTransactionId">The ID of the rental transaction to retrieve.</param>
        /// <returns>A RentalTransaction object if found; otherwise, null.</returns>
        public RentalTransaction GetRentalTransaction(int rentalTransactionId)
        {
            return rentalDAL.GetRentalTransaction(rentalTransactionId);
        }

        /// <summary>
        /// Gets a list of furniture that is available for rental.
        /// </summary>
        /// <returns>A list of Furniture objects that are available for rental.</returns>
        public List<Furniture> GetAvailableFurniture()
        {
            return furnitureDAL.GetAvailableFurniture();
        }

        /// <summary>
        /// Retrieves the daily rental rate of a specific piece of furniture.
        /// </summary>
        /// <param name="furnitureId">The ID of the furniture to retrieve the rate for.</param>
        /// <returns>The daily rental rate of the furniture.</returns>
        public decimal GetFurnitureDailyRate(int furnitureId)
        {
            return furnitureDAL.GetFurnitureDailyRate(furnitureId);
        }

        /// <summary>
        /// Gets the next available ID for a new rental transaction, ensuring uniqueness.
        /// </summary>
        /// <returns>The next available rental transaction ID.</returns>
        public int GetNextRentalTransactionID()
        {
            return rentalDAL.GetNextRentalTransactionID();
        }
    }
}