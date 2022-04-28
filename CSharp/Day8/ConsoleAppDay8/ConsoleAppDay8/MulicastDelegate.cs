using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    delegate void Manyfunctiondel();
    delegate int Manydelegate();
    class MulticastDelegate
    {
        public static void Method1()
        {
            Console.WriteLine("Method 1 Invoked");
        }
        public static void Method2()
        {
            Console.WriteLine("Method 2 Invoked");
        }
        public static void Method3()
        {
            Console.WriteLine("Method 3 Invoked");
        }

        public static int func1()
        {
            return 1;
        }
        public static int func2()
        {
            return 2;
        }

        public static int func3()
        {
            return 3;
        }
        static void Main()
        {
            //the below is creating multiple delegate objects and then multicasting it to an object
            //Manyfunctiondel d1, d2, d3, d4;
            //d1 = new Manyfunctiondel(Method1);
            //d2 = new Manyfunctiondel(Method2);
            //d3 = new Manyfunctiondel(Method3);
            //d4 = d1 + d2 + d3;  // multicasting all delegate objects to a single delegate object
            //d4();
            //d4 -= d2;
            //d4();

            //the below is to create only one object and multicast it to point to other functions
            Manyfunctiondel m1 = new Manyfunctiondel(Method1);
            m1 += Method2;
            m1 += Method3;
            m1();

            Manydelegate md = new Manydelegate(func1);
            md += func2;
            md += func3;
            Console.WriteLine(md()); 
            Console.Read();
        }
    }
}
