
using System;
using System.Collections.Generic;
using System.Windows.Forms;
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
            if (customerID < 0)
            {
                throw new Exception("customerID must be number");
            }
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

        /// <summary>
        /// Returns the customer id and name from the database.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetCustomers()
        {
            return incidentDBSource.GetCustomers();
        }
        /// <summary>
        /// Returns the product code and name from the database.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetProducts()
        {
            return incidentDBSource.GetProducts();
        }

        public Incident getIncident(int incidentID)
        {
           
            return incidentDBSource.getIncident(incidentID);
        }

        public bool checkIncident(int incidentID)
        {

            return (incidentDBSource.checkIncidentRegistration(incidentID) > 0);

        }

        public Dictionary<int, string> GetTechnicians()
        {
            return incidentDBSource.GetTechnicians();
        }
    }
}

