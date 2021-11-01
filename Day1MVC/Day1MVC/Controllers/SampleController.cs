using Day1MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day1MVC.Controllers
{
    //Controller - Collection of action method
    public class SampleController : Controller
    {
        //Action Method
        public IActionResult Index()
        {
            return View();
        }

        //Normal Method
        public string MyName()
        {
            return "Monisha"; 
        }

        //Action Method with various return type

        //Action Method returing action result

        public IActionResult Activities()
        {
            return View();
        }

        //Action Method returing viewresult

        public ViewResult Rules()
        {
            return View();
        }

        //only for displaying set of strings

        public ContentResult Info()
        {
            return Content("<h1>HI ALL</h1>","text/html");
        }
        //Empty result

        [NonAction]
        public EmptyResult SICal()
        {
            float SI = (78999 * 3 * 2) / 100;
            return new EmptyResult();
        }
        //Return as JSON Result
        public JsonResult Deptinfo()
        {
            Department department = new Department();
            department.Id = 101;
            department.Dname = "HR";

            return Json(department);
        }

        public IActionResult Data()
        {
            /*  Department department = new Department();
              department.Id = 101;
              department.Dname = "HR";

              return Json(department);*/
            return Content("<h1>HI ALL!!</h1>", "text/html");
        }


    }
}
