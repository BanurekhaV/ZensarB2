using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppDay10
{
    class Thread1Eg
    {
        static void Main()
        {
            Thread t = Thread.CurrentThread;
            t.Name = "Main Thread";
            // Console.WriteLine("Current Executing Thread Name is :{0}", t.Name);
            // Console.WriteLine("Current Executing Thread :{0}", Thread.CurrentThread.Name);

            //drawbacks of single threaded application
            Method1();
            Method2();
            Method3();
            Console.Read();
        }

        static void Method1()
        {
            for(int i=1; i<=5;i++)
            {
                Console.WriteLine("Method 1 :" + " " + i);
            }
        }

        static void Method2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 2 :" + " " + i);
                if(i==3)
                {
                    Console.WriteLine("Starting to perform Database Operations...");
                    Thread.Sleep(10000);  //10 seconds
                    Console.WriteLine("Database operation completed");
                }
            }
        }
        static void Method3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 3 :" + " " + i);
            }
        }
    }
}
