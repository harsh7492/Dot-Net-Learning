using System;

class BankAccount
{
    public long accNo;
    public string holder;
    public double balance;
}

class SavingAccount : BankAccount
{
    public double interestRate;

    public void AddInterest()
    {
        balance = balance + (balance * interestRate / 100);
    }
}

class CurrentAccount : BankAccount
{
    public double overdraft;
}

class App
{
    static void Main(string[] args)
    {
        BankAccount acc = null;
        SavingAccount sa = null;
        CurrentAccount ca = null;

        int type = 0; // 1 = Saving, 2 = Current
        int ch;

        do
        {
            Console.WriteLine("1. Create Saving Account");
            Console.WriteLine("2. Create Current Account");
            Console.WriteLine("3. Deposit");
            Console.WriteLine("4. Withdraw");
            Console.WriteLine("5. Add Interest");
            Console.WriteLine("6. Show Details");
            Console.WriteLine("7. Exit");
            Console.Write("Enter choice: ");
            ch = int.Parse(Console.ReadLine());

            switch (ch)
            {
                case 1:
                    sa = new SavingAccount();
                    Console.Write("Acc No: ");
                    sa.accNo = long.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    sa.holder = Console.ReadLine();
                    Console.Write("Balance: ");
                    sa.balance = double.Parse(Console.ReadLine());
                    Console.Write("Interest Rate: ");
                    sa.interestRate = double.Parse(Console.ReadLine());

                    acc = sa;
                    type = 1;
                    Console.WriteLine("Saving Account Created.\n");
                    break;

                case 2:
                    ca = new CurrentAccount();
                    Console.Write("Acc No: ");
                    ca.accNo = long.Parse(Console.ReadLine());
                    Console.Write("Name: ");
                    ca.holder = Console.ReadLine();
                    Console.Write("Balance: ");
                    ca.balance = double.Parse(Console.ReadLine());
                    Console.Write("Overdraft: ");
                    ca.overdraft = double.Parse(Console.ReadLine());

                    acc = ca;
                    type = 2;
                    Console.WriteLine("Current Account Created.\n");
                    break;

                case 3:
                    if (acc == null)
                    {
                        Console.WriteLine("No account created.\n");
                        break;
                    }

                    Console.Write("Deposit Amount: ");
                    double d = double.Parse(Console.ReadLine());
                    acc.balance += d;
                    Console.WriteLine("Deposited.\n");
                    break;

                case 4:
                    if (acc == null)
                    {
                        Console.WriteLine("No account created.\n");
                        break;
                    }

                    Console.Write("Withdraw Amount: ");
                    double w = double.Parse(Console.ReadLine());

                    if (type == 2 && ca != null)
                    {
                        if (acc.balance + ca.overdraft >= w)
                        {
                            acc.balance -= w;
                            Console.WriteLine("Withdrawn.\n");
                        }
                        else Console.WriteLine("Limit Exceeded.\n");
                    }
                    else if (type == 1 && sa != null)
                    {
                        if (acc.balance >= w)
                        {
                            acc.balance -= w;
                            Console.WriteLine("Withdrawn.\n");
                        }
                        else Console.WriteLine("Not Enough Balance.\n");
                    }
                    break;

                case 5:
                    if (type == 1 && sa != null)
                    {
                        sa.AddInterest();
                        Console.WriteLine("Interest Added.\n");
                    }
                    else
                        Console.WriteLine("Interest only for Saving Account.\n");
                    break;

                case 6:
                    if (acc == null)
                    {
                        Console.WriteLine("No account created.\n");
                        break;
                    }

                    Console.WriteLine("Acc No: " + acc.accNo);
                    Console.WriteLine("Name: " + acc.holder);
                    Console.WriteLine("Balance: " + acc.balance);

                    if (type == 1 && sa != null)
                        Console.WriteLine("Interest Rate: " + sa.interestRate);

                    if (type == 2 && ca != null)
                        Console.WriteLine("Overdraft: " + ca.overdraft);

                    Console.WriteLine();
                    break;

                case 7:
                    Console.WriteLine("Exiting...");
                    break;

                default:
                    Console.WriteLine("Wrong choice.\n");
                    break;
            }

        } while (ch != 7);
    }
}
