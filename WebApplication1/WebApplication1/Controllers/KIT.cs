using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class KIT:Controller

    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
