using System;
using System.Linq;
using System.Collections.Generic;
using MVcMovie.Models;
using MVcMovie.Data.MVcMovieContext;
using MVcMovie.Repository.MovieRepo;
using MVcMovie.Enumerations;

namespace MVcMovie.Repository.MockMovieRepo
{
    public class SQLMovieRepo : MovieRepository
    {
        private readonly MVcMovieContext context;

        public SQLMovieRepo(MVcMovieContext context)
        {
            this.context = context;

        }

        public Movie GetMovie(int id)
        {
            return context.Movies.Find(id);
        }

        public IEnumerable <Movie> GetAll()
        {
         
         return context.Movies;

        }

        public Movie addMovie (Movie movie)
        {
            // movie.ID = _movieList.Count +1 ;
            context.Movies.Add(movie);
            context.SaveChanges();
            return movie;
        }

        public IEnumerable <Genre> getGenres(){
            var genreArray = new List <Genre>();
            foreach(Genre genres in Enum.GetValues(typeof(Genre)))
            {
                genreArray.Add(genres);
            }
            return genreArray;


        }
    }
}
