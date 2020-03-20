using System;

namespace While_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a target value");
            int num = int.Parse(Console.ReadLine());
            int even_num = 0;
            while(even_num <= num)
            {
                if(even_num%2==0)
                {
                    Console.Write("{0}  ", even_num);                  
                }
                even_num ++;
            }
        }
    }
}
