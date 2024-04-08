using SofaSoGood.Model;
using System.Data.SqlClient;
using System.Data;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// This class is data access layer between model and view for Employee
    /// </summary>
    public class EmployeeDAL
    {

        /// <summary>
        /// Gets the employee by login identifier.
        /// </summary>
        /// <param name="loginId">The login identifier.</param>
        /// <returns></returns>
        public Employee GetEmployeeByLoginID(int loginId)
        {
            Employee employee = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Employee] WHERE LoginID = @LoginID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@LoginID", SqlDbType.Int).Value = loginId;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                LoginID = reader.GetInt32(reader.GetOrdinal("LoginID")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                                Address2 = reader.IsDBNull(reader.GetOrdinal("Address2")) ? null : reader.GetString(reader.GetOrdinal("Address2")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                Zip = reader.GetString(reader.GetOrdinal("Zip")),
                                ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone")),
                            };
                        }
                    }
                }
            }
            return employee;
        }

        /// <summary>
        /// Gets the employee by employee identifier.
        /// </summary>
        /// <param name="employeeId">The employee identifier.</param>
        /// <returns>An Employee object if found; otherwise, null.</returns>
        public Employee GetEmployeeByEmployeeID(int employeeId)
        {
            Employee employee = null;
            using (var connection = SofaSoGoodDBConnection.GetConnection())
            {
                string query = "SELECT * FROM [Employee] WHERE EmployeeID = @EmployeeID";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.Add("@EmployeeID", SqlDbType.Int).Value = employeeId;
                    connection.Open();
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            employee = new Employee
                            {
                                EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID")),
                                LoginID = reader.GetInt32(reader.GetOrdinal("LoginID")),
                                FirstName = reader.GetString(reader.GetOrdinal("FirstName")),
                                LastName = reader.GetString(reader.GetOrdinal("LastName")),
                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
                                DateOfBirth = reader.GetDateTime(reader.GetOrdinal("DateOfBirth")),
                                Address1 = reader.GetString(reader.GetOrdinal("Address1")),
                                Address2 = reader.IsDBNull(reader.GetOrdinal("Address2")) ? null : reader.GetString(reader.GetOrdinal("Address2")),
                                City = reader.GetString(reader.GetOrdinal("City")),
                                State = reader.GetString(reader.GetOrdinal("State")),
                                Zip = reader.GetString(reader.GetOrdinal("Zip")),
                                ContactPhone = reader.GetString(reader.GetOrdinal("ContactPhone")),
                            };
                        }
                    }
                }
            }
            return employee;
        }
    }
}