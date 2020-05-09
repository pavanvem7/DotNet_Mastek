using System;
using System.Collections.Generic;

namespace Stack
{
    public class Program
    {
        public static void Main()
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Gender = "Male"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Gender = "Female"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "John",
                Gender = "Male"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "Ken",
                Gender = "Male"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Valarie",
                Gender = "Female"
            };

            // Create a Stack
            Stack<Customer> stackCustomers = new Stack<Customer>();
            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            Customer c1 = stackCustomers.Pop();
            Console.WriteLine(c1.ID + " -  " + c1.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c2 = stackCustomers.Pop();
            Console.WriteLine(c2.ID + " -  " + c2.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c3 = stackCustomers.Pop();
            Console.WriteLine(c3.ID + " -  " + c3.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c4 = stackCustomers.Pop();
            Console.WriteLine(c4.ID + " -  " + c4.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);

            Customer c5 = stackCustomers.Pop();
            Console.WriteLine(c5.ID + " -  " + c5.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            stackCustomers.Push(customer1);
            stackCustomers.Push(customer2);
            stackCustomers.Push(customer3);
            stackCustomers.Push(customer4);
            stackCustomers.Push(customer5);

            foreach (Customer customer in stackCustomers)
            {
                Console.WriteLine(customer.ID + " -  " + customer.Name);
                Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            }
            Console.WriteLine("-----------------------------------------------------------");

            Customer c = stackCustomers.Peek();
            Console.WriteLine(c.ID + " -  " + c.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            Customer c99 = stackCustomers.Peek();
            Console.WriteLine(c99.ID + " -  " + c99.Name);
            Console.WriteLine("Items left in the Stack = " + stackCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            if (stackCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 is in stack");
            }
            else
            {
                Console.WriteLine("customer1 is not in stack");
            }
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
    }
}
