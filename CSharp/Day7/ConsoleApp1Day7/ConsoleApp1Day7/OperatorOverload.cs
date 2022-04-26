using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Day7
{
    class Distance
    {
        int dist;
        float time;

        public int _Dist
        {
            get { return dist; }
            set { dist = value; }
        }

        //overload the + operator
        public static Distance operator +(Distance d1, Distance d2)
        {
            Distance temp = new Distance();
            temp.dist = d1.dist + d2.dist;
            return temp;
        }

    }
    class OperatorOverload
    { 
        static void Main()
        {
            Distance d1 = new Distance();
            Distance d2 = new Distance();
            d1._Dist = 10;
            d2._Dist = 20;
            int a = 5, b = 10, c;
            c = a + b;
            Distance d3 = d1 + d2;
            Console.WriteLine("The total distance is {0}", d3._Dist);
            Console.ReadLine();
        }
    }
}
