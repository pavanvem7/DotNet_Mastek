using System;

interface ICustomer
{
    void Print();
}

public class Customer : ICustomer
{
    public void Print()
    {
        Console.WriteLine("Prints the method declared in interface");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Customer C1 = new Customer();
        C1.Print();
    }
}

