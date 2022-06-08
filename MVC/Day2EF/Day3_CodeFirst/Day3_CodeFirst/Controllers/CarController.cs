using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3_CodeFirst.Models;

namespace Day3_CodeFirst.Controllers
{
    public class CarController : Controller
    {
        CarContext cc = new CarContext();
        // GET: Car
        public ActionResult Index()
        {

            return View(cc.Cars.ToList());
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Car c)
        {
            cc.Cars.Add(c);
            cc.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}