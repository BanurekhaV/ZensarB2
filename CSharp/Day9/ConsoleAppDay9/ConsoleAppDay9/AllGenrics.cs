using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay9
{
    //generic class
    class MyGenericClass<T>
    {
        //generic field
        private T genericMemberField;

        //generic constructor
        public MyGenericClass(T value)
        {
            genericMemberField = value;
        }

        //generic method

        public T genericMethod(T genericParameter)
        {
            Console.WriteLine("Parameter Type : {0}, value : {1}", typeof(T).ToString(),genericParameter );
            Console.WriteLine("Return Type : {0}, value : {1}",typeof(T).ToString(), genericMemberField);
            return genericMemberField;
        }

        //generic property

        public T genericProperty { get; set; }
    }
    class AllGenrics
    {
        static void Main(string[] args)
        {
            MyGenericClass<int> intgeneric = new MyGenericClass<int>(10);
            int res=intgeneric.genericMethod(200);
            Console.WriteLine(res);
            MyGenericClass<string> strgeneric = new MyGenericClass<string>("Hello Generics");

            strgeneric.genericMethod("Generics with String template");
            Console.Read();

        }
    }
}
