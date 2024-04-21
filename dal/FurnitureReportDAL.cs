using SofaSoGood.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// Data Access Layer for Furniture Report
    /// </summary>
    public class FurnitureReportDAL
    {
        /// <summary>
        /// Gets the popular furniture.
        /// </summary>
        /// <param name="startDate">The start date.</param>
        /// <param name="endDate">The end date.</param>
        /// <returns></returns>
        public List<FurnitureReportItem> GetPopularFurniture(DateTime startDate, DateTime endDate)
        {
            List<FurnitureReportItem> items = new List<FurnitureReportItem>();
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                SqlCommand command = new SqlCommand("getMostPopularFurnitureDuringDates", connection);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add("@startDate", SqlDbType.Date).Value = startDate;
                command.Parameters.Add("@endDate", SqlDbType.Date).Value = endDate;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var item = new FurnitureReportItem
                        {
                            FurnitureID = reader.GetInt32(reader.GetOrdinal("FurnitureID")),
                            CategoryName = reader.GetString(reader.GetOrdinal("CategoryName")),
                            Name = reader.GetString(reader.GetOrdinal("Name")),
                            RentalTransactionsCount = reader.GetInt32(reader.GetOrdinal("RentalTransactionsCount")),
                            TotalRentalTransactions = reader.GetInt32(reader.GetOrdinal("TotalRentalTransactions")),
                            PercentageOfRentals = reader.GetDecimal(reader.GetOrdinal("PercentageOfRentals")),
                            Percentage18To29 = reader.GetDecimal(reader.GetOrdinal("Percentage18To29")),
                            PercentageOutside18To29 = reader.GetDecimal(reader.GetOrdinal("PercentageOutside18To29"))
                        };
                        items.Add(item);
                    }
                }
            }
            return items;
        }
    }
}