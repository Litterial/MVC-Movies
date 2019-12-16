using Microsoft.EntityFrameworkCore;
using MVcMovie.Models;

namespace MVcMovie.Data{
    public class MVcMovieContext : DbContext{
        public MVcMovieContext (DbContextOptions<MVcMovieContext> options) : base(options){}

        public DbSet<Movie> Movies {get;set;}
    }
}