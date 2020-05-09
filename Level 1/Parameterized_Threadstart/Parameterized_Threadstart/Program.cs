using System;
using System.Threading;

namespace Parameterized_Threadstart
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter the target number");
            object target = Console.ReadLine();

            ParameterizedThreadStart parameterizedThreadStart =
                new ParameterizedThreadStart(Number.PrintNumbers);
            Thread T1 = new Thread(parameterizedThreadStart);
            T1.Start(target);
        }
    }

    class Number
    {
        public static void PrintNumbers(object target)
        {
            int number = 0;
            if (int.TryParse(target.ToString(), out number))
            {
                for (int i = 1; i <= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
