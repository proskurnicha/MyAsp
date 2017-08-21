using MyAsp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyAsp.ViewModels
{
    public class MovieFormViewModel
    {
        public int? Id { get; set; }

        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Genre")]
        public byte? GenreId { get; set; }

        [Required]
        [Display(Name = "Data release")]
        public DateTime? DateRelease { get; set; }

        [Required]
        [Display(Name = "Number in stock")]
        [Range(1, 20)]
        public byte? NumberInStock { get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public MovieFormViewModel()
        {
            Id = 0;
        }
        public MovieFormViewModel( Movie movie)
        {
            Id = movie.Id;
            Name = movie.Name;
            GenreId = movie.GenreId;
            DateRelease = movie.DateRelease;
            NumberInStock = movie.NumberInStock;
        }
        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit movie";
                return "New movie";
            }
        }
    }
}