using policymicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Repository
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
        public List<int> gethosloc(int memberid)
        {
            memberpolicy ob = new memberpolicy();
            ob = m.Where(p => p.memberid == memberid).FirstOrDefault();//row
            int x = ob.hospitalid;
            int y = ob.locationid;
            List<int> n = new List<int>();
            n.Add(x);
            n.Add(y);
            return n;
        }
        public List<memberpolicy> fun()
        {
            return m;
        }
        public int receivepolicyid(int memberid)
        {
            int x;//we need to assign a value to x if x does not get value in forloop it will be nullable int ?x
            foreach (var item in m)
            {
                if (item.memberid == memberid)
                {
                    x = item.policyid;
                    return x;
                }
            }
            return 0;
        }
    }
}
