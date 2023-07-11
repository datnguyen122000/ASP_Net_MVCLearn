using ADOLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOLearn.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult List()
        {
            ASPLearnEntities db = new ASPLearnEntities();
            List<Customer> customers = db.Customers.ToList();
            return View(customers);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            ASPLearnEntities db = new ASPLearnEntities();
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            ASPLearnEntities db = new ASPLearnEntities();
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(Customer model)
        {
            ASPLearnEntities db = new ASPLearnEntities();
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == model.Id);
            customer.CustomerName = model.CustomerName;
            customer.PhoneNumber = model.PhoneNumber;
            customer.Address = model.Address;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            ASPLearnEntities db = new ASPLearnEntities();
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}