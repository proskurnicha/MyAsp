using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using AutoMapper;
using MyAsp.Dtos;
using MyAsp.Models;

namespace MyAsp.Controllers.API
{
    public class CustomersController : ApiController
    {
        private ApplicationDbContext _contex;

        public CustomersController()
        {
            _contex = new ApplicationDbContext();
        }

        protected override void Dispose(bool disposing)
        {
            _contex.Dispose();
        }

        //GET /api/customers - возвращает всех пользователей
        public IHttpActionResult GetCustomers()
        {
            var customerDtos = _contex.Customers.ToList().Select(Mapper.Map<Customer, CustomerDto>);
            return Ok(customerDtos);
        }

        //GET /api/customers/1 -  возвращает одного пользователя
        public IHttpActionResult GetCustomer(int id)
        {
            var customer = _contex.Customers.SingleOrDefault(m => m.ID == id);
            if (customer == null)
            {
                return NotFound();
            }
            return Ok(Mapper.Map<Customer, CustomerDto>(customer));
        }

        [HttpPost]
        //POST api/customers - create a new customerDto
        public IHttpActionResult CreateCustomer(CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var customer = Mapper.Map<CustomerDto, Customer>(customerDto); 
            _contex.Customers.Add(customer);
            _contex.SaveChanges();

            return Created(new Uri(Request.RequestUri + "/" + customer.ID), customerDto);
        }

        //PUT api/customers/1  - update customerDto
        [HttpPut]
        public IHttpActionResult UpdateCustomer(int id, CustomerDto customerDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var customerInDb = _contex.Customers.SingleOrDefault(m => m.ID == id);

            if (customerInDb == null)
                return NotFound();

            Mapper.Map(customerDto, customerInDb);
            _contex.SaveChanges();

            return Ok();
        }

        //DELETE /api/customer1
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(int id)
        {
            var customer = _contex.Customers.SingleOrDefault(m => m.ID == id);

            if (customer == null)
                return NotFound();

            _contex.Customers.Remove(customer);
            _contex.SaveChanges();

            return Ok();
        }
    }
}
