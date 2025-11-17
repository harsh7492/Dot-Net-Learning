using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        
    }
    class FullTimeEmployee:Employee
    {
        public long MonthlySalary;
    }
    class PartTimeEmployee:Employee
    {
        public long hour;
        public long rate;
    }
    internal class Six
    {
        static void Main(string[] args)
        { 



            FullTimeEmployee obj1 =new FullTimeEmployee();
            PartTimeEmployee obj2=new PartTimeEmployee();
            obj1.Id = 1; obj1.Name = "Harsh"; obj1.Department = "Technical";
            obj1.MonthlySalary = 25000;
            Console.WriteLine($"Full Time Employee Salary \nEmployee Id={obj1.Id}\nEmployee Name={obj1.Name}\nEmployee Department={obj1.Department}\nEmployee Salary={obj1.MonthlySalary}");

            obj2.hour = 6;
            obj2.rate = 500;
            long partTimeSal = 6 * 500;
            obj2.Id = 2; obj2.Name = "Rahul"; obj2.Department = "HR";
            Console.WriteLine($"Part Time Employee Salary \nEmployee Id={obj2.Id}\nEmployee Name={obj2.Name}\nEmployee Department={obj2.Department}\nEmployee Salary={partTimeSal}");

        }
    }
}
