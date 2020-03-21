using System;

namespace Inheritance
{
    public class Student
    {
        public string Fname;
        public string Lname;
        public int age;
    }

    class FE_Student : Student
    {
        public float Percentage;

        public void Print()
        {
            Console.WriteLine("{0} {1} has secured {2}%.", Fname, Lname, Percentage);
        }
    }

    class BE_Student : Student
    {
        public float CGPA;

        public void Print()
        {
            Console.WriteLine("{0} {1} has secured {2} CGPA.", Fname, Lname, CGPA);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            FE_Student FES = new FE_Student();
            FES.Fname = "Praveen";
            FES.Lname = "Vemula";
            FES.Percentage = 89F;
            FES.Print();

            BE_Student BES = new BE_Student();
            BES.Fname = "Parth";
            BES.Lname = "Waghmare";
            BES.CGPA = 6.76F;
            BES.Print();
        }
    }
}
