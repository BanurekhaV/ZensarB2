using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay4
{
    class Program
    {
        //Methods and Parameters

        //call by value
        public static void CallbyValueMethod(int j)
        {
            Console.WriteLine("J is :" + " " + j);
            j = 100;
            Console.WriteLine("J is :" + " " + j);
        }

        //call by ref

        public static void CallbyRefMethod(ref int j)
        {
            Console.WriteLine("J is :" + " " + j);
            j = 100;
            Console.WriteLine("J is :" + " " +j);
        }

        public static int add(int x, int y)
        {
            Console.WriteLine("Hello");
            return x + y;
        }


        //out parameters example
        public static int Calculator(int a, int b, out int subtract, out int product, out int divide )
        {
            subtract = a - b;
            product = a * b;
            divide = a / b;
            return a + b;
        }

        //params example 1:
        public static int AddElements(params int [] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        //params 2.
        public static void ParamMethod(params int[] arr1)
        {
            Console.WriteLine("There are {0} elements in the array",arr1.Length);
            
            for(int i=0; i<arr1.Length;i++)
            {
                //arr1[i] += 5;
                Console.WriteLine(arr1[i]);
            }
            arr1[1] = 50;
        }
        static void Main(string[] args)
        {
            //int i = 10;
            //CallbyValueMethod(i);
            //Console.WriteLine("The value of i is :" + " " +i);
            //CallbyRefMethod(ref i);
            //Console.WriteLine("The value of i is :" + " " + i);
            //int sum, prod, difference, division;
            //sum = Calculator(20, 10, out difference, out prod, out division);
            //Console.WriteLine($"Sum is {sum}, difference is {difference}, Product is {prod} and Division is {division}");
            //int total = AddElements(512, 720, 250, 567, 889);
            //Console.WriteLine("The sum of all the params value is :{0}",total );
            int[] num = new int[3];
            num[0] = 10;
            num[1] = 20;
            num[2] = 30;
           // ParamMethod(); //0 arguments
            ParamMethod(num); //passing an array
            Console.WriteLine("The changes made by the function");
            for(int x=0;x<num.Length;x++)
            {
                Console.WriteLine(num[x]);
            }
          //  ParamMethod(1, 2, 3, 4, 5, 6, 7, 8, 9); // comma seperated values
            Console.Read();
        }
    }
}
