using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay12
{
    class DelegateTypes
    {
        static void Main()
        {
           
            //1. func delegate with 0 parameters- anonymous
            //Func<int> getrandomnumber = delegate ()
            //{
            //    Random rnd = new Random();
            //    return rnd.Next(1, 100);
            //};
            //int randomnumber = getrandomnumber();
            //Console.WriteLine(randomnumber);

            //1. with lambda
            Func<int> getrandomnumber2 = () => new Random().Next(1, 100);
            int randomnumber = getrandomnumber2();
            Console.WriteLine(randomnumber);

            //one more example of func delegate with lambda
            //we need to add 2 numbers and return the sum
            Func<int, int, int> sum = (x, y) => x + y;
            int total = sum(20, 20);
            Console.WriteLine(total);

             //func delegate with 1 input
            Func<string, bool> strdel = String.IsNullOrEmpty;
            bool result = strdel("CSharp Delegates"); //making a call thru delegate object to a IsNullOrEmpty function
            //pointed by the delegae
            Console.WriteLine($"String.IsNullOrEmpty returned : {result}");

            //func delegate with 2 inputs
            Func<double, double, double> powerdel = Math.Pow;
            double power = powerdel(2, 3); //call the delegate pointing function
            Console.WriteLine($"2 ^ 3 is : {power}");

            //1. Action Delegates with anonymous
            Action<int> Actiondel = delegate (int i)
            {
                Console.WriteLine(i);
            };

            Actiondel(10);
         
            //2. Action delegate with 2 inputs and a method name
            Action<int, int> adddel = Addition;
            adddel(40, 50);

            //3. Action delegate with anonymous method and 0 parameter
            Action anonymousdel = delegate
            {
                Console.WriteLine("Reached Anonymous Method..");
            };
            anonymousdel();
            //4. Action delegate with lambda
            Action<string> lambdadel = (msg) => Console.WriteLine($"Message from Lambda action: {msg}");
            lambdadel("Hi");

            //5. Action delegate pointing to a method with name
            Action<string> str = Show;
            str("batch");

            //1. Predicate delegates with anonymous method
            Predicate<string> checkifupper = delegate (string s)
            {
                return s.Equals(s.ToUpper());
            };

            bool answer = checkifupper("HELLO");
            Console.WriteLine(answer);

            //2. Predicate delegate with lambda
            Predicate<string> isupper = s => s.Equals(s.ToUpper());
            Console.WriteLine(isupper("WORLD"));

            //3.Predicate delegate poiting to a fucntion with name
            Predicate<string> pdel = string.IsNullOrEmpty;
            Console.WriteLine($"string.IsNullOrEmpty returned :{pdel("Data")}");

            //4.Predicate delegate with anonymous method 
            Predicate<char> chardel = delegate (char c) { return char.IsDigit(c); };
            Console.WriteLine($"Char.IsDigit() returned : {chardel('A')}");
                        
            Console.Read();
        }
        public static void Addition(int n1, int n2)
        {
            Console.WriteLine($"{n1} + { n2} = {(n1 + n2)}");
        }

        public static void Show(string str)
        {
            Console.WriteLine($"Uppercase : {str.ToUpper()}");
        }
    }
    
}
