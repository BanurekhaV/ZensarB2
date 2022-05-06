using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDay14
{
    class AsyncAwaitEg
    {
        public static void Main()
        {
            FileRead fr = new FileRead();
            Console.WriteLine("Fileread object created..");
            fr.filereadoperation();
            Console.Read();
        }
    }

    class FileRead
    {
        public async void filereadoperation()
        {
            try
            {
                StreamReader sr = File.OpenText(@"E:\Banu\Zensar\Batch 2\firstgitdata.txt");
                Console.WriteLine($"The first line of the file is : {sr.ReadLine()}");
                sr.Close();
            }
            catch { await FileNotFound(); }
            finally { await ExitProgram(); }
        }
        async Task FileNotFound()
        {
            Console.WriteLine("Specified File not found.. Please check the name and location");
        }
        async Task ExitProgram()
        {
            Console.WriteLine("\n Press any key to exit");
        }
    }
}
