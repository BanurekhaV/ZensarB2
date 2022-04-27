using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    public class Flower
    {
        string name;
        string color;

        public Flower(string name, string color)
        {
            this.name = name;
            this.color = color;
        }

        public void Display()
        {
            Console.WriteLine($"{name} is {color} in color");
        }
    }

    class Flowervase
    {
        Flower[] fobj = new Flower[5];  // array of Flower Objects of size 10

        //create indexer to set and get values of flower thrugh flowervase object
        public Flower this[int pos]
        {
            get { return fobj[pos]; }
            set { fobj[pos] = value; }
        }

        static void Main()
        {
            Flowervase fv = new Flowervase();
            fv[0] = new Flower("Rose", "Red");
            fv[1] = new Flower("Lilly", "White");
            fv[2] = new Flower("Hibiscus", "Pink");

            for(int i=0; i<3;i++)
            {
                fv[i].Display();
            }
            Console.Read();
        }
    }
    class IndexerEg2
    {
    }
}
