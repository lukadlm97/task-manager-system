using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Project
    {
        public int ProjectID { get; set; }
        [ForeignKey(nameof(CompanyID))]
        public Company Company { get; set; }
        [ForeignKey(nameof(ProjectLeadID))]
        public User ProjectLead { get; set; }
        public ICollection<Task> Tasks { get; set; }

        public int CompanyID { get; set; }
        public int ProjectLeadID { get; set; }
    }
}
