using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDay10
{
    class StreamOperations
    {
        FileStream fs;
        string s;
        public void ReadStreamData()
        {
           fs = new FileStream("MyFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            //position the file pointer at the beginning/inbetween/or at the end
            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            //read till the end of the file
            s=sr.ReadLine();
            while(s!=null)
            {
                Console.WriteLine("{0}", s);
                 s = sr.ReadLine();
            }
            sr.Close();
            fs.Close();
        }

        public void WriteStreamData()
        {
             fs = new FileStream("MyFile.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            Console.WriteLine("Enter a string :");
            string str = Console.ReadLine();
            sw.Write(str);
            sw.Flush();
            sw.Close();
            fs.Close();
        }

        static void Main()
        {
            StreamOperations so = new StreamOperations();
            so.WriteStreamData();
            so.ReadStreamData();
            Console.Read();
        }
    }
}
