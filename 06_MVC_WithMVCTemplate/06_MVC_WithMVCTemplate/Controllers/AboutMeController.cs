using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _06_MVC_WithMVCTemplate.Controllers
{
    public class AboutMeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
