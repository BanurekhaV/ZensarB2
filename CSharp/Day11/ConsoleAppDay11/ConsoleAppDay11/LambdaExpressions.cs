using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay11
{
    class LambdaExpressions
    {
        static void Main()
        {
            //list to store numbers
            List<int> numbers = new List<int>() { 71, 12, 15, 29, 18, 27, 17, 9, 34, 36 };


            //display the elements inside the list
            //foreach(var v in numbers)
            //{
            //    Console.WriteLine("{0}",v);
            //}

            //to calculate the square of each value in the list

            var square = numbers.Select(x => x * x);  //lambda expressions

            //Console.WriteLine("Squares of all nos. in the list is ");
            //foreach (int x in square)
            //{
            //    Console.WriteLine("{0}", x);
            //}

            //lambda expression to find all the nos divisible by 3 in the list
            List<int> divby3 = numbers.FindAll(a => (a % 3) == 0);

            
            //Console.WriteLine("List of nos divisible by 3");
            //foreach(var x in divby3)
            //{
            //    Console.WriteLine(x);
            //}

            ////the below lambda will find any first number that is divisible by 3
            //var by3 = numbers.Find(x => x % 3 == 0);
            //Console.WriteLine(by3);

            //let us work with list of objects to find a particular student

            Student student = new Student();
            Student matchedstudnet = student.GetStudents().Find(s => s.ID == 103);

            Console.WriteLine(matchedstudnet.ID + matchedstudnet.Name + matchedstudnet.Email);

            //to sort the students list on the basis of name
            var sortedstudentslist = student.GetStudents().OrderBy(x => x.Name);

            foreach(var v in sortedstudentslist)
            {
                Console.WriteLine(v.ID + " " + v.Name + " "+ v.Email);
            }
            Console.Read();
        }
    }
}
