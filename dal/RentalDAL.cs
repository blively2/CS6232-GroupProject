using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SofaSoGood.Model;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// Data Access Layer class for managing rental transactions with the database.
    /// </summary>
    public class RentalDAL
    {
        /// <summary>
        /// Creates a new rental transaction in the database and associated rental items.
        /// </summary>
        /// <param name="rentalTransaction">The rental transaction object containing the details of the transaction.</param>
        public int CreateRentalTransaction(RentalTransaction rentalTransaction)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "INSERT INTO [RentalTransaction] (MemberID, EmployeeID, RentalDate, DueDate, TotalCost) " +
                                "VALUES (@MemberID, @EmployeeID, @RentalDate, @DueDate, @TotalCost); " +
                                "SELECT CAST(SCOPE_IDENTITY() as int);";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@MemberID", SqlDbType.Int).Value = rentalTransaction.MemberID;
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = rentalTransaction.EmployeeID;
                    command.Parameters.Add("@RentalDate", SqlDbType.Date).Value = rentalTransaction.RentalDate;
                    command.Parameters.Add("@DueDate", SqlDbType.Date).Value = rentalTransaction.DueDate;
                    command.Parameters.Add("@TotalCost", SqlDbType.Decimal).Value = rentalTransaction.TotalCost;

                    connection.Open();
                    int rentalTransactionId = (int)command.ExecuteScalar();

                    foreach (var item in rentalTransaction.RentalItems)
                    {
                        string itemQuery = "INSERT INTO [RentalItem] (RentalTransactionID, FurnitureID, Quantity, DailyRate) " +
                                            "VALUES (@RentalTransactionID, @FurnitureID, @Quantity, @DailyRate)";
                        using (var itemCommand = new SqlCommand(itemQuery, connection))
                        {
                            itemCommand.Parameters.Add("@RentalTransactionID", SqlDbType.Int).Value = rentalTransactionId;
                            itemCommand.Parameters.Add("@FurnitureID", SqlDbType.Int).Value = item.FurnitureID;
                            itemCommand.Parameters.Add("@Quantity", SqlDbType.Int).Value = item.Quantity;
                            itemCommand.Parameters.Add("@DailyRate", SqlDbType.Decimal).Value = item.DailyRate;
                            itemCommand.ExecuteNonQuery();
                        }
                    }
                    return rentalTransactionId;
                }
            }
        }

        /// <summary>
        /// Retrieves a rental transaction and its items from the database based on its ID.
        /// </summary>
        /// <param name="rentalTransactionId">The ID of the rental transaction to retrieve.</param>
        /// <returns>A RentalTransaction object if found; otherwise, null.</returns>
        public RentalTransaction GetRentalTransaction(int rentalTransactionId)
        {
            RentalTransaction rentalTransaction = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [RentalTransaction] WHERE RentalTransactionID = @RentalTransactionID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@RentalTransactionID", SqlDbType.Int).Value = rentalTransactionId;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentalTransaction = new RentalTransaction
                            {
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                RentalDate = reader.GetDateTime(reader.GetOrdinal("RentalDate")),
                                DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost"))
                            };
                        }
                    }
                }

                if (rentalTransaction != null)
                {
                    string itemQuery = "SELECT * FROM [RentalItem] WHERE RentalTransactionID = @RentalTransactionID";
                    using (var itemCommand = new SqlCommand(itemQuery, connection))
                    {
                        itemCommand.Parameters.Add("@RentalTransactionID", SqlDbType.Int).Value = rentalTransactionId;
                        using (var itemReader = itemCommand.ExecuteReader())
                        {
                            rentalTransaction.RentalItems = new List<RentalItem>();
                            while (itemReader.Read())
                            {
                                var rentalItem = new RentalItem
                                {
                                    RentalItemID = itemReader.GetInt32(itemReader.GetOrdinal("RentalItemID")),
                                    RentalTransactionID = itemReader.GetInt32(itemReader.GetOrdinal("RentalTransactionID")),
                                    FurnitureID = itemReader.GetInt32(itemReader.GetOrdinal("FurnitureID")),
                                    Quantity = itemReader.GetInt32(itemReader.GetOrdinal("Quantity")),
                                    DailyRate = itemReader.GetDecimal(itemReader.GetOrdinal("DailyRate"))
                                };
                                rentalTransaction.RentalItems.Add(rentalItem);
                            }
                        }
                    }
                }
            }
            return rentalTransaction;
        }

        /// <summary>
        /// Gets the next available ID for a new rental transaction.
        /// </summary>
        /// <returns>The next available ID for a new rental transaction.</returns>
        public int GetNextRentalTransactionID()
        {
            int nextId = 1;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT ISNULL(MAX(RentalTransactionID), 0) + 1 FROM [RentalTransaction]";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    nextId = (int)command.ExecuteScalar();
                }
            }
            return nextId;
        }

        public List<RentalTransaction> GetRentalHistoryByMemberId(int memberId)
        {
            List<RentalTransaction> rentalHistory = new List<RentalTransaction>();

            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = @"
            SELECT rt.RentalTransactionID, rt.MemberID, rt.EmployeeID, rt.RentalDate, rt.DueDate, rt.TotalCost
            FROM [RentalTransaction] rt
            WHERE rt.MemberID = @MemberID
            ORDER BY rt.RentalTransactionID DESC";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberId);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rentalTransaction = new RentalTransaction
                            {
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                MemberID = reader.GetInt32(reader.GetOrdinal("MemberID")),
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                RentalDate = reader.GetDateTime(reader.GetOrdinal("RentalDate")),
                                DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost")),
                            };

                            rentalHistory.Add(rentalTransaction);
                        }
                    }
                }
            }

            return rentalHistory;
        }
    }
}