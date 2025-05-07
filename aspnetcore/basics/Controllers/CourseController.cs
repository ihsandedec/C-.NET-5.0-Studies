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
            kurs.Description = "Güzel giden calisma";
            kurs.Image ="1.jpg";
            return View(kurs);

        }

          public IActionResult List()
        {
            var kurslar = new List<Course>()
            {
                new Course() { ID =1,Title= "Aspnet calismalarim", Description = "iyi giden Aspnet calisma ", Image="1.jpg" },
                new Course() { ID =2,Title= "Django calismalarim", Description = "iyi giden Django calisma ", Image="2.webp"},
                new Course() { ID =3,Title= "Java calismalarim", Description = "iyi giden Java calisma ", Image="3.webp"},

            };
            

            return View("List",kurslar);
        }
        
    }
}
