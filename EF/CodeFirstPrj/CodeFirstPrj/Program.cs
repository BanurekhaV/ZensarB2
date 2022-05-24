using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeFirstPrj.Models;

namespace CodeFirstPrj
{
    class Program
    {
        static void Main(string[] args)
        {
            using(var dbc=new AccountContext())
            {
                dbc.Customers.Add(new Customer { CustName = "Zensar Technologies" });
                dbc.SaveChanges();
                
                foreach(var cust in dbc.Customers)
                {
                    Console.WriteLine(cust.CustId + " " + cust.CustName);
                }
                Console.Read();
            }
        }
    }
}
