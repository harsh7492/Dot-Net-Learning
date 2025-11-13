using System;
using System.Collections.Generic;
using System.Text;

namespace Class_Work
{
    internal class Array
    {
        static void Main(string[] args)
        {
            int[] a = {5,4,3,2,1 };
            string[] name =new string[5];
            a.Sort();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            Console.WriteLine("Sum of Array Elements=" + a.Sum());
            Console.WriteLine("Enter name=");
            for (int i = 0; i < name.Length; i++)
            {
                name[i]=Console.ReadLine();
                
            }
            int c = 1;
            for(int i=0;i<name.Length;i++)
            {
                Console.WriteLine($"Name-{c}:\t"+name[i]);
                c++;
            }
        }
    }
}