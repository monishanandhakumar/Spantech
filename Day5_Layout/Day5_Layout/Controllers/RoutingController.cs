using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day5_Layout.Controllers
{
    [Route("Book")]
    public class RoutingController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("AllBooks")]
        public IActionResult GetAllBooks()
        {
            return View();
        }

        [Route("id/{id:int?}")]
        public IActionResult GetBookbyid(int id)
        {
            return View();
        }

        [Route("{name=XYZ}")]
        public IActionResult GetBookbyAuthor()
        {
            return View();
        }

        [Route("{name:maxlength(5)}")]
        public IActionResult GetBookbyName(string name)
        {
            return View();
        }
    }
}
