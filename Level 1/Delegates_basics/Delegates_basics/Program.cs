using System;


public delegate void HelloFunctionDelegate(string Message); 


class Program
{

    public static void Hello(string strMessage)
    {
        Console.WriteLine(strMessage);
    }


    public static void Main(string[] args)
    {
        HelloFunctionDelegate H_Del = new HelloFunctionDelegate(Hello);
        H_Del("Hello World");
    }

}
