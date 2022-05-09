using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public sealed class SingletonEg2
    {
        private static int counter = 0;
        private static SingletonEg2 _single = null;

        //returning the only one object thru a property
        public static SingletonEg2 GetInstance
        {
            get
            {
                if (_single == null)
                    _single = new SingletonEg2();
                return _single;
            }
        }

        private SingletonEg2()
        {
            counter++;
            Console.WriteLine("Counter Value is :" + " " + counter.ToString());
        }

        public void ShowDetails(string s)
        {
            Console.WriteLine(s);
        }
    }
}
