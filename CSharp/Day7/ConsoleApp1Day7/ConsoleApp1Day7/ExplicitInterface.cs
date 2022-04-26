using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day7
{
    interface I1
    {
         string _Name { get; set; }
        void InterfaceMethod();        
    }
    interface I2
    {
        void InterfaceMethod();
    }
    class ExplicitInterface : I1,I2
    {
        private string companyname;

        public string _Name
        {
            get { return companyname; }
            set { companyname = value; }
        }
        void I1.InterfaceMethod()
        {
            companyname = "Zensar";
            Console.WriteLine("I1 interfaces method implementation");
            Console.WriteLine(companyname);
        }
         void I2.InterfaceMethod()  //making this method a default by addng public and rmoving the interface qaulifier
        {
            companyname = "New Zensar";
            Console.WriteLine("I2 interfaces method implementation");
            Console.WriteLine(companyname);
        }

        static void Main()
        {
            ExplicitInterface EI = new ExplicitInterface();
            //EI.  - will not be able to invoke any methods that are explicitly implemented
            //in order to invoke we can either use interface reference variables or interface objects
            //pointing to child class -covariance
           // EI._Name = "Zenasar";
            Console.WriteLine("----Using Interfae Reference Variable-------");
            ((I1)EI).InterfaceMethod(); //interface reference variable
            ((I2)EI).InterfaceMethod();
            Console.WriteLine("-------Using Default Function------");
           // EI.InterfaceMethod();
            //other way to invoke the method is
            Console.WriteLine("-------Using Interface Object-------");
            I1 i1 = new ExplicitInterface();
            I2 i2 = new ExplicitInterface();
            i1.InterfaceMethod();
            i2.InterfaceMethod();
            Console.Read();
        }
    }
}
