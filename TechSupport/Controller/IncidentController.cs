
using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    
    
    public  class IncidentController
    {
        private IncidentDAL incidentSource;

        /// <summary>
        /// This controller class interacts with the Incident data source
        /// and performs all the operations on the Incident data source.
        /// </summary>
        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

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
            List<Incident> searchList = new List<Incident>();
            List<Incident> incidentSourceList = this.incidentSource.GetIncidentList();

            foreach (Incident incident in incidentSourceList)
            {
              if (incident.CustomerID == customerID)
                {
                    searchList.Add(incident);
                }
            }
            return searchList;
        }


        public void Add(Incident incident)
        {
            if (incident == null)
            {
                throw new ArgumentNullException("Incident cannot be null");
            }

            this.incidentSource.Add(incident);
        }
    
       
        }
    }

