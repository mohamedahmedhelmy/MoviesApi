using Microsoft.EntityFrameworkCore;
using MoviesApi.Data;
using MoviesApi.Entities;

namespace MoviesApi.Services
{
    public class MoviesService : IMoviesService
    {
        private readonly ApplicationDbContext _ctx;
        public MoviesService(ApplicationDbContext ctx)
        {
            _ctx = ctx;
        }
        public async Task<Movie> Add(Movie movie)
        {
          await _ctx.movies.AddAsync(movie);
            _ctx.SaveChanges();
            return movie;
        }

        public Movie Delete(Movie movie)
        {
             _ctx.movies.Remove(movie);
             _ctx.SaveChanges();
            return movie;
        }

        public async Task<IEnumerable<Movie>> GetAll(int genre=0)
        {
           return await _ctx.movies.Include(m=>m.Genre)
                .Where(m=>m.GenreId == genre || genre==0)
                .OrderByDescending(m => m.Rate)
                .ToListAsync();
        }

        public async Task<Movie> GetById(int id)
        {
          return  await _ctx.movies.Where(m=>m.Id == id).FirstOrDefaultAsync();
        }

        public Movie Update(Movie movie)
        {
            _ctx.movies.Update(movie);
            _ctx.SaveChanges();
            return movie;
        }
    }
}
