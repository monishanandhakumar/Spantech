using Day3_EFCore_DBFirst.Models;
using Day3_EFCore_DBFirst.ViewModel;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day3_EFCore_DBFirst.Controllers
{
    public class VMController : Controller
    {
        private readonly NorthwindContext db;

        public VMController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CusOrder()
        {

            var customerlist = (from cust in db.Customers
                                join
      or in db.Orders on cust.CustomerId equals or.CustomerId
                                select new { cust.CustomerId, cust.CompanyName, or.OrderId, or.OrderDate }).ToList();
            List<CustomerVM> lvm = new List<CustomerVM>();
            foreach(var item in customerlist)
            {
                CustomerVM objvm = new CustomerVM();
                objvm.CustomerId = item.CustomerId;
                objvm.CompanyName = item.CompanyName;
                objvm.OrderId = item.OrderId;
                objvm.OrderDate = item.OrderDate;

                lvm.Add(objvm);

            }
            
            return View(lvm);
        }
    }
}
