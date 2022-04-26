using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day7
{
    class ExceptionEg
    {
        static void Main()
        {
            int a, b, c;
            try
            {
                Console.WriteLine("Enter 2 nos:");
                a = int.Parse(Console.ReadLine());
                b = int.Parse(Console.ReadLine());
                c = a / b;
                Console.WriteLine(c);
            }
            catch (FormatException fe)
            {
                //Console.WriteLine(fe.Message + " " + fe.Source + " " + fe.StackTrace);
                Console.WriteLine("Please enter only numbers and try again");
                //Console.Read();
            }
            catch (DivideByZeroException de)
            {
                Console.WriteLine("You cannot divide a number by 0");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error in application..");
            }
            finally
            {
                Console.WriteLine("Reached Finally block");
            }            
           Console.Read();
        }
    }
}
