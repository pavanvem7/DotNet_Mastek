using System;

namespace Other_Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            // Conditional Operator
            int a = 8, b = 6;
            if(a==4 && b==6)
            {
                Console.WriteLine("Both conditions are True");
            }
            if(a == 8 || b == 6)
            {
                Console.WriteLine("Any one or both conditions are True");
            }

            // Ternary Operator
            int num = 24;
            bool Isnum24 = num == 24 ? true : false;
            Console.WriteLine("Number == 24 is {0} ", Isnum24);
        }
    }
}
