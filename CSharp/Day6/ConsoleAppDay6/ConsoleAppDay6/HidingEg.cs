using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace ConsoleAppDay6
{
    class A1
    {
        public int i = 0;

        public void Method1(string msg)
        {
            Console.WriteLine("Message from Base class {0}", msg);
        }
    }

    class B1: A1
    {
        new int i;  // this  i hides the i in A1 class - name hiding

        public B1(int a, int b)
        {
            base.i = a;  // i in A1 class
            i = b;  //i in B1 class           
        }

        public new void Method1(string s) //method hiding
        {
            Console.WriteLine("Message from Derived Class {0}", s);
            base.Method1("hello");
        }

        public void Show()
        {
            Console.WriteLine("i in Base calss A1 :" + " " +base.i);
            Console.WriteLine("i in Derived class B1 :" + " "+i);
        }
    }
    class HidingEg
    {
        static void Main()
        {
            B1 b1obj = new B1(2, 3);
            b1obj.Show();

            SqlConnection con = new SqlConnection();
            Console.Read();
        }
    }
}
