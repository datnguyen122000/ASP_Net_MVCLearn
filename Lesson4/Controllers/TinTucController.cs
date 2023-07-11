using Microsoft.AspNetCore.Mvc;

namespace Lesson3.Controllers
{
    public class TinTucController : Controller
    {
        public IActionResult DanhSachTinTuc()
        {
            return View();
        }
    }
}
