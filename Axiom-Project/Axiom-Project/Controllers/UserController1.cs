using Axiom_Project.Data;
using Microsoft.AspNetCore.Mvc;
using Axiom_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace Axiom_Project.Controllers
{
    public class UserController1 : Controller
    {
        private readonly AppDbContext _context;

        public UserController1(AppDbContext context)
        {
            _context = context;
        }

        // ---------------- REGISTER ----------------
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(User user)
        {
            _context.Users.Add(user);
            _context.SaveChanges();
            return RedirectToAction("Login");
        }

        // ---------------- LOGIN ----------------
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users
                .FirstOrDefault(x => x.email == email && x.password == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid Email or Password!";
                return View();
            }

            // save session
            HttpContext.Session.SetInt32("UserId", user.id);

            return RedirectToAction("Dashboard");
        }

        // ---------------- DASHBOARD ----------------
        public IActionResult Dashboard()
        {
            int? userId = HttpContext.Session.GetInt32("UserId");

            if (userId == null)
                return RedirectToAction("Login");

            var user = _context.Users.FirstOrDefault(x => x.id == userId);

            return View(user);
        }

        // ---------------- LOGOUT ----------------
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
