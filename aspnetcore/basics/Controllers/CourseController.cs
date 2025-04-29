using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace basics.Controllers
{

    public class CourseController : Controller
    {
        public string Index()
        {
            return "Course/Index";
        }
    }
}