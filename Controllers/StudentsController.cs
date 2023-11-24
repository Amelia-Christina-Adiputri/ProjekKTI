using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MyWebApp.Models;
using MyWebApp.Repositories;

namespace MyWebApp.Controllers
{
    [Authorize] 
    public class StudentsController : Controller
    {
        private readonly ILogger<StudentsController> _logger;
        private readonly IStudentRepository _studentRepository;

        public StudentsController(ILogger<StudentsController> logger,
            IStudentRepository studentRepository)
        {
            _logger = logger;
            _studentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            ViewData["Title"] =  "Student List";
            var models = _studentRepository.GetAll();
            return View(models);

            // Student student = new Student()
            // {
            //     StudentId = 1,
            //     Name = "Jhon Doe",
            //     Email = "jhon@gmail.com",
            //     BirthDate = new DateOnly(1999, 2, 20)
            // }; 

            // ViewData["Message"] = "Hello From Student Controller!";
            // ViewData["Date"] = DateTime.Now;
            // ViewBag.pesan = "Hello From View Bag Student Controller!";
            // return View(student);
        }

        public IActionResult Description()
        {
            // return Content("Hello From Student Controller!");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}