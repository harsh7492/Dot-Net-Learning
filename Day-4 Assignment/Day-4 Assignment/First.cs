class BankAccount
{
    private long accountNumber;
    private long balance;
    
    public long Deposit(long accountNumber, long balance)
    {
        this.accountNumber = accountNumber;
        this.balance = balance;
        return this.accountNumber;

    }
    public  long Withdrawl(long amount)
    {
        this.balance-=amount;
        return this.balance;
    }
    public long GetBalance(long check)
    {
        if (check == this.accountNumber)
        {
            return this.balance;
        }
        else
        {
            
            return this.accountNumber;
        }
    }
}
class Atm
{
    static void Main(string[] args)
    {
        BankAccount obj=new BankAccount();

        Console.WriteLine("Enter Account Number=");
        long ac=Convert.ToInt64(Console.ReadLine());
        Console.WriteLine("Enter Deposit Amount=");
        long amount = Convert.ToInt64(Console.ReadLine());

        long an=obj.Deposit(ac, amount);
        long b = obj.GetBalance(an);
        Console.WriteLine("Enter Account Number to  check balance=");
        long chk = Convert.ToInt64(Console.ReadLine());
        if (chk!= ac)
        {
            long a = obj.GetBalance(chk);

            Console.WriteLine($"Account Number Not Match={chk}");
        }
        else
        {
            Console.WriteLine($"Successfully Deposited\nAccount Number={an}\nBalance={amount}");

            Console.WriteLine("If you want to withdrawl amount enter 1 if not enter 2=");
            long check = Convert.ToInt64(Console.ReadLine());
            if (check == 1)
            {
                Console.WriteLine($"Current Amount={b}");
                Console.WriteLine("Enter WithDraw Amount=");
                long cash = Convert.ToInt64(Console.ReadLine());
                long up = obj.Withdrawl(cash);
                Console.WriteLine($"Account Number={ac}\nUpdated Amount={up}\nThanks for transaction with us");

            }
            else
            {
                Console.WriteLine("Thank You");
            }
        }
    }
}