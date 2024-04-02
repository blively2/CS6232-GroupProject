using System;
using System.Collections.Generic;
using SofaSoGood.DAL;
using SofaSoGood.Model;

namespace SofaSoGood.Controller
{
    public class RentalController
    {
        private readonly RentalDAL rentalDAL;
        private readonly FurnitureDAL furnitureDAL;

        public RentalController()
        {
            rentalDAL = new RentalDAL();
            furnitureDAL = new FurnitureDAL();
        }

        public void CreateRentalTransaction(RentalTransaction rentalTransaction)
        {
            rentalDAL.CreateRentalTransaction(rentalTransaction);

            foreach (var item in rentalTransaction.RentalItems)
            {
                furnitureDAL.UpdateStockQuantity(item.FurnitureID, item.Quantity);
            }
        }

        public RentalTransaction GetRentalTransaction(int rentalTransactionId)
        {
            return rentalDAL.GetRentalTransaction(rentalTransactionId);
        }

        public List<Furniture> GetAvailableFurniture()
        {
            return furnitureDAL.GetAvailableFurniture();
        }

        public decimal GetFurnitureDailyRate(int furnitureId)
        {
            return furnitureDAL.GetFurnitureDailyRate(furnitureId);
        }

        public int GetNextRentalTransactionID()
        {
            return rentalDAL.GetNextRentalTransactionID();
        }
    }
}