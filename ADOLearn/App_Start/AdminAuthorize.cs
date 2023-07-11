using ADOLearn.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;

namespace ADOLearn.App_Start
{
    public class AdminAuthorize:AuthorizeAttribute
    {
        public int RoleId { get; set; }
        public override void OnAuthorization(AuthorizationContext filterContext)
        {
            Employee employee = (Employee) HttpContext.Current.Session["user"];
            if (employee != null)
            {
                //2. check quyền : Có quyền thì => cho thực hiện Filter
                //Ngược lại thì cho trở lại trang => Trang báo lỗi quyền truy cập
                ASPLearnEntities2 db = new ASPLearnEntities2();
                var count = db.Employee_Role.Count(m => m.EmployeeId == employee.Id && m.RoleId == RoleId);
                if (count != 0)
                {
                    //có quyền
                    return;
                }
                else
                {
                    //không có quyền thì quay về trang báo lỗi
                    var returnUrl = filterContext.RequestContext.HttpContext.Request.RawUrl;
                    filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                        new
                        {
                            Controller = "Error",
                            Action = "NotPermit",
                            Area = "Admin",
                            returnUrl = returnUrl.ToString()
                        }
                        ));
                }
                return;
            }
            else
            {
                var returnUrl=filterContext.RequestContext.HttpContext.Request.RawUrl;
                filterContext.Result = new RedirectToRouteResult(new RouteValueDictionary(
                    new
                    {
                        Controller = "Login",
                        Action = "Index",   
                        Area="Admin",
                        returnUrl=returnUrl.ToString()
                    }
                    ));
            }

           
        }
    }
}