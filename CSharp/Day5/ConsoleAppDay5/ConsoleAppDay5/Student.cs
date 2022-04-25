using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay5
{
    class Students
    {
        private string RollNo;
        private string Name;
        private string Class;

        public void GetData()
        {
            Console.WriteLine("Enter Roll No:");
            RollNo = Console.ReadLine();
            Console.WriteLine("Enter Name:");
            Name = Console.ReadLine();
            Console.WriteLine("Enter Class:");
            Class = Console.ReadLine();
        }

        public void PutData()
        {
            Console.WriteLine("Name of the Student" + " " +Name);
            Console.WriteLine("Roll No is  :"+ " "+ RollNo);
            Console.WriteLine("Class is :" + " " + Class);
        }

    }

    class Marks : Students
    {
        protected int[] marks = new int[5];

        public void GetMarks()
        {
            for(int i=0; i<marks.Length;i++)
            {
                Console.Write("Enter Subject {0} Marks :", i + 1);
                marks[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public void PutMarks()
        {
            for (int i = 0; i < marks.Length; i++)
            {
                Console.Write("Marks in Suject {0} is {1} :", i + 1,marks[i]);               
            }
        }
    }

    class Results : Marks
    {
        int TotalMarks = 0;

        public void GetResults()
        {
            for(int i=0; i<marks.Length;i++)
            {
                TotalMarks = TotalMarks + marks[i];
            }
        }

        public void DisplayResults()
        {
            Console.WriteLine("===========Results===========");
            PutData();
            PutMarks();
            Console.WriteLine("Total Marks = "+ " "+ TotalMarks);
        }
    }

    class Multilevel
    {
        static void Main()
        {           
            Results results = new Results();
            results.GetData();
            results.GetMarks();
            results.GetResults();
            results.DisplayResults();
            Console.ReadKey();
        }
    }
}
