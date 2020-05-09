using System;
using System.Collections.Generic;

namespace Sort_List_Simple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 1, 8, 7, 5, 2, 3, 4, 9, 6 };

            Console.WriteLine("Numbers before sorting");
            foreach (int i in numbers)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.Write("\n");
            numbers.Sort();

            Console.WriteLine("Numbers after sorting");
            foreach (int i in numbers)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.Write("\n");
            numbers.Reverse();

            Console.WriteLine("Numbers in descending order");
            foreach (int i in numbers)
            {
                Console.Write(i);
                Console.Write(" ");
            }

            Console.Write("\n\n");
            List<string> alphabets = new List<string>() { "B", "F", "D", "E", "A", "C" };

            Console.WriteLine("Alphabets before sorting");
            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet);
                Console.Write(" ");
            }

            Console.Write("\n");
            alphabets.Sort();

            Console.WriteLine("Alphabets after sorting");
            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet);
                Console.Write(" ");
            }

            Console.Write("\n");
            alphabets.Reverse();

            Console.WriteLine("Alpabets in descending order");
            foreach (string alphabet in alphabets)
            {
                Console.Write(alphabet);
                Console.Write(" ");
            }
        }
    }
}
