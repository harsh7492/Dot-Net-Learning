using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        // This creates a table called Employees
        public DbSet<People> Employees { get; set; }
        public DbSet<Student> Students { get; set; }
    }
}
