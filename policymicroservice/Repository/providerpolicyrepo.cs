using policymicroservice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace policymicroservice.Repository
{
    public class providerpolicyrepo
    {
        public static List<providerpolicy> m = new List<providerpolicy>()
       {
           new providerpolicy()//1
           {
            hospitalid=1,//
            hospitalname="AMRI",
            locationid=1,//
            locationname="ULTADANGA",
            ambulancecharges=1000,//
            operationcharges=7000,//
            medicalcharges=13000,//
            stayingcharges=19000//
           },
           new providerpolicy()//2
           {
            hospitalid=1,
            hospitalname="AMRI",
            locationid=2,
            locationname="PARK STREET",
            ambulancecharges=2000,
            operationcharges=8000,
            medicalcharges=14000,
            stayingcharges=20000
           },
           new providerpolicy()//3
           {
            hospitalid=1,
            hospitalname="AMRI",
            locationid=3,
            locationname="SEALDAH",
            ambulancecharges=3000,
            operationcharges=9000,
            medicalcharges=15000,
            stayingcharges=21000
           },
           new providerpolicy()//4
           {
            hospitalid=2,
            hospitalname="CMRI",
            locationid=1,
            locationname="ULTADANGA",
            ambulancecharges=4000,
            operationcharges=10000,
            medicalcharges=16000,
            stayingcharges=22000
           },
           new providerpolicy()//5
           {
            hospitalid=2,
            hospitalname="CMRI",
            locationid=2,
            locationname="PARK STREET",
            ambulancecharges=5000,
            operationcharges=11000,
            medicalcharges=17000,
            stayingcharges=23000
           },
           new providerpolicy()//6
           {
            hospitalid=2,
            hospitalname="CMRI",
            locationid=3,
            locationname="SEALDAH",
            ambulancecharges=6000,
            operationcharges=12000,
            medicalcharges=18000,
            stayingcharges=24000
           },
           new providerpolicy()//7
           {
            hospitalid=3,
            hospitalname="NRS",
            locationid=1,
            locationname="ULTADANGA",
            ambulancecharges=100,
            operationcharges=200,
            medicalcharges=300,
            stayingcharges=400
           }
       };
        public List<int> getbenefits(List<int> a)
        {
            List<int> b = new List<int>();//4 
            foreach(var item in m)
            {
                if(item.hospitalid==a[0] && item.locationid==a[1])
                {
                    b.Add(item.ambulancecharges);
                    b.Add(item.operationcharges);
                    b.Add(item.medicalcharges);
                    b.Add(item.stayingcharges);
                }
            }
            return b;
        }
    }
}
