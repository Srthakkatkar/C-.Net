using Microsoft.AspNetCore.Mvc;
using DrivingSchoolApp.Models;
using System.Collections.Generic;

namespace DrivingSchoolApp.Controllers
{
    public class StudentController : Controller
    {
        // Temporary storage (no DB)
        public static List<Student> students = new List<Student>();

        public IActionResult Index()
        {
            return View(students);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Student student)
        {
            students.Add(student);
            return RedirectToAction("Index");
        }
    }
}