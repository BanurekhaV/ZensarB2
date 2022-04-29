using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDay10
{
    class BinaryFileOperations
    {
        //using Binary Reader and Writer classes

        static void WriteBinaryFile()
        {
            using(BinaryWriter writer= new BinaryWriter(File.Open(@"E:\Banu\Zensar\zensarbinary.bin",FileMode.Create)))
            {
                writer.Write("0x8023440");
                writer.Write("This is Binary Writer");
                writer.Write(true);
            }
        }

        static void ReadBinaryFile()
        {
            BinaryReader reader = new BinaryReader(File.Open("E:\\Banu\\Zensar\\zensarbinary.bin", FileMode.Open));
            Console.WriteLine("Data 1 :" + " " + reader.ReadString());
            Console.WriteLine("Data 2 :" + " " + reader.ReadString());
            Console.WriteLine("Data3 :" + " " + reader.ReadBoolean());
        }
        static void Main(string[] args)
        {
            WriteBinaryFile();
            ReadBinaryFile();
            Console.Read();
        }
    }
}
