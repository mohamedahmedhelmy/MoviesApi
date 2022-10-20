using Microsoft.EntityFrameworkCore;
using MoviesApi.Entities;

namespace MoviesApi.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

        }
        public DbSet<Movie> movies { get; set; }
        public DbSet<Genre> genres { get; set; }
    }
}
