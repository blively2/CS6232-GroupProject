using SofaSoGood.DAL;
using SofaSoGood.Model;
using System.Collections.Generic;

namespace SofaSoGood.Controller
{
    /// <summary>
    /// Represents the return controller.
    /// </summary>
    public class ReturnController
    {
        private readonly ReturnDAL returnDal;

        /// <summary>
        /// Initializes a new instance of the <see cref="ReturnController"/> class.
        /// </summary>
        public ReturnController()
        {
            returnDal = new ReturnDAL(new FurnitureDAL(), new RentalDAL());
        }

        /// <summary>
        /// Processes the return.
        /// </summary>
        /// <param name="returnTransaction">The return transaction.</param>
        /// <returns>The processed return transaction with updated amounts and IDs.</returns>
        public ReturnTransaction ProcessReturn(ReturnTransaction returnTransaction)
        {
            return returnDal.ProcessReturn(returnTransaction);
        }

        /// <summary>
        /// Retrieves all return transactions associated with a specific member ID.
        /// </summary>
        /// <param name="memberId">The ID of the member whose return history is being requested.</param>
        /// <returns>A list of ReturnTransaction objects representing the member's return history.</returns>
        public List<ReturnTransaction> GetReturnHistoryByMemberId(int memberId)
        {
            return returnDal.GetReturnHistoryByMemberId(memberId);
        }

        /// <summary>
        /// Retrieves a return transaction from the database based on its ID.
        /// </summary>
        /// <param name="returnTransactionId">The ID of the return transaction to retrieve.</param>
        /// <returns>A ReturnTransaction object if found; otherwise, null.</returns>
        public ReturnTransaction GetReturnTransaction(int returnTransactionId)
        {
            return returnDal.GetReturnTransaction(returnTransactionId);
        }
    }
}