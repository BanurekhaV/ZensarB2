using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day1MVC.Controllers
{
    public class DataController : Controller
    {
        // GET: Data
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult JobRules()
        {
            List<string> rules = new List<string>()
            {
                "Avoid T-Shirts", "Carry ID Card", "Be on Time","Work Committedly"
            };
            //1. using viewbag to transfer data to views from controller
            ViewBag.Getrules = rules as List<string>;

            //2. using ViewData to transfer data from controller to view
            ViewData["Followrules"] = rules as List<string>;
            return View();
        }

        public ActionResult JobRules2()
        {
            List<string> rules = new List<string>()
            {
                "Avoid T-Shirts", "Carry ID Card", "Be on Time","Work Committedly"
            };

            //2. using ViewData to transfer data from controller to view
            ViewData["Followrules"] = rules as List<string>;
            return View();
        }

        //3. To check if data can be transfered across requests
        public ActionResult Test_DataTransfer()
        {
            ViewBag.data1 = "Data1";
            ViewData["data2"] = "Data 2";
             return View(); // data1 and data2 data can be transferred to the view

           // return Redirect("Index");
        }
    }
}