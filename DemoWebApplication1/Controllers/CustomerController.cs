using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DemoWebApplication1.Models;

namespace DemoWebApplication1.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Create()
        {

            return View();
        }

        public IActionResult getid(int? id)
        {
            Customer customer = null;
            if(id == null)
            {
                ViewData["Message"] = "Id Not specified";

            }
            return View();

        }
        [HttpPost]
        public IActionResult CreateCustomer(Customer newCustomer)
        {

            return View();
        }


        public IActionResult Order()
        {
            var order = new Order()
            {
                id = 101,
                orderDate = DateTime.Now,
                customerID = 101

            };
            return View(order);
        }

        public IActionResult getAllCustomer()
        {
            var customers = new List<Customer>();
            var c1 = new Customer(){ id = 101,Firstname = "Joe",Lastname = "Zeng"};
            var c2 = new Customer() { id = 102, Firstname = "Hammad", Lastname = "chad" };
            customers.Add(c1);
            customers.Add(c2);
            return View(customers);


        }

        public IActionResult Get()
        {
            ViewData["Firstname"] = "John";
            ViewData["Lastname"] = "Smith";

            var customer = new Customer()
            {
                id = 101,
                Firstname = "Joe",
                Lastname = "Zeng"

            };

            return View(customer);
        }
    }
}