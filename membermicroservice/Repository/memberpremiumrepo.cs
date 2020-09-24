using membermicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace membermicroservice.Repository
{
    public class memberpremiumrepo
    {
        public List<memberpremium> m = new List<memberpremium>()
        {
         new memberpremium()
         {
             memberid=1,
             topup=1000,
             premium=2000,
             paiddate=DateTime.Today
         },
         new memberpremium()
         {
             memberid=2,
             topup=1000,
             premium=2000,
             paiddate=DateTime.Today
         },

};
          public List<memberpremium> fun()
        {
            return m;
        }
    }
}
