using MyAsp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using MyAsp.ViewModels;

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

        public ActionResult New()
        {
            var membershipType = _context.MembershipTypes.ToList();
            var viewModel = new NewCustomerViewModel()
            {
                MembershipTypes = membershipType
            };
            return View(viewModel);
        }

        [HttpPost]
        public ActionResult Create(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
            return RedirectToAction("Index", "Customers");
        }
        // GET: Customers
        public ActionResult Index()
        {
            //Include для того что бы извлекать данные из таблицы MembershipType
            var customers = _context.Customers.Include(c => c.MembershipType).ToList();
            return View(customers);
        }

        public ActionResult Deteils(int id)
        {
            var customer = _context.Customers.Include(c => c.MembershipType).SingleOrDefault(cust => cust.ID == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }

    }
}