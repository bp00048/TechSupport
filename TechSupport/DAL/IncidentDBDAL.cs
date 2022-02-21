
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
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

        

        public List<Incident> GetOpenIncidents()
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
                    Incident Incident = new Incident();
                    Incident.IncidentID = (int)reader["incidentID"];
                    Incident.ProductCode = reader["ProductCode"].ToString();
                    Incident.ProductName = reader["productName"].ToString();
                    Incident.DateOpened = (DateTime)reader["DateOpened"];
                    Incident.CustomerName = reader["customerName"].ToString();
                    Incident.TechnicianName = reader["techniciansName"].ToString();
                    Incident.Title = reader["Title"].ToString();
                    Incident.DateClosed = reader["DateClosed"].ToString();
                   

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

            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }
            
           

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
            Incident newIncident = new Incident();
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

            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }
            
           

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
        /// <summary>
        /// Adds a new incident into the tech support database
        /// </summary>
        /// <param name="incident">Includes the customerid, product code, title, description and the current date.</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }

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
        /// <summary>
        /// Checks to make sure the Incident being closed or updated is not closed by getting all incidents with the same ID as the incident being compared
        /// and the DateClosed column being null (empty).
        /// </summary>
        /// <param name="incidentID">The incident being compared</param>
        /// <returns></returns>
        public int CheckIncidentStatus(int incidentID)
        {

            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =
              "SELECT COUNT(*) FROM Incidents " +
              "WHERE Incidents.IncidentID=@incidentID " +
              "AND DateClosed IS NULL";

            using (SqlCommand selectCommand = new SqlCommand(selectStatement, connection))
            {

                selectCommand.Parameters.AddWithValue("@incidentID", incidentID);
                selectCommand.Parameters["@incidentID"].Value = incidentID;
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
    public Incident GetIncident(int incidentID)
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =
              "SELECT Incidents.IncidentID as incidentID, Customers.Name as customerName, Products.ProductCode as productCode, Technicians.Name as techName, " +
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
               
                selectCommand.Parameters.AddWithValue("@incidentID", incidentID);
                selectCommand.Parameters["@incidentID"].Value = incidentID;
                connection.Open();
                
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    gotIncident.IncidentID = (int)reader["incidentID"];
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


