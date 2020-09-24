using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace memberportal.Models
{
    public class memberclaim
    {
        //the corresponding controller and mvc must have the same controller name and model class
        //the hospital id dropdown is made using memberpolicyrepo as it has hospitalid
        public int memberid { get; set; }
        public int claimid { get; set; }
        public int billedamount { get; set; }
        public int claimedamount { get; set; }
        public int benefitid { get; set; }
        public string claimstatus { get; set; }
    }
}
