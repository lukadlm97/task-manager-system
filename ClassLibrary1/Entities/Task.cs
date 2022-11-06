using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        [ForeignKey(nameof(ProjectID))]
        public Project Project { get; set; }
        [ForeignKey(nameof(StatusID))]
        public Status Status { get; set; }
        [ForeignKey(nameof(CreatorID))]
        public Contract Creator { get; set; }
        public ICollection<Contract> Workers { get; set; }
        public ICollection<Quote> Quotes { get; set; }
        public int ProjectID { get; set; }
        public int StatusID { get; set; }
        public int CreatorID { get; set; }

    }
}
