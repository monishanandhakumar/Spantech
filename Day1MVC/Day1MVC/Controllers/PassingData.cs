using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1MVC.Controllers
{
    public class PassingData : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //Passing data from controller to view -- viewbag,viewdata
        //viewbag is dynamic property,viewdata is dictionary(explicit conversion is requied)
        public IActionResult BookList()
        {
            List<string> book = new List<string>() { "Java", "CN", "AI" };
            ViewBag.books = book;
            ViewData["listofbooks"] = book;

            return View();
        }

        //Tempdata passing data from controller to controller, controller to view

        public IActionResult Demo()
        {
            TempData["Message"] = "Had Lunch??";
                                   //actionmethod ,controllername
            return RedirectToAction("Index", "Deparment");
        }

        public IActionResult Namerequest()
        {
            List<string> names=new List<string>() {"Anu","Banu"};
            TempData["Friendsname"] = names;
            TempData.Keep(); //retain the tempdata value for subsequest request
            return View();
        }

        public IActionResult Nextrequest()
        {
            var getname = TempData["Friendsname"];
            return View(getname);
        }


    }
}
