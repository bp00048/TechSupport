using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{

    /// <summary>
    /// DAL for the Customers table in the database.
    /// </summary>
    class CustomersDAL
    {


        /// <summary>
        /// Returns the list of customers with their ID and name and returns in a Dictionary.
        /// </summary>
        /// <returns>A Dictionary object that includes both customerID and Name</returns>
        public Dictionary<int, string> GetCustomers()
        {
            var customerList = new Dictionary<int, string>();


            string selectStatement =

              "SELECT CustomerID, Name " +
              "FROM Customers " +
              "ORDER BY Name ASC";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
        
                        while (reader.Read())
                        {
                            customerList.Add((int)reader["CustomerID"], (string)reader["Name"]);
                        }

                    }

                    return customerList;
                }
            }

        }
    }

}
