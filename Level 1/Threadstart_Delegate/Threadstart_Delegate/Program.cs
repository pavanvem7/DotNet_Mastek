using System;
using System.Threading;

namespace Threadstart_Delegate
{
    class Program
    {
        static void Main(string[] args)
        {

            //Thread T1 = new Thread(new ThreadStart(Number.PrintNumbers));
            //Thread T1 = new Thread(delegate () { Number.PrintNumbers(); });
            Thread T1 = new Thread(() => Number.PrintNumbers());
            T1.Start();
            
        }
    }

    class Number
    {
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
