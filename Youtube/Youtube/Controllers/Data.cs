using Microsoft.AspNetCore.Mvc;
using Self.Models;


namespace Self.Controllers
{
    public class Data : Controller
    {
        public IActionResult Index()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult Index(Add obj)
        {
            int sum=obj.num1+obj.num2;
            ViewBag.Sum=sum;

            return View();
        }

    }
}
