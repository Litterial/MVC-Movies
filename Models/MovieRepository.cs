using System.Collections.Generic;

namespace MVcMovie.Models
{
    public interface MovieRepository
    {
        Movie GetMovie (int Id);
        IEnumerable <Movie> GetAll();
        Movie addMovie(Movie movie);
    }
}
