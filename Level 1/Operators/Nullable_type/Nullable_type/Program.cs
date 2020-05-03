using System;

namespace Nullable_type
{
    class Program
    {
        static void Main(string[] args)
        {
            int? Tickets = null;

            int available = Tickets ?? 0;

            Console.WriteLine("Available Tickets are {0}", available);
        }
    }
}
