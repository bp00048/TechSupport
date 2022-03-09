using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.DAL
{
    class TechniciansDAL
    {

        /// <summary>
        /// Returns a list of TechID's and the Technian's names.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetTechnicians()
        {
            var techniciansList = new Dictionary<int, string>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =

              "SELECT TechID, Name " +
              "FROM Technicians ";

            SqlDataReader reader = null;

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    techniciansList.Add((int)reader["TechID"], (string)reader["Name"]);
                }

            }

            return techniciansList;
        }
    }
}
