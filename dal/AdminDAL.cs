using System.Data;
using System.Data.SqlClient;
using SofaSoGood.Model;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// This class is data access layer between model and view for Admin
    /// </summary>
    public class AdminDAL
    {
        /// <summary>
        /// Gets the admin by login identifier.
        /// </summary>
        /// <param name="loginID">The login identifier.</param>
        /// <returns></returns>
        public Admin GetAdminByLoginID(int loginID)
        {
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                var query = "SELECT * FROM Admin WHERE LoginID = @LoginID";
                var command = new SqlCommand(query, connection);
                command.Parameters.Add("@LoginID", SqlDbType.Int).Value = loginID;

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        return new Admin
                        {
                            AdminID = reader.GetInt32(reader.GetOrdinal("AdminID")),
                            LoginID = reader.GetInt32(reader.GetOrdinal("LoginID")),
                            FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                            LastName = reader.GetString(reader.GetOrdinal("LastName")),
                            DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                            Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                            Address2 = reader.IsDBNull(reader.GetOrdinal("Address2")) ? null : reader.GetString(reader.GetOrdinal("Address2")),
                            City = reader.GetString(reader.GetOrdinal("City")),
                            State = reader.GetString(reader.GetOrdinal("State")),
                            Zip = reader.GetString(reader.GetOrdinal("Zip")),
                            ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone"))
                        };
                    }
                }
            }
            return null;
        }
    }
}
