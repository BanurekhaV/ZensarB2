using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay2
{
    class Program
    {
         static void Main(string[] args)
        {
            // int age = 32; //local scope
            // string name=null;
            // int ? data = null; //making a primitive type a nullable type
            //// name = "Zensar";
            // Console.WriteLine("Name is {0} and Age is {1}",name,age);
            // StringBuilder sb = new StringBuilder("CSharp");
            // Console.WriteLine("Before appending{0}",sb);
            // sb.Append(".Net");
            // Console.WriteLine("After appending{0}",sb);
            // if(data==null)
            // {
            //     Console.WriteLine("It is a null");
            // }
            // else
            // {
            //     Console.WriteLine("It is not a null");
            // }

            // Decisionmaking dm = new Decisionmaking();
            // dm.checkGrade(); //calls function with if
            // secondclass sc = new secondclass();
            // sc.GradewithSwitch(); //calls function with switch
            int x = 10;
            float f = x; // implicit conversion
            Console.WriteLine(f);
            float fl = 125.654f;
            x = (int)fl; //explicit conversion
            Console.WriteLine(x);

            string s = "c#";
            object obj = s;  //implicit
            x = 100;
            obj = x;  //boxing
            Console.WriteLine(obj);
            x = (int)obj;  //unboxing
            Console.WriteLine(x);
           // Loops loops = new Loops();
          // loops.ForLoop();
           // loops.WhileLoop();
            //loops.DoWhileLoop();
            //Loops.staticForLoop(); // calling static function of other class with the class name
            Console.Read();
        }
    }
}
