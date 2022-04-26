using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day7
{
     abstract class Shapes   //base class
    {
        public abstract float Area();  //abstract method
        
        public void Test()  //non-abstract method
        {
            Console.WriteLine("Test Method of Shapes Class");
        }
        public virtual string SampleMethod(string s)
        {
            return "Hello" + " " + s;
        }
    }

    class Square : Shapes
    {
        int side = 0;

       public Square(int n)
        {
            side = n;
        }
        public override float Area()
        {
            return side * side;
        }
        public override string SampleMethod(string s)
        {
            Console.WriteLine(base.SampleMethod(s)); 
            Console.WriteLine("This is the SampleMethod of Square Class");
            return "Square";
        }
    }
    class AbstractEg
    {
        static void Main()
        {
            Shapes shapes;
            shapes = new Square(6); //covariance;
            Console.WriteLine(shapes.Area());
            Console.WriteLine(shapes.SampleMethod("Batch"));
            Console.Read();
        }
    }
}
