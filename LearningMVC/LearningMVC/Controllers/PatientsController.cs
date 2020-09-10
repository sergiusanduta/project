using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LearningMVC.Controllers
{
    public class PatientsController : Controller
    {
        // http:/localhost:5000/Patients/Abc
        public IActionResult Abc()
        {
            return View();
        }

        // http:/localhost:5000/Patients/DisplayCovidPatients
        public IActionResult DisplayCovidPatients()
        {
            return View();
        }

        
    }
}
