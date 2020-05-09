using System;
using System.Collections.Generic;

namespace Methods_List_Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer()
            {
                ID = 101,
                Name = "Mark",
                Salary = 5200
            };

            Customer customer2 = new Customer()
            {
                ID = 103,
                Name = "John",
                Salary = 7000
            };

            Customer customer3 = new Customer()
            {
                ID = 102,
                Name = "Ken",
                Salary = 5500
            };

            List<Customer> listCutomers = new List<Customer>(100);
            listCutomers.Add(customer1);
            listCutomers.Add(customer2);
            listCutomers.Add(customer3);

            Console.WriteLine("Are all salaries greater than 5000: "
                + listCutomers.TrueForAll(x => x.Salary > 5000));

            System.Collections.ObjectModel.ReadOnlyCollection<Customer>
                readOnlyCustomers = listCutomers.AsReadOnly();

            Console.WriteLine("Total Items in ReadOnlyCollection = " +
                readOnlyCustomers.Count);

            Console.WriteLine("List capacity before invoking TrimExcess = " +
                    listCutomers.Capacity);
            listCutomers.TrimExcess();
            Console.WriteLine(listCutomers.Capacity);
        }
    }

    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
    }
}
