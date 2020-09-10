using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningMVC.Controllers
{
    
    public class CarsController : Controller
    {
        List<string> bmws = new List<string>() {"BMW","i8","750i","320i","M5","M3","M4"};

        // localhost:5000/cars/ferrari
        public IActionResult Ferrari()
        {
            return View();
        }

        public IActionResult BMW()
        {
            return View(bmws);
        }
    }
}
