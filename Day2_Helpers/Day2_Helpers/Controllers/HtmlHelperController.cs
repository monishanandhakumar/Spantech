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

        //Standard html helper
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Register register)
        {
            return View();
        }

        //Scaffolded code  //Tag helper
        public IActionResult RForm()
        {
            return View();
        }

        [HttpPost]
        public IActionResult RForm(Register register)
        {
            //Checks for all the validation is satisfied or not
            if(ModelState.IsValid)
            {

            }
            else
            {

            }
            return View();
        }

    }
}
