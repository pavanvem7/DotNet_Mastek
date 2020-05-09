using System;
using System.Collections.Generic;

namespace List_Collection_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customer2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };


            List<Customer> listCustomers = new List<Customer>(2);
            listCustomers.Add(customer1);
            listCustomers.Add(customer2);
            listCustomers.Add(customer3);

            Customer cust = listCustomers[0];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                     cust.ID, cust.Name, cust.Salary);
            Console.WriteLine("------------------------------------------------");

            
            foreach (Customer c in listCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", c.ID, c.Name, c.Salary);
            }
            Console.WriteLine("------------------------------------------------");

            /*listCustomers.Insert(1, customer3);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                   listCustomers[1].ID, listCustomers[1].Name, listCustomers[1].Salary);
            Console.WriteLine("------------------------------------------------");

            Console.WriteLine("Index of Customer3 object in the List = " +
                    listCustomers.IndexOf(customer3));
            Console.WriteLine("------------------------------------------------");*/


            //Video 75

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");


            if (listCustomers.Contains(customer2))
            {
                Console.WriteLine("Customer2 object exists in the list");
            }
            else
            {
                Console.WriteLine("Customer2 object does not exist in the list");
            }
            Console.WriteLine("------------------------------------------------------");

            if (listCustomers.Exists(x => x.Name.StartsWith("M")))
            {
                Console.WriteLine("List contains customer whose name starts with M");
            }
            else
            {
                Console.WriteLine("List does not contain a customer whose name starts with M");
            }
            Console.WriteLine("------------------------------------------------------");

            Customer cust1 = listCustomers.Find(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust1.ID, cust1.Name, cust1.Salary);
            Console.WriteLine("------------------------------------------------------");

            Customer lastMatch = listCustomers.FindLast(customer => customer.Salary > 5000);
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", lastMatch.ID, lastMatch.Name, lastMatch.Salary);
            Console.WriteLine("------------------------------------------------------");

            List<Customer> filteredCustomers = listCustomers.FindAll(customer => customer.Salary > 5000);
            foreach (Customer cstmr in filteredCustomers)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cstmr.ID, cstmr.Name, cstmr.Salary);
            }
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Index of the first matching customer object whose salary is greater 5000 =" +
                listCustomers.FindIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine("Index of the Last matching customer object whose salary is greater 5000 = " +
                listCustomers.FindLastIndex(customer => customer.Salary > 5000));
            Console.WriteLine("------------------------------------------------------");
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
