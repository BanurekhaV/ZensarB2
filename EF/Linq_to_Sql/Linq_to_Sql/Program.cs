using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_to_Sql
{
    class Program
    {
        static void Main(string[] args)
        {
            Northwind1DataContext dbc = new Northwind1DataContext();
            var regiondata = dbc.Regions.ToList();

            var expprd = dbc.Ten_Most_Expensive_Products();

            foreach(var r in regiondata)
            {
                Console.WriteLine($"{r.RegionID}, {r.RegionDescription}");
            }
            Console.WriteLine("-------------------------");

            foreach(var v in expprd)
            {
                Console.WriteLine(v.TenMostExpensiveProducts + "  " + v.UnitPrice);
            }
            Console.Read();

        }
    }
}
