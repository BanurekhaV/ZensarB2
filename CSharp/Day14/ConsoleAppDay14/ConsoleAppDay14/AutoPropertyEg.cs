using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    class Employee
    {
        public string EmpName { get; } = "Adarsh";
        public double Salary { get; } = 50000.0; //autoproperty initializer

        //various ways to mention properties in a class
        public string Name { get; set; } = "Vyshnavi";
        public string Name1 { get; private set; }

        public string Companyname { get; protected set; } = "Zensar";
        public Employee()
        {
            // EmpName = "Akshay";
            Companyname = "New Zensar";
            Console.WriteLine(EmpName + " " + Salary);
        }
    }
    class AutoPropertyEg : Employee
    {
        static void Main()
        {
            Employee employee = new Employee();
            employee.Name = "Shubam";
            Console.WriteLine(employee.Name1 + " " + employee.Companyname);

            AutoPropertyEg ape = new AutoPropertyEg();
            ape.Companyname = "Zensar P. Ltd.";
            //before c# 6.0 dictionary initializaion
            Dictionary<string, string> empdict = new Dictionary<string, string>()
            {   {"Vamsi","E045" },
                {"Vineeth","E067" },
                {"Vinodh","E010" },
                {"Vamsi M","E027" }
            };

            //with C# 6.0
            Dictionary<string, string> mydict = new Dictionary<string, string>()
            {
                ["Vajreshwari"] = "E100",
                ["Venkat S"] = "E231",
                ["Venkat M"] = "E002"
            };

            Console.WriteLine(@"Dictionary Initializers in C# 6.0\n\n
                                  List of Employees\n
                             -----------------------------");
            foreach(KeyValuePair<string,string> kvp in mydict)
            {
                Console.WriteLine($"Name : {kvp.Key} and EmpId : {kvp.Value}");
            }
           
            Console.Read();
        }
    }
}
