using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    class GenericList
    {
        static void Main()
        {
            List<int> numlist = new List<int>();
            numlist.Add(4);
            numlist.Add(8);
            numlist.Add(2);
            numlist.Sort();

            foreach(int x in numlist)
            {
                Console.WriteLine(x);
            }
            List<string> strlist = new List<string>()     
            { "Red","Blue","Green","Yellow","White","Black" };
           
            strlist.Sort();
            foreach(var s in strlist)
            {
                Console.WriteLine(s);
            }
            List<Employee> emplist = new List<Employee>();
            emplist.Add(new Employee(101, "Vineeth", 23000));
            emplist.Add(new Employee(102, "Vajahulla", 24000));
            emplist.Add(new Employee(103, "Saikumar", 23500));
            emplist.Add(new Employee(104, "Lokesh", 24000));

            foreach(Employee e in emplist )
            {
                Console.WriteLine(e.ToString());
            }

            //working with Dictionary - Generic collection with key and value pair

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "AndhraPradesh");
            dict.Add(4, "Maharashtra");
            dict.Add(3, "MadhyaPradesh");
            dict.Add(6, "Karnataka");

            foreach(var ky in dict.Keys)
            {
                Console.WriteLine(ky);
            }

            foreach (var v in dict.Values)
            {
                Console.WriteLine(v);
            }

            foreach (KeyValuePair<int,string> kvp in dict)
            {
                Console.Write(kvp);
            }

            Console.WriteLine("Enter the key to get State");
            int k = int.Parse(Console.ReadLine());
            if(dict.ContainsKey(k))
            {
                Console.Write(k + " represents" + " " + dict[k]);
            }

            else
            {
                Console.WriteLine("Invalid Key");
            }

            Console.Read();
        }
    }
    class Employee
    {
        int Empid;
        string Empname;
        double Empsalary;
        static string company="Zensar";

        public Employee(int eid, string ename, float sal)
        {
            Empid = eid;
            Empname = ename;
            Empsalary = sal;
        }

        public override string ToString()
        {
            // return base.ToString();
            return string.Format("Empid:  "+ " " +Empid + " " + "with Name :" + Empname + " " + "Earns a salary of :" + " " +
                Empsalary + " " + "works for" + " " + company);
        }

        //public void objectInitialize()
        //{
        //    Employee emp = new Employee()
        //    {
        //        Empid = 200,
        //        Empname = "Banurekha",
        //        Empsalary = 23000,
        //    };
        //}
    }

}
