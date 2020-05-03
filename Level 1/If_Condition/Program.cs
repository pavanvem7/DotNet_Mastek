using System;

namespace If_Condition
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter any number");
            int num = int.Parse(Console.ReadLine());
            if (num == 1)
            {
                Console.WriteLine("Number is one");
            }
            if (num == 2)
            {
                Console.WriteLine("Number is two");
            }
            if (num != 1 && num != 2)
            {
                Console.WriteLine("Number entered is neither one nor two");
            }
        }
    }
}
