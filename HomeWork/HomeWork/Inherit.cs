class EmpAllowance
{
    public int sal;
    public string name;
    public int year;
    public void Sal()
    {
        Console.WriteLine("Enter name and Salary of Employee and year of working=");
        name = Console.ReadLine();
        sal = Convert.ToInt32(Console.ReadLine());
        year = Convert.ToInt32(Console.ReadLine());


    }
    public int Hra()
    {
        int hra = sal / 100 * 25;
        return hra;
    }
    public int Ta()
    {
        int Ta = sal / 100 * 22;
        return Ta;
    }
    public int Da()
    {
        int Da = sal / 100 * 26;
        return Da;
    }
}
class Medical:EmpAllowance
{
   public void Med()
    {
        if (sal > 1000000)
            Console.WriteLine("Medical Allowed");
        else
            Console.WriteLine("Medical not Allowed");
    }
}
class Leave : Medical
{
    public void Lea()
    {
        if (year > 5)
            Console.WriteLine("30 Leave");
        else
            Console.WriteLine("year lesss than 5 for leave");

    }
}
class Inherit
{
    static void Main(string[] args)
    {
        Leave obj3=new Leave();
        obj3.Sal();
        int hra, da, ta;
        hra = obj3.Hra();
        ta= obj3.Ta();
        da = obj3.Da();
        Console.WriteLine($"Employee Details\nName={obj3.name}\nBasic Sal={obj3.sal}\nyear of working={obj3.year}\nHRA={hra}\nDA={da}\nTA={ta}");
        obj3.Med();
        obj3.Lea();
    }
}
  