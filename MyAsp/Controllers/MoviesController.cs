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
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Shrek" };
            ViewData["Movies"] = movie;
            return View();
        }
        //public ActionResult Random()
        //{
        //    var movie = new Movie() { Name = "Shrek" };

        //    return View(movie);
        //}

        //[Route("Movies/released/{year:regex(\\d{4}):range(1900,2017)}/{month:regex(\\d{1,2}):range(1,12)}")]
        ////min, max, minlength, maxlength, float, int, guid
        //public ActionResult ByReleaseDate(int year, int month)
        //{
        //    return Content(year + "/" + month);
        //}

        //public ActionResult Edit(int movieId)
        //{
        //    return Content("id=" + movieId);
        //}

        //public ActionResult Index(int? pageIndex, string sortBy)
        //{
        //    if (!pageIndex.HasValue)
        //        pageIndex = 1;
        //    if (string.IsNullOrWhiteSpace(sortBy))
        //        sortBy = "Name";
        //    return Content(String.Format("pageIndex = {0} and sortBy = {1}", pageIndex, sortBy));
        //}
    }
}