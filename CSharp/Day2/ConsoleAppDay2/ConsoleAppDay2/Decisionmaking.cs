using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay2
{
    class Loops
    {
        public void ForLoop()
        {
            int total = 0;
            int i = 1;
            for (; i <= 5; i++)
            {
                if (i == 3)
                    //continue;
                    break;
                Console.WriteLine("For Loop Value {0}", i);
                total += i; // total=total+i
            }
            Console.WriteLine("The Sum of the numbers is :{0}",total);
           // staticForLoop(); //calling static function within the class without the classname
        }

        public static void staticForLoop()
        {
            //multiple initialization and iterations
            for(int i=0,j=0;i+j<=5;i++,j++)
            {
                Console.WriteLine("i = {0} and j = {1}",i,j);
            }
        }

        public void WhileLoop()
        {
            int i = 0;
            while(i<5)
            {
                Console.WriteLine(i);
                i++;
            }

        }

        public void DoWhileLoop()
        {
            int i = 0;
            do
            {
                Console.WriteLine(i);
                i++;
            } while (i < 5);
        }
    }
    class Decisionmaking
    {
        public void checkGrade()
        {
            char grade;
            Console.WriteLine("Enter Grade :");
            grade =Convert.ToChar(Console.ReadLine());
            if(grade=='A')
                Console.WriteLine("Outstanding");
             else if(grade=='B')
                Console.WriteLine("Excellent");
            else if (grade == 'C')
                Console.WriteLine("Very Good");
            else if (grade == 'D')
                Console.WriteLine("Fair");
            else if (grade == 'E')
                Console.WriteLine("Fail");
            else
                Console.WriteLine("Invalid Grade");
        }
    }
   
    class secondclass
    {
        public void GradewithSwitch()
        {
            char grade;
            Console.WriteLine("Enter Grade :");
            grade = Convert.ToChar(Console.ReadLine());
            switch(grade)
            {
                case 'A':
                    Console.WriteLine("Outstanding");
                    break; //will take us to the end of switch case
                case 'B':
                    Console.WriteLine("Excellent");
                    break;
                case 'C':
                    Console.WriteLine("Very Good");
                    break;
                case 'D':
                    Console.WriteLine("Fair");
                    break;
                case 'E':
                    Console.WriteLine("Failure");
                    break;
                default:
                    Console.WriteLine("Invalid Grade");
                    break;
            }

        }
    }
}
