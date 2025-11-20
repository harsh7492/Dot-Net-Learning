using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace CRM.Models
{
    public class Report
    {
        public int Id { get; set; }

        // Summary Cards
        public int TotalCustomers { get; set; }
        public int TotalEmployees { get; set; }
        public int TodayNewCustomers { get; set; }
        public int TodayNewEmployees { get; set; }

        // Database fields (strings)
        public string RecentCustomersJson { get; set; }
        public string RecentEmployeesJson { get; set; }

        // Not mapped lists (used in dashboard)
        [NotMapped]
        public List<Customer> RecentCustomers
        {
            get => string.IsNullOrEmpty(RecentCustomersJson)
                    ? new List<Customer>()
                    : JsonSerializer.Deserialize<List<Customer>>(RecentCustomersJson);
            set => RecentCustomersJson = JsonSerializer.Serialize(value);
        }

        [NotMapped]
        public List<Employee> RecentEmployees
        {
            get => string.IsNullOrEmpty(RecentEmployeesJson)
                    ? new List<Employee>()
                    : JsonSerializer.Deserialize<List<Employee>>(RecentEmployeesJson);
            set => RecentEmployeesJson = JsonSerializer.Serialize(value);
        }
    }
}
