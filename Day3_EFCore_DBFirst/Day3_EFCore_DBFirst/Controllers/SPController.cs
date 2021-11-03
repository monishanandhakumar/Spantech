using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day3_EFCore_DBFirst.Models;
using Microsoft.EntityFrameworkCore;

namespace Day3_EFCore_DBFirst.Controllers
{
    public class SPController : Controller
    {
        private readonly NorthwindContext db;

        public SPController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult TenProducts()
        {
            return View(db.Ten_Most_Expensive_Products.FromSqlRaw("[dbo].[Ten Most Expensive Products]"));
        }

        public IActionResult Order()
        {
            string cid = "TOMSP";
            return View(db.CustOrders.FromSqlRaw(" [dbo].[CustOrdersOrders]@p0",parameters:new[] {cid}).ToList());
        }

    }
}
