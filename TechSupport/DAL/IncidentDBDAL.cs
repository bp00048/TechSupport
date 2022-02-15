﻿
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class includes the DAL from the tech support database. It returns the open incidents.
    /// </summary>
    public static class IncidentDBDAL
    {

        /// <summary>
        /// Connects to the Tech Support database and uses a select statement to get the product code, date opened, customer name, technician name and title
        /// from the selected tables. It then returns a list of the designated incidents objects.
        /// </summary>
        /// <returns></returns>

        public static List<Incident> GetOpenIncidents()
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
              "ON Incidents.techID = Technicians.techID " +
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

        public static void Add(Incident incident)
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "INSERT INTO Incidents (CustomerID, ProductCode, Title, Description) VALUES(@customerName, @productCode, @title, @description)";
            SqlCommand command = new SqlCommand(query, connection);

            command.Parameters.AddWithValue("@customerID", incident.CustomerID);
            command.Parameters["@customerID"].Value = incident.CustomerID;
            command.Parameters.AddWithValue("@productCode", incident.ProductCode);
            command.Parameters["@productCode"].Value = incident.ProductCode;
            command.Parameters.AddWithValue("@title", incident.Title);
            command.Parameters["@title"].Value = incident.Title;
            command.Parameters.AddWithValue("@description", incident.Description);
            command.Parameters["@description"].Value = incident.Description;

            try
            {
                connection.Open();
                command.ExecuteNonQuery();
                Console.WriteLine("Records Inserted Successfully");
            }
            catch (SqlException e)
            {
                Console.WriteLine("Error Generated. Details: " + e.ToString());
            }
            finally
            {
                connection.Close();
            }


            public static int Authenticate(Incident incident)
        {
            SqlConnection connection = TechSupportDBConnection.GetConnection();
            string query = "SELECT COUNT(*) " +
                "FROM INCIDENTS " +
                "WHERE customerName = @customerName" +
                "AND productName = @productName";

            using (SqlCommand cmd = new SqlCommand(query, connection))
            {
                cmd.Parameters.AddWithValue("@customerName", incident.CustomerName);
                cmd.Parameters["@customerName"].Value = incident.CustomerName;
                cmd.Parameters.AddWithValue("@productName", incident.ProductName);
                cmd.Parameters["@productName"].Value = incident.ProductName;
                int count = Convert.ToInt32(cmd.ExecuteScalar());
                return count;
            }
        }
    } 

}  
