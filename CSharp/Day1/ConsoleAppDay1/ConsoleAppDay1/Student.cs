using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay1
{
    class Student
    {
        //Fields Declaration
        int RollNo;
        string Name;
        float Marks;

        //Function declaration and definition
        public void getDetails()
        {
            Console.WriteLine("Enter Roll No :");
            RollNo =int.Parse(Console.ReadLine()); // one way to convert string into int
            //  RollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Marks :");
            Marks = float.Parse(Console.ReadLine());
            //Marks=Convert.ToSingle(Console.ReadLIne());
        }

        public void DisplayDetails()
        {
            Console.WriteLine($"Student Named {Name} with RollNo {RollNo} has secured {Marks} marks");
        }
    }
}
