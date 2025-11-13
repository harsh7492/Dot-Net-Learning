

using System;
class Cost
{
    public int qua { get; set; }
    public int dis { get; set; }
    public int cost { get; set; }
}

 class Shop
{
    public static void Main(string[] args)
    {
        Cost obj = new Cost();
        Console.WriteLine("Enter Quantity=");
        obj.qua = Convert.ToInt32(Console.ReadLine());
        obj.cost = obj.qua * 100;
        if (obj.qua > 1000)
        {
            obj.dis = obj.cost / 100 * 10;
            Console.WriteLine("Total Amount=" + obj.cost);
            Console.WriteLine("Discount Amount=" + obj.dis);
            Console.WriteLine("Discounted Total Cost=" + (obj.cost - obj.dis));
        }
        else
            Console.WriteLine("Total Cost=" + obj.cost);


    }
}