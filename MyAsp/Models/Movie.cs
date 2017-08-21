using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MyAsp.Models
{
    public class Movie
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name  { get; set; }
        public Genre Genre { get; set; }
        [Required]
        [Display(Name = "Genre")]
        public byte GenreId { get; set; }
        [Required]
        [Display(Name = "Data added")]
        public DateTime? DateAdded { get; set; }
        [Required]
        [Display(Name = "Data release")]
        public DateTime? DateRelease { get; set; }
        [Required]
        [Display(Name = "Number in stock")]
        public byte NumberInStock { get; set; }

    }
}