using SofaSoGood.DAL;
using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Transactions;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// Represent return controller
    /// </summary>
    public class ReturnController
    {
        private readonly ReturnDAL returnDal;
        private readonly RentalDAL rentalDal;
        private readonly FurnitureDAL furnitureDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnController"/> class.
        /// </summary>
        public ReturnController()
        {
            returnDal = new ReturnDAL();
            rentalDal = new RentalDAL();
            furnitureDal = new FurnitureDAL();
        }

        /// <summary>
        /// Processes the return.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <returns></returns>
        public ReturnTransaction ProcessReturn(ReturnTransaction returnTransaction)
        {
            using (TransactionScope scope = new TransactionScope())
            {
                using (var connection = SofaSoGoodDBConnection.GetConnection())
                {
                    connection.Open();

                    decimal totalRefund = 0;
                    decimal totalFine = 0;

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
                    }

                    returnTransaction.ReturnAmount = totalRefund;
                    returnTransaction.FineAmount = totalFine;

                    int returnTransactionId = returnDal.CreateReturnTransaction(returnTransaction);
                    returnTransaction.ReturnTransactionID = returnTransactionId;

                    foreach (var returnItem in returnTransaction.ReturnItems)
                    {
                        returnDal.AddReturnItem(returnItem, returnTransactionId);
                    }

                    foreach (var returnItem in returnTransaction.ReturnItems)
                    {
                        furnitureDal.IncreaseStockQuantity(returnItem.FurnitureID, returnItem.QuantityReturned);
                    }

                    scope.Complete();
                }
            }
            return returnTransaction;
        }

        /// <summary>
        /// Calculates the refund or fine.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction.</param>
        /// <param name="returnItem">The return item.</param>
        /// <returns></returns>
        /// <exception cref="System.ArgumentException">No matching rental item found for return item.</exception>
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

        /// <summary>
        /// Retrieves all rental transactions associated with a specific member ID.
        /// </summary>
        /// <param name="memberId">The ID of the member whose rental history is being requested.</param>
        /// <returns>A list of RentalTransaction objects representing the member's rental history.</returns>
        public List<ReturnTransaction> GetReturnHistoryByMemberId(int memberId)
        {
            return returnDal.GetReturnHistoryByMemberId(memberId);
        }

        /// <summary>
        /// Retrieves a rental transaction from the database based on its ID.
        /// </summary>
        /// <param name="rentalTransactionId">The ID of the rental transaction to retrieve.</param>
        /// <returns>A RentalTransaction object if found; otherwise, null.</returns>
        public ReturnTransaction GetReturnTransaction(int returnTransactionId)
        {
            return returnDal.GetReturnTransaction(returnTransactionId);
        }
    }
}
