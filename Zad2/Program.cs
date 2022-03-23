using System;

namespace Zad2
{
    class Program
    {
        static void Main(string[] args)
        {
            StringChecker stringChecker = new StringChecker();
            Console.Write(stringChecker.IsStringValid().ToString());
        }
    }
}