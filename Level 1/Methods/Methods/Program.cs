using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.Even_num(20);

            Console.WriteLine("");
            int sum = Program.Add(3, 5);
            Console.WriteLine("Sum = {0} ", sum);

            int result = 0;
            Sub(55, 40, out result);
            Console.WriteLine("Subtraction = {0}", result);

            ParamsMethod(1, 2, 3, 4, 5, 6, 7);
        }

        public void Even_num(int n)
        {
            Console.WriteLine("Even numbers are ");

            for(int i = 0; i<=n; i+=2)
            {
                Console.Write("{0}   ", i);
            }
        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static void Sub(int num3 , int num4 , out int result)
        {
            result = num3 - num4;
        }

        public static void ParamsMethod(params int[] num)
        {
            Console.WriteLine("There are {0} elements in an array", num.Length);
            foreach(int i in num)
            {
                Console.Write("{0}   ", i);
            }
        }
    }
}
