using System;

interface IA
{
    void AMethod();
}

public class A : IA
{
    public void AMethod()
    {
        Console.WriteLine("Print for A");
    }
}

interface IB
{
    void BMethod();
}

public class B : IB
{
    public void BMethod()
    {
        Console.WriteLine("Print for B");
    }
}

public class AB : IA, IB
{
    A a = new A();
    B b = new B();
    public void AMethod()
    {
        a.AMethod();
    }
    public void BMethod()
    {
        b.BMethod();
    }
}
class Program
{
    static void Main()
    {
        AB ab = new AB();
        ab.AMethod();
        ab.BMethod();
    }
}

