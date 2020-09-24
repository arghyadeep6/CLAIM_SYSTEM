using policymicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Repository
{
    public class policyrepo
    {
        public static List<policy> m = new List<policy>()
        {
            new policy()
            {
                policyid=1,
                policyname="JEEVAN SATHI",
                hospitalid=1,
                premium=1000,
                tenure=1,
            },
            new policy()
            {
                policyid=2,
                policyname="YOJNA",
                hospitalid=3,
                premium=2000,
                tenure=2,
            },
            new policy()
            {
                policyid=3,
                policyname="INSURANCE",
                hospitalid=3,
                premium=3000,
                tenure=3,
            },
            new policy()
            {
                policyid=4,
                policyname="LIC",
                hospitalid=2,
                premium=4000,
                tenure=5,
            },
            new policy()
            {
                policyid=4,
                policyname="LIC",
                hospitalid=1,
                premium=4000,
                tenure=5,
            },
            new policy()
            {
                policyid=1,
                policyname="JEEVAN SATHI",
                hospitalid=2,
                premium=1000,
                tenure=1,
            }
        };
        public int givepolicy(int policyid)
        {
            foreach(var item in m)
            {
                if (item.policyid == policyid)
                    return item.premium;
            }
            return 0;//not all codepaths return a value
        }
    }
}
