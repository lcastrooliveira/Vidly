using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;
using System.ComponentModel.DataAnnotations;

namespace Vidly.ViewModels
{
    public class MovieFormViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel(Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            ReleaseDate = movie.ReleaseDate;
            NumberInStock = movie.GenreId;
        }

        public MovieFormViewModel()
        {
            Id = 0;
        }

        public int? Id { get; set; }

        [Required(ErrorMessage = "Please enter movies's name.")]
        [StringLength(255)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please provide a release date")]
        public DateTime? ReleaseDate { get; set; }

        [Required]
        [Range(0, 20, ErrorMessage = "Stock must be between 0 and 20")]
        public int? NumberInStock { get; set; }

        [Required(ErrorMessage = "Please Choose a Genre")]
        public int? GenreId { get; set; }
    }
}