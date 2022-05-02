using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay11
{
    class DisposableEg : IDisposable
    {
        public void Dispose()
        {
            Console.WriteLine("Releasing all Resources..");
        }

        public void DoSomething()
        {
            Console.WriteLine("Using Various Resources..");
        }

        public DisposableEg()
        {
            Console.WriteLine("Allocating various Resources...");
        }
        static void Main()
        {
            //eg 1.
            //string multilines = @"This is line no 1.
            //This is line 2 
            //Here is line 3
            // There goes line 4
            //  This is the final and fifth line";

            //using (var reader = new StringReader(multilines))
            //{
            //    string item;
            //    do
            //    {
            //        item = reader.ReadLine();
            //        Console.WriteLine(item);
            //    } while (item != null);
            //}

            ////eg 2
            //using(var sreader= new StreamReader("E:\\Banu\\Zensar\\Batch 2\\firstgitdata.txt") )
            //{
            //    Console.WriteLine(sreader.ReadToEnd());
            //}

            ////eg 3 using try finally which is equivalent to using block with some coding
            //var streader = new StreamReader(@"E:\Banu\Zensar\Batch 2\firstgitdata.txt");
            //try
            //{
            //    Console.WriteLine(streader.ReadToEnd());
            //}
            //finally
            //{
            //    if (streader != null)
            //        streader.Dispose();
            //}

            //eg 4 using IDisposable interface
            using(var dispeg =  new DisposableEg())
            {
                dispeg.DoSomething();
            }

            //declaring Anonymous types

            var myanonymoustype = new
            {
                data1="CSharp",
                data2=2,
                data3=true,
            };
            Console.WriteLine(myanonymoustype.GetType());
            Console.Read();
        }
    }
}
