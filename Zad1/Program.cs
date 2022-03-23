using System;

namespace Zad1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new A(1, 2);
            var b = new B();

            RunTest(a);
            RunTest(b);
        }

        public static void RunTest(A toTestClass)
        {
            Console.WriteLine(toTestClass.Test());
        }
    }
}
