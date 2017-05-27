using AutoMapper;
using System;
using System.Linq;
using System.Web.Http;
using VidlyThirdTime.Dtos;
using VidlyThirdTime.Models;

namespace VidlyThirdTime.Controllers.api
{
    public class MoviesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        // GET /api/movies
        [HttpGet]
        public IHttpActionResult GetMovies()
        {
            var movie = _context.Movies.ToList().Select(Mapper.Map<Movie, MoviesDto>);
            return Ok(movie);
        }

        // GET /api/movies/1
        [HttpGet]
        public IHttpActionResult GetMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();

            return Ok(Mapper.Map<Movie, MoviesDto>(movie));
        }

        // POST /api/movies
        [HttpPost]
        public IHttpActionResult CreateMoive(MoviesDto moviesDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var movie = Mapper.Map<MoviesDto, Movie>(moviesDto);
            movie.DateAdded = DateTime.Now;

            _context.Movies.Add(movie);
            _context.SaveChanges();

            moviesDto.Id = movie.Id;
            moviesDto.DateAdded = movie.DateAdded;

            return Created(new Uri(Request.RequestUri + "/" + moviesDto.Id), moviesDto);
        }

        // PUT /api/Movie/1
        [HttpPut]
        public IHttpActionResult UpdateMovie(int id, MoviesDto moviesDto)
        {
            if (!ModelState.IsValid) return BadRequest();

            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);

            if (movieInDb == null) return NotFound();

            Mapper.Map(moviesDto, movieInDb);
            _context.SaveChanges();
            return Ok();
        }

        // DELETE /api/movie/1
        [HttpDelete]
        public IHttpActionResult RemoveMovie(int id)
        {
            var movie = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movie == null) return NotFound();

            _context.Movies.Remove(movie);
            _context.SaveChanges();
            return Ok();
        }

    }
}
