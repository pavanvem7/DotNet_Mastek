using System;

namespace If_Else_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Example1
            Console.WriteLine("Enter any number ");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Number = 1");
            }
            else if (num == 2)
            {
                Console.WriteLine("Number = 2");
            }
            else if (num == 3)
            {
                Console.WriteLine("Number = 3");
            }
            else
            {
                Console.WriteLine("Number is not between 1 and 3 ");
            }

            //Example2
            Console.WriteLine("Enter num1 ");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter num2 ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == 5 || num2 == 8)
            {
                Console.WriteLine("Number is 5 or 8");
            }
            else
            {
                Console.WriteLine("Number is neither 5 nor 8");
            }
            if (num1 == 4 && num2 == 10)
            {
                Console.WriteLine("Numbers are 4 and 10");
            }
        }
    }
}
