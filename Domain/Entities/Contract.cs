using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contract
    {
        public int ContractID { get; set; }
        [ForeignKey(nameof(CompanyID))]
        public Company Company { get; set; }
        [ForeignKey(nameof(UserID))]
        public User User { get; set; }
        [ForeignKey(nameof(ContractTypeID))]
        public ContractType ContractType { get; set; }
        public bool Active { get; set; }
        public DateTime Start { get; set; }
        public DateTime? End { get; set; }
        public int CompanyID { get; set; }
        public int UserID { get; set; }
        public int ContractTypeID { get; set; }


    }
}
