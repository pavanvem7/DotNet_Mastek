using System;

namespace Switch_statement
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_rate = 0;
            Console.WriteLine("Welcome to Caffe Shop!");
            Start:
            Console.WriteLine("Please select your coffee size - 1-small, 2-medium, 3-large");
            int coffee_size = int.Parse(Console.ReadLine());
            
            switch (coffee_size)
            {
                case 1:
                    total_rate += 100;
                    break;
                case 2:
                    total_rate += 150;
                    break;
                case 3:
                    total_rate += 200;
                    break;
                default:
                    Console.WriteLine("Please enter valid coffee size ");
                    goto Start;
            }
            Choice:
            Console.WriteLine("Anything else - Yes or no");
            string choice = Console.ReadLine();

            switch(choice.ToUpper())
            {
                case "YES":
                    goto Start;
                case "NO":
                    break;
                default:
                    Console.WriteLine("Please select valid choice");
                    goto Choice;
            }
            
            Console.WriteLine("Your bill amount is {0} ", total_rate);
            Console.WriteLine("Thank You For Shopping! Visit Again!");
        }
    }
}
