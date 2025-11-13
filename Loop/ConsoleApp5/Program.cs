class Harsh
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter Start and End Numbers=");
        int s = Convert.ToInt32(Console.ReadLine());
        int e = Convert.ToInt32(Console.ReadLine());
        int sum = 0;
            for(int i = s; i <= e; i++)
        {
            if (i % 2 == 0 || i % 3 == 0)
            {
                Console.WriteLine(i);
                sum += i;
            }
        }
            Console.WriteLine("Sum="+sum);
    }
}