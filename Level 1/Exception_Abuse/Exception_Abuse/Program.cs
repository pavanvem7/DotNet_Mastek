using System;

namespace Exception_Abuse
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Please enter numerator: ");
                int Numerator;
                int Denominator;
                bool IsNrConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Numerator);
                if (IsNrConversionSuccessful)
                {
                    Console.WriteLine("Please enter denominator: ");
                    bool IsDrConversionSuccessful = Int32.TryParse(Console.ReadLine(), out Denominator);
                    if (IsDrConversionSuccessful)
                    {
                        if (Denominator == 0)
                        {
                            Console.WriteLine("Denominator cannot be zero");
                        }
                        else
                        {
                            int Result = Numerator / Denominator;
                            Console.WriteLine("Result = {0} ", Result);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Denominator must be valid number between {0} and {1} ", Int32.MinValue, Int32.MaxValue);

                    }
                }
                else
                {
                    Console.WriteLine("Numerator must be valid number between {0} and {1} ", Int32.MinValue, Int32.MaxValue);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
    }
}
