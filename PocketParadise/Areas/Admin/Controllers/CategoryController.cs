using PocketParadise.DataAccess.Repository.IRepository;
using Microsoft.AspNetCore.Mvc;
using PocketParadise.DataAccess.Data;
using PocketParadise.Models;
using Microsoft.AspNetCore.Authorization;
using PocketParadise.Utility;

namespace PocketParadise.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = SD.Role_Admin)]
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _unitOfWork;
        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public IActionResult Index()
        {
            List<Category> objectCategoryList = _unitOfWork.Category.GetAll().ToList();
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

                _unitOfWork.Category.Add(obj);
                _unitOfWork.Save();
                TempData["success"] = "Category Created Successfully";
                return RedirectToAction("Index");
            }
            return View();

        }

        public IActionResult Edit(int? id)
        {
            if (id == null || id == 0)
            {
                return NotFound(); // could also have an error view to return here
            }

            //there are many ways here to get the id from the category object here are a few:
            //Category? categoryFromDB = _db.Categories.Find(id);

            Category? categoryFromDb = _unitOfWork.Category.Get(x => x.Id == id);

            if (categoryFromDb == null)
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
                _unitOfWork.Category.Update(obj);
                _unitOfWork.Save();
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

            Category? categoryFromDb = _unitOfWork.Category.Get(x => x.Id == id);

            if (categoryFromDb == null)
            {
                return NotFound();
            }

            return View(categoryFromDb);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeletePost(int? id)
        {
            Category? categoryFromDB = _unitOfWork.Category.Get(x => x.Id == id);
            if (categoryFromDB == null)
            {
                return NotFound();
            }
            _unitOfWork.Category.Remove(categoryFromDB);
            _unitOfWork.Save();
            TempData["success"] = "Category Deleted Successfully";
            return RedirectToAction("Index");
        }
    }
}
