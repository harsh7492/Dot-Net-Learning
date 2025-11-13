
using System;
class Sal
{
    public int sal { get; set; }
    public int bonus { get; set; }
    public int year { get; set; }


}

 class Bonus
{
     static void Main(string[] args)
    {
        Sal obj = new Sal();
        Console.WriteLine("Enter Salary of Employee and year of working=");
        obj.sal = Convert.ToInt32(Console.ReadLine());
        obj.year = Convert.ToInt32(Console.ReadLine());


        if (obj.year > 5)
        {
            obj.bonus = obj.sal / 100 * 5;
            Console.WriteLine("Salary+Bonus=" + (obj.bonus + obj.sal));
        }
        else
            Console.WriteLine("Salary=" + obj.sal);


    }
}