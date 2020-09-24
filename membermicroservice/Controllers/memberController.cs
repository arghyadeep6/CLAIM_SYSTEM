using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using membermicroservice.Models;
using membermicroservice.Repository;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace membermicroservice.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class memberController : ControllerBase
    {
        Uri baseAddress = new Uri("https://localhost:44399/api"); //claim  
        HttpClient client;
        public memberController()
        {
            client = new HttpClient();
            client.BaseAddress = baseAddress;

        }
        [HttpGet]
        public List<memberclaim> Get()
        {
            List<memberclaim> ls = new List<memberclaim>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/claim").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<List<memberclaim>>(data);
            }
            return ls;
        }
        [HttpGet("{id}")]
        public memberclaim Get(int id)//for displaying the claims in the index page
        {
            memberclaim ls = new memberclaim();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/claim/"+id).Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<memberclaim>(data);
            }
            return ls;
        }
        // POST api/<memberController>
        [HttpPost]
        public string Post([FromBody] memberclaim obj)//for submitting claims
        {
            string data = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/claim", content).Result;
            if (response.IsSuccessStatusCode)
            {
                return "success";

            }
            return "failed";
        }

        // PUT api/<memberController>/5
        [HttpPut("{id}")]
        public memberclaim Put(int id, [FromBody] memberclaim obj)//for viewing claim status
        {
            memberclaim ob = new memberclaim();
            string data = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/claim/" + id, content).Result;
            if(response.IsSuccessStatusCode)
            {

                string data1 = response.Content.ReadAsStringAsync().Result;
                ob = JsonConvert.DeserializeObject<memberclaim>(data);
               
            }
            return ob;
        }

        // DELETE api/<memberController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
