using System.Collections.Generic;
using MVcMovie.Models;
using MVcMovie.Enumerations;
namespace MVcMovie.Repository.MovieRepo
{
    public interface MovieRepository
    {
        Movie GetMovie (int Id);
        IEnumerable <Movie> GetAll();
        Movie addMovie(Movie movie);

        IEnumerable<Genre> getGenres();    }
}
