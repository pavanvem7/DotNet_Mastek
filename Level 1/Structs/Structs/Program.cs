using System;

public struct Student
{
    private int _ID;

    public string Email
    {
        set;
        get;
    }

    public int Id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("ID cannot be a negative number");
            }
            this._ID = value;
        }
        get
        {
            return this._ID;
        }
    }
}
class Program
{
    static void Main()
    {
        Student S1 = new Student();
        S1.Id = 107;
        S1.Email = "pavan@test.com";
        Console.WriteLine("Student Id = {0} and Student Email = {1}", S1.Id, S1.Email);
    }
}
