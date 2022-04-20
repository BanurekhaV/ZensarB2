using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    class Employee
    {
        //instance fields
        int Empid;
        string EmpName;
        float EmpSalary;

        //class field
        static string companyname = "Zensar";

        //declare constructors
        //1. Empty constructor
        public Employee()
        {
            Empid = 100;
            EmpName = "Himakar";
            EmpSalary = 25000.55f;
            Console.WriteLine($"Employee id is:{Empid}, Name is {EmpName} and Salary is :{EmpSalary}");

        }

        //2. Parameterized constructor
        public Employee(int Empid, string EmpName, float EmpSalary)
        {
            this.Empid = Empid;
            this.EmpName = EmpName;
            this.EmpSalary = EmpSalary;
            Console.WriteLine($"Employee id is:{Empid}, Name is {EmpName} and Salary is :{EmpSalary}");
        }

        //destructor
        ~Employee()
        {
            Console.WriteLine("Bye from Employee");
            Console.Read();
        }
        public string Message() //instance function of a class 
        {
            return "Hi" + EmpName;
        }

        public static void Display() // static function of a class
        {
            Console.WriteLine("Hello User" );
        }
        public static void Main(string[] args)
        {
            Employee employee = new Employee();//call the empty constructor 
            Employee employee1 = new Employee(200, "Tejasree", 25000); // call the parameterized constructor
            string output= employee.Message();
            Console.WriteLine(output);
            Console.WriteLine(employee1.Message()); 
            Console.Read();
        }

    }
}
