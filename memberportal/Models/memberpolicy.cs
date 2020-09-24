using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace memberportal.Models
{
    public class memberpolicy
    {
        public int memberid { get; set; }
        public string membername { get; set; }
        public int policyid { get; set; }
        //one member is assigned to only one policy
        public string subscriptiondate { get; set; }
        //it will not contain premium amount
        //hence it will not contain cap amount
        public int locationid { get; set; }
        public string locationname { get; set; }
        public int hospitalid { get; set; }
        public string hospitalname { get; set; }
        //topup is essential to check first validation
    }
}
