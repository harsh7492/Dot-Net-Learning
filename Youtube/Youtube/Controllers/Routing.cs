using Microsoft.AspNetCore.Mvc;

namespace Self.Controllers
{
    public class Routing : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Info()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
