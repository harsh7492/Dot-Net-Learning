using System;

class Harsh
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Total Number of classess run in semester=");
        double total = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter Total Number of Attend classess=");
        double attend = Convert.ToDouble(Console.ReadLine());
        
        double present = attend / total * 100;


        if (present >=75)
            Console.WriteLine("You are eligible\t" + present);
        else
            Console.WriteLine("You are not eligible");

    }
}