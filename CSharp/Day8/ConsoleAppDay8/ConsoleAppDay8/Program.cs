using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    class MyIndexer
    {
       private string[] name = new string[3]; //array field of size 3

        public string this[int flag]  //index positon
        {
            get { 
              //  string temp = name[flag];
                return name[flag]; 
            }
            set
            {
                name[flag] = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyIndexer mi = new MyIndexer();
            mi[0] = "Hello";
            mi[1] = "All";
            mi[2] = "Welcome to Indexers";
            Console.WriteLine($"The elements of the indexer are :{mi[0]}, {mi[1]}, {mi[2]}");
            Console.Read();
        }
    }
}
