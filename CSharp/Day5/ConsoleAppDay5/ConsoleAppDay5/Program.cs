using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    class Student
    {
        public int marks;  //to allow access of marks
    }
    class Program
    {
        //to confirm that structures are value types and classes are reference type
        static void Main(string[] args)
        {
            Student s1= new Student(); //or Student s1;
            s1.marks = 67;
            Console.WriteLine(s1.marks);

            Student s2= new Student();
            s2 = s1;  //s1 and s2 are Value types and hence a copy of marks is given to s2
            Console.WriteLine(s2.marks);
            s1.marks = 85;
            Console.WriteLine($"After changes  s1 is :{s1.marks} and s2 is:{s2.marks}" );
            Console.Read();

        }

    }
}
