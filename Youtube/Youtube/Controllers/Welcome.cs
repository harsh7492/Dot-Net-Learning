using Microsoft.AspNetCore.Mvc;

namespace Self.Controllers
{
    public class Welcome : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Square()
        {
            int num = 5;
            int result = num * num;
            ViewBag.data = result;
            return View();
        }
    }
}
