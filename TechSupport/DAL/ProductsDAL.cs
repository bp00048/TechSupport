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
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =

              "SELECT Name, ProductCode " +
              "FROM Products " +
              "ORDER BY Name ASC ";

            SqlDataReader reader = null;

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    productList.Add((string)reader["ProductCode"], (string)reader["Name"]);
                }

            }

            return productList;
        }
    }
}
