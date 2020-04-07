using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mhmdkoeik_Assignment2.Models;

namespace Mhmdkoeik_Assignment2.Controllers
{
    public class CustomersController : Controller
    {

        // GET: Customers
        public ViewResult Index()
        {
            var customers = GetCustomers();

            return View(customers);
        }

        public ActionResult Details(int id)

        {
            var customer = GetCustomers().SingleOrDefault(c => c.id == id);

            if (customer == null)
                return HttpNotFound();

            return View(customer);
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { id = 1, Name = "John Smith" },
                new Customer { id = 2, Name = "Mary Williams" }
            };
        }
    }
}