using CRM.Models;
using CRM.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CRM.Controllers
{
    public class ReportController : Controller
    {
        private readonly AppDbContext _context;

        public ReportController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Generate()
        {
            var report = new Report
            {
                TotalCustomers = _context.Customers.Count(),
                TotalEmployees = _context.Employees.Count(),

                TodayNewCustomers = _context.Customers
                    .Count(c => c.CreatedDate.Date == DateTime.Today),

                TodayNewEmployees = _context.Employees
                    .Count(e => e.CreatedDate.Date == DateTime.Today),

                RecentCustomers = _context.Customers
                    .OrderByDescending(x => x.Id)
                    .Take(5)
                    .ToList(),

                RecentEmployees = _context.Employees
                    .OrderByDescending(x => x.Id)
                    .Take(5)
                    .ToList()
            };

            // Save only summary data (list not saved)
            _context.Reports.Add(report);
            _context.SaveChanges();

            return RedirectToAction("Index", new { id = report.Id });
        }

        public IActionResult Index(int id)
        {
            var report = _context.Reports.Find(id);

            if (report == null)
                return NotFound();

            // Fill lists again (REAL data loaded now)
            report.RecentCustomers = _context.Customers
                .OrderByDescending(c => c.Id)
                .Take(5)
                .ToList();

            report.RecentEmployees = _context.Employees
                .OrderByDescending(e => e.Id)
                .Take(5)
                .ToList();

            return View(report);
        }
    }
}
