
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
            SqlConnection connection = TechSupportDBConnection.GetConnection();
           

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

            SqlDataReader reader = null;

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    Incident Incident = new Incident
                    {
                        IncidentID = (int)reader["incidentID"],
                        ProductCode = reader["ProductCode"].ToString(),
                        ProductName = reader["productName"].ToString(),
                        DateOpened = (DateTime)reader["DateOpened"],
                        CustomerName = reader["customerName"].ToString(),
                        TechnicianName = reader["techniciansName"].ToString(),
                        Title = reader["Title"].ToString(),
                        DateClosed = reader["DateClosed"].ToString()
                      
                    };


                    incidentList.Add(Incident);
                }

            }


            return incidentList;
        }

        /// <summary>
        /// Updates the incident in the database using techID, description and IncidentID.
        /// </summary>
        /// <param name="incident">The incident being updated</param>
        public void UpdateIncident(Incident incident)
        {

            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "UPDATE Incidents " +
                "SET TechID=@techID, Description=@description " +
                "WHERE IncidentID=@incidentID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                command.Parameters["@incidentID"].Value = incident.IncidentID;
                command.Parameters.AddWithValue("@techID", incident.TechID);
                command.Parameters["@techID"].Value = incident.TechID;
                command.Parameters.AddWithValue("@description", incident.Description);
                command.Parameters["@description"].Value = incident.Description;

                connection.Open();
                command.ExecuteScalar();
            }
        }
        /// <summary>
        /// Gets all the incidents that match the exact description and incidentID of the current incident attempting to be updated or closed
        /// to make sure they have not been updated or closed already.
        /// </summary>
        /// <param name="incident"></param>
        /// <returns></returns>
        public int CheckChanges(Incident incident)
        {
            
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "SELECT COUNT(*) FROM Incidents " +
                            "WHERE IncidentID=@incidentID " +
                            "AND Description=@description ";
           
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                command.Parameters["@incidentID"].Value = incident.IncidentID;
                command.Parameters.AddWithValue("@description", incident.Description);
                command.Parameters["@description"].Value = incident.Description;

                connection.Open();
                int count = Convert.ToInt32(command.ExecuteScalar());
                return count;
            

        }
        }

      /// <summary>
      /// Updates the Incident's CloseDate with the current DateTime to signify the Incident has been closed.
      /// </summary>
      /// <param name="incident">The incident being updated/closed</param>
            public void CloseIncident(Incident incident)
        {

            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "UPDATE Incidents " +
                "SET DateClosed=@closeDate, TechID=@techID, Description=@description " +
                "WHERE IncidentID=@incidentID";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                
                command.Parameters.AddWithValue("@closeDate", incident.DateClosed);
                command.Parameters["@closeDate"].Value = incident.DateClosed;

                command.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                command.Parameters["@incidentID"].Value = incident.IncidentID;

                command.Parameters.AddWithValue("@techID", incident.TechID);
                command.Parameters["@techID"].Value = incident.TechID;

                command.Parameters.AddWithValue("@description", incident.Description);
                command.Parameters["@description"].Value = incident.Description;


                connection.Open();
                command.ExecuteScalar();
            }
        }


 
        /// <summary>
        /// Adds a new incident into the tech support database
        /// </summary>
        /// <param name="incident">Includes the customerid, product code, title, description and the current date.</param>
        public void Add(Incident incident)
        {

            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "INSERT INTO " +
                "Incidents (CustomerID, ProductCode, Title, " +
                "Description, DateOpened) VALUES(@customerID," +
                "@productCode, @title, @description, CURRENT_TIMESTAMP)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {

                command.Parameters.AddWithValue("@customerID", incident.CustomerID);

                command.Parameters.AddWithValue("@productCode", incident.ProductCode);

                command.Parameters.AddWithValue("@title", incident.Title);

                command.Parameters.AddWithValue("@description", incident.Description);

                connection.Open();
                command.ExecuteScalar();

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

            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =
              "SELECT COUNT(*) FROM Incidents " +
              "WHERE Incidents.IncidentID=@incidentID " +
              "AND DateClosed IS NULL";

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {

                selectCommand.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                selectCommand.Parameters["@incidentID"].Value = incident.IncidentID;
                connection.Open();

                int count = Convert.ToInt32(selectCommand.ExecuteScalar());
                return count;

            }

         
        }
    /// <summary>
    /// Returns the incidentID, customerName, productCode, technicianName, title, dateOpened, and description info from designated Incident as located by its ID.
    /// </summary>
    /// <param name="incidentID">the ID of the incident being found.</param>
    /// <returns></returns>
    public Incident GetIncident(Incident incident)
           
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =
              "SELECT Incidents.IncidentID as incidentID, Incidents.TechID as techID, Customers.Name as customerName, Products.ProductCode as productCode, Technicians.Name as techName, " +
              "Incidents.Title as title, Incidents.DateOpened as dateOpened, Incidents.Description as description " +
              "FROM Incidents " +
              "LEFT JOIN Customers " +
              "ON Customers.CustomerID=Incidents.CustomerID " +
              "LEFT JOIN Products " +
              "ON Products.ProductCode=Incidents.ProductCode " +
              "LEFT JOIN Technicians " +
              "ON Incidents.TechID=Technicians.TechID " +
              "WHERE Incidents.IncidentID=@incidentID";
           
            Incident gotIncident = new Incident();
            SqlDataReader reader = null;

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {
               
                selectCommand.Parameters.AddWithValue("@incidentID", incident.IncidentID);
                selectCommand.Parameters["@incidentID"].Value = incident.IncidentID;
                connection.Open();
                
                reader = selectCommand.ExecuteReader();


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

                }

            }

            return gotIncident;
        }
    }
}


