using System;
using System.Collections.Generic;
using System.Linq;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, Customer> dictionaryCustomers = new Dictionary<int, Customer>();

            Customer customr1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5000
            };

            Customer customr2 = new Customer()
            {
                ID = 102,
                Name = "Pam",
                Salary = 7000
            };

            Customer customr3 = new Customer()
            {
                ID = 104,
                Name = "Rob",
                Salary = 5500
            };

            dictionaryCustomers.Add(customr1.ID, customr1);
            dictionaryCustomers.Add(customr2.ID, customr2);
            dictionaryCustomers.Add(customr3.ID, customr3);

            Console.WriteLine("Customer 101 in customer dictionary");
            Customer customer101 = dictionaryCustomers[101];
            Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}",
                            customer101.ID, customer101.Name, customer101.Salary);
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (KeyValuePair<int, Customer> customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");

            /*Console.WriteLine("All customer keys and values in customer dictionary");
            foreach (var customerKeyValuePair in dictionaryCustomers)
            {
                Console.WriteLine("Key = " + customerKeyValuePair.Key);
                Customer cust = customerKeyValuePair.Value;
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", cust.ID, cust.Name, cust.Salary);
            }
            Console.WriteLine("--------------------------------------------------");*/

            Console.WriteLine("All Keys in Customer Dictionary");
            foreach (int key in dictionaryCustomers.Keys)
            {
                Console.WriteLine(key);
            }
            Console.WriteLine("--------------------------------------------------");

            Console.WriteLine("All Customer objects in Customer Dictionary");
            foreach (Customer customer in dictionaryCustomers.Values)
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer.ID, customer.Name, customer.Salary);
            }

            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");

            Customer customer999;
            if (dictionaryCustomers.TryGetValue(999, out customer999))
            {
                Console.WriteLine("ID = {0}, Name = {1}, Salary = {2}", customer999.ID, customer999.Name, customer999.Salary);
            }
            else
            {
                Console.WriteLine("Customer with Key = 999 is not found in the dictionary");
                Console.WriteLine("-------------------------------------------------------------------");
            }

            Console.WriteLine("Total items in Dictionary = {0}", dictionaryCustomers.Count());
            Console.WriteLine("-------------------------------------------------------------------");

            Console.WriteLine("Items in dictionary where Salary is greater than 5000 = {0}",
                dictionaryCustomers.Count(x => x.Value.Salary > 5000));
            Console.WriteLine("-------------------------------------------------------------------");

        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
