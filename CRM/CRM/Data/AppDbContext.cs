using CRM.Models;
using Microsoft.EntityFrameworkCore;

namespace CRM.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        // Existing DbSets
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Report> Reports { get; set; }

        // ✨ NEW: Add the DbSet for the User model
        public DbSet<User> Users { get; set; }
    }
}