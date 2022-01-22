﻿using System;
using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
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
    }
}
