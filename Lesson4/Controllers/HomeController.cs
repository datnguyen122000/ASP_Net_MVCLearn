using Microsoft.AspNetCore.Mvc;
using Lesson4.Math;
using Lesson4.Models;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Xml.Linq;

namespace Lesson4.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult TrangChu()
        {
            //ViewBag.A = new MathHelp().tinhTong(5,10);
            //truyền thông qua view
            ViewBag.title = "Danh sách sinh viên";
            List<Student> students = ListStudent.students;
            return View(students);
        }

        public IActionResult OldestStudent()
        {
            //ViewBag.A = new MathHelp().tinhTong(5,10);
            //truyền thông qua view
            ViewBag.title = "Danh sách sinh viên";
            List<Student> students = ListStudent.students;
            return View(students.OrderByDescending(s => s.Age).Take(2).ToList());
        }

        public IActionResult OrderByAge()
        {
            //ViewBag.A = new MathHelp().tinhTong(5,10);
            //truyền thông qua view
            ViewBag.title = "Danh sách sinh viên";
            List<Student> students = ListStudent.students;
            return View(students.OrderBy(s => s.Age).ToList());
        }

        public IActionResult GioiThieu()
        {
            return View();
        }

        public IActionResult AddNewStudent()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SaveNewStudent(string name, int age, int classId)// tên ở đây phải trùng với tên bên razor thì mới lấy ra được dữ liệu
        {

            int id = ListStudent.students[ListStudent.students.Count - 1].Id + 1;
            Student student = new Student(id, name, age, classId);
            ListStudent.students.Add(student);
            return Redirect("~/Home/TrangChu");
        }
        public ActionResult AddNewStudent2()
        {
            Student student = new Student();
            return View(student);
        }

        [HttpPost]
        public ActionResult AddNewStudent2(Student student) // ở bên cshtml thì các ô input phải thêm thuộc tính Name="... 
        {
            //if (student.Age <= 0)
            //{
            //    ModelState.AddModelError("", "Tuổi phải nhập >0");
            //    return View(student);
            //}
            int id = ListStudent.students[ListStudent.students.Count - 1].Id + 1;
            ListStudent.students.Add(new Student(id, student.Name, student.Age, student.ClassId));
            return Redirect("~/Home/TrangChu");
        }
    }
}
