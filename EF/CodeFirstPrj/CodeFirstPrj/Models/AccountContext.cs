using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CodeFirstPrj.Models
{
    class AccountContext : DbContext
    {
        public AccountContext():base("name=AccountContext")
        {

        }

        public DbSet<Account>Accounts { get; set; }
        public DbSet<Customer>Customers { get; set; }
    }
}
