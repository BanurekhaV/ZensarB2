using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay11
{
    class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        public  List<Student> GetStudents()
        {
            List<Student> studlist = new List<Student>();
            Student s1 = new Student { ID = 101, Name = "Supriya", Email = "supriya@gmail.com" };
            Student s2 = new Student { ID = 102, Name = "Suraj", Email = "suraj@outlook.com" };
            Student s3 = new Student { ID = 103, Name = "Ramya", Email = "ramya@gmail.com" };
            Student s4 = new Student { ID = 104, Name = "RaviShankar", Email = "ravi@hotmail.com" };
            studlist.Add(s1);
            studlist.Add(s2);
            studlist.Add(s3);
            studlist.Add(s4);
            //  studlist.Add(new Student { ID = 105, Name = "Roshan", Email = "roshan@gmail.com" });
            return studlist;
        }
    }
    class QueryExpressions
    {
        static void Main()
        {
            int[] intval = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }; //array 

            //query expressions to find all odd nos from the array
            IEnumerable<int> Oddvalues = from val in intval
                                         where (val % 2) != 0
                                         select val;

            //query expressions to find all even nos from the array
            var evennos = from e in intval
                          where (e % 2) == 0
                          select e;

            //IQueryable<int> queryoutput = (IQueryable<int>)(from n in intval
            //                              where (n % 3) == 0
            //                              select n);

            //iterate the fetched results of odd nos.
            foreach(int v in Oddvalues)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("-----------");
            //iterate the fetched results of even nos.
            foreach (var v in evennos)
            {
                Console.WriteLine(v);
            }
            //Console.WriteLine("----------");
            ////iterate the fetched results of nos. divisible by 3
            //foreach (int v in queryoutput)
            //{
            //    Console.WriteLine(v);
            //}

            //working with list objects in query expressions
            //query the list collection and find out all students whose names start with S/R
            Student stud1 = new Student();
            IEnumerable<string> studnames = from stud in stud1.GetStudents()
                                            where stud.Name.Contains("S")
                                            select stud.Name;

            IEnumerable<Student> st = from s in stud1.GetStudents()
                                      where s.ID == 103
                                      select s;

            foreach (var v in studnames)
            {
                Console.WriteLine(v);
            }

            foreach(Student s in st)
            {
                Console.WriteLine($"The Id :{s.ID}, Name : {s.Name} and Email :{s.Email}");
            }
            Console.Read();      
        }
    }
}
