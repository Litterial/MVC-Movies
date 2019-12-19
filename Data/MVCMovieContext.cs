using Microsoft.EntityFrameworkCore;
using MVcMovie.Models;

namespace MVcMovie.Data{
    public class MVcMovieContext : DbContext{
        public MVcMovieContext (DbContextOptions<MVcMovieContext> options) : base(options){ Database.EnsureCreated();}

        public DbSet<Movie> Movies {get;set;}
    }
}