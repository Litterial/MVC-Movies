using System;
using System.ComponentModel.DataAnnotations;
using MVcMovie.Enumerations;
using MVcMovie.Validating;

namespace MVcMovie.Models{
    public class Movie{ 
        private  DateTime _releaseDate;     
        public int ID {get;set;}
        
        [Required]
        [MaxLength(50)]
        public string Title { get;set; }
        
        [Required]
        [DataType(DataType.Date)]
        [Range(typeof(DateTime),"1/1/1950","12/31/2020",ErrorMessage = "Years must be between 1950 and 2020")]
        public DateTime ReleaseDate { 
            get{return _releaseDate;}
            set{ _releaseDate = value;} 
        }
        
        [Required]
        [MovieYear]
        // [Compare ("ReleaseDate",ErrorMessage = "Years do not match.")]
        public int Year { get; set; }

        public Genre Genre {get;set;}

       

    }

}