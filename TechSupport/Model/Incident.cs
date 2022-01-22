using System;
namespace TechSupport.Model
{
    /// <summary>
    /// This class contains the title, description and customerID associated with a
    /// reported incident.
    /// </summary>
    public class Incident
    {

        public string Title { get; }

        public string Description { get; }

        public int CustomerID { get; }
       
        public Incident(string title, string description, int customerID)
        {
            if (string.IsNullOrEmpty(title))
            {
                throw new ArgumentException("Incident title cannot be null or empty", "title");
            }
        
            if (string.IsNullOrEmpty(description))
            {
                throw new ArgumentException("Incident description cannot be null or empty", "description");
            }
            
            if (customerID < 0) 
            {
                throw new ArgumentOutOfRangeException("customerID", "Customer ID needs to be higher than 0");
            }

            this.Title = title;
            this.Description = description;
            this.CustomerID = customerID;
        }

    }
}
