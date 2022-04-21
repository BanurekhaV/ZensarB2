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

        public void JaggedArray()
        {
            //decl jagged array of 2 rows
            int[][] myjagged = new int[2][];
            //let us set the size of the columns for each jagged row
            myjagged[0] = new int[3];
            myjagged[1] = new int[2];

            //initializing values of the jagged array
            myjagged[0][0] = 2;
            myjagged[0][1] = 4;
            myjagged[0][2] = 6;

            myjagged[1][0] = 3;
            myjagged[1][1] = 5;

            //decl and initializing a jagged array
            int[][] jagged2 = {new int[] {5,10,15,20},
                new int[]{25,30},
                new int[]{35,40,45}              
            };
            //we need 2 loops to iterate either a 2dimensional or jagged array
            //outer loop for rows 
            for (int i = 0; i < jagged2.Length; i++)
            {
                Console.Write("Element " + i + ":");
                //inner loop for columns
                for(int j=0;j<jagged2[i].Length;j++)
                {
                    Console.Write(jagged2[i][j] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
