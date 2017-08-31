using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyAsp.Models;
using MyAsp.ViewModels;

namespace MyAsp.Controllers
{
    public class MoviesController : Controller
    {
        private ApplicationDbContext _context;

        public MoviesController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        [Authorize(Roles = RoleName.CanManageMovie)]
        public ActionResult New()
        {
            if (!ModelState.IsValid)
            {
                var movieForm = new MovieFormViewModel
                {

                };
                return View("MovieForm", movieForm);
            }
            var genres = _context.Genres.ToList();
            var movieFormViewModel = new MovieFormViewModel()
            {
                Genres = genres
            };
            return View("MovieForm", movieFormViewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovie)]
        public ActionResult Edit(int id)
        {
            var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == id);
            if (movieInDb == null)
                return HttpNotFound();
            var movieFormViewModel = new MovieFormViewModel(movieInDb)
            {
                Genres = _context.Genres.ToList()
            };
            return View("MovieForm", movieFormViewModel);
        }

        [Authorize(Roles = RoleName.CanManageMovie)]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Save(Movie movie)
        {
            if (!ModelState.IsValid)
            {
                var movieModel = new MovieFormViewModel()
                {
                    Genres = _context.Genres.ToList()
                };
                return View("MovieForm", movieModel);
            }
            movie.DateAdded = DateTime.Now;
            if (movie.Id == 0)
            {
                _context.Movies.Add(movie);
            }

            else
            {
                var movieInDb = _context.Movies.SingleOrDefault(m => m.Id == movie.Id);
                movieInDb.DateRelease = movie.DateRelease;
                movieInDb.Genre = movie.Genre;
                movieInDb.Name = movie.Name;
                movieInDb.NumberInStock = movie.NumberInStock;
            }
            _context.SaveChanges();
            return RedirectToAction("Index", "Movies");
        }

        // GET: Movies/Random
        public ActionResult Index()
        {
            if (User.IsInRole("CanManageMovie"))
                return View("List");
            else
                return View("ReadOnlyList");
        }

        [Authorize(Roles = RoleName.CanManageMovie)]
        public ActionResult Details(int id)
        {
            var movie = _context.Movies.Include(c => c.Genre).SingleOrDefault(mov => mov.Id == id);
            if (movie == null)
                return HttpNotFound();
            return View(movie);
        }
    }
}