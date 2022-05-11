using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestingProject_Nunit
{
    public class Accounts
    {
        private string accno;
        private float balance;

        public float accountbalance
        {
            set { balance = value; }
        }
        public Accounts(string accno)
        {
            this.accno = accno;
        }

        public float CheckBalance()
        {
            return balance;
        }

        public void Deposit(float amt)
        {
            balance += amt;
        }

        public void Withdraw(float amt)
        {
            if (balance >= amt)
                balance -= amt;
            else
                throw new Exception("Not Enough Funds");
        }
    }
}
