using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace SofaSoGood.Controller
{
    public class ReturnController
    {
        private readonly ReturnDAL returnDal;
        private readonly RentalDAL rentalDal;
        private readonly FurnitureDAL furnitureDal;

        public ReturnController()
        {
            returnDal = new ReturnDAL();
            rentalDal = new RentalDAL();
            furnitureDal = new FurnitureDAL();
        }

        public ReturnTransaction ProcessReturn(ReturnTransaction returnTransaction)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var connection = SofaSoGoodDBConnection.GetConnection())
                {
                    connection.Open();

                    decimal totalRefund = 0;
                    decimal totalFine = 0;

                    int returnTransactionId = returnDal.CreateReturnTransaction(returnTransaction);
                    returnTransaction.ReturnTransactionID = returnTransactionId;

                    foreach (var returnItem in returnTransaction.ReturnItems)
                    {
                        RentalTransaction rentalTransaction = rentalDal.GetRentalTransactionByRentalItemId(returnItem.RentalItemID);

                        decimal itemRefundOrFine = CalculateRefundOrFine(rentalTransaction, returnItem);

                        if (itemRefundOrFine < 0)
                        {
                            totalRefund += Math.Abs(itemRefundOrFine);
                        }
                        else
                        {
                            totalFine += itemRefundOrFine;
                        }

                        int furnitureId = rentalDal.GetFurnitureIdByRentalItemId(returnItem.RentalItemID);
                        furnitureDal.IncrementStockQuantity(furnitureId, returnItem.QuantityReturned);

                        rentalDal.UpdateRentalItemQuantity(returnItem.RentalItemID, -returnItem.QuantityReturned);

                        returnDal.AddReturnItem(returnItem, returnTransactionId);
                    }

                    returnTransaction.ReturnAmount = totalRefund;
                    returnTransaction.FineAmount = totalFine;

                    scope.Complete();
                }
            }
            return returnTransaction;
        }

        private decimal CalculateRefundOrFine(RentalTransaction rentalTransaction, ReturnItem returnItem)
        {

            RentalItem rentalItem = rentalTransaction.RentalItems.FirstOrDefault(ri => ri.RentalItemID == returnItem.RentalItemID);

            if (rentalItem == null)
            {
                throw new ArgumentException("No matching rental item found for return item.");
            }

            decimal dailyRate = rentalItem.DailyRate;
            DateTime returnDate = DateTime.Now;

            int rentedDays = (rentalTransaction.DueDate - rentalTransaction.RentalDate).Days + 1;
            int actualDaysRented = (returnDate - rentalTransaction.RentalDate).Days + 1;

            if (returnDate <= rentalTransaction.DueDate)
            {
                int daysUnused = rentedDays - actualDaysRented;
                decimal refundAmount = daysUnused > 0 ? daysUnused * dailyRate : 0;
                return -refundAmount;
            }
            else
            {
                int daysLate = actualDaysRented - rentedDays;
                decimal fineAmount = daysLate * dailyRate;
                return fineAmount;
            }
        }
    }
}
