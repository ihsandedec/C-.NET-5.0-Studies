using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using basics.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basics.Controllers
{

    public class CourseController : Controller
    {
        public IActionResult Index()
        {
            var kurs = new Course();
            kurs.ID = 1;
            kurs.Title = "Aspnet calismalarim";
            return View(kurs);

        }

          public IActionResult List()
        {
            var kurslar = new List<Course>()
            {
                new Course() { ID =1,Title= "Aspnet calismalarim", Description = "iyi giden Aspnet calisma "},
                new Course() { ID =2,Title= "Django calismalarim", Description = "iyi giden Django calisma "},
                new Course() { ID =3,Title= "Java calismalarim", Description = "iyi giden Java calisma "},

            };
            

            return View("List",kurslar);
        }
    }
}