using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public interface Shape
    {
        void draw();
    }

    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Rectangle");
        }

    }
    class Triangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Triangle");
        }
    }
    class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Drawing Square");
        }
    }

    public class ShapeFactory
    {
        public Shape getShape(string shapetype)
        {
            if(shapetype.Equals("Rectangle"))
            {
                return new Rectangle();
            }
            else if(shapetype.Equals("Square"))
            {
                return new Square();
            }
            else if(shapetype.Equals("Triangle"))
            {
                return new Triangle();
            }
            else
                return null;
        }
    }
    class FactoryPattern
    {
        static void Main()
        {
            ShapeFactory sf = new ShapeFactory();
            Shape s = sf.getShape("Rectangle");
            s.draw();
            s = sf.getShape("Triangle");
            s.draw();
            s = sf.getShape("Square");
            s.draw();
            Console.Read();
        }
    }
}
