using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Company
    {
        public int CompanyID { get; set; }
        public string Name { get; set; }
        public ICollection<Contract> Contracts { get; set; }
        public ICollection<Project> Projects { get; set; }

    }
}
