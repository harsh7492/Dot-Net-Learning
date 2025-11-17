using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;
using WebApplication1.Models.LoginModel;

namespace WebApplication1.LoginController.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Login model)
        {
            if (model.UserId == "admin" && model.Password == "123")
            {
                return RedirectToAction("Index", "Dash");
            }

            ViewBag.Error = "Invalid UserId or Password!";
            return View();
        }

        public IActionResult Index1()
        {
            return View();
        }
    }
}
