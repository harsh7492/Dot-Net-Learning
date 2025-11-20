namespace CRM.Models
{
    public class Employee
    {

        public int Id { get; set; }
        public string name { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string position { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;

    }
}
