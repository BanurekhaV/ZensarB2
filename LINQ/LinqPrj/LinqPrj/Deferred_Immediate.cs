using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrj
{
    class Employee
    {
        public int ID { get; set; }
        public string Name{ get; set; }
        public float Salary { get; set; }
    }
    class Deferred_Immediate
    {
        static void Main()
        {
            var employees = new List<Employee>
            {
                new Employee{ID=101,Name="Vinod",Salary=30000},
                 new Employee{ID=102,Name="Vineeth",Salary=35000},
                  new Employee{ID=103,Name="Vyshnavi",Salary=40000},
            };
            //Linq query is only constructed , but not executed here
            var emp = employees.Where(x => x.Salary < 35000).Select(y => y.Name);

            //we will create another employee instance after the linq query
            employees.Add(new Employee { ID = 104, Name = "Maruthi", Salary = 30000 });
            employees.Add(new Employee { ID = 105, Name = "Vajaullah", Salary = 29000 });

            foreach(var e in emp)
            {
                Console.WriteLine(e);
            }
            Console.Read();
        }
    }
}
