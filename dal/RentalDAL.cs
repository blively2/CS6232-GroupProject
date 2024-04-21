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


        /// <summary>
        /// Retrieves the rental history for a specific member identified by their member ID.
        /// </summary>
        /// <param name="memberId">The unique identifier of the member whose rental history is being requested.</param>
        /// <returns>A list of RentalTransaction objects representing the rental transactions associated with the specified member.
        /// The transactions are ordered by their ID in descending order, the most recent transactions appear first.</returns>
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

        public RentalItem GetRentalItemById(int rentalItemId)
        {
            RentalItem rentalItem = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [RentalItem] WHERE RentalItemID = @RentalItemID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalItemID", rentalItemId);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rentalItem = new RentalItem
                            {
                                RentalItemID = rentalItemId,
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                                DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate"))
                            };
                        }
                    }
                }
            }
            return rentalItem;
        }

        public void UpdateRentalItemQuantity(int rentalItemId, int newQuantity)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "UPDATE [RentalItem] SET Quantity = @Quantity WHERE RentalItemID = @RentalItemID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@RentalItemID", rentalItemId);
                    command.Parameters.AddWithValue("@Quantity", newQuantity);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        public RentalTransaction GetRentalTransactionByRentalItemId(int rentalItemId)
        {
            RentalTransaction rentalTransaction = null;

            string query = @"
        SELECT rt.* 
        FROM [RentalTransaction] rt
        JOIN [RentalItem] ri ON rt.RentalTransactionID = ri.RentalTransactionID
        WHERE ri.RentalItemID = @RentalItemID";

            using (var connection = SofaSoGoodDBConnection.GetConnection())
            using (var command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@RentalItemID", rentalItemId);
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
                            TotalCost = reader.GetDecimal(reader.GetOrdinal("TotalCost")),
                            RentalItems = GetRentalItemsByTransactionId(reader.GetInt32(reader.GetOrdinal("RentalTransactionID")))
                        };
                    }
                }
            }

            return rentalTransaction;
        }

        private List<RentalItem> GetRentalItemsByTransactionId(int rentalTransactionId)
        {
            List<RentalItem> rentalItems = new List<RentalItem>();

            string itemQuery = "SELECT * FROM [RentalItem] WHERE RentalTransactionID = @RentalTransactionID";
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            using (var command = new SqlCommand(itemQuery, connection))
            {
                command.Parameters.AddWithValue("@RentalTransactionID", rentalTransactionId);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var rentalItem = new RentalItem
                        {
                            RentalItemID = reader.GetInt32(reader.GetOrdinal("RentalItemID")),
                            RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                            FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                            Quantity = reader.GetInt32(reader.GetOrdinal("Quantity")),
                            DailyRate = reader.GetDecimal(reader.GetOrdinal("DailyRate"))
                        };
                        rentalItems.Add(rentalItem);
                    }
                }
            }

            return rentalItems;
        }

        public List<Furniture> GetCurrentlyRentedFurnitureByMemberID(int memberId)
        {
            List<Furniture> currentlyRentedFurnitures = new List<Furniture>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = @"
SELECT 
    f.FurnitureID,
    rt.RentalTransactionID,
    ri.RentalItemID,
    rt.RentalDate,
    rt.DueDate,
    f.Name AS FurnitureName, 
    f.CategoryName AS FurnitureCategory,
    f.StyleName AS FurnitureStyle,
    f.Description, 
    f.RentalRatePerDay,
    ri.Quantity AS AmountRented
FROM 
    RentalTransaction rt
    INNER JOIN RentalItem ri ON rt.RentalTransactionID = ri.RentalTransactionID
    INNER JOIN Furniture f ON ri.FurnitureID = f.FurnitureID
WHERE 
    rt.MemberID = @MemberID
    AND NOT EXISTS (
        SELECT 1 FROM ReturnItem ri2
        WHERE ri2.RentalItemID = ri.RentalItemID
    );";

                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@MemberID", memberId);
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var rentedFurnitureInfo = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                RentalTransactionID = reader.GetInt32(reader.GetOrdinal("RentalTransactionID")),
                                RentalItemID = reader.GetInt32(reader.GetOrdinal("RentalItemID")),
                                RentalDate = reader.GetDateTime(reader.GetOrdinal("RentalDate")),
                                DueDate = reader.GetDateTime(reader.GetOrdinal("DueDate")),
                                Name = reader.GetString(reader.GetOrdinal("FurnitureName")),
                                CategoryName = reader.GetString(reader.GetOrdinal("FurnitureCategory")),
                                StyleName = reader.GetString(reader.GetOrdinal("FurnitureStyle")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                AmountRented = reader.GetInt32(reader.GetOrdinal("AmountRented"))
                            };
                            currentlyRentedFurnitures.Add(rentedFurnitureInfo);
                        }
                    }
                }
            }
            return currentlyRentedFurnitures;
        }
    }
}