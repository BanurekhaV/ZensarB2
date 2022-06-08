using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace Day3Others.Controllers
{
    public class RegisterUserController : Controller
    {
        // GET: RegisterUser
        public ActionResult Index()
        {
            return View();
        }

        //fetch the data from the view to controller using form collection
        //using standard html helpers
        public ActionResult CreateRegistration()
        {
            return View();
        }

        [HttpPost]
        public ActionResult CreateRegistration(FormCollection frm)
        {
            string name = frm["txtname"].ToString();
            string password = frm["txtpwd"].ToString();
            string gender = frm["Gender"].ToString();
            string city = frm["City"].ToString();
            bool music = Convert.ToBoolean(frm["M"].Split(',')[0]);
            bool sports = Convert.ToBoolean(frm["S"].Split(',')[0]);
            bool arts= Convert.ToBoolean(frm["A"].Split(',')[0]);

            string interest = "";
            if(music==true)            
                interest += "Music";
            if (sports == true)
                interest += "Sports";
            if (arts == true)
                interest += "Arts";

            StringBuilder sb = new StringBuilder();
            sb.Append(name + "<br/>");
            sb.Append(password + "<br/>");
            sb.Append(gender + "<br/>");
            sb.Append(city + "<br/>");
            sb.Append(interest + "<br/>");
            return Content(sb.ToString());
        }
    }
}