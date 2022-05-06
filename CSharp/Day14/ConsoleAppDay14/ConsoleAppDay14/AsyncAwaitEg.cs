using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Console;
using static System.Convert;

namespace ConsoleAppDay14
{
    class AsyncAwaitEg
    {
        public static void Main()
        {
            FileRead fr = new FileRead();
            WriteLine("Fileread object created..");
            fr.filereadoperation();

            int x = ToInt32(ReadLine());
            WriteLine(x);
            Read();
        }
    }

    class FileRead
    {
        public async void filereadoperation()
        {
            try
            {
                StreamReader sr = File.OpenText(@"E:\Banu\Zensar\Batch 2\firstgitdata.txt");
                WriteLine($"The first line of the file is : {sr.ReadLine()}");
                sr.Close();
            }
            catch { await FileNotFound(); }
            finally { await ExitProgram(); }
        }
        async Task FileNotFound()
        {
            WriteLine("Specified File not found.. Please check the name and location");
        }
        async Task ExitProgram()
        {
            WriteLine("\n Press any key to exit");
        }
    }
}
