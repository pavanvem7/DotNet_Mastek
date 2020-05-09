using System;
using System.Collections.Generic;

namespace Generic_List
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 4000,
                Type = "RetailCustomer"
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000,
                Type = "RetailCustomer"
            };

            Customer customer3 = new Customer()
            {
                ID = 103,
                Name = "Rob",
                Salary = 5500,
                Type = "RetailCustomer"
            };

            Customer customer4 = new Customer()
            {
                ID = 104,
                Name = "John",
                Salary = 6500,
                Type = "CorporateCustomer"
            };

            Customer customer5 = new Customer()
            {
                ID = 105,
                Name = "Sam",
                Salary = 3500,
                Type = "CorporateCustomer"
            };


            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            List<Customer> listCorporateCustomers = new List<Customer>();
            listCorporateCustomers.Add(customer4);
            listCorporateCustomers.Add(customer5);

            listCustomers.AddRange(listCorporateCustomers);

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            List<Customer> corporateCustomers = listCustomers.GetRange(3, 2);
            foreach (Customer customer in corporateCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            listCustomers.Remove(customer1);

            listCustomers.RemoveAt(0);

            listCustomers.RemoveAll(x => x.Type == "RetailCustomer");

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            listCustomers.RemoveRange(0, 2);

            listCustomers.Insert(0, customer1);
            listCustomers.Insert(1, customer2);
            listCustomers.Insert(2, customer3);

            listCustomers.InsertRange(0, listCorporateCustomers);

            foreach (Customer customer in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}, Type = {3}",
                    customer.ID, customer.Name, customer.Salary, customer.Type);
            }
            Console.WriteLine("------------------------------------------------------");

            listCustomers.Clear();

            Console.WriteLine(" Total Items in the List = " + listCustomers.Count);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public string Type { get; set; }
    }
}
