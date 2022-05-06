using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    class ExceptionFiltersEg
    {
        static void Main()
        {
            try
            {
                int a = 10, b = 0, c;
                c = a / b;
                int[] arr = new int[5];
                arr[6] = 10;                
            }
            catch(Exception e) when (e.GetType().ToString() == "System.IndexOutOfRangeException")
            {
                //do something here
                SomeJob();
                Console.Read();
            }
            catch(Exception e) when (e.GetType().ToString() == "System.DivideByZeroException")
            {
                Console.WriteLine("Encounterd a divide by zero exception.. try again");
            }

        }
        static void SomeJob()
        {
            Console.WriteLine("This is a new Job being performed....");
        }
    }
}
