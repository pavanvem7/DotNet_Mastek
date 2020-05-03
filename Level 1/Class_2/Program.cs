using System;

namespace Class_2
{
    class Circle
    {
        static float _pi;
        int _radius;

        static Circle()
        {
            Circle._pi = 3.141F;
            Console.WriteLine("Static Constructor Called!");
        }
        
        public Circle(int Radius)
        {
            this._radius = Radius;
            Console.WriteLine("Instance Constructor Called!");
        }

        public float Area()
        {
            return Circle._pi * this._radius * this._radius;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Circle C = new Circle(5);
            float area = C.Area();
            Console.WriteLine("Area = {0}", area);

            Circle C2 = new Circle(7);
            float area2 = C2.Area();
            Console.WriteLine("Area = {0}", area2);
        }
    }
}
