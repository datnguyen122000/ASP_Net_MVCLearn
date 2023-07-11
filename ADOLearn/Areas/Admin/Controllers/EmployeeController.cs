using ADOLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ADOLearn.App_Start; // khai báo để sử dụng AdminAuthorize

namespace ADOLearn.Areas.Admin.Controllers
{
    public class EmployeeController : Controller
    {

        // GET: Admin/Employee
        //public bool CheckRole(int roleId)
        //{
        //    ASPLearnEntities2 db = new ASPLearnEntities2();
        //    Employee employee = (Employee)Session["user"];
        //    var count = db.Employee_Role.Count(m => m.EmployeeId == employee.Id && m.RoleId == roleId);
        //    if (count == 0)
        //    {
        //        //báo không có quyền
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }
        //}

        [AdminAuthorize(RoleId =1)]
        public ActionResult List()
        {
           //if(CheckRole(1)==false)
           // {
           //     return Redirect("~/Admin/Error/NotPermit");
           // }
            return View();
        }

        [AdminAuthorize(RoleId = 2)]
        public ActionResult Add()
        {
            //if (CheckRole(2) == false)
            //{
            //    return Redirect("~/Admin/Error/NotPermit");
            //}


            return View();
        }

        [AdminAuthorize(RoleId = 3)]
        public ActionResult Update()
        {
            //if (CheckRole(3) == false)
            //{
            //    return Redirect("~/Admin/Error/NotPermit");
            //}

            return View();
        }

        [AdminAuthorize(RoleId = 4)]
        public ActionResult Delete()
        {
            //if (CheckRole(4) == false)
            //{
            //    return Redirect("~/Admin/Error/NotPermit");
            //}

            return View();
        }
    }
}