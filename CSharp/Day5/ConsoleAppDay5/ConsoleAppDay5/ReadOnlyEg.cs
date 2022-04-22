using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    class ReadOnlyEg
    {
        //decl readonly variables
        public readonly int myvar1=5; //initializing a readonly variable during declaration
        public readonly int myvar2; // initializing this readonly variable thru constructor
        const float PI=3.14f;
        public ReadOnlyEg(int x, int y)
        {
            myvar1 = x;
            myvar2 = y;
            Console.WriteLine("The values of myvar1 and myvar2 are {0}, {1}", myvar1, myvar2);
        }
        public ReadOnlyEg(int x)
        {            
            myvar2 = x;
            Console.WriteLine("The values of myvar1 and myvar2 are {0}, {1}",myvar1,myvar2);
        }

        static void Main()
        {
            ReadOnlyEg roeg = new ReadOnlyEg(10);
            //  roeg.myvar1 = 100;
            ReadOnlyEg roeg1 = new ReadOnlyEg(111, 222);

            Console.WriteLine(AllTypesExample.y);
            Console.WriteLine(AllTypesExample.myconst);
            AllTypesExample ate = new AllTypesExample(20, true);
            Console.WriteLine(ate.x);
            Console.WriteLine(ate.flag);
            Console.Read();
        }
    }

    class AllTypesExample
    {
       public int x; // Non static field
       public static int y=125; //static field
      public  const float myconst = 25.55f; //const field
      public  readonly bool flag; //readonly field

        public AllTypesExample(int x, bool b)
        {
            this.x = x;
            flag = b;
        }
    }
}
