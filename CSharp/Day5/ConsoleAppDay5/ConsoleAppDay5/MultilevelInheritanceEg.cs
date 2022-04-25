using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    class Parent
    {
        protected int data;

        Parent() //usedefined default constructor
        {

        }
        public Parent(int a)
        {
            data = a;
            Console.WriteLine("Parents Data is :" + data);
        }

        ~Parent()
        { 
            Console.WriteLine("Parent saying Bye");
            Console.Read();
        }
    }

    class Child : Parent
    {
        int data2;
        public Child(int x):base(x)
        {
            data2 = x;
            data = 100;
            Console.WriteLine("Childs Data is: " + data2 + " " + this.data);
        }

        public Child(int x, int y):base(y)
        {
            data2 = x;
            data = 200;
            Console.WriteLine("Childs Data thru 2nd constructor is: " + data2 + " " +this.data);
        }
        ~Child()
        {
            Console.WriteLine("Child saying Bye");
            Console.Read();
        }
    }
    class MultilevelInheritanceEg
    {
        static void Main()
        {
            Child c = new Child(10);
            Child c1 = new Child(20, 25);
            Console.Read();
        }
    }
}
