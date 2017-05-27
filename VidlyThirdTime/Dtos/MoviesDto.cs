using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyThirdTime.Dtos
{
    public class MoviesDto
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Range(1, 20)]
        public int Stock { get; set; }

        [Required]
        public byte GenreId { get; set; }

    }
}