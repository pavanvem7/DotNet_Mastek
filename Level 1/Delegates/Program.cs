using System;
using System.Collections.Generic;



class Program
{
    static void Main(string[] args)
    {
        List<Employee> emplist = new List<Employee>();

        emplist.Add(new Employee() { ID = 100, Name = "PAVAN", Salary = 5000, Experience = 6 });
        emplist.Add(new Employee() { ID = 100, Name = "Suyog", Salary = 7000, Experience = 8 });
        emplist.Add(new Employee() { ID = 100, Name = "Innani", Salary = 4000, Experience = 3 });

            

        Employee.Promote(emplist, emp => emp.Experience > 5);
            
    }



}

public delegate bool IsPromotable(Employee empl);

public class Employee
{
    public int ID { get; set; }
    public string Name { get; set; }
    public int Salary { get; set; }
    public int Experience { get; set; }

    public static void Promote(List<Employee> emplist, IsPromotable EmployeePromotable)
    {
        foreach(Employee emp in emplist)
        {
            if(EmployeePromotable(emp))
            {
                Console.WriteLine("{0} has been promoted!", emp.Name);
            }
        }
    }
}

