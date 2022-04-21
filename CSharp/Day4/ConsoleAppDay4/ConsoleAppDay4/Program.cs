using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay4
{
    class Program
    {
        //Methods and Parameters

        //call by value
        public static void CallbyValueMethod(int j)
        {
            Console.WriteLine("J is :" + " " + j);
            j = 100;
            Console.WriteLine("J is :" + " " + j);
        }

        //call by ref

        public static void CallbyRefMethod(ref int j)
        {
            Console.WriteLine("J is :" + " " + j);
            j = 100;
            Console.WriteLine("J is :" + " " +j);
        }

        public static int add(int x, int y)
        {
            Console.WriteLine("Hello");
            return x + y;
        }


        //out parameters example
        public static int Calculator(int a, int b, out int subtract, out int product, out int divide )
        {
            subtract = a - b;
            product = a * b;
            divide = a / b;
            return a + b;
        }
        static void Main(string[] args)
        {
            int i = 10;
            CallbyValueMethod(i);
            Console.WriteLine("The value of i is :" + " " +i);
            CallbyRefMethod(ref i);
            Console.WriteLine("The value of i is :" + " " + i);
            int sum, prod, difference, division;
            sum = Calculator(20, 10, out difference, out prod, out division);
            Console.WriteLine($"Sum is {sum}, difference is {difference}, Product is {prod} and Division is {division}");
            Console.Read();
        }
    }
}
