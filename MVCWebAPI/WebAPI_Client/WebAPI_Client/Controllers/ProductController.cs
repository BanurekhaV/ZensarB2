using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;
using WebAPI_Client.Models;
using Newtonsoft.Json;

namespace WebAPI_Client.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        public ActionResult Index()
        {
            return View();
        }
        //client consuming web api services
        public ActionResult Display()
        {
            IEnumerable<MVCProductModel> prodlist = null;
            //create an httpclient object to access webapi
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44345/api/");
                var responsetask = webclient.GetAsync("employee");
                responsetask.Wait();
                var result = responsetask.Result;
                if (result.IsSuccessStatusCode)
                {
                    var readtask = result.Content.ReadAsStringAsync().Result;
                    // readtask.Wait();
                    prodlist = JsonConvert.DeserializeObject<List<MVCProductModel>>(readtask);
                }
                else
                {
                    prodlist = Enumerable.Empty<MVCProductModel>();
                    ModelState.AddModelError(string.Empty, "Some Error Occured.. Try later");
                }
                return View(prodlist);
            }
        }

        //to add a new record
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(MVCProductModel prod)
        {
            using (var webclient = new HttpClient())
            {
                webclient.BaseAddress = new Uri("https://localhost:44345/api/");
                var posttask = webclient.PostAsJsonAsync<MVCProductModel>("employee", prod);
                posttask.Wait();

                var result = posttask.Result;
                if (result.IsSuccessStatusCode)
                {
                    return RedirectToAction("Display");
                }
            }
            ModelState.AddModelError(string.Empty, "some error occured..");
            return View(prod);
        }
    }
}
