using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Linq_to_Sql_Sqlmetal.DAL;

namespace Linq_to_Sql_Sqlmetal
{
    class Program
    {
        static void Main(string[] args)
        {
            NorthwindContext dbc = new NorthwindContext();
            var regiondata = dbc.Region.ToList();

            var expprd = dbc.Ten_Most_Expensive_Products();

            foreach (var r in regiondata)
            {
                Console.WriteLine($"{r.RegionID}, {r.RegionDescription}");
            }
            Console.WriteLine("-------------------------");

            foreach (var v in expprd)
            {
                Console.WriteLine(v.TenMostExpensiveProducts + "  " + v.UnitPrice);
            }
            Console.Read();

        }
    }
}
