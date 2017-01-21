using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        static List<Customer> customers = new List<Customer>()
        {
            new Customer { Id = 1, Name = "Mariah Carry" },
            new Customer { Id = 2, Name = "Eduardo Cunha" }
        };
        // GET: Customers
        public ActionResult Index()
        {
            return View(customers);
        }


        [Route("Customers/Details/{id}")]
        public ActionResult Details(int id)
        {
            var customer = customers.Find(movie => movie.Id == id);
            if (customer == null)
                return HttpNotFound();
            else
                return View(customer);
        }
    }
}