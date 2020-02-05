using System;
using System.ComponentModel.DataAnnotations;
using MVcMovie.Models;

namespace MVcMovie.Validating{
    public class MovieYearAttribute : ValidationAttribute
    {
        public MovieYearAttribute()
        {
            Year = Int32.Parse(DateTime.Now.Year.ToString())+1;
            
        }

        public int Year { get; }

        public string HigherYear() =>
            $"Movies must have a release year between 1950 and {Year}.";

        public string YearMismatch() =>
            $"Your selected year must match with you Release Date Year";
        protected override ValidationResult IsValid(object value,
            ValidationContext validationContext)
        {
            // int count=0;
            var movie = (Movie)validationContext.ObjectInstance;
            var yearString =value.ToString();
            var releaseYear = Int32.Parse(yearString);
            var calendarYear= Int32.Parse((movie.ReleaseDate).Year.ToString());
            // bool boolYear= Int32.TryParse(yearString,out count);
            // // var releaseYear1 = value.ToString();
            Console.WriteLine(releaseYear);

            if (releaseYear > Year)
            {
                return new ValidationResult(HigherYear());
            }

            if (releaseYear != calendarYear)
            {
                  return new ValidationResult(YearMismatch());
            }

            return ValidationResult.Success;
        }
    }
}