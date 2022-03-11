
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class includes the DAL from the tech support database. It returns the open incidents.
    /// </summary>
    public class IncidentDBDAL
    {

        /// <summary>
        /// Connects to the Tech Support database and uses a select statement to get the product code, date opened, customer name, technician name and title
        /// from the selected tables. It then returns a list of the designated incidents objects.
        /// </summary>
        /// <returns></returns>
        ///



        public List<Incident> GetIncidents()
        {
            List<Incident> incidentList = new List<Incident>();



            string selectStatement =
              "SELECT Incidents.IncidentID as incidentID, Products.ProductCode, DateOpened, " +
              "Customers.Name as customerName, Technicians.Name as techniciansName, Title, Products.Name as productName, DateClosed " +
              "FROM Incidents " +
              "LEFT JOIN Customers " +
              "ON Customers.CustomerID=Incidents.CustomerID " +
              "LEFT JOIN Products " +
              "ON Products.ProductCode=Incidents.ProductCode " +
              "LEFT JOIN Technicians " +
              "ON Incidents.techID=Technicians.techID ";



            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {


                        while (reader.Read())
                        {

                            Incident Incident = new Incident();
                            Incident.IncidentID = (int)reader["incidentID"];
                            Incident.ProductCode = reader["ProductCode"].ToString();
                            Incident.ProductName = reader["productName"].ToString();
                            Incident.DateOpened = (DateTime)reader["DateOpened"];
                            Incident.CustomerName = reader["customerName"].ToString();
                            Incident.TechnicianName = reader["techniciansName"].ToString();
                            Incident.Title = reader["Title"].ToString();

                            if (reader["dateClosed"].ToString() != DateTime.MinValue.ToString())
                            {
                                Incident.DateClosed = reader["DateClosed"].ToString();

                            }
                            else
                            {
                                Incident.DateClosed = "";
                            }


                            incidentList.Add(Incident);

                        }
                    }

                }

            }


            return incidentList;
        }

        /// <summary>
        /// Updates the incident in the database using techID, description and IncidentID.
        /// </summary>
        /// <param name="incident">The incident being updated</param>
        public void UpdateIncident(Incident newIncident, Incident oldIncident)
        {

            string query = "UPDATE Incidents " +
                "SET TechID=@techID, Description=@description " +
                "WHERE IncidentID=@incidentID " +
                "AND (DateClosed=@oldCloseDate " +
                "OR DateClosed IS NULL AND @oldCloseDate IS NULL) " +
                "AND (Description=@oldDescription " +
                "OR Description IS NULL AND @oldDescription IS NULL)";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {


                    command.Parameters.AddWithValue("@description", newIncident.Description);
                    command.Parameters["@description"].Value = newIncident.Description;

                    command.Parameters.AddWithValue("@incidentID", newIncident.IncidentID);
                    command.Parameters["@incidentID"].Value = newIncident.IncidentID;

                    command.Parameters.AddWithValue("@techID", newIncident.TechID);
                    command.Parameters["@techID"].Value = newIncident.TechID;


                    if (oldIncident.DateClosed == "")
                    {
                        command.Parameters.AddWithValue("@oldCloseDate", DBNull.Value);
                        command.Parameters["@oldCloseDate"].Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@oldCloseDate", DateTime.Parse(oldIncident.DateClosed));
                        command.Parameters["@oldCloseDate"].Value = DateTime.Parse(oldIncident.DateClosed);
                    }

                    if (oldIncident.Description == "")
                    {
                        command.Parameters.AddWithValue("@oldDescription", DBNull.Value);
                        command.Parameters["@oldDescription"].Value = DBNull.Value;
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@oldDescription", oldIncident.Description);
                        command.Parameters["@oldDescription"].Value = oldIncident.Description;
                    }

                    int rows = command.ExecuteNonQuery();
                    if (rows == 0)
                    {
                        throw new Exception("That incident has already been updated. Please try again.");
                    }
                }
            }
        }


        /// <summary>
        /// Updates the Incident's CloseDate with the current DateTime to signify the Incident has been closed.
        /// </summary>
        /// <param name="incident">The incident being updated/closed</param>
        public void CloseIncident(Incident newIncident, Incident oldIncident)
        {


            string query = "UPDATE Incidents " +
                "SET DateClosed=@closeDate, TechID=@techID, Description=@description " +
                "WHERE IncidentID=@incidentID " +
                "AND (DateClosed=@oldCloseDate " +
                "OR DateClosed IS NULL AND @oldCloseDate IS NULL) " +
                "AND Description=@oldDescription ";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {
                    {
                        if (oldIncident.DateClosed == "")
                        {
                            command.Parameters.AddWithValue("@oldCloseDate", DBNull.Value);
                            command.Parameters["@oldCloseDate"].Value = DBNull.Value;
                        }
                        else
                        {
                            command.Parameters.AddWithValue("@oldCloseDate", DateTime.Parse(oldIncident.DateClosed));
                            command.Parameters["@oldCloseDate"].Value = DateTime.Parse(oldIncident.DateClosed);
                        }


                        command.Parameters.AddWithValue("@oldDescription", oldIncident.Description);
                        command.Parameters["@oldDescription"].Value = oldIncident.Description;



                        command.Parameters.AddWithValue("@closeDate", newIncident.DateClosed);
                        command.Parameters["@closeDate"].Value = newIncident.DateClosed;

                        command.Parameters.AddWithValue("@incidentID", newIncident.IncidentID);
                        command.Parameters["@incidentID"].Value = newIncident.IncidentID;

                        command.Parameters.AddWithValue("@description", newIncident.Description);
                        command.Parameters["@description"].Value = newIncident.Description;

                        command.Parameters.AddWithValue("@techID", newIncident.TechID);
                        command.Parameters["@techID"].Value = newIncident.TechID;

                        int rows = command.ExecuteNonQuery();
                        if (rows == 0)
                        {
                            throw new Exception("That incident has already been updated. Please try again.");
                        }
                    }
                }
            }
        }




        /// <summary>
        /// Adds a new incident into the tech support database
        /// </summary>
        /// <param name="incident">Includes the customerid, product code, title, description and the current date.</param>
        public void Add(Incident incident)
        {

          
            string query = "INSERT INTO " +
                "Incidents (CustomerID, ProductCode, Title, " +
                "Description, DateOpened) VALUES(@customerID," +
                "@productCode, @title, @description, CURRENT_TIMESTAMP)";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))

                {

                    command.Parameters.AddWithValue("@customerID", incident.CustomerID);

                    command.Parameters.AddWithValue("@productCode", incident.ProductCode);

                    command.Parameters.AddWithValue("@title", incident.Title);

                    command.Parameters.AddWithValue("@description", incident.Description);

                    command.ExecuteScalar();

                }
            }

        }

        /// <summary>
        /// Checks to make sure the Incident being closed or updated is not closed by getting all incidents with the same ID as the incident being compared
        /// and the DateClosed column being null (empty).
        /// </summary>
        /// <param name="incidentID">The incident being compared</param>
        /// <returns></returns>
        public int CheckIncidentStatus(Incident incident)
        {

            string selectStatement =
              "SELECT COUNT(*) FROM Incidents " +
              "WHERE Incidents.IncidentID=@incidentID " +
              "AND DateClosed IS NULL";

            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))

                {

                    command.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                    command.Parameters["@incidentID"].Value = incident.IncidentID;
               

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    if (count == 0)
                    {
                        throw new Exception("That incident has already been closed or does not exist.");
                    }
                    return count;
                }

            }


        }

        public List<Incident> GetAllIncidentsByTechnician(int techID)
        {
            List<Incident> incidentList = new List<Incident>();

            string selectStatement =

              "SELECT Products.Name as productName, Incidents.DateOpened as dateOpened, " +
              "Customers.Name as customerName, Title " +
              "FROM Incidents " +
              "LEFT JOIN Customers " +
              "ON Customers.CustomerID=Incidents.CustomerID " +
              "LEFT JOIN Products " +
              "ON Products.ProductCode=Incidents.ProductCode " +
              "LEFT JOIN Technicians " +
              "ON Incidents.techID=Technicians.techID " +
              "WHERE Technicians.TechID = @techID";


            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))

                {

                    selectCommand.Parameters.AddWithValue("@techID", techID);
                    selectCommand.Parameters["@techID"].Value = techID;
                    using (SqlDataReader reader = selectCommand.ExecuteReader())
                    {
                       

                        while (reader.Read())
                        {
                            Incident newIncident = new Incident
                            {
                                ProductName = reader["productName"].ToString(),
                                DateOpened = (DateTime)reader["dateOpened"],
                                CustomerName = reader["customerName"].ToString(),
                                Title = reader["Title"].ToString()

                            };
                            incidentList.Add(newIncident);
                        }

                    }

                }
            }

            return incidentList;

        }



        /// <summary>
        /// Returns the incidentID, customerName, productCode, technicianName, title, dateOpened, and description info from designated Incident as located by its ID.
        /// </summary>
        /// <param name="incidentID">the ID of the incident being found.</param>
        /// <returns></returns>
        public Incident GetIncident(Incident incident)

        {

            string selectStatement =
              "SELECT Incidents.IncidentID as incidentID, Incidents.TechID as techID, Customers.Name as customerName, Products.ProductCode as productCode, Technicians.Name as techName, " +
              "Incidents.Title as title, Incidents.DateClosed as dateClosed, Incidents.DateOpened as dateOpened, Incidents.Description as description " +
              "FROM Incidents " +
              "LEFT JOIN Customers " +
              "ON Customers.CustomerID=Incidents.CustomerID " +
              "LEFT JOIN Products " +
              "ON Products.ProductCode=Incidents.ProductCode " +
              "LEFT JOIN Technicians " +
              "ON Incidents.TechID=Technicians.TechID " +
              "WHERE Incidents.IncidentID=@incidentID";

            Incident gotIncident = new Incident();


            using (SqlConnection connection = TechSupportDBConnection.GetConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(selectStatement, connection))

                {
                    command.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                    command.Parameters["@incidentID"].Value = incident.IncidentID;

                    using (SqlDataReader reader = command.ExecuteReader())
                    {

                        while (reader.Read())
                        {
                            gotIncident.IncidentID = (int)reader["incidentID"];
                            if (reader["techID"].ToString() != "")
                            {
                                gotIncident.TechID = (int)reader["techID"];
                            }
                            gotIncident.CustomerName = reader["customerName"].ToString();
                            gotIncident.ProductCode = reader["productCode"].ToString();
                            gotIncident.DateOpened = (DateTime)reader["dateOpened"];
                            gotIncident.TechnicianName = reader["techName"].ToString();
                            gotIncident.Description = reader["description"].ToString();
                            gotIncident.Title = reader["title"].ToString();

                            if (reader["dateClosed"].ToString() != DateTime.MinValue.ToString())
                            {
                                gotIncident.DateClosed = reader["DateClosed"].ToString();

                            }
                            else
                            {
                                gotIncident.DateClosed = "";
                            }


                        }

                    }

                    return gotIncident;
                }
            }
        }

    }
}


