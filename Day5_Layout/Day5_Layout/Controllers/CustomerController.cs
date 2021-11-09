using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day5_Layout.Controllers
{
    public class CustomerController : Controller
    {
        public IActionResult CusIndex()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
    }
}
