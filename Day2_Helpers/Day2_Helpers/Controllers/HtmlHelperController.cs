using Day2_Helpers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2_Helpers.Controllers
{
    public class HtmlHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Register register)
        {
            return View();
        }

        //Scaffolded code
        public IActionResult RForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RForm(Register register)
        {
            return View();
        }

    }
}
