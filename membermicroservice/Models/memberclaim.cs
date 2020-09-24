using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class memberclaim
    {
        public int memberid { get; set; }
        public int claimid { get; set; }
        public int billedamount { get; set; }
        public int claimedamount { get; set; }
        public int benefitid { get; set; }
        public string claimstatus { get; set; }

    }
}
