using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    class ProductsDAL
    {


        /// <summary>
        /// Returns the list of products with their code and name and returns in a Dictionary.
        /// </summary>
        /// <returns>A Dictionary object that includes both productCode and Name</returns>
        public Dictionary<string, string> GetProducts()
        {
            var productList = new Dictionary<string, string>();

            string selectStatement =

              "SELECT Name, ProductCode " +
              "FROM Products " +
              "ORDER BY Name ASC ";



            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                       
                        while (reader.Read())
                        {
                            productList.Add((string)reader["ProductCode"], (string)reader["Name"]);
                        }

                    }

                    return productList;
                }
            }
        }
    }
}
