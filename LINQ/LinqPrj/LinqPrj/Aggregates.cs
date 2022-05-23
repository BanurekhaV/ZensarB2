using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrj
{
    class Aggregates
    {
        static void Main()
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6 }; //{2,3,4,5,6}->{6,4,5,6}->{24,5,6}->{120,6}
            Console.WriteLine("Average of numbers : {0}",numbers.Average());
            Console.WriteLine("Sum of numbers :{0}",numbers.Sum());
            Console.WriteLine("Maximum of the numbers :{0}",numbers.Max());
            Console.WriteLine("Count of elements :{0}",numbers.Count());

            //Aggregate : preforms a specified operation to each element in a collection,
            //while carrying the result forward

            var result=numbers.Aggregate((a,b)=>a*b);
            Console.WriteLine("Aggegated result after multiplication : {0}", result);
            result = numbers.Aggregate((a, b) => a + b);
            Console.WriteLine("Aggergated value after addition :{0}",result);

            //Aggregate : preforms a specified operation to each element in a collection,
            //while carrying the result forward. Seed sets initial value
            result = numbers.Aggregate(10, (a, b) => a + b);
            Console.WriteLine($"{result} is with a seed value of 10");

            //conversion of collection to list
            string[] names = { "Pamela", "Ben", "John" };
            List<string> lname = names.ToList();
            Console.WriteLine(string.Format("names is of type :{0}", names.GetType().Name));
            Console.WriteLine( string.Format("lname is of type : {0}",lname.GetType().Name));
            Console.Read();
        }
    }
}
