using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechSupport.Model
{
  /// <summary>
  /// Technician class that holds the Name, TechID, Email and Phone data from the technician database.
  /// </summary>
    class Technician
    {
        public string Name { get; set; }

        public int TechID { get; set; }

        public string Email { get; set; }

        public string Phone { get; set; }
    }
}
