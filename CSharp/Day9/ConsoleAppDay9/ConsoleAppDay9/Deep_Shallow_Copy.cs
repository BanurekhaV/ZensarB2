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
            Console.WriteLine(p1.Age + " " + p1.desc.Fname);
            p2.desc.Fname = "Henry";
            Console.WriteLine(p1.desc.Fname);
            Console.WriteLine(p2.desc.Fname);

            Console.Read();
        }
    }
}
