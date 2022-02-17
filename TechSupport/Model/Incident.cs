using System;
namespace TechSupport.Model
{
    /// <summary>
    /// This class contains the title, description and customerID associated with a
    /// reported incident.
    /// </summary>
    public class Incident
    {

        public string Title { get; set; }

        public string Description { get; set; }

        public int CustomerID { get; set; }

        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public DateTime DateOpened { get; set; }
        public string CustomerName { get; set; }
        public string TechnicianName { get; set; }
        public string IncidentID { get; set; }



        /// <summary>
        /// Overloaded constructor. Assigns the title, description and customer Id assuming it follows the correct critera (cannot be null/empty and customer
        /// id must be a number). If it doesnt, an error is thrown.
        /// </summary>
        /// <param name="title">Title of incident</param>
        /// <param name="description">Description of incident</param>
        /// <param name="customerID">Customer ID associated with the incident</param>
        public Incident(string title, string description, int customerID)
        {

            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title cannot be null or empty");
            }
        
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description cannot be null or empty");
            }
            
            if (customerID < 0) 
            {
                throw new ArgumentOutOfRangeException("customerID", "Customer ID needs to be higher than 0");
            }
           
           

          
            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }
        /// <summary>
        /// Empty constructor
        /// </summary>
        public Incident()
        {
        }


    }
}
