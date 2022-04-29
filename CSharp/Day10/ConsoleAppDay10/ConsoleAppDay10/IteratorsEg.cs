using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay10
{
    class IteratorsEg
    {
        static void Main()
        {
            List<string> Months = new List<string>() 
            {"Jan",
            "Feb","Mar","Apr","May","June","July","Aug","Aug",
            "Sept","Oct","Nov","Dec"
            };
            foreach(string s in Months)
            {
                Console.WriteLine(s);
            }

            IEnumerable<string> ienumerableofstring = Months;
            foreach(string s in ienumerableofstring)
            {
                Console.WriteLine(s);
            }

            IEnumerator<string> ienumeratorofstring = Months.GetEnumerator();

            while(ienumeratorofstring.MoveNext())
            {
                Console.WriteLine(ienumeratorofstring.Current);
            }
            Console.Read();
        }
    }
}
