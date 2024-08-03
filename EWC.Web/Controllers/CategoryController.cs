using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using EWC.DataAccess.Data;
using EWC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace EWC.Web.Controllers
{
    // [Route("[controller]")]
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;

        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            List<Category> categories = _context.Categorys.ToList();
            return View(categories);
            // return View();
        }

        public IActionResult Create()
        {
            return View();
        }
        // [HttpPost]
        // public IActionResult Create(Category category)
        // {
        //     if (category.Name == category.DisplayOrder.ToString())
        //     {
        //         ModelState.AddModelError("Name", "The DisplayOrder cannot exactly match the Name.");
        //     }

        //     if (category.Name != null && category.Name.ToLower() == "test")
        //     {
        //         ModelState.AddModelError("Name", "Test is invalid value");
        //     }

        //     if (ModelState.IsValid)
        //     {
        //         _context.Category.Add(category);
        //         _context.SaveChanges();
        //         TempData["success"] = "Category Created Successfully";

        //         return RedirectToAction("Index");
        //     }
        //     return View(category);
        // }

        // [HttpGet]
        // public IActionResult Edit(int? id)
        // {
        //     if (id == null)
        //     {
        //         return NotFound();
        //     }
        //     Category category = _context.Category.FirstOrDefault(x => x.Id == id);
        //     if (category == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(category);
        // }

        // [HttpPost]
        // public IActionResult Edit(Category category)
        // {
        //     if (category.Name == category.DisplayOrder.ToString())
        //     {
        //         ModelState.AddModelError("Name", "The DisplayOrder cannot exactly match the Name.");
        //     }

        //     if (category.Name != null && category.Name.ToLower() == "test")
        //     {
        //         ModelState.AddModelError("Name", "Test is invalid value");
        //     }
        //     if (ModelState.IsValid)
        //     {
        //         _context.Category.Update(category);
        //         _context.SaveChanges();
        //         TempData["success"] = "Category Updated Successfully";

        //         return RedirectToAction("Index");
        //     }
        //     return View(category);
        // }

        // [HttpGet]
        // public IActionResult Delete(int? id)
        // {
        //     if (id == null || id == 0)
        //     {
        //         return NotFound();
        //     }
        //     Category? categoryFromDb = _context.Category.Find(id);
        //     //Category? categoryFromDb1 = _db.Categories.FirstOrDefault(u=>u.Id==id);
        //     //Category? categoryFromDb2 = _db.Categories.Where(u=>u.Id==id).FirstOrDefault();

        //     if (categoryFromDb == null)
        //     {
        //         return NotFound();
        //     }
        //     return View(categoryFromDb);
        // }

        // [HttpPost, ActionName("Delete")]
        // public IActionResult DeletePOST(int? id)
        // {
        //     Category? obj = _context.Category.Find(id);
        //     if (obj == null)
        //     {
        //         return NotFound();
        //     }
        //     _context.Category.Remove(obj);
        //     _context.SaveChanges();
        //     TempData["success"] = "Category Deleted Successfully";

        //     return RedirectToAction("Index");
        // }
    
    
    }
}