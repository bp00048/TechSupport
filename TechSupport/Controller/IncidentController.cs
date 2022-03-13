
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
        private CustomersDAL customerSource;
        private RegistrationDAL registrationSource;
        private TechniciansDAL technicianSource;
        private ProductsDAL productSource;
        private Incident gotIncident;

        /// <summary>
        /// This controller class interacts with the Incident data source
        /// and performs all the operations on the Incident data source.
        /// </summary>
        public IncidentController()
        {
            this.productSource = new ProductsDAL();
            this.technicianSource = new TechniciansDAL();
            this.customerSource = new CustomersDAL();
            this.registrationSource = new RegistrationDAL();
            this.incidentSource = new IncidentDAL();
            this.incidentDBSource = new IncidentDBDAL();

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
        public List<Incident> GetIncidents()
        {
            return incidentDBSource.GetIncidents();
        }

        /// <summary>
        /// Returns a list of incidents given a specific techID.
        /// </summary>
        /// <param name="techID"></param>
        /// <returns></returns>
        public List<Incident> GetAllIncidentsByTechnician(int techID)
        {
            if (techID < 0)
            {
                throw new ArgumentNullException("TechID is invalid.");
            }

            return this.incidentDBSource.GetAllIncidentsByTechnician(techID);
        }

        /// <summary>
        /// Adds an incident to the database.
        /// </summary>
        /// <param name="incident"></param>
        public void AddIncident(Incident incident)
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
            return customerSource.GetCustomers();
        }
        /// <summary>
        /// Returns the product code and name from the database.
        /// </summary>
        /// <returns></returns>
        public Dictionary<string, string> GetProducts()
        {
            return productSource.GetProducts();
        }

        /// <summary>
        /// Returns the incident based on the incident id passed from the database.
        /// </summary>
        /// <param name="incidentID">the ID of the incident being fetched</param>
        /// <returns></returns>

        public Incident GetIncident(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.gotIncident = incidentDBSource.GetIncident(incident);
            return this.gotIncident;
        }
        /// <summary>
        /// Makes sure the Incident being updated/closed is open.
        /// </summary>
        /// <param name="incidentID">Id of the incident being compared</param>
        /// <returns></returns>
        public bool CheckIncidentStatus(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            return (incidentDBSource.CheckIncidentStatus(incident) > 0);

        }
        /// <summary>
        /// uses CheckIncidentStatus to ensure the incident has not already been closed. Uses CheckChanges to make sure the incident
        /// has not been updated since it has been gotten.
        /// </summary>
        /// <param name="incident">The incident being compared</param>
        private void Validate(Incident incident)
            { 
                 if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            if (!CheckIncidentStatus(incident))
            {
                throw new Exception("Incident has already been closed. Please reload incident.");
            }
           
        }
        /// <summary>
        /// Validates that the incident can be updated and sends the incident to be updated in the database.
        /// </summary>
        /// <param name="incident">The incident being updated.</param>
        public void UpdateIncident(Incident newIncident, Incident oldIncident)
        {
            if (newIncident == null || oldIncident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }
            this.Validate(oldIncident);
            incidentDBSource.UpdateIncident(newIncident, oldIncident);
        }

        /// <summary>
        /// Gets a Dictionary list of current technicians with their names and IDs.
        /// </summary>
        /// <returns></returns>
        public Dictionary<int, string> GetTechnicians()
        {
            return technicianSource.GetTechnicians();
        }

        /// <summary>
        /// Validates that the incident can be closed and sends the incident to be updated (closed) in the database.
        /// </summary>
        /// <param name="incident">The incident being closed</param>
        public void CloseIncident(Incident newIncident, Incident oldIncident)
        {
            if (newIncident == null || oldIncident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.Validate(oldIncident);
            incidentDBSource.CloseIncident(newIncident, oldIncident);
        }
        /// <summary>
        /// Makes sure the incident being added is registered to the customer it is being added with.
        /// </summary>
        /// <param name="incident">The incident being added</param>
        /// <returns></returns>
        public bool IsRegistered(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            return (registrationSource.IsRegistered(incident) > 0);
        }

      
    }
}

