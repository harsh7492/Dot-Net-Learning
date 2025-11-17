using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment
{
    internal class Five
    {
        static void Main(string[] args)
        {
            long[] sal = new long[5];
            for (int i = 0; i < sal.Length; i++)
            {
                Console.WriteLine("Enter Employee Sal=");
                sal[i] = Convert.ToInt64(Console.ReadLine());
            }
            Console.WriteLine("Employee Salaries");
            for (int i = 0; i < sal.Length; i++)
            {
                Console.WriteLine($"Employee Sal=" + sal[i]);
            }
            Console.WriteLine($"Highest Employee Salary=" + sal.Max());
            Console.WriteLine($"Lowest Employee Salary=" + sal.Min());
            Console.WriteLine($"Average Employee Salary=" + sal.Average());

        }
    }
}