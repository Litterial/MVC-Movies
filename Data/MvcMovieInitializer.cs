using MVcMovie.Data;
using System.Linq;
using MVcMovie.Models;
using MVcMovie.Data.MVcMovieConfiguration;
using MVcMovie.Data.MVcMovieContext;
namespace MVcMovie.MVcMovieIntitializer{

    public class MVcMovieIntitializer{

         public static void Initialize (MVcMovieContext context){
             if (context.Movies.Any())
             {
                 return;
             }

         }

}   
}