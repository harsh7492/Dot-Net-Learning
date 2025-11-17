using System;
using System.Collections.Generic;
using System.Text;

namespace Day_4_Assignment
{
    internal class Four
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine($"Enter Student {i} Name=");
                list.Add(Console.ReadLine());
            }
            Console.WriteLine("Student List");
            foreach (string i in list)
            {
                Console.WriteLine($"Name={i}");
            }
        }
    }
}