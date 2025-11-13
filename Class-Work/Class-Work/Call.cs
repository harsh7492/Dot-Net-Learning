//ref in both declaration and and calling
class Call
{
    static void Main(String[] args)
    {
        int num = 30;
        Callv(num);
        Callr(ref num);
        Callv(num);


    }
    static void Callv(int value)
    {
        Console.WriteLine("Call by value=" + value);
    }
    static void Callr(ref int value)
    {
        value = 40;
        Console.WriteLine("Call by reference=" + value);

    }
}