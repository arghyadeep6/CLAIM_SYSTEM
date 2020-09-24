using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public class memberpolicyrepo
    {
        public static List<memberpolicy> m = new List<memberpolicy>()
        {
            new memberpolicy()
            {
              policyid=1,
              memberid=1,
              membername="AMIT",
              subscriptiondate="XXX",
              locationid=1,
              locationname="ULTADANGA",
              hospitalid=2,
              hospitalname="CMRI"
            },
            new memberpolicy()
            {
              policyid=1,
              memberid=2,
              membername="RAM",
              subscriptiondate="XXX",
              locationid=1,
              locationname="ULTADANGA",
              hospitalid=3,
              hospitalname="NRS"
            },
            new memberpolicy()
            {
              policyid=2,
              memberid=3,
              membername="SUBHAM",
              subscriptiondate="XXX",
              locationid=2,
              locationname="PARK STREET",
              hospitalid=3,
              hospitalname="NRS"
            },
            new memberpolicy()
            {
              policyid=1,
              memberid=4,
              membername="ARGHYA",
              subscriptiondate="XXX",
              locationid=3,
              locationname="SEALDAH",
              hospitalid=1,
              hospitalname="AMRI"
            },
            new memberpolicy()
            {
              policyid=2,
              memberid=5,//given
              membername="SUJOY",
              subscriptiondate="XXX",
              locationid=2,//
              locationname="PARK STREET",
              hospitalid=1,//
              hospitalname="AMRI"
            }
        };
    }
}
