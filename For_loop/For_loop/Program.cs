using System;

namespace For_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[5];
            Console.WriteLine("Enter any five values");
            for(int i=0 ; i<num.Length ; i++)
            {
                num[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("");

            for(int i=0; i<num.Length; i++)
            {
                if (num[i]% 2 == 1)
                        continue;
                Console.Write("{0}   ",num[i]);
            }
        }
    }
}
