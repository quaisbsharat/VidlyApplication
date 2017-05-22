using System.Collections.Generic;
using System.Web.Mvc;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.Controllers
{
    public class MoviesController : Controller
    {
        IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie{Name = "Shrek",Id= 1},
                new Movie{Name = "Wall-e",Id= 2}
            };
        }
        // GET: Movie
        [Route("Movies/")]
        [Route("Movies/index")]
        public ActionResult Random()
        {
            return View(GetMovies());
        }
    }
}