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
        // GET: Customers
        public ActionResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Deteils(int id)
        {
            var customer = GetCustomers().SingleOrDefault(cust => cust.ID == id);
            if (customer == null)
                return HttpNotFound();
            return View(customer);
        }



        public IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer() {ID = 1, Name = "Natalia"},
                new Customer() {ID = 2, Name = "Bogdan"},
                new Customer() {ID = 3, Name = "Victor"}
            };
        }
    }
}