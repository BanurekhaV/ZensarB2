using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1MVC.Models;

namespace Day1MVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }

        //action method 1.
        public string NormalMethod()
        {
            return "Hello All!!..";
        }

        //action method 2

        public ContentResult Contents()
        {
            // return Content("Good Morning to all of you..");
            return Content("<h1>Good Morning to all of you..</h1>");
        }

        //action method 3
        [NonAction]
        public EmptyResult Noresult()
        {
            int amt = 45000;
            float SI = (amt * 3 * 2) / 100;
            return new EmptyResult();
        }

        //action method 4
        public JsonResult EmployeeData()
        {
            Employee e = new Employee();
            e.ID = 100;
            e.Name = "Anil Kumar";
            e.Age = 35;
            return Json(e, JsonRequestBehavior.AllowGet);
        }

        //action method with redirectresult
        //here we are redirecting to an action method of the same controller

        public RedirectResult RedirectMethod()
        {
            return Redirect("EmployeeData");
        }

        //action method redirecting to an action method of another controller
        public RedirectResult Redirect_to_Contoller()
        {
            return Redirect("/Home/About");

        }
    }
}