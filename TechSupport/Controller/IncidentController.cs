
using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{


    public class IncidentController
    {
        private IncidentDAL incidentSource;
        private IncidentDBDAL incidentDBSource;

        /// <summary>
        /// This controller class interacts with the Incident data source
        /// and performs all the operations on the Incident data source.
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
            this.incidentDBSource = new IncidentDBDAL();

        }

        /// <summary>
        /// Returns the incident list from the DAL to be displayed
        /// </summary>
        /// <returns></returns>

        public List<Incident> GetIncidentList()
        {
            return this.incidentSource.GetIncidentList();
        }

        /// <summary>
        /// Overloaded constructor. Returns incident list that only
        /// includes the customerId that was passed to the method.
        /// </summary>
        /// <param name="customerID">Customer's unique id.</param>
        /// <returns>List of data incidents that only are involved with the ID specified.</returns>
        public List<Incident> GetIncidentList(int customerID)
        {
            return this.incidentSource.GetIncidentList(customerID);
        }

        /// <summary>
        /// Adds an incident to the DAL list 
        /// </summary>
        /// <param name="incident">The incident to be added</param>
        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.incidentSource.Add(incident);
        }
        /// <summary>
        /// Returns the incident list from the DBDAL to be displayed
        /// </summary>
        /// <returns></returns>
        public List<Incident> GetOpenIncidents()
        {
            return incidentDBSource.GetOpenIncidents();
        }

        public void AddOpenIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            incidentDBSource.Add(incident);
        }
        public Dictionary<int, string> GetCustomers()
        {
            return incidentDBSource.GetCustomers();
        }

        public Dictionary<string, string> GetProducts()
        {
            return incidentDBSource.GetProducts();
        }
    }
}

