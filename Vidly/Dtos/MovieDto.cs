using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

namespace Vidly.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter movies's name.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a release date")]
        public DateTime ReleaseDate { get; set; }

        public DateTime DateAdded { get; set; }

        [Range(0, 20, ErrorMessage = "Stock must be between 0 and 20")]
        public int NumberInStock { get; set; }

        public GenreDto Genre { get; set; }

        [Required(ErrorMessage = "Please Choose a Genre")]
        public int GenreId { get; set; }
    }
}