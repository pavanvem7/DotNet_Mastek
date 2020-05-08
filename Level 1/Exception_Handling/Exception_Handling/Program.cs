using System;
using System.IO;
class Program
{
    static void Main()
    {
        StreamReader str = null;
        try
        {
            str = new StreamReader("/Users/pavanvemula/Desktop/Text.rtf");
            Console.WriteLine(str.ReadToEnd());
        }

        catch (Exception exc)
        {
            Console.WriteLine("{0}", exc.Message);
        }

        finally
        {
            str.Close();
            Console.WriteLine("Finally Blocked!!");
        }

    }
}

