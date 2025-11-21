using CRM.Data;
using CRM.Models;
 // FIX: Necessary using directive
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace CRM.Controllers
{
    [Authorize] // Protects the search page
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index(string query)
        {
            var model = new SearchResultViewModel { SearchTerm = query };

            if (string.IsNullOrWhiteSpace(query))
            {
                return View(model);
            }

            string lowerQuery = query.Trim().ToLower();

            // Queries use lowercase properties
            model.Customers = await _context.Customers
                .Where(c =>
                    (c.email != null && c.email.ToLower().Contains(lowerQuery)) ||
                    (c.name != null && c.name.ToLower().Contains(lowerQuery)) ||
                    (c.phoneNumber != null && c.phoneNumber.ToLower().Contains(lowerQuery)))
                .ToListAsync();

            model.Employees = await _context.Employees
                .Where(e =>
                    (e.email != null && e.email.ToLower().Contains(lowerQuery)) ||
                    (e.name != null && e.name.ToLower().Contains(lowerQuery)) ||
                    (e.position != null && e.position.ToLower().Contains(lowerQuery)))
                .ToListAsync();

            return View(model);
        }
    }
}