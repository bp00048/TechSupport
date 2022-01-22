
using System;
using System.Collections.Generic;
using TechSupport.DAL;
using TechSupport.Model;

namespace TechSupport.Controller
{
    
    
    public  class IncidentController
    {
        private IncidentDAL incidentSource;

        public IncidentController()
        {
            this.incidentSource = new IncidentDAL();
        }

        public List<Incident> GetIncidentList()
        {
            return this.incidentSource.GetIncidentList();
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
