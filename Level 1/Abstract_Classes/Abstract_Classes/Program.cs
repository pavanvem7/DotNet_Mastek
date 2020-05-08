using System;



public abstract class Customer
{
    public abstract void Print();
}




class Program : Customer
{
    public override void Print()
    {
        Console.WriteLine("Print sucsessful");
    }


    public static void Main()
    {
        Program P = new Program();
        P.Print();
    }
}
