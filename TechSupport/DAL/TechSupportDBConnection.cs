
using System.Data.SqlClient;


namespace TechSupport.DAL
{
    /// <summary>
    /// Connection to the Tech Support database
    /// </summary>
    public static class TechSupportDBConnection
    {
        /// <summary>
        /// Connects to the techsupport database on the local host and returns the SqlConnection object.
        /// </summary>
        /// <returns></returns>
        public static SqlConnection GetConnection()
        {
            string connectionString =
                "Data Source=localhost;Initial Catalog=TechSupport;" +
                "Integrated Security=True";
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }
    }
}
