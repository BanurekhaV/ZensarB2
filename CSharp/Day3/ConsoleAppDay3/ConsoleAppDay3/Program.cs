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

            for(int x=0; x<5;x++)
            {
                Console.WriteLine(myarray[x]);
            }
            Console.Read();
        }
        
    }

    
}
