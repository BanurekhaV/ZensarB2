using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestingProject_Nunit;

namespace AccountTester
{
    [TestFixture]
    public class TestAccount
    {
        
        Accounts acc;

        [SetUp]
        public void SetupObjects()
        {
            //arrange
            acc = new Accounts("12345");
        }

        [Test]
        public void TestingDepositMethod()
        {
            //act
            acc.Deposit(1000);

            //assert
            Assert.AreEqual(1000, acc.CheckBalance());
        }

        [Test]
        public void TestingDeposit_ifbalance_is_changed_should_fail()
        {
            acc.accountbalance = 2000;
            acc.Deposit(1000);
            Assert.LessOrEqual(acc.CheckBalance(),4000);
        }
        public void TestingWithdrawMethod()
        {
            acc.Withdraw(100);
        }

        [Test]
        public void Withdraw_should_throw_exception()
        {
            Assert.Throws<Exception>(TestingWithdrawMethod);
        }
    }
}
