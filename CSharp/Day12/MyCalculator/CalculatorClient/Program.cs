using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyCalculator;   //dll 
using MyCalculator2;


namespace CalculatorClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculator calculatorobj = new Calculator();
            Console.WriteLine(calculatorobj.Add(5, 6));
            Console.WriteLine(calculatorobj.Message("Banurekha"));
            Console.WriteLine(calculatorobj.Subtract(10,4));
            Console.WriteLine(calculatorobj.Multiply(5,6));
            Console.Read();
        }
    }
}
