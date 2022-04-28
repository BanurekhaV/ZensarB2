using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    public delegate void prints(string s);

    public class printEg
    {
        static FileStream fs;
        static StreamWriter sw;

        public static void WriteToScreen(string str)
        {
            Console.WriteLine("The string is {0}", str);
        }

        public static void WriteToFile(string str)
        {
            fs = new FileStream("message.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
            sw.WriteLine(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        //passing delegate object as an argument/parameter to a function
        public static void sendsdata(prints ps)
        {
            ps("This is  a class on delegates");
        }

    }

    class Delegate3
    {
        static void Main()
        {
            prints ps1 = new prints(printEg.WriteToScreen);
            prints ps2 = new prints(printEg.WriteToFile);
            //ps1("This is write to screen");
           // ps2("This is writing data to a file");

            printEg.sendsdata(ps1);
            printEg.sendsdata(ps2);
            Console.Read();
        }
    }
}
