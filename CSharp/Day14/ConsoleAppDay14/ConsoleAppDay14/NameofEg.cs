using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay14
{
    class NameofEg
    {
        int[] arr = new int[5];

        #region
        public static void Main()
        {
            NameofEg noe = new NameofEg();
            try
            {
                noe.Display(noe.arr);
            }
            catch(IndexOutOfRangeException ie)
            {
                //we can display the name of the method that throws an exception
                // Console.WriteLine(ie.Message); usual way oh handling error
                ///summary
                ///the name of operator is used here to check which function is throwing an exception
                Console.WriteLine(nameof(noe.arr));
                Console.WriteLine(nameof(NameofEg));
                Console.WriteLine($"The Method :{nameof(noe.Display)} - resulted in an {ie.Message}");
            }
            Console.Read();
        }

       public int Display(int[] a)
        {
            a[6] = 10;
            return a[6];
        }
        #endregion
    }

}
