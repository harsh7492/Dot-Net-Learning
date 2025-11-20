using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

namespace CRM.Controllers
{
    public class HomeController : Controller
    {
        // Public welcome page (Allows anyone to access)
        [AllowAnonymous]
        public IActionResult Welcome()
        {
            return View();
        }

        // Main dashboard after successful login
        [Authorize]
        public IActionResult Index()
        {
            return View();
        }

        // ⚙️ FIX ADDED: Action for the "Settings" link in the sidebar
        [Authorize]
        public IActionResult Privacy()
        {
            return View();
        }

        // You should also include a basic error action if you haven't already
        // [AllowAnonymous]
        // public IActionResult Error()
        // {
        //     return View();
        // }
    }
}