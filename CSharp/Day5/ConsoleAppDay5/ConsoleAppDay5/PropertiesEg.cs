using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
     class Employee
    {
        private string empcode = "N.A";
        private string empname = "Not Known";
        private int age = 0;
        public float Salary { get; } //automatic property implementation
        public DateTime DOJ { get; set; }
        

        //using properties to access he private members
        //decl property for empcode field
        public string _Ecode
        {
            get
            {
                return empcode;  //to get the field values in get accessor
            }
            set
            {
                empcode = value; //to set the value of the private field using set accessor
            }
        }

        //property for name and age
        public string Name
        {
            get { return empname; }
            set { empname = value; }
        }

        public int Years
        {
            get { return age; } //only getter no setter
        }
        public void showdetails()
        {
            Console.WriteLine($"Empcode {empcode}, Name {empname} and age {age}");
           
        }
    }
    class PropertiesEg
    {
        enum Days {Sun,Mon,Tue,Wed,Thur,Fri,Sat};
        static void Main()
        {
            Employee employee = new Employee();
            employee.showdetails();
            employee._Ecode = "E100";  //this will call the set accessor
                                       // employee.showdetails();
            Console.WriteLine(employee._Ecode); // this will call the get accessor
            employee.Name = "Sreedhar";
            employee.DOJ = Convert.ToDateTime("22/04/2022");
            //  Console.WriteLine(employee.Salary);
            //  Console.WriteLine($"Employee Name {employee.Name} ,Employee Ecode {employee._Ecode} , Age {employee.Years}, and Date of Joining{employee.DOJ}");
            Console.WriteLine(employee.ToString());

            //accessing the values of enum type
            foreach(int x in Enum.GetValues(typeof(Days)))
            {
                Console.WriteLine(x);
            }

            foreach(string s in Enum.GetNames(typeof(Days)))
            {
                Console.WriteLine(s);
            }

            int weekstart =(int) Days.Mon;
            int weekend = (int)Days.Fri;

            Console.WriteLine("Mondays : {0}",weekstart);
            Console.WriteLine("Fridays: {0}",weekend);
            

            Console.Read();
        }

    }
}
