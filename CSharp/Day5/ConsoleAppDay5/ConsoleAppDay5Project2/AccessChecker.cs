using System;

using ConsoleAppDay5;

namespace ConsoleAppDay5Project2
{
    class AccessChecker : AccessSpecifiersEg
    {
        static AccessChecker accesscheck = new AccessChecker();
        static void Main(string[] args)
        {
            accesscheck.name = "Child";
            accesscheck.city = "Childcity";
            accesscheck.phone = "childphone";
            Console.WriteLine($"{accesscheck.name},{accesscheck.phone}");
        }
    }

    
}
