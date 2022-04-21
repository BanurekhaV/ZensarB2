using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
    class ArraysEg
    {
        //examples for 2 dimensional arrays
        public void TwoDimension()
        {
            //declare a 2 dimensional array
            int[,] myarr = new int[2, 3];  //2 rows and 3 columns
            //declare and to initialize the 2 dimensional array
            int[,] myarr1 = new int[2, 3] { {1,2,3 }, {4,5,6 } };

            Console.WriteLine(myarr1[0, 1]); // returns a value of 2 as per the above values

            //to change the value of a 2 dimensional array
            myarr1[1, 0] = 14;

            Console.WriteLine(myarr1[1, 0]);
        }
    }
}
