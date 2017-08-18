using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MyAsp
{
    public class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            routes.IgnoreRoute("{resource}.axd/{*pathInfo}");

            //routes.MapMvcAttributeRoutes();

            //routes.MapRoute(
            //    "MoviesByRealeseDate",
            //    "Movies/released/{year}/{month}",
            //    new {controller  = "movies", action = "ByReleaseDate"},
            //    new {year = @"\d{4}", month = @"\d{1,2}"});//@"2016|2017"

            routes.MapRoute(
                name: "Default",
                url: "{controller}/{action}/{id}",
                defaults: new { controller = "Home", action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}
