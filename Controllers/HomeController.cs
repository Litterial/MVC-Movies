using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVcMovie.Models;

namespace MVcMovie.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private MovieRepository _movieRepository;

        public HomeController(ILogger<HomeController> logger, MovieRepository movieRepo)
        {
            _logger = logger;
            _movieRepository = movieRepo;
        }

        public IActionResult Index()
        {
            // ViewData["ID"] = _movieRepository.GetMovie(1).ID;
            // ViewData["Name"] = _movieRepository.GetMovie(1).Title;
            // ViewData["Year"] = _movieRepository.GetMovie(1).Year;
            // ViewData["FullDate"] = _movieRepository.GetMovie(1).ReleaseDate.ToString("MMMM d, yyyy");
            var model = _movieRepository.GetAll();

            

            return View(model);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult MovieForm()
        {
        
            return View();
        }

        [HttpPost]
        public IActionResult MovieForm(Movie movie)
        {
            if(ModelState.IsValid){
                Movie newMovie = _movieRepository.addMovie(movie);
                return RedirectToAction("Index");
            }
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
