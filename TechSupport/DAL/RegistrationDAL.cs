
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
            string selectStatement = "SELECT COUNT(*) FROM Registrations " +
                            "WHERE CustomerID=@customerID " +
                            "AND ProductCode=@productCode";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))

                {
                    command.Parameters.AddWithValue("@customerID", incident.CustomerID);
                    command.Parameters["@customerID"].Value = incident.CustomerID;
                    command.Parameters.AddWithValue("@productCode", incident.ProductCode);
                    command.Parameters["@productCode"].Value = incident.ProductCode;
            
                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count;
                }
            }
        }
    }
}
