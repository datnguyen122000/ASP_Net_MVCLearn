using ADOLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ADOLearn.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Index()
        {
            //khi chưa đăng nhâp mà cố tình vào trong index thì sẽ trở về màn hình login
            if (Session["user"] == null)
            {
                return RedirectToAction("Login");
            }
            return View();
        }
        // GET: Admin/Admin
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string username,string password)
        {
            //check db
            ASPLearnEntities2 db = new ASPLearnEntities2();
            var employee = db.Employees.SingleOrDefault(m=>m.Username.ToLower()==username.ToLower() &&m.Password==password);
            if(employee != null)
            {
                Session["user"] = employee;
                return RedirectToAction("Index");
            }
            else
            {
                TempData["error"] = "Tài khoản đăng nhập không đúng";
                return View();
            }
        }

        public ActionResult Logout()
        {
            Session.Remove("user");
            return RedirectToAction("Login");
        }
    }
}