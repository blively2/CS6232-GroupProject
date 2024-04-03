using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }

}

