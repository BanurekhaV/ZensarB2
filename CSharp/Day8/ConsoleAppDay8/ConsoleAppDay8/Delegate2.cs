using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay8
{
    delegate int NumberChange(int n);
    class Delegate2
    {
        static int num = 10;
        public static int AddNum(int p)
        {
            num += p;
            return num;
        }

        public static int MultiplyNum(int q)
        {
            num *= q;
            return num;
        }
        public static int getNum()
        {
            return num;
        }

        static void Main()
        {
            //create delegate instances 
            NumberChange nc1 = new NumberChange(AddNum);
            NumberChange nc2 = new NumberChange(MultiplyNum);
            //calling the methods using the delegate objects
            Console.WriteLine("Value of Num before delegate call : {0}", getNum());
            nc1(25);
            Console.WriteLine("Value of Num after delegate nc1 call : {0}", getNum());
            nc2.Invoke(5);
            Console.WriteLine("Value of Num after delegate nc2 call : {0}", getNum());
            Console.Read();
        }
    }
}
