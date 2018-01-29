using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;
using Vidly.Models.ViewModels;

namespace Vidly.Controllers
{
    public class CustomerController : Controller
    {
        public List<Customer> customersList = new List<Customer> 
        {
            new Customer() { Name = "James Hall-Treworgy" },
            new Customer() { Name = "Trevor Treworgy" }
        };

        [Route("customers")]
        public ActionResult Customers()
        {
            return View(this.customersList);
        }

        [Route("customers/{id}")]
        public ActionResult Details(int id) 
        {
            return View(this.customersList[id]);
        }
    }
}
