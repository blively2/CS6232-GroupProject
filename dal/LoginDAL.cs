using System;
using System.Data.SqlClient;
using System.Data;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// This class is data access layer between model and view for Members
    /// </summary>
    public class LoginDAL
    {

        /// <summary>
        /// Verifies that the entered Username and Password exist in the Database on the same row in the Login table.
        /// </summary>
        public Boolean VerifyUserCredentials(string Username, string Password)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                var query = @"SELECT COUNT(1) FROM Login WHERE Username = @Username AND Password = @Password";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.VarChar, 45).Value = Username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar, 45).Value = Password;

                    connection.Open();
                    var result = (int)command.ExecuteScalar();
                    return result > 0;
                }
            }
        }

        /// <summary>
        /// Returns the LoginID associated with the Username and Password entered by the User.
        /// </summary>
        public int GetLoginIDByUsernameAndPassword(string Username, string Password)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                var query = @"SELECT LoginID FROM Login WHERE Username = @Username AND Password = @Password";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@Username", SqlDbType.VarChar, 45).Value = Username;
                    command.Parameters.Add("@Password", SqlDbType.VarChar, 45).Value = Password;

                    connection.Open();
                    var result = command.ExecuteScalar();
                    if (result != null)
                    {
                        return (int)result;
                    }
                    else
                    {
                        return -1;
                    }
                }
            }
        }
    }
}