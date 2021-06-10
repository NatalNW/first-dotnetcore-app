using Microsoft.EntityFrameworkCore;

namespace FilmesCRUDRazor.Models
{
    public class MovieContext : DbContext
    {
        public MovieContext(DbContextOptions<MovieContext> options) : base(options){
            //Default
        }

        public DbSet<Movie> Filme { get; set; }
    }
}