using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Models
{
    public class policy
    {
        public int policyid { get; set; }
        public string policyname { get; set; }
        public int hospitalid {get;set;}
        public int premium { get; set; }
        public int tenure { get; set; }
        //policy will not contain benefit details

    }
}
