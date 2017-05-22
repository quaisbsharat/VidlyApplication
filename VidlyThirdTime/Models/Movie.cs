using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyThirdTime.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }
        public DateTime DateAdded { get; set; }
        public int Stock { get; set; }

        //Navigation Propery
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }

        public Movie()
        {
            DateAdded = DateTime.Now;
        }
    }
}