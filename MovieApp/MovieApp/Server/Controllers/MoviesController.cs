using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MovieApp.Server.Services;
using System.Threading.Tasks;
using MovieApp.Shared.DTOs;
using MovieApp.Shared.Models;


namespace MovieApp.Server.Controllers
{
    [Authorize]
    [Route("api/movies")]
    [ApiController]
    public class MoviesController : ControllerBase
    {
        private readonly ILogger<MoviesController> _logger;
        private readonly IMoviesDbService _dbService;

        public MoviesController(ILogger<MoviesController> logger, IMoviesDbService dbService)
        {
            _logger = logger;
            _dbService = dbService;
        }

        [HttpGet]
        public async Task<IActionResult> GetMovies()
        {
            return Ok(await _dbService.GetMovies());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMovieById(int id)
        {
            return Ok(await _dbService.GetMovie(id));
        }

        [HttpPost]
        public async Task<IActionResult> AddMovie(MovieFormDTO movieFormDto)
        {
            await _dbService.AddMovie(new Movie
            {
                Title = movieFormDto.Title,
                Summary = movieFormDto.Summary,
                InTheaters = movieFormDto.InTheaters,
                Trailer = movieFormDto.Trailer,
                ReleaseDate = movieFormDto.ReleaseDate,
                Poster = movieFormDto.Poster
            });

            return Ok();
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> UpdateMovie(int id, MovieFormDTO movieFormDto)
        {
            var movie = await _dbService.GetMovie(id);

            if (movie == null)
            {
                return NotFound();
            }

            movie.Title = movieFormDto.Title;
            movie.Summary = movieFormDto.Summary;
            movie.InTheaters = movieFormDto.InTheaters;
            movie.Trailer = movieFormDto.Trailer;
            movie.ReleaseDate = movieFormDto.ReleaseDate;
            movie.Poster = movieFormDto.Poster;

            await _dbService.UpdateMovie(movie);

            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            _dbService.DeleteMovie(id);

            return Ok();
        }
    }
}
