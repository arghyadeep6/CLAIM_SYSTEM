using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using claimmicroservice.Models;
using claimmicroservice.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace claimmicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class claimController : ControllerBase
    {
        /// <summary>
        ///  GET: api/<claimController>
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IEnumerable<memberclaim> Get()//View Bills je by dafault index e or asbe
        {
            memberclaimrepo ob = new memberclaimrepo();
            return ob.give();
        }
        // GET api/<claimController>/5
        [HttpGet("{id}")]
        public memberclaim Get(int id)
        {
            memberclaimrepo ob = new memberclaimrepo();
           memberclaim ob1 = new memberclaim();
            ob1=ob.fetchclaimsformember(id);
            return ob1;
        }

        // POST api/<claimController>
        [HttpPost]
        public string Post([FromBody] memberclaim obj)
        {
            memberclaimrepo ob = new memberclaimrepo();
            ob.create(obj);
            return "SUCCESSFULLY ADDED";
        }
        Uri baseAddress = new Uri("https://localhost:44367/api");   //Port No.
        HttpClient client;
        // PUT api/<claimController>/5
        public claimController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }
        [HttpPut("{id}")]
        public memberclaim Put(int id, [FromBody] memberclaim obj)//edit korle j er ekta page e nie chole jai ota thakbe na
        {
            string s1 = obj.claimstatus;
            List<int> ls = new List<int>();
            int p = 0;
            int op = 0;

            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/policy/1/2").Result;//[100,200,300,400]]
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<List<int>>(data);
            }
            HttpResponseMessage response1 = client.GetAsync(client.BaseAddress + "/policy/" + id).Result;//used to fetch the policyid of that particular memberid
            if (response1.IsSuccessStatusCode)
            {
                string data = response1.Content.ReadAsStringAsync().Result;
                op = Convert.ToInt32(data);               //it is giving corrcet result #policyid
                p = JsonConvert.DeserializeObject<int>(data);//it is becoming 0 i don't know
            }
            int d = obj.benefitid;
            HttpResponseMessage response2 = client.GetAsync(client.BaseAddress + "/policy/" + op + "/" + id + "/" + d).Result;
            int o = 0;
            if (response2.IsSuccessStatusCode)
            {
                string data = response2.Content.ReadAsStringAsync().Result;
                o = Convert.ToInt32(data);               //it is giving corrcet result #policyid
                                                         // p = JsonConvert.DeserializeObject<int>(data);//it is becoming 0 i don't know
            }
            if (obj.claimedamount > obj.billedamount)//if the bill is very less
            {
                //  return "Rejected";
                obj.claimstatus = "REJECTED";
            }
            if (obj.claimedamount > o)//it checks for all the benefit ids also for benefitid even when no benefit id is selected
            {
                obj.claimstatus = "REJECTED";
            }

            memberclaimrepo x = new memberclaimrepo();
            foreach(var item in memberclaimrepo.m)
            {
                if (item.claimid == obj.claimid)
                    item.claimstatus = obj.claimstatus;
            }
           return obj;
        }   
    }
}
