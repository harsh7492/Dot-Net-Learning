using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class CRUD : Controller
    {
        private readonly AppDbContext _context;
        public CRUD(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(People emp)
        {
            _context.Employees.Add(emp);
            _context.SaveChanges();
            return RedirectToAction("Result");
        }
        public IActionResult Result()
        {
            var data = _context.Employees.ToList();
            return View(data);
        }
        //public IActionResult Result()
        //{
        //    var data = _context.Employees.Where(equals => equals.Name == "ram").ToList();
        //    return View(data);
        //}



    }
}
