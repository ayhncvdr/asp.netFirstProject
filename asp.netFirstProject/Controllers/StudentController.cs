using asp.netFirstProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace asp.netFirstProject.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detail(int id)
        {
            // from db
            string[] names = new string[] {"Ayhan", "Hamide", "Adnan" };
            Student student = new Student();
            student.Id = id;
            student.Name = names[id%names.Length];
            student.Age = (id+1)*22;

            return View(student);
        }
    }
}
