using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6
{
    class Employee
    {
        int Eid, Age;
        string Name, Address;
        static string compmanyname;
        //private constructor
        private Employee()
        {
            Console.WriteLine("Enter Employee Id,Name,Age,Address");
            this.Eid = Convert.ToInt32(Console.ReadLine());
            this.Age=Convert.ToInt32(Console.ReadLine());
            this.Name = Console.ReadLine();
            this.Address = Console.ReadLine();
        }
        public Employee(int eid, string name)
        {
            Eid = eid;
            Name = name;
        }
        //copy constructor
        public Employee(Employee emp)
        {
            this.Eid = emp.Eid;
            this.Address = emp.Address;
            this.Age = emp.Age;
            this.Name = emp.Name;
            compmanyname = "myZensar"; // can initialize static field in an non-static constructor
            //but the field will loose its static nature
        }
        public void Display()
        {
            Employee employee = new Employee();
            Console.WriteLine($"Employee id{Eid}, Empname {Name}, Age {Age} Address {Address} and Company {compmanyname}");
            compmanyname = "New Zensar";
            Console.WriteLine($"Employee id{Eid}, Empname {Name}, Age {Age} Address {Address} and Company {compmanyname}");
        }

        //static constructor
        static Employee()
        {
            compmanyname ="Zensar";            
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(200,"Akshay");
            Employee e2 = new Employee(e1);
            e1.Display();
            
            e2.Display();
            Console.Read();
        }
    }
}
