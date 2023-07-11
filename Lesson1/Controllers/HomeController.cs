using Microsoft.AspNetCore.Mvc;

namespace Lesson1.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()//index là tên của view có thể add view
        {
            return View();
        }

        public IActionResult HienThiTen()//index là tên của view có thể add view
        {
            return View();
        }
    }
}
