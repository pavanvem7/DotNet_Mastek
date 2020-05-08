using System;
using System.IO;

namespace Inner_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter 1st number : ");
                int FN = int.Parse(Console.ReadLine());

                Console.Write("Enter 2nd number : ");
                int SN = int.Parse(Console.ReadLine());
                Console.WriteLine();
                int Reuslt = FN / SN;
                Console.WriteLine("Result = {0}", Reuslt);
            }
            catch (Exception ex)
            {
                string filepath = @"/Users/pavanvemula/Desktop/Log.txt";
                if (File.Exists(filepath))
                {
                    StreamWriter sw = new StreamWriter(filepath);
                    sw.Write(ex.GetType().Name);
                    sw.Write(ex.Message);
                    sw.Close();
                    Console.WriteLine("Please try again");
                }
                else
                {
                    throw new FileNotFoundException(filepath + "is not present");
                }
            }

        }
    }
}
