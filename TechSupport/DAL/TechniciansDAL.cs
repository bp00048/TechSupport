using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class TechniciansDAL
    {

        /// <summary>
        /// Returns a list of TechID's and the Technian's names.
        /// 
        /// THIS METHOD IS NOT REFERENCED IN HOMEWORK6. However I am leaving it
        /// here to reference for homework fixes. Afterwards, I will remove it
        /// for clarity. However I recognize that having two methods "GetTechnicians" and 
        /// "GetAllTechnicians" is confusing, and therefore would have changed or omitted it.
        /// 
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetTechnicians()
        {
            var techniciansList = new Dictionary<int, string>();
            string selectStatement =

              "SELECT TechID, Name " +
              "FROM Technicians ";


            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            techniciansList.Add((int)reader["TechID"], (string)reader["Name"]);
                        }

                    }

                    return techniciansList;
                }
            }
        }

        /// <summary>
        /// Returns the list of technicians that have incidents
        /// </summary>
        /// <returns></returns>

        public static List<Technician> GetAllTechnicians()
        {
            List<Technician> techniciansList = new List<Technician>();

            string selectStatement =
              "SELECT DISTINCT Technicians.TechID as techID, Name, Email, Phone " +
              "FROM Technicians " +
              "LEFT JOIN Incidents " +
              "ON Incidents.TechID=Technicians.TechID " +
              "WHERE Incidents.TechID IS NOT NULL";

           
                using (SqlConnection connection = TechSupportDBConnection.GetConnection())
                {
                    connection.Open();
                    using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                    {
                        using (SqlDataReader reader = selectCommand.ExecuteReader())
                        {

                            while (reader.Read())
                            {
                                Technician newTech = new Technician
                                {
                                    TechID = (int)reader["techID"],
                                    Name = reader["Name"].ToString(),
                                    Phone = reader["Phone"].ToString(),
                                    Email = reader["Email"].ToString()

                                };
                                techniciansList.Add(newTech);
                            }

                        }

                    }
                }
          
            return techniciansList;
        }
    }
}
