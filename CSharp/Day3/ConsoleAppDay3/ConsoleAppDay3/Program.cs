using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay3
{
   internal class Program
    {
        static void Main(string[] args)
        {
            int? data = 50;
            int result;
            if(data==null)
            {
                result = 0;
            }
            else
            {
                result =(int) data;
                //or
                result = data.Value;
            }
            Console.WriteLine(result);

            //null coalescing operator ?? (is a ternary operator)
            result = data ?? 0;
            Console.WriteLine(result + "" + "from null coalescing");
            Console.Read();
        }
        
    }

    
}
