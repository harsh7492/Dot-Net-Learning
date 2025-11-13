//Program for Operator Calculation
class Cal
{
   public double num1 { get; set; }
  public  double num2 { get; set; }
   public string op { get; set; }
}
class Harsh
{
    static void Main(string[] args)
    {
        Cal obj=new Cal();
        Console.WriteLine("Enter Two Numbers=");
        obj.num1=Convert.ToInt32(Console.ReadLine());
        obj.num2 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter Operator");
        obj.op = Console.ReadLine();
        switch (obj.op)
        {
            case "+":double sum = obj.num1 + obj.num2;
                Console.WriteLine("Sum="+sum);
                break;
            case "-":
                double sub = obj.num1 - obj.num2;
                Console.WriteLine("Sub=" + sub);
                break;
            case "*":
                double mul = obj.num1 * obj.num2;
                Console.WriteLine("Mul=" + mul);
                break;
            case "/":
                double div = obj.num1 / obj.num2;
                Console.WriteLine("div=" + div);
                break;
            default:Console.WriteLine("Wrong Operator");
                break;
        }



    }
}