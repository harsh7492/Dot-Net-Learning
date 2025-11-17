using Microsoft.AspNetCore.Mvc;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class HarshController : Controller
    {
        // http get
        public IActionResult page1()
        {
            TempData["message"] = "hello";
            return View();
        }

        public IActionResult page2()
        {
            ViewBag.msg = TempData["message"];
            return View();
        }

        public IActionResult page3()
        {
            ViewBag.msg = TempData["message"];
            return View();
        }

        public IActionResult page4()
        {
            DB obj = new DB();
            return View(obj);
        }

        // POST
        [HttpPost]
        public IActionResult page4(DB obj)
        {
            string result = obj.name;   // get input value

            ViewBag.result = result;    // send to view

            return View(obj);           // return model to page
        }


        //[HttpPost]
        //public IActionResult page1(string t1)
        //{
        //    TempData["message"] = t1;
        //    ViewBag.msg = TempData["message"];
        //    return RedirectToAction("page2", "Harsh");
        //}
    }
}
