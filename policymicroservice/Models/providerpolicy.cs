using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Models
{
    public class providerpolicy
    {
        //hospital id and locationid is the composite primary key
        public int hospitalid { get; set; }
        public string hospitalname { get; set; }
        public int locationid { get; set; }
        public string locationname { get; set; }
        //Benefits Availed
        //public int None { get; set; }
        //This none field will be manually created and added to the list
        public int ambulancecharges { get; set; }
        public int operationcharges { get; set; }
        public int medicalcharges { get; set; }
        public int stayingcharges { get; set; }


    }
}
