using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelFirstPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            using(Model1Container dbc= new Model1Container())
            {
                //Console.WriteLine("Enter Publisher name:");
                //string pname = Console.ReadLine();

                //var publisher = new Publisher
                //{
                //    PId = 1,
                //    PName = "Culcattu Book House",
                //    Estd = Convert.ToDateTime("12/10/1956"),
                //    BookId = 1
                //};
                //dbc.Publishers.Add(publisher);
                //dbc.SaveChanges();

                var pubquery = from p in dbc.Publishers
                               select p;

                foreach(var v in pubquery)
                {
                    Console.WriteLine($"{v.PId} {v.PName} {v.Estd}");
                }
                Console.Read();
            }
        }
    }
}
