using Lesson4.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lesson4.Controllers
{
    public class OrderController : Controller
    {
        public IActionResult ListOrders()
        {
            return View(ListOrder.orders);
        }

        public IActionResult AddOrder()
        {
            return View(new Order());
        }

        [HttpPost]
        public IActionResult AddOrder(Order order)
        {
            if (ListOrder.orders.Count != 0) { order.Id = ListOrder.orders[ListOrder.orders.Count - 1].Id + 1; } else { order.Id = 1; }
            ListOrder.orders.Add(order);
            return RedirectToAction("ListOrders");
        }

        public IActionResult EditOrder(int id)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == id);
            return View(order);
        }

        [HttpPost]
        public IActionResult EditOrder(Order model)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == model.Id);
            order.CustomerName = model.CustomerName;
            order.Phone = model.Phone;
            order.Address = model.Address;
            order.OrderDate = model.OrderDate;      
            return RedirectToAction("ListOrders");
        }

        public IActionResult DeleteOrder(int id)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == id);
            ListOrder.orders.Remove(order);
            return RedirectToAction("ListOrders");
        }

        public IActionResult DetailOrder(int id)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == id);
            return View(order);
        }

        public IActionResult AddDetail(int id)
        {
            ViewBag.Id = id;    
            return View(new Computer());
        }

        [HttpPost]
        public IActionResult AddDetail(int id,Computer computer)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == id);
            if (order.computers.Count == 0) {
                computer.Id = 1;
            }
            else
            {
                computer.Id = order.computers[order.computers.Count - 1].Id+1;
            }
               
            order.computers.Add(computer);
            return Redirect("DetailOrder?id="+id);
        }

        public IActionResult EditDetail(int idComputer,int idOrder)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == idOrder);
            Computer computer = order.computers.SingleOrDefault(x => x.Id == idComputer);
            ViewBag.idOrder=idOrder;
            return View(computer);
        }

        [HttpPost]
        public IActionResult EditDetail(Computer model, int idOrder)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == idOrder);
            Computer computer = order.computers.SingleOrDefault(x => x.Id == model.Id);
            computer.Serie = model.Serie;
            computer.Price = model.Price;
            computer.ProductDate = model.ProductDate;
            computer.Manufacturer = model.Manufacturer;
            return Redirect("~/Order/DetailOrder?id=" + idOrder);
        }

        public IActionResult DeleteDetail(Computer model, int idOrder)
        {
            Order order = ListOrder.orders.SingleOrDefault(x => x.Id == idOrder);
            Computer computer = order.computers.SingleOrDefault(x => x.Id == model.Id);
            order.computers.Remove(computer);
            return Redirect("~/Order/DetailOrder?id=" + idOrder);
        }
    }
}
