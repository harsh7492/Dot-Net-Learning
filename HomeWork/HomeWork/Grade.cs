
using System;
class Marks
{
    public int m { get; set; }

}

 class Grade
{
    public static void Main(string[] args)
    {
        Marks obj = new Marks();
        Console.WriteLine("Enter Marks of Student=");
        obj.m = Convert.ToInt32(Console.ReadLine());


        if (obj.m > 80)
            Console.WriteLine("Grade=A");
        else if (obj.m >= 60 && obj.m <= 80)
            Console.WriteLine("Grade=B");
        else if (obj.m >= 50 && obj.m <= 60)
            Console.WriteLine("Grade=C");
        else if (obj.m >= 45 && obj.m <= 50)
            Console.WriteLine("Grade=D");
        else if (obj.m >= 25 && obj.m <= 45)
            Console.WriteLine("Grade=E");
        else
            Console.WriteLine("Grade=F");


    }
}