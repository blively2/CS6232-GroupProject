using System.Data.SqlClient;

namespace SofaSoGood.DAL
{
    /// <summary>
    /// Provides a way to manage database connections for the SofaSoGood application.
    /// </summary>
    public static class SofaSoGoodDBConnection
    {
        /// <summary>
        /// Creates and returns a new instance of SqlConnection configured for the SofaSoGood database.
        /// </summary>
        public static SqlConnection GetConnection()
        {
            string connectionString = "Data Source=localhost;Initial Catalog=CS6232-g3;Integrated Security=True;";
            return new SqlConnection(connectionString);
        }
    }
}