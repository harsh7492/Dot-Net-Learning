class Harsh
{
    static void Main()
    {

        string EmployeeName()
        {
            Console.WriteLine("Enter Employee Name=");
            string name=Console.ReadLine();
            return name;
        }
        int EmployeeSalary()
        {
            Console.WriteLine("Enter Employee Basic Salary=");
            int sal = Convert.ToInt32(Console.ReadLine());
            return sal;
        }
        string Name =EmployeeName();
        int Sal = EmployeeSalary();
        
        int Hra()
        {
            int hra = Sal / 100 * 25;
            return hra;
        }
        int Ta()
        {
            int Ta = Sal / 100 * 22;
            return Ta;
        }
        int Da()
        {
            int Da = Sal / 100 * 26;
            return Da;
        }
        int Pf()
        {
            int pf = Sal / 100 * 12;
            return pf;
        }
        int Tax()
        {
            int tax = Sal / 100 * 18;
            return tax;
        }
        int La()
        {
            int day = 2;
            int la = Sal /30 * day;
            return la;
        }
        int Ot()
        {
            int ot= 2;
            int oa=500;
            int extra = ot * oa;
            return extra;
        }
        int hra = Hra();
        int ta = Ta();
        int da = Da();
        int pf = Pf();
        int tax=Tax();
        int ot = Ot();
        int la = La();
;        void GrossSal()
        {
            //Console.WriteLine($"EmployeeName={Name}\nBasicSal={Sal}\nHra={hra}\nTa={ta}\nDa={da}\nPf={pf}\nTax={tax}\nOverTime={ot}");
            int grossSal = Sal + hra + ta + da - pf;
            Console.WriteLine("Gross Salary=" + grossSal);
        }
        GrossSal();
        void NetSal()
        {
            Console.WriteLine($"Salary Details\nEmployeeName={Name}\nBasicSal={Sal}\nHra={hra}\nTa={ta}\nDa={da}\nPf={pf}\nTax={tax}\nOverTime={ot}\nLeaveDays={la}");
            int net = Sal + hra + ta + da+ot- pf-la;
            if (Sal > 100000)
                Console.WriteLine("After Cutting Tax Net Salary="+(net - tax));
            else
               Console.WriteLine("Net Salary=" + net);
        }
        NetSal();


    }
}