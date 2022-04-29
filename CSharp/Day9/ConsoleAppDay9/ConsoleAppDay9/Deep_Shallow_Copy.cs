using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay9
{
    class Person
    {
        public int Age;
        public PersonDescription desc; //composition (complex object)

        public Person(int a, string fn, string ln)
        {
            Age = a;
            desc = new PersonDescription(fn, ln);
        }

        public object ShallowCopy()
        {
            return this.MemberwiseClone();
        }

        public Person DeepCopy()
        {
            Person dcopy = new Person(this.Age, desc.Fname, desc.Lname);
            return dcopy;
        }
    }

    class PersonDescription
    {
        public string Fname;
        public string Lname;

        public PersonDescription(string f, string l)
        {
            Fname = f;
            Lname = l;
        }
    }
    class Deep_Shallow_Copy
    {
        static void Main()
        {
            Person p1 = new Person(40, "Steve", "Jobbs");
            Person p2 = (Person)p1.ShallowCopy();
            Console.WriteLine(p1.Age + " " + p1.desc.Fname+" "+p2.desc.Fname);
            p2.desc.Fname = "Henry";
            Console.WriteLine($"p1s fname is {p1.desc.Fname}");
            Console.WriteLine($"p2s fname is {p2.desc.Fname}");

            Person p3 = p1.DeepCopy();
            Console.WriteLine($"p3 data  is :{p3.Age}, {p3.desc.Lname},{p3.desc.Fname}");
            Console.WriteLine($"p1 data is : {p1.Age}, {p1.desc.Lname},{p1.desc.Fname}");
            p3.desc.Fname = "Robert";
            Console.WriteLine("--------------");
            Console.WriteLine($"p3 data  is :{p3.Age}, {p3.desc.Lname},{p3.desc.Fname}");
            Console.WriteLine($"p1 data is : {p1.Age}, {p1.desc.Lname},{p1.desc.Fname}");
            Console.WriteLine("-------------");
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p3.GetHashCode());

            //if we equate 2 objects then
            p2 = p1;
            Console.WriteLine(p1.GetHashCode());
            Console.WriteLine(p2.GetHashCode());
            Console.Read();
        }
    }
}
