using SofaSoGood.Model;
using System;
using System.Collections.Generic;
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
    }
}
