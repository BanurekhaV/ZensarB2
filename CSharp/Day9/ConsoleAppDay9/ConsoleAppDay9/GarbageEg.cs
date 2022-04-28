using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay9
{
    class GarbageEg
    {
        static void Main()
        {
            GarbageEg gobj = new GarbageEg();
           
            Console.WriteLine("The number of generations are :" + " " + GC.MaxGeneration);
            Console.WriteLine("The generation number of the object is :" + GC.GetGeneration(gobj));
            Console.WriteLine("The total Memory :" + " "+GC.GetTotalMemory(false));
            Console.Read();
        }
    }
}
