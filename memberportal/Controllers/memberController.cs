using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using memberportal.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;//
//integrating membermicroservice with memberportal
namespace memberportal.Controllers
{
    //we do not need repo for memberclaim
    //we do not need repo for memberpolicy as we are not displaying it anywhere
    //here membermvc contacts with only memberController
    //but another way would be it can contact with claim controller as well
    //no need to setup startup projects in properties
    public class memberController : Controller
    {
        Uri baseaddress = new Uri("https://localhost:44370/api");
        HttpClient client;
        public memberController()
        {
            client = new HttpClient();
            client.BaseAddress = baseaddress;
        }
        public IActionResult Index()
        {
            List<memberclaim> ls = new List<memberclaim>();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/member").Result;
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<List<memberclaim>>(data);
            }
            return View(ls);
            
        }
        public IActionResult Submit_Claim()
        {
            return View();
        }
        //remove claim id from Submit_Claim.cshtml
        [HttpPost]
        public IActionResult Submit_Claim(memberclaim obj)
        {
           
            string data = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PostAsync(client.BaseAddress + "/member", content).Result;
            if (response.IsSuccessStatusCode)
            {
                //return View("Index");
               return RedirectToAction("Index");
            }
            return View();
        }
        public IActionResult Edit(int id)
        {
            memberclaim ls = new memberclaim();
            HttpResponseMessage response = client.GetAsync(client.BaseAddress + "/member/" + id).Result;
            //if a user has multiple claims then it will return multiple rows for the same memberid in this case it is id
            if (response.IsSuccessStatusCode)
            {
                string data = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<memberclaim>(data);
            }
            return View(ls);
        }
        [HttpPost]
        public IActionResult Edit(memberclaim obj)
        {
            memberclaim ls = new memberclaim();
            string data = JsonConvert.SerializeObject(obj);
            StringContent content = new StringContent(data, Encoding.UTF8, "application/json");
            HttpResponseMessage response = client.PutAsync(client.BaseAddress + "/member/" + obj.memberid, content).Result;
            if (response.IsSuccessStatusCode)
            {
                string data1 = response.Content.ReadAsStringAsync().Result;
                ls = JsonConvert.DeserializeObject<memberclaim>(data);
                return View("claimstatus",ls);
            }
            return View();
        }
        [HttpPost]
        public IActionResult claimstatus(memberclaim obj)
        {
            return View();
        }
    }
}
