using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Sort
    {
        public int[] a=new int[5];
        public string[] s=new string[5];
        public string name;
        public int t,f=0;
        public void Max()
        {
            Console.WriteLine("Enter Array Elements No=");
            for(int i=0; i<a.Length; i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Before Desc");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
            for (int i = 0; i < a.Length-1; i++)
            {
             for(int j=i+1;j<a.Length; j++)
                {
                    if (a[i] < a[j])
                    {
                        t = a[i];
                        a[i] = a[j];
                        a[j] = t;
                    }
                }
            }
            Console.WriteLine("After Desc");
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }

        }

        public void Sc()
        {
            Console.WriteLine("Enter Names=");
            for (int i = 0; i < s.Length; i++)
            {
                s[i] =Console.ReadLine();
            }
            Console.WriteLine("Names");
            for (int i = 0; i < s.Length; i++)
            {
                Console.WriteLine(s[i]);

            }
            Console.WriteLine("Enter Name to search=");
                name = Console.ReadLine();
            for (int i = 0; i < s.Length; i++)
            {
                if (name == s[i])
                {
                    f = 1;
                    break;
                }

            }
            if (f == 0)
            {
                Console.WriteLine("Name Not Found");
            }
            else
            {
                Console.WriteLine("Name Found");

            }
        }
    }
    internal class Yesterday
    {
        static void Main(string[] args)
        {
            Sort obj= new Sort();
            obj.Max();
            obj.Sc();
        }
    }
}
