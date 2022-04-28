using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay9
{
    //generic delegate
    public delegate T Trans<T>(T arg);
    //public delegate int Trans(int arg);

     class util
    {
        public static void Transform<T>(T[] values, Trans<T> t )
        {
            for(int i=0; i<values.Length;i++)
            {
                values[i] = t(values[i]);  //values[0]=4->16, values[1]=5->25, values[2]=6->36 t(4)
                                          //values[0]=4.4->                                     t(4.4)
            }
        }
    }
    class GenericDelegate
    {
        static void Main()
        {
            int[] arr = new int[] { 4, 5, 6 };
           // float[] arr = new float[] { 4.4f, 5.5f, 6.6f };
            util.Transform(arr, Square);
          //  util.Transform(farr,Multiply)

            foreach(var i in arr)
            {
                Console.Write(i + " ");
            }
            Console.Read();
        }

        static int Square(int x)
        {
            return x * x;
        }

        static float Square(float x)
        {
            return x * x;
        }
    }
}
