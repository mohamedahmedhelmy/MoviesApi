using Microsoft.EntityFrameworkCore;
using MoviesApi.Data;
using MoviesApi.Entities;

namespace MoviesApi.Services
{
    public class GenresService: IGenresService
    {
        private readonly ApplicationDbContext _context;

        public GenresService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Genre> Add(Genre genre)
        {
            await _context.AddAsync(genre);
            _context.SaveChanges();

            return genre;
        }

        public Genre Delete(Genre genre)
        {
            _context.Remove(genre);
            _context.SaveChanges();

            return genre;
        }

        public async Task<IEnumerable<Genre>> GetAll()
        {
            return await _context.genres.OrderBy(g => g.Name).ToListAsync();
        }

        public async Task<Genre> GetById(int id)
        {
            return await _context.genres.SingleOrDefaultAsync(g => g.Id == id);
        }

        public Task<bool> IsvalidGenre(byte id)
        {
            return _context.genres.AnyAsync(g => g.Id == id);
        }

        public Genre Update(Genre genre)
        {
            _context.Update(genre);
            _context.SaveChanges();

            return genre;
        }
    }
}
