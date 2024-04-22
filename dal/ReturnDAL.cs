using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SofaSoGood.DAL
{
    public class ReturnDAL
    {
        public int CreateReturnTransaction(ReturnTransaction returnTransaction)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = @"
            INSERT INTO [ReturnTransaction] (EmployeeID, MemberID, ReturnDate, ReturnAmount, FineAmount) 
            VALUES (@EmployeeID, @MemberID, @ReturnDate, @ReturnAmount, @FineAmount);
            SELECT CAST(SCOPE_IDENTITY() AS int);";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@EmployeeID", returnTransaction.EmployeeID);
                    command.Parameters.AddWithValue("@MemberID", returnTransaction.MemberID);
                    command.Parameters.AddWithValue("@ReturnDate", returnTransaction.ReturnDate);
                    command.Parameters.AddWithValue("@ReturnAmount", returnTransaction.ReturnAmount);
                    command.Parameters.AddWithValue("@FineAmount", returnTransaction.FineAmount);

                    connection.Open();
                    int returnTransactionId = (int)command.ExecuteScalar();
                    return returnTransactionId;
                }
            }
        }

        public void AddReturnItem(ReturnItem returnItem, int returnTransactionId)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = @"
            INSERT INTO [ReturnItem] (ReturnTransactionID, RentalItemID, QuantityReturned) 
            VALUES (@ReturnTransactionID, @RentalItemID, @QuantityReturned);";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@ReturnTransactionID", returnTransactionId);
                    command.Parameters.AddWithValue("@RentalItemID", returnItem.RentalItemID);
                    command.Parameters.AddWithValue("@QuantityReturned", returnItem.QuantityReturned);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Retrieves the rental history for a specific member identified by their member ID.
        /// </summary>
        /// <param name="memberId">The unique identifier of the member whose rental history is being requested.</param>
        /// <returns>A list of RentalTransaction objects representing the rental transactions associated with the specified member.
        /// The transactions are ordered by their ID in descending order, the most recent transactions appear first.</returns>
        public List<ReturnTransaction> GetReturnHistoryByMemberId(int memberId)
        {
            List<ReturnTransaction> rentalHistory = new List<ReturnTransaction>();

            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = @"
            SELECT rt.ReturnTransactionID, rt.EmployeeID, rt.EmployeeID, rt.MemberID, rt.ReturnDate, rt.ReturnAmount, rt.FineAmount
            FROM [ReturnTransaction] rt
            WHERE rt.MemberID = @MemberID
            ORDER BY rt.ReturnTransactionID DESC";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberId);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var returnTransaction = new ReturnTransaction
                            {
                                ReturnTransactionID = reader.GetInt32(reader.GetOrdinal("ReturnTransactionID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                ReturnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate")),
                                ReturnAmount = reader.GetDecimal(reader.GetOrdinal("ReturnAmount")),
                                FineAmount = reader.GetDecimal(reader.GetOrdinal("FineAmount")),
                            };

                            rentalHistory.Add(returnTransaction);
                        }
                    }
                }
            }

            return rentalHistory;
        }

        /// <summary>
        /// Retrieves a rental transaction and its items from the database based on its ID.
        /// </summary>
        /// <param name="rentalTransactionId">The ID of the rental transaction to retrieve.</param>
        /// <returns>A RentalTransaction object if found; otherwise, null.</returns>
        public ReturnTransaction GetReturnTransaction(int returnTransactionId)
        {
            ReturnTransaction returnTransaction = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [ReturnTransaction] WHERE ReturnTransactionID = @ReturnTransactionID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@ReturnTransactionID", SqlDbType.Int).Value = returnTransactionId;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            returnTransaction = new ReturnTransaction
                            {
                                ReturnTransactionID = reader.GetInt32(reader.GetOrdinal("ReturnTransactionID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                ReturnDate = reader.GetDateTime(reader.GetOrdinal("ReturnDate")),
                                ReturnAmount = reader.GetDecimal(reader.GetOrdinal("ReturnAmount")),
                                FineAmount = reader.GetDecimal(reader.GetOrdinal("FineAmount"))
                            };
                        }
                    }
                }

                if (returnTransaction != null)
                {
                    string itemQuery = "SELECT * FROM [ReturnItem] WHERE ReturnTransactionID = @ReturnTransactionID";
                    using (var itemCommand = new SqlCommand(itemQuery, connection))
                    {
                        itemCommand.Parameters.Add("@ReturnTransactionID", SqlDbType.Int).Value = returnTransactionId;
                        using (var itemReader = itemCommand.ExecuteReader())
                        {
                            returnTransaction.ReturnItems = new List<ReturnItem>();
                            while (itemReader.Read())
                            {
                                var returnItem = new ReturnItem
                                {
                                    ReturnItemID = itemReader.GetInt32(itemReader.GetOrdinal("ReturnItemID")),
                                    ReturnTransactionID = itemReader.GetInt32(itemReader.GetOrdinal("ReturnTransactionID")),
                                    RentalItemID = itemReader.GetInt32(itemReader.GetOrdinal("RentalItemID")),
                                    QuantityReturned = itemReader.GetInt32(itemReader.GetOrdinal("QuantityReturned"))
                                };
                                returnTransaction.ReturnItems.Add(returnItem);
                            }
                        }
                    }
                }
            }
            return returnTransaction;
        }
    }
}
