using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mhmdkoeik_Assignment2.Models;

namespace Mhmdkoeik_Assignment2.Controllers
{
        // GET: Movies
        public class MoviesController : Controller
        {
            public ViewResult Index()
            {
                var movies = GetMovies();

                return View(movies);
            }
        public ActionResult Details(int id)

        {
            var movie = GetMovies().SingleOrDefault(c => c.id == id);

            if (movie == null)
                return HttpNotFound();

            return View(movie);
        }

        private List<Movie> GetMovies()
            {
                return new List<Movie>
            {
                new Movie { id = 1, Name = "Fast and Furious" },
                new Movie { id = 2, Name = "Mr.Robot" }
            };
            }
        }
    }

           //var movie = new Movie() { Name = "Mhmdkoeik!" };

/*var customers = new List<Customer>
{
    new Customer {Name = "Customer 1"},
    new Customer {Name = "Customer 2"}
};
var viewModel = new RandomMovieViewModel
{
    Movie = movie,
    Customer = customers
};

 return View(viewModel);
//return Content("hello world");
//return HttpNotFound();
//return new EmptyResult();
//return RedirectToAction("Index", "Home", new { page = 1, sortBy = "name" });
}

public ActionResult Edit(int id)
{
return Content("id = " + id);
}

public ActionResult Index(int? pageIndex, string sortBy)
{
if (!pageIndex.HasValue)
{
    pageIndex = 1;
}
if (String.IsNullOrWhiteSpace(sortBy))
{
    sortBy = "Name";
}

return Content(String.Format("pageIndex={0} & sortBy={1}",pageIndex,sortBy));
}

public ActionResult ByReleaseDate(int year , int month)
{
return Content(year + "/" + month);
}

*/
      