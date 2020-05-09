using System;
using System.Collections.Generic;

namespace Anonymous_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> listEmployees = new List<Employee>()
            {
                new Employee{ ID = 101, Name = "Mark"},
                new Employee{ ID = 102, Name = "John"},
                new Employee{ ID = 103, Name = "Mary"},
            };

            /*Employee employee = listEmployees.Find(delegate (Employee x)
            { return x.ID == 102; });
            Console.WriteLine("ID = {0}, Name {1}",
                employee.ID, employee.Name);*/

            Employee employee1 = listEmployees.Find(Emp => Emp.ID == 101);
            Console.WriteLine("ID = {0}, Name {1}",
                employee1.ID, employee1.Name);
        }
    }

    public class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

}
