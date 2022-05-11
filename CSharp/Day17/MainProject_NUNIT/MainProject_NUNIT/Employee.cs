using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainProject_NUNIT
{
    public class Employee
    {
        public int ID { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public double Salary { get; set; }
        public string Gender { get; set; }
        

        List<Employee> emplist = new List<Employee>();
        public string Login(string userid, string password)
        {
            if (string.IsNullOrEmpty(userid) || string.IsNullOrEmpty(password))
            {
                return "User Id or Password Cannot be Empty";
            }
            else if (userid == "Admin" && password == "Admin123")
            {
                return "Welcome Admin";
            }
            else
                return "Invalid Userid or Password";             
        }

        public List<Employee> AllEmployees()
        {
                      
            emplist.Add(new Employee { ID = 100, FName= "Suresh", LName ="Kumar", Gender = "Male", Salary = 35000});
            emplist.Add(new Employee { ID = 101, FName = "Monisha", LName= "Devi", Gender = "Female", Salary = 40000 });
            emplist.Add(new Employee { ID = 102, FName = "Geetha", LName = "Bali", Gender = "Female", Salary = 45000 });

            return emplist;
        }

        public string GetName(string fname, string lname)
        {
            return string.Concat(fname+lname);
        }

        public List<Employee> GetEmployeeByID(int id)
        {
            
           List<Employee> e =( from emp in emplist
                where emp.ID == id
                select emp).ToList();
            if (e != null)
            {
                return e;
            }
            else
                e = null;
                return e;
        }
    }
}
