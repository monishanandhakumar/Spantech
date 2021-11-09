using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day3_EFCore_DBFirst.Models;
namespace Day3_EFCore_DBFirst.Controllers
{
    public class CategoryController : Controller
    {
        private readonly NorthwindContext db;

        //constructor injection
        public CategoryController(NorthwindContext context)
        {
            db = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        //1 fetching data fro categries table

        public IActionResult Getdetails()
        {
           List<Category> categories=db.Categories.ToList();
            return View(categories);
        }

        //2 Scaffloded

        public IActionResult Getdetailscat()
        {
            List<Category> categories = db.Categories.ToList();
            return View(categories);
        }

        //create
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Add(Category category)
        {
            db.Categories.Add(category);
            db.SaveChanges();
            return RedirectToAction("Getdetailscat");
        }

        //Delete
        public IActionResult Delete(int id)
        {
           Category category= db.Categories.Find(id);
            db.Categories.Remove(category);
            db.SaveChanges();
            return RedirectToAction("Getdetailscat");
        }

        //display
        public IActionResult Display(int id)
        {
            Category category = db.Categories.Find(id);
            
            return View(category);
        }

        //Edit assignment

        public IActionResult Edit(int id)
        {
            Category category = db.Categories.Find(id);

            return View(category);
        }
        [HttpPost]
        public IActionResult Edit(Category c)
        {
            Category category = db.Categories.Find(c.CategoryId);

            category.CategoryName = c.CategoryName;
            category.Description = c.Description;
            category.Picture = c.Picture;
            db.SaveChanges();

            return RedirectToAction("Getdetailscat");
        }

    }
}
