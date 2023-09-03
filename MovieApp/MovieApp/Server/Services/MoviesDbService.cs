using System;
using Microsoft.EntityFrameworkCore;
using MovieApp.Server.Data;
using MovieApp.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MovieApp.Shared.DTOs;

namespace MovieApp.Server.Services
{
    public interface IMoviesRepository
    {

    }

    public interface IMoviesDbService
    {
        Task<List<Movie>> GetMovies();
        Task<Movie> AddMovie(Movie movie);
        Task<Movie> GetMovie(int movieId);
        Task<Movie> UpdateMovie(Movie movie);
        void DeleteMovie(int movieId);
    }

    public class MoviesDbService : IMoviesDbService
    {
        private readonly ApplicationDbContext _context;

        public MoviesDbService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Movie> AddMovie(Movie movie)
        {
            await _context.Movies.AddAsync(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        public Task<Movie> GetMovie(int movieId)
        {
            return _context.Movies
                .Include(m => m.MoviesGenres)
                .Include(m => m.MoviesActors)
                .FirstOrDefaultAsync(m => m.Id == movieId);
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            _context.Movies.Update(movie);
            await _context.SaveChangesAsync();

            return movie;
        }

        public void DeleteMovie(int movieId)
        {
            var movie = _context.Movies.Find(movieId);

            if (movie == null)
            {
                throw new Exception("Movie not found");
            }

            _context.Movies.Remove(movie);
            _context.SaveChanges();
        }

        public Task<List<Movie>> GetMovies()
        {
            return _context.Movies.OrderBy(m => m.Title).ToListAsync();
        }
    }
}
