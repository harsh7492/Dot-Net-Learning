class Data
{
     string Name;
    public string name
    {
        get
        {
            return Name;
        }
        set
        {
            Name=value;
        }
    }
}
class Encap
{
    static void Main(string[] args)
    {
        Data data = new Data();
        data.name = "Harsh Kumar Rai";
        Console.WriteLine("Name="+data.name);
    }
}