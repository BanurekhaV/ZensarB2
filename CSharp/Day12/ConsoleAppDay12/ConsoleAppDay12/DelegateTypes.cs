using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay12
{
    class DelegateTypes
    {        
        static void Main()
        {
            //1. func delegate with 0 parameters- anonymous
            //Func<int> getrandomnumber = delegate ()
            //{
            //    Random rnd = new Random();
            //    return rnd.Next(1, 100);
            //};
            //int randomnumber = getrandomnumber();
            //Console.WriteLine(randomnumber);

            //1. with lambda
            Func<int> getrandomnumber2 = () => new Random().Next(1, 100);
            int randomnumber = getrandomnumber2();
            Console.WriteLine(randomnumber);

            //one more example of func delegate with lambda
            //we need to add 2 numbers and return the sum
            Func<int, int, int> sum = (x, y) => x + y;
            int total = sum(20, 20);
            Console.WriteLine(total);

             //func delegate with 1 input
            Func<string, bool> strdel = String.IsNullOrEmpty;
            bool result = strdel("CSharp Delegates"); //making a call thru delegate object to a IsNullOrEmpty function
            //pointed by the delegae
            Console.WriteLine($"String.IsNullOrEmpty returned : {result}");

            //func delegate with 2 inputs
            Func<double, double, double> powerdel = Math.Pow;
            double power = powerdel(2, 3); //call the delegate pointing function
            Console.WriteLine($"2 ^ 3 is : {power}");
            Console.Read();
        }
    }
}
