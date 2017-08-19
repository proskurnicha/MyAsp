using MyAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyAsp.Controllers
{
    public class CustomersController : Controller
    {
        private ApplicationDbContext _context;

        public CustomersController()
        {
            _context = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }

        // GET: Customers
        public ActionResult Index()
        {
            var customers = _context.Customers.ToList();
            return View(customers);
        }

        public ActionResult Deteils(int id)
        {
            var customer = _context.Customers.SingleOrDefault(cust => cust.ID == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

    }
}