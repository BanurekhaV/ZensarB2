using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDay13
{
    class Account
    {
       public double Amount { get; set; }
        public Account(double amt)
        {
            Amount = amt;
        }
    }
    class TasksEg
    {
        static void Main()
        {
            var account = new Account(1000);
            Console.WriteLine(account.Amount);
            var tasks = new Task[50];
            for(int i=0;i<tasks.Length;i++)
            {
                tasks[i] = Task.Run(() => RandomlyUpdate(account));
            }
            Task.WaitAll(tasks);
            Console.WriteLine(account.Amount);
            Console.Read();
        }

        static void RandomlyUpdate(Account account)
        {
            var rnd = new Random();
            for(int i=0; i<10; i++)
            {
                var amt = rnd.Next(1, 100);
                bool docredit = rnd.NextDouble() < 0.5; //any number <0.5 will store a value of true in docredit
                if(docredit)                             //else false in docredit
                {
                    account.Amount += amt;
                }
                else
                {
                    account.Amount -= amt;
                }
            }
        }
    }
}
