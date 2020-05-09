using System;
using System.Collections.Generic;

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
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

            // Create a Queue
            Queue<Customer> queueCustomers = new Queue<Customer>();
            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            Customer c1 = queueCustomers.Dequeue();
            Console.WriteLine(c1.ID + " -  " + c1.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c2 = queueCustomers.Dequeue();
            Console.WriteLine(c2.ID + " -  " + c2.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c3 = queueCustomers.Dequeue();
            Console.WriteLine(c3.ID + " -  " + c3.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c4 = queueCustomers.Dequeue();
            Console.WriteLine(c4.ID + " -  " + c4.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);

            Customer c5 = queueCustomers.Dequeue();
            Console.WriteLine(c5.ID + " -  " + c5.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            queueCustomers.Enqueue(customer1);
            queueCustomers.Enqueue(customer2);
            queueCustomers.Enqueue(customer3);
            queueCustomers.Enqueue(customer4);
            queueCustomers.Enqueue(customer5);

            foreach (Customer customer in queueCustomers)
            {
                Console.WriteLine(customer.ID + " -  " + customer.Name);
                Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            }
            Console.WriteLine("-----------------------------------------------------------");

            Customer c = queueCustomers.Peek();
            Console.WriteLine(c.ID + " -  " + c.Name);
            Console.WriteLine("Items left in the Queue = " + queueCustomers.Count);
            Console.WriteLine("-----------------------------------------------------------");

            if (queueCustomers.Contains(customer1))
            {
                Console.WriteLine("customer1 is in Queue");
            }
            else
            {
                Console.WriteLine("customer1 is not in Queue");
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
                                                                                                                                              