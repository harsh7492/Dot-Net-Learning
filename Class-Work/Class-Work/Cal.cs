class Value
{
    public int num1 { get; set; }
    public int num2 { get; set; }
}
class Add
{
    
    public int add(int num1,int num2)
    {
        return num1 + num2;
    }
}
class Mul
{
    
    public int mul(int num1,int num2)
    {
        return num1 * num2;
    }
}
class Calc
{
    static void Main(string[] args)
    {
        Add obj1=new Add();
        Mul obj2 = new Mul();
        Value val=new Value();
        val.num1 = 3;
        val.num2 = 4;
        int sum=obj1.add(val.num1,val.num2);
        int mul=obj2.mul(val.num1, val.num2);
        Console.WriteLine($"Sum={sum}\nMul={mul}");

    }
}