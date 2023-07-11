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
            ASPLearnEntities1 db=new ASPLearnEntities1();
            List<Customer> customers=db.Customers.ToList();
            return View(customers);
        }

        public ActionResult Add()
        {
           
            return View(new Customer());
        }
        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            ASPLearnEntities1 db = new ASPLearnEntities1();
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            ASPLearnEntities1 db = new ASPLearnEntities1();
            Customer customer=db.Customers.Find(id);
           
            return View(customer);
        }

        [HttpPost]
        public ActionResult Edit(Customer customerEdit)
        {
            ASPLearnEntities1 db = new ASPLearnEntities1();
            Customer customer = db.Customers.Find(customerEdit.Id);
            customer.PhoneNumber = customerEdit.PhoneNumber;
            customer.CustomerName = customerEdit.CustomerName;
            customer.Address = customerEdit.Address;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            ASPLearnEntities1 db = new ASPLearnEntities1();
            Customer customer = db.Customers.Find(id);
            db.Customers.Remove(customer);  
            db.SaveChanges();
            return RedirectToAction("List");
        }

    }
}