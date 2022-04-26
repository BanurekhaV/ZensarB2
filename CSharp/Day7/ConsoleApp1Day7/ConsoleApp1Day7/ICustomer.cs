using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day7
{
     interface ICustomer1
    {
        void Print(); //only decl no code
        string Message(string str);
    }

    interface ICustomer2
    {
        void Show();
    }
    interface ISupplier : ICustomer2, ICustomer1
    {
        void Supplier();
    }
    class Customer : ISupplier      //ICustomer1,ICustomer2
    {
        public void Supplier()
        {
            Console.WriteLine("Supplier Method");
        }
       public void Print()
        {
            Console.WriteLine("This is Implemented code of Print()");
        }
        public string Message(string s)
        {
            return "Welcome" + " " + s;
        }
        public void Show()
        {
            Console.WriteLine("Show Method");
        }
    }

    class Tester
    {
        static void Main()
        {            
            Customer cust = new Customer();
            cust.Print();
            string s=cust.Message("Interface");
            Console.WriteLine(s);
            cust.Show();
            Console.Read();
        }
    }
}
