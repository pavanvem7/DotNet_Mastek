using System;

namespace Conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = 2.143F;
            float b = 213453825312334.14F;   // Large Value
            int c = Convert.ToInt32(a);
            int d = (int)b;
            Console.WriteLine(c);
            Console.WriteLine(d);

            string num1 = "100";
            string num2 = "150PSV";
            int result1 = int.Parse(num1);
            Console.WriteLine(result1);

            int result2 = 0;
            bool istrue = int.TryParse(num2, out result2);
            if(istrue)
            {
                Console.WriteLine(result2);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }
        }
    }
}
