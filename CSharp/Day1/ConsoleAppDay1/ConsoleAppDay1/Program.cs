using System;


namespace ConsoleAppDay1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Console.WriteLine("Hello All ! Welcome to DotNet Programming");
             Program p = new Program(); //instantiating an object of class Program
             int res = p.add(5, 6); // calling function
             Console.WriteLine(res);
             Console.WriteLine("Enter Your Name :");
             string name = Console.ReadLine();
             Console.WriteLine("Hello {0}, Welcome to CSharp",name); //place holders
             Console.WriteLine("Hello" + " "+ name +" "+ "Welcome to CSharp"); //concatenation
             Console.WriteLine($"Hello {name} welcome to CSharp"); //string interpolation*/
            Student s = new Student();
            s.getDetails();
            s.DisplayDetails();
            Console.Read();
        }

        public int add(int a, int b) // called function
        {
            return a + b;
        }
    }
}
