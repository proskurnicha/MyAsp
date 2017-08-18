using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAsp.Models;

namespace MyAsp.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Movies/Random
        public ActionResult Index()
        {
            var movie = GetMovies();
            return View(movie);
        }

        public ActionResult Details(int id)
        {
            var movie = GetMovies().SingleOrDefault(mov => mov.ID == id);
            if(movie == null)
                return HttpNotFound();
            return View(movie);
        }
        public IEnumerable<Movie> GetMovies()
        {
            return new List<Movie>()
            {
                new Movie() {ID=1, Name ="Game of Thrones"},
                new Movie(){ID=2, Name="Shrek"}
            };
        }
    }
}