

using System;
class Op
{
    public int num1 { get; set; }
    public int num2 { get; set; }
    public int num3 { get; set; }


}

 class Max
{
    public static void Main(string[] args)
    {
        Op obj = new Op();
        Console.WriteLine("Enter Three Numbers=");
        obj.num1 = Convert.ToInt32(Console.ReadLine());
        obj.num2 = Convert.ToInt32(Console.ReadLine());
        obj.num3 = Convert.ToInt32(Console.ReadLine());

        if (obj.num1 > obj.num2 && obj.num1 > obj.num3)
            Console.WriteLine("Num 1 is Greater");
        else if (obj.num2 > obj.num1 && obj.num2 > obj.num3)
            Console.WriteLine("Num 2 is Greater");
        else
            Console.WriteLine("Num 3 is Greater");

    }
}