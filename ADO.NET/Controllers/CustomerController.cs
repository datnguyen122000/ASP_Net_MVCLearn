using ADO.NET.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADO.NET.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            List<Customer> customers = db.Customers.ToList();
            return View(customers);
        }
    }
}