using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.Controllers.api
{
    public class MoviesController : ApiController
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        public IEnumerable<Movie> GetMovies()
        {
            return _context.Movies.ToList();
        }
    }
}
