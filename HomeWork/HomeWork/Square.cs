
using System;
class Rectangle
{
    public int len { get; set; }
    public int breadth { get; set; }
}

 class Square
{
    public static void Main(string[] args)
    {
        Rectangle obj = new Rectangle();
        Console.WriteLine("Enter Length and breadth of Rectangle=");
        obj.len = Convert.ToInt32(Console.ReadLine());
        obj.breadth = Convert.ToInt32(Console.ReadLine());


        if (obj.len == obj.breadth)
            Console.WriteLine("Square");
        else
            Console.WriteLine("Rectangle");


    }
}