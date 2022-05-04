using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay12
{
    delegate void Print(int val);
    delegate void ArithmeticHandler(int fnumber, int snumber);
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            Print p = delegate (int x) { Console.WriteLine("Inside Anonymous Function:{0}", x); };
            p(100);

            //anonymous method can access the variable defined in an outer function
            Print p1 = delegate (int x) { x += i; Console.WriteLine("Anonymous method accessing outside variable {0}", x); };
            p1(50);

            //using method expression to call anonymous 
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int[] evennos = Array.FindAll(arr, delegate (int num) { return num % 2 == 0; });
            Console.WriteLine("The even nos are :");

            foreach(int z in evennos)
            {
                Console.Write(z + " ");
            }

            //anonymous methods with lambda expressions
            ArithmeticHandler ah = delegate (int fnum, int snum)
            {
                Console.WriteLine("Addition of {0} and {1} is {2}", fnum,snum,fnum+snum);
            };
            ah(5, 10);

            // with lambda
            ArithmeticHandler ah2 = (fnum, snum) =>
            {
                Console.WriteLine("Addition of {0} and {1} is {2} using lambda", fnum, snum, fnum + snum);
            };
            ah2(5, 10);
            Console.Read();
        }
    }
}
