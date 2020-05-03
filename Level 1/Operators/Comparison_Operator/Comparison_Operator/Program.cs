using System;

namespace Comparison_Operator
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8, b = 3;
            Console.WriteLine("a= {0}    b= {1} ", a, b);
            if (a == b)
            {
                Console.WriteLine("a and b are Equal");
            }
            if (a != b)
            {
                Console.WriteLine("a and b are Not Equal");
            }
            if (a > b) 
            {
                Console.WriteLine("Value of a is greater than b ");
            }
            if (a < b)
            {
                Console.WriteLine("Value of b is greater than a ");
            }
        }
    }
}
