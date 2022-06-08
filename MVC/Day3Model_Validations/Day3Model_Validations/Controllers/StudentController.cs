using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day3Model_Validations.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        //strongly typed helper
        public ActionResult StronglyTyped()
        {
            return View();
        }

        //templated Helper
        public ActionResult TemplatedHelper()
        {
            return View();
        }

        //editor for helper
        public ActionResult EditorForModel()
        {
            return View();
        }
    }
}