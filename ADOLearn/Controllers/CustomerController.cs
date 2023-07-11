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
        public ActionResult List(string filter)
        {
          ASPLearnEntities2 db = new ASPLearnEntities2();
            if (string.IsNullOrEmpty(filter))
            {
                filter = "";
            }
            //List<Customer> customers = db.Customers.Where(m => m.CustomerName.ToLower().Contains(filter.ToLower()) || m.PhoneNumber.Contains(filter)).ToList();
            List<listCustomer_Result> customersProc = db.listCustomer(filter).ToList();
            List<Customer> customers = new List<Customer>();
            foreach (var item in customersProc)
            {
                Customer customer = new Customer();
                customer.Id = item.Id;  
                customer.CustomerName = item.CustomerName;
                customer.PhoneNumber = item.PhoneNumber;
                customer.Address = item.Address;    
                customer.IdCustomerType = item.IdCustomerType;  
                customers.Add(customer);    
            }
            ViewBag.filter = filter;
            return View(customers);
        }

        public ActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add(Customer customer)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            db.Customers.Add(customer);
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Edit(int id)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
            return View(customer);
        }
        [HttpPost]
        public ActionResult Edit(Customer model)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == model.Id);
            customer.CustomerName = model.CustomerName;
            customer.PhoneNumber = model.PhoneNumber;
            customer.Address = model.Address;
            db.SaveChanges();
            return RedirectToAction("List");
        }

        public ActionResult Delete(int id)
        {
            ASPLearnEntities2 db = new ASPLearnEntities2();
            Customer customer = db.Customers.SingleOrDefault(x => x.Id == id);
            db.Customers.Remove(customer);
            db.SaveChanges();
            return RedirectToAction("List");
        }
    }
}