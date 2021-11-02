using Day2_Helpers.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day2_Helpers.Controllers
{
    public class TagHelperController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //by default all the action methods are get method
        public IActionResult AddBook()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BookModel book)
        {
            List<BookModel> b = new List<BookModel>();
            b.Add(book);
            return View("DisplayBookDetails",b);
        }

        public IActionResult DisplayBookDetails(BookModel book)
        {
            return View(book);
        }
    }
}
