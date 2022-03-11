
using System.Collections.Generic;

using TechSupport.Model;
using TechSupport.DAL;


namespace TechSupport.Controller
{
    class TechnicianController
    {

        public TechnicianController() { }
    
        public List<Technician> GetAllTechnicians()
        {
            return TechniciansDAL.GetAllTechnicians();
        }

    }

}
