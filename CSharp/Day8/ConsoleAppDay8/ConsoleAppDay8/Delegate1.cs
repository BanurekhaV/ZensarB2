using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
     delegate void EmployeeDelegate(string s); //declaration of a delegate 
     delegate void SecondDelegate();
    class Delegate1
    {
        public void accept(string s)
        {
            Console.WriteLine("Hello " +  " " + s);
        }
        public static void Show(string s)
        {
            Console.WriteLine(s);
        }

        public void NoParameterMethod()
        {
            Console.WriteLine("Reached No parameter Method");
        }
        public string Message()
        {
            return "Hi";
        }

        static void Main()
        {
            Delegate1 del1 = new Delegate1();
            Console.WriteLine(del1.Message()); 
            EmployeeDelegate empd1 = new EmployeeDelegate(Show);
            EmployeeDelegate empd2 = new EmployeeDelegate(del1.accept);
            SecondDelegate sd = new SecondDelegate(del1.NoParameterMethod);

            empd1("Banurekha"); //calling a delegate that internally calls the function that it is pointing to
            empd2.Invoke("Venkat");
            sd(); //or sd.Invoke();
            Console.Read();
        }
    }

 }
