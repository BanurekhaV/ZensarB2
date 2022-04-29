using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ConsoleAppDay10
{
    class MultithreadEg
    {
        static void Main()
        {
            Console.WriteLine("Main Thread Started...");
            //create many threads to handle various functions

            Thread t1 = new Thread(Method1)
            {
                Name = "Thread1"
            };

            Thread t2 = new Thread(Method2)
            {
                Name = "Thread2"
            };
            Thread t3 = new Thread(Method3)
            {
                Name = "Thread3"
            };

            //execute the threads
            t1.Start();
            t2.Start();
            t3.Start();
            Console.WriteLine("Main Thread Ended");
            Console.Read();
        }

        static void Method1()
        {
            Console.WriteLine($"Thread : {Thread.CurrentThread.Name} started...");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 1 :" + " " + i);
            }
            Console.WriteLine($"Thread : {Thread.CurrentThread.Name} ended...");
        }

        static void Method2()
        {
            Console.WriteLine($"Thread : {Thread.CurrentThread.Name} started...");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 2 :" + " " + i);
                if (i == 3)
                {
                    Console.WriteLine("Starting to perform Database Operations...");
                    Thread.Sleep(10000);  //10 seconds
                    Console.WriteLine("Database operation completed");
                }
                Console.WriteLine($"Thread : {Thread.CurrentThread.Name} ended...");
            }
        }
        static void Method3()
        {
            Console.WriteLine($"Thread : {Thread.CurrentThread.Name} started...");
            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine("Method 3 :" + " " + i);
            }
            Console.WriteLine($"Thread : {Thread.CurrentThread.Name} ended...");
        }
    }
}
