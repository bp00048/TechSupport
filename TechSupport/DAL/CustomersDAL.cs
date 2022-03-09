using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    class CustomersDAL
    {


        /// <summary>
        /// Returns the list of customers with their ID and name and returns in a Dictionary.
        /// </summary>
        /// <returns>A Dictionary object that includes both customerID and Name</returns>
        public Dictionary<int, string> GetCustomers()
        {
            var customerList = new Dictionary<int, string>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =

              "SELECT CustomerID, Name " +
              "FROM Customers " +
              "ORDER BY Name ASC";

            SqlDataReader reader = null;

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    customerList.Add((int)reader["CustomerID"], (string)reader["Name"]);
                }

            }

            return customerList;
        }
    }



}
