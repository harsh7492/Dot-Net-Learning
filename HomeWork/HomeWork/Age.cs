
using System;
class Age
{
    public int p1 { get; set; }
    public int p2 { get; set; }
    public int p3 { get; set; }


}

 class Person
{
    public static void Main(string[] args)
    {
        Age obj = new Age();
        Console.WriteLine("Enter Three Person Age=");
        obj.p1 = Convert.ToInt32(Console.ReadLine());
        obj.p2 = Convert.ToInt32(Console.ReadLine());
        obj.p3 = Convert.ToInt32(Console.ReadLine());

        if (obj.p1 > obj.p2 && obj.p1 > obj.p3)
            Console.WriteLine("Person 1 Age is Oldest");
        else if (obj.p2 > obj.p1 && obj.p2 > obj.p3)
            Console.WriteLine("Person 2 Age is Oldest");
        else
            Console.WriteLine("Person 3 Age is Oldest");
        if (obj.p1 < obj.p2 && obj.p1 < obj.p3)
            Console.WriteLine("Person 1 Age is Younger");
        else if (obj.p2 < obj.p1 && obj.p2 < obj.p3)
            Console.WriteLine("Person 2 Age is Younger");
        else
            Console.WriteLine("Person 3 Age is younger");

    }
}