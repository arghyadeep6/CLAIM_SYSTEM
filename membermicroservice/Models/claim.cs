using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Models
{
    public class claim
    {
        public int claimid { get; set; }
        public int billedamount { get; set; }
        public int claimedamount { get; set; }
        public string claimstatus { get; set; }
    }
}
