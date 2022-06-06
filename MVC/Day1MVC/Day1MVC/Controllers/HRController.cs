using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Day1MVC.Models;

namespace Day1MVC.Controllers
{
    public class HRController : Controller
    {
        // GET: HR
        //calling a ListDepartment action method's view of the same controller in index 
        public ActionResult Index()
        {
            List<Department> deptlist = new List<Department>();
            deptlist.Add(new Department { ID = 1, DeptName = "CSE" });
            deptlist.Add(new Department { ID = 2, DeptName = "Mech" });
            deptlist.Add(new Department { ID = 3, DeptName = "CIvil" });
            deptlist.Add(new Department { ID = 4, DeptName = "IT" });
            return View("ListDepartment",deptlist);
        }

        //the below is an action method that is dependant on the Index() action method for
        //department details.
        public ActionResult ListDepartment(List<Department> dlist)
        {
            //the below view will be bound to a model (department)
            return View(dlist);
        }

        //the below action method has its own view that retrieves the list of employees
        public ActionResult ListEmployee()
        {
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee { ID = 1001, Age = 25, Name = "Sai Kumar" });
            emplist.Add(new Employee { ID = 1002, Age = 29, Name = "Romesh" });
            emplist.Add(new Employee { ID = 1003, Age = 46, Name = "Suraj" });
            emplist.Add(new Employee { ID = 1004, Age = 34, Name = "Thakre" });
            return View(emplist);
        }

        //Action method with its own view that returns one employee object

        public ActionResult DisplayEmployee()
        {
            Employee Emp = new Employee() { ID = 10, Name = "Deepak", Age = 27 };
            return View(Emp);
        }

    }
}