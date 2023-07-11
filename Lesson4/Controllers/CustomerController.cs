using Lesson4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Reflection;

namespace Lesson4.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult ListCustomers()
        {
            return View(ListCustomer.customers);
        }

        public IActionResult AddNewCustomer()
        {

            return View(new Customer());
        }

        [HttpPost]
        public IActionResult AddNewCustomer(Customer customer)
        {
        if (ListCustomer.customers.Count != 0) { customer.Id = ListCustomer.customers[ListCustomer.customers.Count-1].Id + 1; }else { customer.Id = 1; }
        ListCustomer.customers.Add(customer);   
           return RedirectToAction("ListCustomers");
        }

        public IActionResult EditCustomer(int id)
        {
            Customer customer = ListCustomer.customers.SingleOrDefault(x => x.Id == id);
            return View(customer);
        }

        [HttpPost]
        public IActionResult EditCustomer(Customer model)
        {
            Customer customer = ListCustomer.customers.SingleOrDefault(x => x.Id == model.Id);
            customer.Name= model.Name;  
            customer.Address= model.Address;
            customer.Email= model.Email;    
            customer.Sex= model.Sex;
            customer.PhoneNumber= model.PhoneNumber;
            return RedirectToAction("ListCustomers");
        }

        public IActionResult DeleteCustomer(int id) {
            Customer customer = ListCustomer.customers.SingleOrDefault(x => x.Id == id);
            ListCustomer.customers.Remove(customer);
            return RedirectToAction("ListCustomers");
        }
    }
}
