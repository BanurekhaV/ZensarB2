using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay13
{
    public delegate string MyDelegate(string str);
    class EventsEg2
    {
        public event MyDelegate MyEvent;

        public EventsEg2()
        {
            this.MyEvent += new MyDelegate(this.WelcomeUser);
            this.MyEvent += new MyDelegate(this.DisplayName);
        }

        public string WelcomeUser(string username)
        {
            return "Welcome" + " " + username;
        }

        public string DisplayName(string name)
        {
            return name;
        }

        static void Main()
        {
            EventsEg2 ec2 = new EventsEg2();
            Console.WriteLine(ec2.MyEvent("Banurekha"));
            Console.Read();
        }
    }
}
