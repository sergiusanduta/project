using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FirstMvcProject.Controllers
{
    public class Movie
    {
        public string Title { get; set; }
        public int Rating { get; set; }
    }

    public class MoviesController : Controller
    {
        public IActionResult Index()
        {
            List<Movie> movies = new List<Movie>()
            {
                new Movie { Title = "Terminator", Rating = 4},
                new Movie { Title = "Terminator3", Rating = 2},
            };

            return View(movies);
        }
    }
}
