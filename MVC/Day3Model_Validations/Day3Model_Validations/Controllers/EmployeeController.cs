using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day3Model_Validations.Models;

namespace Day3Model_Validations.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { EmpId = 1,
                EmpFName = "First",
                EmpLName = "Last",
                DOB = Convert.ToDateTime("06/06/2000"),
                UserName = "Fl",
                Password = "fl@1234"
            });
            emplist.Add(new Employee
            {
                EmpId = 2,
                EmpFName = "Begin",
                EmpLName = "End",
                DOB = Convert.ToDateTime("10/05/1998"),
                UserName = "Be",
                Password = "be@1234"
            });
            return View(emplist);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Create(Employee emp)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    return RedirectToAction("Index");
                }
                return View();
            }
            catch
            {
                return View();
            }
        }
    }
}