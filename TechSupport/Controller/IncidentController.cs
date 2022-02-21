
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
        private Incident gotIncident;

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

        /// <summary>
        /// Returns the incident based on the incident id passed from the database.
        /// </summary>
        /// <param name="incidentID">the ID of the incident being fetched</param>
        /// <returns></returns>

        public Incident GetIncident(int incidentID)
        {
            this.gotIncident = incidentDBSource.GetIncident(incidentID);
            return this.gotIncident;
        }
        /// <summary>
        /// Makes sure the Incident being updated/closed is open.
        /// </summary>
        /// <param name="incidentID">Id of the incident being compared</param>
        /// <returns></returns>
        public bool CheckIncidentStatus(int incidentID)
        {
            return (incidentDBSource.CheckIncidentStatus(incidentID) > 0);

        }
        /// <summary>
        /// uses CheckIncidentStatus to ensure the incident has not already been closed. Uses CheckChanges to make sure the incident
        /// has not been updated since it has been gotten.
        /// </summary>
        /// <param name="incident">The incident being compared</param>
        private void Validate(Incident incident)
        {
            if (!CheckIncidentStatus(incident.IncidentID))
            {
                throw new Exception("Incident has already been closed. Please reload incident.");
            }
            if (incidentDBSource.CheckChanges(incident) > 0)
            {
                throw new Exception("Incident has already been updated. Please reload incident.");
            }
        }
        /// <summary>
        /// Validates that the incident can be updated and sends the incident to be updated in the database.
        /// </summary>
        /// <param name="incident">The incident being updated.</param>
        public void UpdateIncident(Incident incident)
        {
            this.Validate(incident);
            incidentDBSource.UpdateIncident(incident);
        }

        /// <summary>
        /// Gets a Dictionary list of current technicians with their names and IDs.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetTechnicians()
        {
            return incidentDBSource.GetTechnicians();
        }

        /// <summary>
        /// Validates that the incident can be closed and sends the incident to be updated (closed) in the database.
        /// </summary>
        /// <param name="incident">The incident being closed</param>
        public void CloseIncident(Incident incident)
        {
            this.Validate(incident);
            incidentDBSource.CloseIncident(incident);
        }
        /// <summary>
        /// Makes sure the incident being added is registered to the customer it is being added with.
        /// </summary>
        /// <param name="incident">The incident being added</param>
        /// <returns></returns>
        public bool IsRegistered(Incident incident)
        {
            return (incidentDBSource.IsRegistered(incident) > 0);
        }
    }
}

