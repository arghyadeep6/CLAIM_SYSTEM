using claimmicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace claimmicroservice.Repository
{
    public class memberclaimrepo
    {
        //do we need to make the list static
        public static List<memberclaim> m = new List<memberclaim>()
        {
            new memberclaim()
            {
                memberid=1,
                claimid=2,
                billedamount=1200,
                claimedamount=1000,
                claimstatus="Pending",
                benefitid=1
            }
        };
        
        public void create(memberclaim ob)
        {
            Random rand = new Random();
            ob.claimid = rand.Next(15000,18000);
            ob.claimstatus = "PENDING";
            m.Add(ob);
        }
        public memberclaim fetchclaimsformember(int id)
        {
           memberclaim l = new memberclaim();
            foreach(var item in m)//fetch all the claims for a particular memberid
            {
                if(item.memberid==id)
                {
                    l=item;
                }
            }
            return l;
        }
        public List<memberclaim> give()
        {
            
            return m;
        }
        public memberclaim getclaim(int id)//it returns an object of class type
        {
            memberclaim y = new memberclaim();
            foreach (var item in m)//fetch a single claim for a particular claimid
            {
                if (item.claimid == id)
                {
                    y = item;//eivabe ki direct kora jai na ei vabe kora jai eta to just ekta assign
                    //y.claimstatus = item.status;
                    break;
                }
            }
            return y;
        }
    }
}
