using Microsoft.AspNetCore.Mvc;
using Student_Info.Models;
using System.Collections.Generic;

namespace Student_Info.Controllers
{
    public class Data : Controller
    {
        
        private static List<Info> studentList = new List<Info>();

        
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Table()
        {
            return View(studentList);
        }

        
        [HttpPost]
        public IActionResult Table(Info obj)
        {
            
            studentList.Add(obj);

            
            //ViewBag.id = obj.Roll;
            //ViewBag.name = obj.Name;
            //ViewBag.course = obj.Course;
            //ViewBag.gen = obj.gender;
            //ViewBag.address = obj.Address;
            //ViewBag.phone = obj.phone;

           
            return View(studentList);
        }
    }
}
