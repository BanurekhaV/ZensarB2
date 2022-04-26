using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day7
{
    class MethodOverloading
    {
        public static void swap(int num1, int num2)
        {
            num1 = num1 + num2;        
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("Swapping of Integers num1= "+ num1 + "num2= "+num2);
        }

        public static void swap(char c1, char c2)
        {
            char temp = ' ';
            temp = c1;
            c1 = c2;
            c2 = temp;
            Console.WriteLine("Swapping of Characters c1 ="+ " "+ c1 + "c2= "+c2);
        }
    }
    class MethodOverload
    {
        static void Main(string[] args)
        {
            MethodOverloading.swap(5, 7); // go to line no.12
            MethodOverloading.swap('a', 'b');
            Console.Read();
        }
    }
}
