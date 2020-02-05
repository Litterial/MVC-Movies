using Microsoft.EntityFrameworkCore;
using MVcMovie.Models;

namespace MVcMovie.Data.MVcMovieContext{
    public class MVcMovieContext : DbContext{
        public MVcMovieContext (DbContextOptions<MVcMovieContext> options) : base(options){ Database.EnsureCreated();}

        public DbSet<Movie> Movies {get;set;}

        protected override void OnModelCreating (ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MVcMovieContext).Assembly);
        }
    }
}