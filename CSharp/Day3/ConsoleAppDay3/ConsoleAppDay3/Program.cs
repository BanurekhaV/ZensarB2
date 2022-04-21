using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
   internal class Program
    {
        static void Main(string[] args)
        {
            int? data = 50;
            int result;
            if(data==null)
            {
                result = 0;
            }
            else
            {
                result =(int) data;
                //or
                result = data.Value;
            }
            Console.WriteLine(result);

            //null coalescing operator ?? (is a ternary operator)
            result = data ?? 0;
            Console.WriteLine(result + "" + "from null coalescing");

            //simple array example

            int[] myarray = new int[5];
            int[] arr1 = { 1, 2, 3, 4, 5 }; // one way to initialize the array with values

            //2nd way of initializing arrays
            //myarray[0] = 10;
            //myarray[1] = 20;
            //myarray[2] = 30;
            //myarray[3] = 40;
            //myarray[4] = 50;

            //3rd way and usual way to initialize 
            for(int x=0;x<5;x++)
            {
                Console.WriteLine("Enter nos into array of 5");
                myarray[x] = Convert.ToInt32(Console.ReadLine()); //x+5
            }
            //for loop to print all the values in the myarray
            for(int x=0; x<myarray.Length;x++)
            {
                Console.WriteLine(myarray[x]);
            }

            //foreach loop to print all the values in the myarray

            Console.WriteLine("======Using Foreach Loop=====");
            foreach(int i in myarray)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine("old value at 3rd place is :"+ " "+ myarray[2]);
            //change the value at a particular index
            myarray[2] = 100;
            Console.WriteLine("New value at 3rd place is :" + " " + myarray[2]);
            Console.WriteLine("The length is :" + " " + myarray.Length);
            Console.WriteLine("The smallest element is :" + " " + myarray.Min());
            Console.WriteLine("The largest element is :" + " "+ myarray.Max());
            Console.WriteLine("The sum of all elements is :"+ " " + myarray.Sum());

            Console.WriteLine("-----------2 dimensional array values------");
            ArraysEg ae = new ArraysEg();
            ae.TwoDimension();
              Console.Read();
        }
        
    }

    
}
