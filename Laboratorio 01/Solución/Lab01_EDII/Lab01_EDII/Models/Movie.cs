using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab01_EDII.Models
{
    public class Movie
    {
        //Constructor de modelo Bebida
        public Movie(string _director, string _imdbRating, string _genre, string _relaseDate, string _rottenTomatoesRating, string _title)
        { 
            Director = _director;
            ImbdRating = _imdbRating;
            Genre = _genre;
            RelaseDate = _relaseDate;  //Investigar formato de fecha
            RottenTomatoesRating = _rottenTomatoesRating;
            Title = _title;
        }
        public Movie()
        {

        }
        public string Director { get; set; }
        public string ImbdRating { get; set; }
        public string Genre { get; set; }
        public string RelaseDate { get; set; }
        public string RottenTomatoesRating { get; set; }
        public string Title { get; set; }
    }
}
