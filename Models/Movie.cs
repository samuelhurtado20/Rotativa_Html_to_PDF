using System.Collections.Generic;

namespace Rotativa_Html_to_PDF.Models
{
    public class Movie
    {
        public Movie()
        {

        }

        public Movie(string name, int year, string type)
        {
            this.Name = name;
            this.Year = year;
            this.Type = type;
        }

        public string Name { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
    }

    public class Movies
    {
        public List<Movie> Action { get; set; }
        public List<Movie> Thriller { get; set; }
    }
}
