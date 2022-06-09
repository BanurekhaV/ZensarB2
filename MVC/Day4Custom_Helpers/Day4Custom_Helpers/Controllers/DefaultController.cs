using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Day4Custom_Helpers.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        //calling customhelpers
        public ActionResult CustomHelp()
        {
            return View();
        }
    }
}