using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    /// <summary>
    /// This class includes the DAL of Incident objects. It adds to and returns the list.
    /// </summary>
    public class IncidentDAL
    {

        private static List<Incident> _incidents = new List<Incident>
            {
             new Incident("Broken Wifi", "Wifi not connecting", 7640),
             new Incident("New Headphones", "left headphone not working", 7640),
             new Incident("Wifi", "Wifi turned of", 7088),
             new Incident("Computer not turning on", "Sending from phone...", 7640),
             new Incident("Mouse", "Not detecting mouse bluetooth", 7640)
            };
        /// <summary>
        /// Returns the list of incidents
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetIncidentList()
        {
            return _incidents;
        }

        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            _incidents.Add(incident);
        
        }
        /// <summary>
        /// Returns a list of incidents that include only the customerID passed through the method
        /// </summary>
        /// <param name="customerID">The customer searched for</param>
        /// <returns></returns>
        public List<Incident> GetIncidentList(int customerID)
        {
            List<Incident> searchList = new List<Incident>();

            searchList = _incidents.FindAll(s => s.CustomerID.Equals(customerID));
           
            return searchList;
        }
    }
}
