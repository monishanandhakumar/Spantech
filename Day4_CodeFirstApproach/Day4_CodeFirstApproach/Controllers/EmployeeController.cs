using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day4_CodeFirstApproach.Models;

namespace Day4_CodeFirstApproach.Controllers
{
    public class EmployeeController : Controller
    {
        private readonly EmpoyeeDbContext db;

        public EmployeeController(EmpoyeeDbContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Employee employee)
        {
            db.Employees.Add(employee);
                db.SaveChanges();
            return View();
        }
    }
}
