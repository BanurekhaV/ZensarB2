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

        public Employee()
        {
            Console.WriteLine("Enter Employee Id,Name,Age,Address");
            this.Eid = Convert.ToInt32(Console.ReadLine());
            this.Age=Convert.ToInt32(Console.ReadLine());
            this.Name = Console.ReadLine();
            this.Address = Console.ReadLine();
        }

        //copy constructor
        public Employee(Employee emp)
        {
            this.Eid = emp.Eid;
            this.Address = emp.Address;
            this.Age = emp.Age;
            this.Name = emp.Name;
        }
        public void Display()
        {
            Console.WriteLine($"Employee id{Eid}, Empname {Name}, Age {Age} and Address {Address}");
        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee();
            Employee e2 = new Employee(e1);
            e1.Display();
            e2.Display();
            Console.Read();
        }
    }
}
