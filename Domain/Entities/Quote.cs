using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Quote
    {
        public int QuoteID { get; set; }
        public string Description { get; set; }
        [ForeignKey(nameof(ContractID))]
        public Contract Creator { get; set; }
        public int ContractID { get; set; }
    }
}
