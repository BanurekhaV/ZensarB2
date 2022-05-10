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
            EmployeeBAL employeebal = new EmployeeBAL(new EmployeeDAL());

            List<Employee> emplist = employeebal.EmployeeDetails();

            foreach(Employee e in emplist)
            {
                Console.WriteLine($"ID :{e.ID}, Name : {e.Name}, and Department : {e.Department}");
                Console.Read();
            }

        }
    }
}
