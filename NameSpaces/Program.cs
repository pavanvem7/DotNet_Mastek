using System;
using PA = ProjectA;

namespace NameSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            PA.ClassA.PrintA();
        }
    }
}

namespace ProjectA
{
    class ClassA
    {
        public static void PrintA()
        {
            Console.WriteLine("Printed from NameSpace ProjectA");
        }
    }
}
