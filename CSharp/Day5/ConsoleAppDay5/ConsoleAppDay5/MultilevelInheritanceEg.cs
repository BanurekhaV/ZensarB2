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

        public Parent(int a)
        {
            data = a;
        }
    }

    class Child : Parent
    {
        
        public Child(int n):base(n) //instantiating a base class through the child class constructor
        {
            data = n;
        }

    }
    class MultilevelInheritanceEg
    {

    }
}
