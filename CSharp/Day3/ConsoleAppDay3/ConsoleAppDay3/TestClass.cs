using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    class TestClass
    {
        static string name;
      
        public void TestMethod1()
        {
            name = "Rishikesh";
            Console.WriteLine("This is TestMethod1" + " "+ name);
        }

        public static void TestMethod2()
        {
            name = "Venkat";
            Console.WriteLine("This is Test Method 2" + name);
            name = "Vajreshwari";
            Console.WriteLine("This is Test Method 2" + name);
        }
        static void Main(string[] args)
        {
            TestClass tc = new TestClass(); //default constructor is supplied by the framework
            tc.TestMethod1() ;
            TestClass.TestMethod2();
            TestClass tc1 = new TestClass();
            tc1.TestMethod1();
            TestClass.TestMethod2();
            Console.ReadKey();
        }
    }
}
