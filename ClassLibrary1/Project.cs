using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Project
    {
        public int ID { get; set; }
        public Company Company { get; set; }
        public User ProjectLead { get; set; }
        public IEnumerable<Domain.Task> Tasks { get; set; }
        
    }
}
