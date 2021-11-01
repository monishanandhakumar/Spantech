using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day1MVC.Models;
namespace Day1MVC.Controllers
{
    public class DeparmentController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Deptdetails()
        {
            Department department = new Department();
            department.Id = 101;
            department.Dname = "HR";

            return View(department);
        }

        public IActionResult LisDeptdetails()
        {
           List<Department> department = new List<Department>();
            department.Add(new Department { Id = 101, Dname = "Admin" });
            department.Add(new Department { Id = 102, Dname = "HR" });
            department.Add(new Department { Id = 103, Dname = "UX" });

            return View(department);
        }


    }
}
