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
            //or
            //List<Category> category = db.Categories.ToList();
            //return View(category);
        }

        //fetching category data by name in ascending order
        //query syntax
        public ActionResult GetCategoryByName()
        {
            List<string> catname = (from cat in db.Categories
                                    orderby cat.CategoryName
                                    select cat.CategoryName).ToList();
            return View(catname);

        }

        //the above output can be got using method syntax

        public ActionResult GetCategoryByMethod()
        {
            dynamic cat = (db.Categories.OrderBy(c => c.CategoryName).Select(c1 => c1.CategoryName)).ToList();
            return View(cat);

        }
       
        //crud operations to insert
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost,ActionName("Create")]
        //1. data from view to controller using a Model object
        //public ActionResult Create(Category c)
        //{
        //    db.Categories.Add(c);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //2. passing data from view to controller using parameters
        //public ActionResult Create(int CategoryID, string CategoryName,string Description)
        //{
        //    Category c = new Category();
        //    c.CategoryID = CategoryID;
        //    c.CategoryName = CategoryName;
        //    c.Description = Description;
        //    db.Categories.Add(c);
        //    db.SaveChanges();
        //    return RedirectToAction("Index");
        //}

        //3. passing data from view to controller using Request Object

        public ActionResult CreatePost()
        {
            Category cat = new Category();
            cat.CategoryID = Convert.ToInt32(Request["CategoryID"]);
            cat.CategoryName = Request["CategoryName"].ToString();
            cat.Description = Request["Description"].ToString();
            db.Categories.Add(cat);
            db.SaveChanges();
            return RedirectToAction("Index");


        }


        // get details of category based on an given id
        public ActionResult Details(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        //edit records
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Category c = db.Categories.Find(id);
            return View(c);
        }

        [HttpPost]
        public ActionResult Edit(Category cat)
        {
            Category category = db.Categories.Find(cat.CategoryID);
            category.CategoryName = cat.CategoryName;
            category.Description = cat.Description;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        //delete record
        public ActionResult Delete(int id)
        {
            Category c = db.Categories.Find(id);
            db.Categories.Remove(c);
            db.SaveChanges();
            return RedirectToAction("Index");

        }

        //calling stored procedure
        [ActionName("ExpensiveProducts")]
        public ActionResult Proc_Expensive_Products()
        {
            return View("Proc_Expensive_Products", db.Ten_Most_Expensive_Products());
        }
    }
}