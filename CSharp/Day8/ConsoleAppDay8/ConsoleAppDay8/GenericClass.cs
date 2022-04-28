using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    class GenMethod
    {
        //generic method

        public void Display<T>(string msg, T value)
        {
            Console.WriteLine("{0} : {1}", msg, value);
        }
    }
    class GenericClass
    {
        public static void Main()
        {
            GenMethod gm = new GenMethod();
            gm.Display<int>("Integer Value", 5);
            gm.Display<string>("String Value", "I am a string");
            gm.Display<char>("Character Value", 'a');
            Console.Read();

        }
    }
}
