using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 99, 45, 53, 24, 14, 59 };
            var result = from n in numbers
                         where n > 50
                         orderby n
                         select n.ToString();

            foreach(var item in result)
            {
                Console.WriteLine(item);
            }

            IEnumerable<string> sname = from std in student.GetStudents()
                                        where std.Age >= 20
                                        select std.Name;

            IEnumerable<string> studentname= from std in student.GetStudents()
                                             where std.Name.EndsWith("h")
                                             select std.Name;

           var slist = from std in student.GetStudents()
                        where std.ID == 3
                        select std;

            List<student> studentlist = student.GetStudents();
            var teenAgeStudents = studentlist.Where(s => s.Age > 12 && s.Age < 20)
                                  .ToList<student>();


            foreach (string s in sname)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("-------------");
            foreach (string s in studentname)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine("---------------");
            foreach(var v in slist)
            {
                Console.WriteLine(v.ID + " " +v.Name+ " "+v.Age);
            }
            Console.WriteLine("-----Teenaage students--------");

            foreach(var v in teenAgeStudents)
            {
                Console.WriteLine(v.ID + " " + v.Name + " " + v.Age);
            }
            Console.Read();
        }
    }

    class student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }

        public static List<student> GetStudents()
        {
            List<student> studentlist = new List<student>()
            {
                new student() { ID = 1, Name = "Jagadeesh", Age = 13 },
                new student() { ID = 2, Name = "Monika", Age = 21 },
                new student() { ID = 3, Name = "Brijesh", Age = 18 },
                new student() { ID = 4, Name = "Ram", Age = 20 },
                new student() { ID = 5, Name = "Roma", Age = 15 }
            };
            return studentlist;
        }
    }

}
