using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2.Models;

namespace Day2.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            Employee e = new Employee() { ID = 1, Name = "Sandy", DOJ = DateTime.Now, Email = "sandy@gmail.com" };

            return View(e);
        }
        [ActionName("Data")]
        public ActionResult Sample()
        {
            //  return View("Sample");
            return View();
        }
    }
}