using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using MyAsp.Models;

namespace MyAsp.Dtos
{
    public class MovieDto
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }

        [Required]
        public byte GenreId { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateRelease { get; set; }

        [Range(1,20)]
        public byte NumberInStock { get; set; }
    }
}