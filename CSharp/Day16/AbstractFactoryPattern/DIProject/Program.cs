using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. DI thru constructor
            //EmployeeBAL employeebal = new EmployeeBAL(new EmployeeDAL());

            //List<Employee> emplist = employeebal.EmployeeDetails();

            //2. DI thru Property
            //EmployeeBAL employeebal = new EmployeeBAL();
            //employeebal._EmployeeObject = new EmployeeDAL();

            //List<Employee> emplist = employeebal.EmployeeDetails();

            //3. DI thru Method call
            EmployeeBAL employeebal = new EmployeeBAL();

            List<Employee> emplist = employeebal.EmployeeDetails(new EmployeeDAL());

            foreach (Employee e in emplist)
            {
                Console.WriteLine($"ID :{e.ID}, Name : {e.Name}, and Department : {e.Department}");
               
            }

            Employee emp = employeebal.GetOneEmployee();
            Console.WriteLine(emp.ID + " " + emp.Name + " "+emp.Department);
            Console.Read();
        }
    }
}
