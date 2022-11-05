using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Contract
    {
        public int ID { get; set; }
        public Company Company { get; set; }
        public User User { get; set; }
        public ContractType ContractType { get; set; }
        public bool Active { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
