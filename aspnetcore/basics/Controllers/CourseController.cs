using System;
using System.Collections.Generic;
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
            return View();
        }
    }
}