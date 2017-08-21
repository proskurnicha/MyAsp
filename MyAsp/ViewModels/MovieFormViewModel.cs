using MyAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyAsp.ViewModels
{
    public class MovieFormViewModel
    {
        public Movie Movie{ get; set; }
        public IEnumerable<Genre> Genres { get; set; }

        public string Title
        {
            get
            {
                if (Movie != null && Movie.Id != 0)
                    return "Edit movie";
                return "New movie";
            }
            set { Title = value; }
        }
    }
}