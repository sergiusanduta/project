using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MvcCore.Controllers
{
    public class CarsController : Controller
    {
        public IActionResult Index()
        {
            return View();
     
        }

        public  IActionResult All()
        {
            return View();
        }
    }
}
