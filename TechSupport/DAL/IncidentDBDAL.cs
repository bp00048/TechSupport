
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public static class IncidentDBDAL
    {


        public static List<Incident> GetOpenIncidents()
        {
            List<Incident> incidentList = new List<Incident>();
            SqlConnection connection = TechSupportDBConnection.GetConnection();

            string selectStatement =
              "SELECT ProductCode, DateOpened, " +
              "Customers.Name as customerName, Technicians.Name as techniciansName, Title " +
              "FROM Incidents " +
              "JOIN Customers " +
              "ON Customers.CustomerID=Incidents.CustomerID " +
              "LEFT JOIN Technicians " +
              "ON Incidents.techID = Technicians.techID " +
              "WHERE DateClosed IS NULL " +
              "ORDER BY DateOpened DESC ";
             
            //  "ORDER BY DateOpened ";
            SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
            SqlDataReader reader = null;

            // the try-catch block is commented because the default behavior of exception handling is
            // exceptions are propagated to the caller of the method when exceptions are not caught in the method.
            //try
            //{

            try
            {
                connection.Open();
                reader = selectCommand.ExecuteReader();
              

                while (reader.Read())
                {
                    Incident Incident = new Incident();

                    Incident.ProductCode = reader["ProductCode"].ToString();
                    Incident.DateOpened = (DateTime)reader["DateOpened"];
                    Incident.CustomerName = reader["customerName"].ToString();
                    Incident.TechnicianName = reader["techniciansName"].ToString();
                    Incident.Title = reader["Title"].ToString();

                    incidentList.Add(Incident);
                }

            }
            //catch (SqlException ex)
            //{
            //    throw;
            //}
            //catch (Exception ex)
            //{
            //    throw;
            //}
            finally
            {
                if (connection != null)
                    connection.Close();
                if (reader != null)
                    reader.Close();
            }
            return incidentList;
        }
    } 
}  
