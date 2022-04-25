using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay6
{
    class ParseEg
    {
        static void Main()
        {
            int i = 100;
            float f = i;
            f = 12345487657.457f;
              i = (int)f; //explicit typecast and hence there is data loss
            //i = int.Parse(f); cannot pass variables to parse function as it expects only string
            //i = Convert.ToInt32(f); //conversion function
          //  Console.WriteLine(i);

            string str = "500eggs";
            //  i = int.Parse(str);
            // Console.WriteLine(i); // the above will throw an exception while trying to parse, since
            //the value is a proper string

            //to avoid exception we can use a tryParse()
            int result = 0;
            bool status = int.TryParse(str, out result);
            if(status)   //if boolean true
            {
                Console.WriteLine("Successfull" + " " + result);
            }
            else
                Console.WriteLine("Invalid Data");
            Console.Read();
        }
    }
}
