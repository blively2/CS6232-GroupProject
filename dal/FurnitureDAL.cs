using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using SofaSoGood.Model;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// This class is data access layer between model and view for Furniture.
    /// </summary>
    public class FurnitureDAL
    {
        /// <summary>
        /// Gets the furniture identifier.
        /// </summary>
        /// <param name="ID">The identifier.</param>
        /// <returns></returns>
        public Furniture GetFurnitureByID(int ID)
        {
            Furniture furniture = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Furniture] WHERE FurnitureID = @FurnitureID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int).Value = ID;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            furniture = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                InStockQuantity = reader.GetInt32(reader.GetOrdinal("InStockQuantity")),
                                TotalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"))
                            };
                        }
                    }
                }
            }

            return furniture;
        }

        /// <summary>
        /// Gets the furniture by category.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureByCategory()
        {
            List<string> categories = new List<string>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                const string query = "SELECT DISTINCT CategoryName FROM [Furniture]";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            categories.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return categories;

        }

        /// <summary>
        /// Gets the name of the furniture by category.
        /// </summary>
        /// <param name="categoryName">Name of the category.</param>
        /// <returns></returns>
        public List<Furniture> GetFurnitureByCategoryName(string categoryName)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Furniture] WHERE CategoryName = @CategoryName";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@CategoryName", SqlDbType.VarChar)).Value = categoryName;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                InStockQuantity = reader.GetInt32(reader.GetOrdinal("InStockQuantity")),
                                TotalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"))
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        /// <summary>
        /// Gets the furniture styles.
        /// </summary>
        /// <returns></returns>
        public List<string> GetFurnitureStyles()
        {
            List<string> styles = new List<string>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                const string query = "SELECT DISTINCT StyleName FROM [Furniture]";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            styles.Add(reader.GetString(0));
                        }
                    }
                }
            }
            return styles;
        }

        /// <summary>
        /// Gets the name of the furniture by style.
        /// </summary>
        /// <param name="styleName">Name of the style.</param>
        /// <returns></returns>
        public List<Furniture> GetFurnitureByStyleName(string styleName)
        {
            List<Furniture> furnitureList = new List<Furniture>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Furniture] WHERE StyleName = @StyleName";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add(new SqlParameter("@StyleName", SqlDbType.VarChar)).Value = styleName;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                InStockQuantity = reader.GetInt32(reader.GetOrdinal("InStockQuantity")),
                                TotalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"))
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        /// <summary>
        /// Retrieves a single piece of furniture from the database based on its unique ID.
        /// </summary>
        /// <param name="ID">The unique identifier of the furniture to retrieve.</param>
        /// <returns>A Furniture object if found; otherwise, null.</returns>
        public Furniture GetFurnitureID(int ID)
        {
            Furniture furniture = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Furniture] WHERE FurnitureID = @FurnitureID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int).Value = ID;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            furniture = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                InStockQuantity = reader.GetInt32(reader.GetOrdinal("InStockQuantity")),
                                TotalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"))
                            };
                        }
                    }
                }
            }

            return furniture;
        }

        /// <summary>
        /// Retrieves the daily rental rate of a specific piece of furniture based on its ID.
        /// </summary>
        /// <param name="furnitureId">The ID of the furniture whose daily rental rate is to be retrieved.</param>
        /// <returns>The daily rental rate as a decimal value.</returns>
        public decimal GetFurnitureDailyRate(int furnitureId)
        {
            decimal dailyRate = 0;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT RentalRatePerDay FROM [Furniture] WHERE FurnitureID = @FurnitureID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int).Value = furnitureId;
                    connection.Open();
                    dailyRate = (decimal)command.ExecuteScalar();
                }
            }
            return dailyRate;
        }

        /// <summary>
        /// Updates the stock quantity of a specific piece of furniture after a rental transaction.
        /// </summary>
        /// <param name="furnitureId">The ID of the furniture whose stock quantity is to be updated.</param>
        /// <param name="quantityRented">The quantity of the furniture that was rented, which will be subtracted from the current stock.</param>
        public void UpdateStockQuantity(int furnitureId, int quantityRented)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "UPDATE [Furniture] SET InStockQuantity = InStockQuantity - @QuantityRented WHERE FurnitureID = @FurnitureID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@FurnitureID", SqlDbType.Int).Value = furnitureId;
                    command.Parameters.Add("@QuantityRented", SqlDbType.Int).Value = quantityRented;
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Retrieves all furniture items from the database that are currently available for rent.
        /// </summary>
        /// <returns>A list of Furniture objects representing all available furniture items.</returns>
        public List<Furniture> GetAvailableFurniture()
        {
            List<Furniture> availableFurniture = new List<Furniture>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Furniture] WHERE InStockQuantity > 0";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                InStockQuantity = reader.GetInt32(reader.GetOrdinal("InStockQuantity")),
                                TotalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"))
                            };
                            availableFurniture.Add(furniture);
                        }
                    }
                }
            }
            return availableFurniture;
        }

        /// <summary>
        /// Retrieves all furniture items from the database, regardless of their stock quantity.
        /// </summary>
        /// <returns>A list of all Furniture objects found in the database.</returns>
        public List<Furniture> GetAllFurniture()
        {
            List<Furniture> furnitureList = new List<Furniture>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Furniture]";
                using (var command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Furniture furniture = new Furniture
                            {
                                FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                                Name = reader.GetString(reader.GetOrdinal("Name")),
                                CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                                StyleName = reader.GetString(reader.GetOrdinal("StyleName")),
                                Description = reader.GetString(reader.GetOrdinal("Description")),
                                RentalRatePerDay = (double)reader.GetDecimal(reader.GetOrdinal("RentalRatePerDay")),
                                InStockQuantity = reader.GetInt32(reader.GetOrdinal("InStockQuantity")),
                                TotalQuantity = reader.GetInt32(reader.GetOrdinal("TotalQuantity"))
                            };
                            furnitureList.Add(furniture);
                        }
                    }
                }
            }
            return furnitureList;
        }

        public void IncrementStockQuantity(int furnitureId, int quantityReturned)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "UPDATE [Furniture] SET InStockQuantity = InStockQuantity + @QuantityReturned WHERE FurnitureID = @FurnitureID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FurnitureID", furnitureId);
                    command.Parameters.AddWithValue("@QuantityReturned", quantityReturned);
                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}