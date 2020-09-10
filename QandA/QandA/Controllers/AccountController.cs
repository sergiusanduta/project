using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace QandA.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult SignOut()
        {
            return View();
        }

        public IActionResult SignIn()
        {
            return View();
        }
    }
}
