using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class memberpremium
    {
        public int memberid { get; set; }
        public int topup { get; set; }
        public int premium { get; set; }
        public DateTime paiddate { get; set; }
    }
}
