using FirstMVCDemo.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCDemo.Controllers
{
    public class StudentController : Controller
    {
        public static List<Student> _student = new List<Student>
        {
            new Student {Id=1,Name="venu",Age=23,Gender= "Male"},
            new Student {Id=2,Name="sai",Age=20,Gender= "Male"},
            new Student {Id=3,Name="shiva",Age=20,Gender= "Male"},
            new Student {Id=4,Name="hari",Age=21,Gender= "Male"},
        };
        public IActionResult Index()
        {
            return View();
        }

    }
}
