using System;
using System.Threading;

namespace Thread_CallBack
{
    public delegate void SumOfNumbersCallback(int sumOfNumbers);

    class Number
    {
        int _target;
        SumOfNumbersCallback _callbackMethod;

        public Number(int target, SumOfNumbersCallback callbackMethod)
        {
            this._target = target;
            this._callbackMethod = callbackMethod;
        }

        public void ComputeSumOfNumbers()
        {
            int sum = 0;
            for (int i = 1; i <= _target; i++)
            {
                sum = sum + i;
            }

            _callbackMethod?.Invoke(sum);
        }
    }

    class Program
    {
        public static void PrintSumOfNumbers(int sum)
        {
            Console.WriteLine("Sum of numbers is " + sum);
        }

        public static void Main()
        {
            Console.WriteLine("Please enter the target number");
            int target = Convert.ToInt32(Console.ReadLine());

            SumOfNumbersCallback callbackMethod = new SumOfNumbersCallback(PrintSumOfNumbers);

            Number number = new Number(target, callbackMethod);

            Thread T1 = new Thread(new ThreadStart(number.ComputeSumOfNumbers));
            T1.Start();
        }
    }
}
