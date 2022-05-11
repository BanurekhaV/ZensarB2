using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using MainProject_NUNIT;

namespace UnitTest_MSTEST_Project1
{
    [TestClass]
    public class UnitTest1
    {
        [AssemblyInitialize]

        public static void beforeAssembly(TestContext tc)
        {
            Console.WriteLine("Before Assembly");
        }
        [ClassInitialize]

        public static void Beforeclass(TestContext tc)
        {
            Console.WriteLine("This is before the class");
        }

        
        [TestInitialize]

        public void BeforeAllTestMethods()
        {
            Console.WriteLine("Before every Test Method");
        }

        [TestCleanup]

        public void AfterAllTestMethods()
        {
            Console.WriteLine("After every test method");
        }

        [ClassCleanup]

        public static void AfterClass()
        {
            Console.WriteLine("After the class");
        }

        [AssemblyCleanup]

        public static void afterAssembly()
        {
            Console.WriteLine("After Assembly");
        }
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine("This is Test Method 1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("This is Method 2");
        }

        [TestMethod]

        public void TestMethod3()
        {
            Console.WriteLine("This is Method 3");
        }

        [TestMethod]
        public void GetNames()
        {
            //arrange
            Employee e = new Employee();
            string fname = "Geetha";
            string lname = "Kumari";
            string expected = "GeethaKumari";
            string actual;

            //act
            actual = e.GetName(fname, lname);
            //assert
            Assert.AreEqual(expected, actual);

        }
    }
}
