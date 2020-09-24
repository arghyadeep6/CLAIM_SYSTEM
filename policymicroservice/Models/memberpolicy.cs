using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Models
{
    public class memberpolicy
    {
        public int policyid { get; set; }
        public int memberid { get; set; }
        //one member is assigned to only one policy
        public string membername { get; set; }
        public string subscriptiondate { get; set; }
        //it will not contain premium amount
        //hence it will not contain cap amount
        public int locationid { get; set; }
        public string locationname { get; set; }
        public int hospitalid { get; set; }
        public string hospitalname { get; set; }
        public int topup { get; set; }//make it topup frequency
        //topup is essential to check first validation
        //hospital.cs not required

    }
}
