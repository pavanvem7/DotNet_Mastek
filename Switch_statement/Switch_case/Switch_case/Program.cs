using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number");
            int num = int.Parse(Console.ReadLine());

            switch(num)
            {
                case 10:
                case 20:
                case 30:
                    Console.WriteLine("Number entered is {0}", num);
                    break;
                default:
                    Console.WriteLine("Number entered is not 10, 20, and 30");
                    break;
            }
        }
    }
}
