using System;

namespace Do_while_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            int odd_num = 1;
            do
            {
                Console.WriteLine("Enter your target");
                int target = int.Parse(Console.ReadLine());
                while (odd_num <= target)
                {
                    Console.Write("{0}   ", odd_num);
                    odd_num += 2;
                }
                do
                {
                    Console.WriteLine("Do you want to continue- Yes or No");
                    choice = Console.ReadLine().ToUpper();
                    if (choice != "YES" && choice != "NO")
                    {
                        Console.WriteLine("Invalid choice");
                    }
                } while (choice != "YES" && choice != "NO");
            } while (choice == "YES");          
        }
    }
}
