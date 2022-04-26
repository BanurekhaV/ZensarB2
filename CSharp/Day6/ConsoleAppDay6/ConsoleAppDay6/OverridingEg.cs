using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6
{
    class Shape   //base class
    {
        protected float R, L, B;

        //this function is calculating the area of circle. It is marked virtual to allow
        //overriding in the derived class
        public virtual float Area()            
        {
            return 3.14f; 
        }
    }

    class Rectangle : Shape
    {
        public void GetLB()
        {
            Console.WriteLine("Enter Length :");
            L = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Breadth :");
            B = Convert.ToSingle(Console.ReadLine());
           // float temp;
            // bool s = float.TryParse(Console.ReadLine(), out temp);
           // B = temp;
        }
        public override float Area()
        {
            return L * B;
        }
    }

    class Circle : Shape
    {
        public void GetRadius()
        {
            Console.WriteLine("Enter Radius :");
            R = float.Parse(Console.ReadLine());
        }
        public override float Area()
        {
            Console.WriteLine(base.Area()); 
            return 3.14f * R * R;
           // return base.Area();
        }
    }
    class OverridingEg
    {
        static void Main()
        {
            Rectangle r = new Rectangle();
            r.GetLB();  
            Console.WriteLine("Area of Rectangle is {0}", r.Area());
            Circle c = new Circle();
            c.GetRadius();
            Console.WriteLine("Area of Circle is {0}", c.Area());
                      
            Console.Read();
        }
    }
}
