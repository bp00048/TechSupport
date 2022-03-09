
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class RegistrationDAL
    {

        /// <summary>
        /// Gets all database submissions that have the same matching customerID and productCode to check to make sure the product is registered to the customer.
        /// </summary>
        /// <param name="incident">The incident being compared</param>
        /// <returns></returns>
        public int IsRegistered(Incident incident)
        {

            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM Registrations " +
                            "WHERE CustomerID=@customerID " +
                            "AND ProductCode=@productCode";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@customerID", incident.CustomerID);
                command.Parameters["@customerID"].Value = incident.CustomerID;
                command.Parameters.AddWithValue("@productCode", incident.ProductCode);
                command.Parameters["@productCode"].Value = incident.ProductCode;
                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            }

        }
    }
}
