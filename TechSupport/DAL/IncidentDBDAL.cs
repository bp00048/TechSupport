using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechSupport.Model;

namespace TechSupport.DAL
{
    class IncidentDBDAL
    {
    

    public static List<Incident> GetOpenIncidents()
    {
        List<Incident> incidentList = new List<Incident>();

        string selectStatement =
                "SELECT i.ProductCode, i.DateOpened, i.Name," +
                "t.Name, i.Title" +
                "FROM Incidents i" +
                "LEFT JOIN Technicians t" +
                "ON i.techID = t.techID" +
                "WHERE DateClosed = null" +
                "ORDER BY DateOpened";
        // the try-catch block is commented because the default behavior of exception handling is
        // exceptions are propagated to the caller of the method when exceptions are not caught in the method.
        //try
        //{
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
                        Incident.IncidentNumber = reader["IncidentNumber"].ToString();
                        Incident.IncidentDate = (DateTime)reader["IncidentDate"];
                        Incident.IncidentTotal = (decimal)reader["IncidentTotal"];
                        Incident.PaymentTotal = (decimal)reader["PaymentTotal"];
                        Incident.CreditTotal = (decimal)reader["CreditTotal"];
                        Incident.DueDate = (DateTime)reader["DueDate"];
                        IncidentList.Add(Incident);
                    }
                }
            }
        }


        // }
        //catch (SqlException ex)
        //{
        //exceptions are thrown to the controller, then to the view
        //Please make sure that do not use MessageBox.Show(ex.Message) in the DAL
        //because it couples the DAL with the view

        //throw is used instead of throw ex because the former preserves the stack trace
        //    throw ;
        //}
        //catch (Exception ex)
        //{
        //    throw ;
        //}

        return IncidentList;
    }
    /// <summary>
    /// This method uses try/catch/finally and placed closing of the resources (connection, reader) in the 
    /// finally block.
    /// 
    /// </summary>
    /// <returns>a list of Incidents</returns>
    public List<Incident> GetIncidentsDue2()
    {
        List<Incident> IncidentList = new List<Incident>();
        SqlConnection connection = TechSupportDBConnection.GetConnection();
        string selectStatement =
            "SELECT IncidentNumber, IncidentDate, IncidentTotal, " +
            "PaymentTotal, CreditTotal, DueDate " +
            "FROM Incidents " +
            "WHERE IncidentTotal - PaymentTotal - CreditTotal > 0 " +
            "ORDER BY DueDate";
        SqlCommand selectCommand = new SqlCommand(selectStatement, connection);
        SqlDataReader reader = null;

        try
        {
            connection.Open();
            reader = selectCommand.ExecuteReader();

            while (reader.Read())
            {
                Incident Incident = new Incident();
                Incident.IncidentNumber = reader["IncidentNumber"].ToString();
                Incident.IncidentDate = (DateTime)reader["IncidentDate"];
                Incident.IncidentTotal = (decimal)reader["IncidentTotal"];
                Incident.PaymentTotal = (decimal)reader["PaymentTotal"];
                Incident.CreditTotal = (decimal)reader["CreditTotal"];
                Incident.DueDate = (DateTime)reader["DueDate"];
                IncidentList.Add(Incident);
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
        return IncidentList;
    }


}
}
