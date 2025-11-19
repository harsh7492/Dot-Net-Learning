using Microsoft.AspNetCore.Mvc;
using WebApplication2.Data;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class Record : Controller
    {
        private readonly AppDbContext _context;
        public Record(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Student1()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Student1(Student std)
        {
            _context.Students.Add(std);
            _context.SaveChanges();
            return RedirectToAction("Data");
        }
        public IActionResult Data()
        {
            return View();
        }


    }
}
