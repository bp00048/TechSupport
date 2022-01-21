using System.Collections.Generic;
using TechSupport.Model;

namespace TechSupport.DAL
{
    public class IncidentDAL
    {

        private static List<Incident> _incidents = new List<Incident>
            {
             new Incident("Broken Wifi", "Wifi not connecting", 7640)
            };
    }
}
