using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    public delegate void EmployeeDelegate(string s); //declaration of a delegate 
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

        public string Message()
        {
            return "Hi";
        }

        static void Main()
        {
            Delegate1 del1 = new Delegate1();
            EmployeeDelegate empd1 = new EmployeeDelegate(Delegate1.Show);
            EmployeeDelegate empd2 = new EmployeeDelegate(del1.accept);

            empd1("Banurekha"); //calling a delegate that internally calls the function that it is pointing to
            empd2.Invoke("Venkat");
            Console.Read();
        }
    }
}
