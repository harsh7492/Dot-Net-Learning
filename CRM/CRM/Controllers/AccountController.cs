using CRM.Data;
using CRM.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Security.Claims;

namespace CRM.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;

        // The PasswordHasher service is REMOVED from the constructor.
        public AccountController(AppDbContext context)
        {
            _context = context;
        }

        // --- REGISTER (GET) ---
        public IActionResult Register()
        {
            return View();
        }

        // --- REGISTER (POST) ---
        [HttpPost]
        public async Task<IActionResult> Register(string name, string email, string password, string confirm)
        {
            if (password != confirm)
            {
                ViewBag.Error = "Password and confirmation password do not match.";
                return View();
            }

            if (await _context.Users.AnyAsync(u => u.Email == email))
            {
                ViewBag.Error = "An account with this email already exists.";
                return View();
            }

            // WARNING: Storing plain text password in PasswordHash is UNSAFE.
            var user = new User
            {
                Name = name,
                Email = email,
                PasswordHash = password, // INSECURE: Storing plain text password
                Role = "User"
            };

            _context.Users.Add(user);
            await _context.SaveChangesAsync();

            return RedirectToAction("Login");
        }

        // --- LOGIN (GET) ---
        public IActionResult Login()
        {
            return View();
        }

        // --- LOGIN (POST) ---
        [HttpPost]
        public async Task<IActionResult> Login(string email, string password)
        {
            // WARNING: Validating against plain text stored in PasswordHash is UNSAFE.
            var user = await _context.Users
                .FirstOrDefaultAsync(u => u.Email == email && u.PasswordHash == password);

            if (user == null)
            {
                ViewBag.Error = "Invalid login attempt.";
                return View();
            }

            // Authentication succeeded: Create Claims Identity
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(ClaimTypes.Email, user.Email),
                new Claim(ClaimTypes.Name, user.Name ?? user.Email),
                new Claim(ClaimTypes.Role, user.Role)
            };

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);

            await HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity));

            return RedirectToAction("Index", "Home");
        }

        // --- LOGOUT ---
        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Welcome", "Home");
        }
    }
}