using Microsoft.AspNetCore.Mvc;

namespace Lesson3.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult TrangChu()
        {
            //đây là cách redirect đên action trong cung controller
            //return RedirectToAction("GioiThieu");

            //chuyển sang một action trong controller khác
            //return RedirectToAction("DanhSachTinTuc", "TinTuc");

            //chuyen sang mot duong dan 
            //return Redirect("http://google.com");

            return View();
        }

        public IActionResult GioiThieu()
        {
            return View();
        }
    }
}
