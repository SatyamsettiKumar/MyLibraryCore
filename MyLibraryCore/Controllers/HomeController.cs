using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace MyLibraryCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("this is Mvc");
           // return View();
        }
    }
}
