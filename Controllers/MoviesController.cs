using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class MoviesController : Controller
    {

        [Route("movies")]
        public ActionResult Movies() 
        {
            return View(this.getMovies()); 
        }

        [Route("movies/{id}")]
        public ActionResult Details(int Id)
        {
            return View(this.getMovies()[Id]);
        }

        [Route("movies/random")]
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek!" };
            var customers = new List<Customer>
            {
                new Customer { Name = "Customer 1" },
                new Customer { Name = "Customer 2" }
            };

            var viewModel = new RandomMovieViewModel
            {
                Movie = movie,
                Customers = customers
            };

            return View(viewModel);
        }

        //[Route("movies/random")]
        public ActionResult Edit(int movieId)
        {
            return Content("Movie ID: " + movieId); 
        }   

        public ActionResult Index(int? page, string sortBy) 
        {
            if(!page.HasValue) 
            {
                page = 1;
            }

            if(String.IsNullOrWhiteSpace(sortBy)) 
            {
                sortBy = "Name";
            }

            return Content(String.Format("page={0}&sortBy={1}", page, sortBy));
        }

        [Route("movies/released/{year}/{month}")]
        public ActionResult ByReleaseDate(int year, int month) 
        {
            return Content(String.Format("{0} : {1}", month, year)); 
        }

        public List<Movie> getMovies() 
        {
            var movies = new List<Movie>
            {
                new Movie { Id = 1, Name = "Gatsby" },
                new Movie { Id = 2, Name = "The Wolf of Wallstreet" }
            };

            return movies;
        }
    }
}
