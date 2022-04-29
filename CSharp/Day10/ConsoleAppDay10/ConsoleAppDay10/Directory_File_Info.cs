using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleAppDay10
{
    class Directory_File_Info
    {
        static void Main()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"E:\Zensar\NewDir");
            if (dirinfo.Exists)
            {
                Console.WriteLine("Directory already exists");
            }
            else
                dirinfo.Create();
            Console.WriteLine("New Directory Created");

            //to get all the subdirectories of a given directory
            DirectoryInfo[] directories = dirinfo.GetDirectories();
            foreach(object dirnames in directories)
            {
                Console.WriteLine(dirnames.ToString());
            }

            //to get all the files in the directory
            FileInfo[] filenames = dirinfo.GetFiles();
            foreach(FileInfo fi in filenames)
            {
                Console.WriteLine("File Name :{0} and Size : {1}", fi.Name,fi.Length );
            }
            Console.Read();
        }
    }
}
