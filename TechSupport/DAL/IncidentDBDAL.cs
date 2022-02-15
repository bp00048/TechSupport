
using System;
using System.Collections;
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

        public List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =
              "SELECT Incidents.ProductCode, DateOpened, " +
              "Customers.Name as customerName, Technicians.Name as techniciansName, Title, Products.Name as productName " +
              "FROM Incidents " +
              "JOIN Customers " +
              "ON Customers.CustomerID=Incidents.CustomerID " +
              "JOIN Products " +
              "ON Products.ProductCode=Incidents.ProductCode " +
              "LEFT JOIN Technicians " +
              "ON Incidents.techID=Technicians.techID " +
              "WHERE DateClosed IS NULL ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
              

                while (reader.Read())
                {
                    Incident Incident = new Incident();
                   
                    Incident.ProductCode = reader["ProductCode"].ToString();
                    Incident.ProductName = reader["productName"].ToString();
                    Incident.DateOpened = (DateTime)reader["DateOpened"];
                    Incident.CustomerName = reader["customerName"].ToString();
                    Incident.TechnicianName = reader["techniciansName"].ToString();
                    Incident.Title = reader["Title"].ToString();

                    incidentList.Add(Incident);
                }

            }

            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return incidentList;
        }

        public Dictionary<int, string> GetCustomers()
        {
            var customerList = new Dictionary<int, string>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =

              "SELECT CustomerID, Name " +
              "FROM Customers ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    customerList.Add((int)reader["CustomerID"], (string)reader["Name"]);
                }

            }

            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return customerList;
        }

        public Dictionary<string, string> GetProducts()
        {
            var productList = new Dictionary<string, string>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =

              "SELECT Name, ProductCode " +
              "FROM Products ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    productList.Add((string)reader["ProductCode"], (string)reader["Name"]);
                }

            }

            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return productList;
        }

        public List<Incident> GetProductNames()
        {
            List<Incident> incidentList = new List<Incident>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =

              "SELECT ProductName " +
              "FROM Products " +
              "GROUP BY ProductName";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();


                while (reader.Read())
                {
                    Incident Incident = new Incident();

                    Incident.ProductName = reader["ProductName"].ToString();

                    incidentList.Add(Incident);
                }

            }

            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return incidentList;
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null.");
            }
            
            if (this.Authenticate(incident) != -1 || this.Authenticate(incident) != -2)
            {
                throw new ArgumentException("Product not registered with customer.");
            }


            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "INSERT INTO " +
                "Incidents (CustomerID, ProductCode, Title, " +
                "Description, DateOpened) VALUES(@customerName," +
                "@productCode, @title, @description, CURRENT_TIMESTAMP)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
   
                command.Parameters.AddWithValue("@customerID", incident.CustomerID);
                command.Parameters["@customerID"].Value = incident.CustomerID;
                command.Parameters.AddWithValue("@productCode", incident.ProductCode);
                command.Parameters["@productCode"].Value = incident.ProductCode;
                command.Parameters.AddWithValue("@title", incident.Title);
                command.Parameters["@title"].Value = incident.Title;
                command.Parameters.AddWithValue("@description", incident.Description);
                command.Parameters["@description"].Value = incident.Description;
                connection.Open();
                command.ExecuteScalar();
                
            }

        }


        private int Authenticate(Incident incident)
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
