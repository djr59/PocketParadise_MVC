using Microsoft.AspNetCore.Mvc;
using PocketParadise.Data;
using PocketParadise.Models;

namespace PocketParadise.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;
        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            List<Category> objectCategoryList = _db.Categories.ToList();
            return View(objectCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            if (obj.Name == obj.DisplayOrder.ToString())
            {
                //this is just an example of a custom error, this is not a real important thing to check for. kind of a dumb check.
                //TO DO - this should be, there should not be allowed to be another category made where we try to give it the same name or display order that another field has.......
                //the key here shouws that this error is for the name field of the category model.
                ModelState.AddModelError("name", "The DisplayOrder cannot exactly match the Name.");
            }

            if (ModelState.IsValid)
            {
                //_unitOfWork.Category.Add(obj);
                //_unitOfWork.Save();
                //TempData["success"] = "Category created successfully";

                _db.Categories.Add(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int? id)
        {
            if(id == null || id == 0)
            {
                return NotFound(); // could also have an error view to return here
            }

            //there are many ways here to get the id from the category object here are a few:
            //Category? categoryFromDB = _db.Categories.Find(id);

            Category? categoryFromDb = _db.Categories.FirstOrDefault(x => x.Id == id);

            if (categoryFromDb == null ) 
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost]
        public IActionResult Edit(Category obj)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Update(obj);
                _db.SaveChanges();
                TempData["success"] = "Category Updated Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Delete(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // could also have an error view to return here
            }

            //there are many ways here to get the id from the category object here are a few:
            //Category? categoryFromDB = _db.Categories.Find(id);

            Category? categoryFromDb = _db.Categories.FirstOrDefault(x => x.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? categoryFromDB = _db.Categories.Find(id);
            if (categoryFromDB == null)
            {
                return NotFound();
            }
            _db.Categories.Remove(categoryFromDB);
            _db.SaveChanges();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
