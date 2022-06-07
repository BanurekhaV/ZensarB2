using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day2EF_Prj.Models;

namespace Day2EF_Prj.Controllers
{
    public class CategoryController : Controller
    {
        NorthwindEntities db = new NorthwindEntities();
        // GET: Category
        public ActionResult Index()
        {

            return View(db.Categories.ToList());
        }
    }
}