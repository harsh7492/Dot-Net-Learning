namespace CRM.Models
{
    public class SearchResultViewModel
    {
        public List<Customer> Customers { get; set; } = new List<Customer>();
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public string SearchTerm { get; set; } = string.Empty;
    }
}
