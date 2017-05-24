﻿using System;
using System.ComponentModel.DataAnnotations;

namespace VidlyThirdTime.Models
{
    public class Movie
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Display(Name = "Release Date")]
        [Required]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Required]
        [Display(Name = "Number on Stock")]
        public int Stock { get; set; }

        //Navigation Propery
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }

        public Movie()
        {
            DateAdded = DateTime.Now;
        }
    }
}