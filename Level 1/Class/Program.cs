using System;

namespace Class
{

    class Person
    {
        string _Fname;
        string _Lname;
        public Person(string Fname, string Lname)
        {
            this._Fname = Fname;
            this._Lname = Lname;
        }
        public void Print()
        {
            Console.WriteLine("Full Name is {0} {1}", this._Fname, this._Lname);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Person P = new Person("Praveen", "Vemula");
            P.Print();
        }
    }
}
