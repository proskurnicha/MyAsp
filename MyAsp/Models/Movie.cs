using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace MyAsp.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name  { get; set; }
        [Required]
        public Genre Genre { get; set; }
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateRelease { get; set; }
        public byte NumberInStock { get; set; }

    }
}