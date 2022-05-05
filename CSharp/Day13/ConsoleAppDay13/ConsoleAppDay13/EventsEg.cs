using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay13
{
    
    class EventClass
    {
       private int value=5;
        //user->event->delegate->functions()
        public delegate void numbermanipulator(int x);
        public event numbermanipulator changenum;

        public virtual void onNumChange(int x)
        {
            Console.WriteLine($"Event Raised ..and the value from {value} is changed to {x}");
        }

        public EventClass(int n)
        {
            this.changenum += new numbermanipulator(this.onNumChange);
            setValue(n);
        }

        public void setValue(int x)
        {
            if(value!=x)
            {
               // value = x;
                //changenum();
                changenum(x);  //event is being raised here that goes in search of the delegate
                value = x;               // the delegate associated with the event is numbermanipulator
            }
            else
            {
                Console.WriteLine("No changes in the value");
            }
        }
    }
    class EventsEg
    {
        static void Main(string[] args)
        {
            EventClass ec = new EventClass(5);
            ec.setValue(10);
            ec.setValue(15);
            ec.setValue(15);
            Console.Read();
        }
    }
}
