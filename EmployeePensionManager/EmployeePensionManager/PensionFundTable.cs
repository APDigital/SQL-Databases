using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePensionManager
{
   public class PensionFundTable
    {
        public int Id { get; set; }
        public int EmployeeID { get; set; }
        public int Contribution { get; set; }
        public int PensionProviderID { get; set; }
        public DateTime LastContributionDate { get; set; }
        public Employee Employee { get; set; }

     
    }
}
