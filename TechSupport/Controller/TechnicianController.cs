
using System.Collections.Generic;

using TechSupport.Model;
using TechSupport.DAL;

/// <summary>
/// This is the controller class between tech Technician class and the TechnicianDAL.
/// </summary>

namespace TechSupport.Controller
{
    class TechnicianController
    {

        public TechnicianController() { }
    
        /// <summary>
        /// Calls on the TechnicianDAL's GetAllTechnicians method to return a list of technicians with incidents.
        /// </summary>
        /// <returns></returns>
        public List<Technician> GetAllTechnicians()
        {
            return TechniciansDAL.GetAllTechnicians();
        }

    }

}
