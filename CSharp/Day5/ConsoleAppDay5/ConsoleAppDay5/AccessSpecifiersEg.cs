using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
   public class AccessSpecifiersEg
    {
        private string code="Code";
        public string name="Name";
        internal string address="Address";
        protected string phone="123456789";
         protected internal string city ="Chennai";

        public void show()
        {
            Console.WriteLine($"{code},{name},{address},{phone},{city}");
        }
    }

    class TestClass : AccessSpecifiersEg
    {
        static void Main()
        {
            AccessSpecifiersEg access = new AccessSpecifiersEg();
            access.show();
            access.name = "Zensar";
            access.address = "Pune";
          //  access.city = "Hyderabad";           
            access.show();
            //accessing fields thru child class object

            TestClass testclass = new TestClass();
            testclass.name = "Rishikesh";
            testclass.phone = "999999999999";
            testclass.address = "Maharashtra";
            testclass.city = "Mycity";
            Console.Read();
        }
    }

    class sample : TestClass
    {
        public void testaccess()
        {
            AccessSpecifiersEg eg = new AccessSpecifiersEg();
           
        }
    }
}
