using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace memberportal.Models
{
    public class memberpremium
    {
        public int memberid { get; set; }
        public int topup { get; set; } //topup is essential to check first validation
        public int premium { get; set; }
        public DateTime paiddate { get; set; }
    }
}
