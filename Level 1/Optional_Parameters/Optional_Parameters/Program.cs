using System;
using System.Runtime.InteropServices;

namespace Optional_Parameters
{
    class Program
    {
        public static void AddNumbers(int firstNumber, int secondNumber,
                                      [Optional] int[] restOfTheNumbers)
        {
            int result = firstNumber + secondNumber;
            if (restOfTheNumbers != null)
            {
                foreach (int i in restOfTheNumbers)
                {
                    result += i;
                }
            }

            Console.WriteLine("Total = " + result.ToString());
        }

        public static void Main()
        {
            AddNumbers(14, 11);
            AddNumbers(10, 20, new int[] { 7, 10, 15});
        }
    }
}
