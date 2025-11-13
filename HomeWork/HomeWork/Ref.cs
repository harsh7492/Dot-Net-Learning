using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork
{
    class Value
    {
        public int a;
        public int b;
    }
    class Calc
    {
        public int Add(ref int a, ref int b)
        {
            a = 6;
            b = 1;
            return a + b;
        }
        public int Sub(ref int a, ref int b)
        {
            a = 6;
            b = 2;
            return a - b;
        }
        public int mul(ref int a, ref int b)
        {
            a = 6;
            b = 9;
            return a * b;
        }
        public int Div(ref int a, ref int b)
        {
            a = 8;
            b = 2;
            return a / b;
        }
    }
    class Val
    {
        public int Add( int a,  int b)
        {
            
            return a + b;
        }
        public int Sub( int a,  int b)
        {
           return a - b;
        }
        public int mul( int a,  int b)
        {
            return a * b;
        }
        public int Div( int a,  int b)
        {
           
            return a / b;
        }
    }
    internal class Ref
    {
        static void Main(string[] args)
        {
            Calc obj = new Calc();
            Val obj2 = new Val();

            Value val =new Value();
            val.a = 8;
            val.b = 4;
            //Call By Rreference
            Console.WriteLine("Sum="+obj.Add(ref val.a,ref val.b));
            Console.WriteLine("Sub = " + obj.Sub(ref val.a, ref val.b));
            Console.WriteLine("Mul = " + obj.mul(ref val.a, ref val.b));
            Console.WriteLine("Div = " + obj.Div(ref val.a, ref val.b));
            //call by value
            Console.WriteLine("Sum=" + obj2.Add(val.a, val.b));
            Console.WriteLine("Sub = " + obj2.Sub( val.a,  val.b));
            Console.WriteLine("Mul = " + obj2.mul( val.a,  val.b));
            Console.WriteLine("Div = " + obj2.Div( val.a,  val.b));

        }
    }
}
