using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class SingleTonObject
    {
        //create static object of the class and creating it through a private constructor
        private static SingleTonObject sobj = new SingleTonObject();

        //private constructor
        private SingleTonObject() { }

        //Method to retrieve the one and only object of the class
        public static SingleTonObject getObject()
        {
            return sobj;
        }

        public void DisplayObject()
        {
            Console.WriteLine("Hi.. This is a SingleTon Object");
        }
    }
        
    class Program
    {
        static void Main(string[] args)
        {
            //Geting a singleton class object hrough the method of the class and not the constructor
            SingleTonObject s = SingleTonObject.getObject();
                s.DisplayObject();
            SingletonEg2 s2 = SingletonEg2.GetInstance;
            s2.ShowDetails("Client 1");
            SingletonEg2 s3 = SingletonEg2.GetInstance;
            s3.ShowDetails("Client 2");
                Console.Read();
        }
    }
}
