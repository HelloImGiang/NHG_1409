using Microsoft.AspNetCore.Mvc;
using NguyenHuongGiang_BTH.Models;

namespace NguyenHuongGiang_BTH.Controllers
{
public class StudentController : Controller 
{
    public IActionResult Index()
    {
            // khơi tao list student
            List<Student> StdList = new List<Student>()
            {
                new Student {StudentID = 1, StudentName = "Nguyen Huong Giang", StudentAge = 21},
                new Student {StudentID = 2, StudentName = "Nguyen Huong G", StudentAge = 25},
                new Student {StudentID = 3, StudentName = "Nguyen Huong Gi", StudentAge = 18},
                new Student {StudentID = 4, StudentName = "Nguyen Huong Gia", StudentAge = 2},
                new Student {StudentID = 5, StudentName = "Nguyen Huong Gian", StudentAge = 1}

            };
            ViewData["Student"] = StdList;
            return View(StdList);
    }
[HttpGet]     
public IActionResult Create()
{
    return View();
}
[HttpPost] // nhận đc dữ liệu từ view gửi lên
    public IActionResult Create(Student std)   
        {
            string message = std.StudentID + "-";
            message += std.StudentName +"-";
            message += std.StudentAge;
            ViewBag.SinhVien = message;
            return View();
            // ViewBag.SinhVien = "Hello: " + std.StudentID + "-" + std.StudentName + "-" + std.StudentAge;
            // return View();
            
        }
    }
}
