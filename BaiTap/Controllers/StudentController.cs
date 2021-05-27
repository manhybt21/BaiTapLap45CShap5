using BaiTap.Data.EF;
using BaiTap.Data.Entities;
using BaiTap.Service.IServicess;
using BaiTap.Service.Servicess;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiTap.Controllers
{
    public class StudentController : Controller
    {
        public readonly IStudentService _studentService;
        public readonly databaseContext _databaseContext;
        public StudentController(databaseContext databaseContext,IStudentService studentService)
        {
            _databaseContext = databaseContext;
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var getSt = _studentService.GetListStudent();
            return View(getSt.ToList());
        }
        public IActionResult Create()
        {
            ViewData["MaLop"] = new SelectList(_databaseContext.Classes, "IdClass", "ClassName");
            return View();
        }
       [HttpPost]
        public IActionResult Create(Student student)
        {
            var create = _studentService.CreateStudent(student);
           return RedirectToAction("Index", "Student");
        }
        public IActionResult Update(int id)
        {
            ViewData["MaLop"] = new SelectList(_databaseContext.Classes, "IdClass", "ClassName");
            var update = _databaseContext.Students
               .SingleOrDefault(m => m.IdStudent == id);
            return View(update);
        }
        [HttpPost]
        public IActionResult Update(Student st)
        {
            _studentService.UpdateStudent(st);
           return RedirectToAction("Index", "Student");
        }
        [HttpGet("student/delete/{id}")]
        [HttpPost("student/delete/{id}")]
        public IActionResult Delete(int id)
        {
            _studentService.DeleteStudent(id);
            return RedirectToAction("Index", "Student");
        }
    }
}
