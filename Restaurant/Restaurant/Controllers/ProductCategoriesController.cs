using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CategoryViewModel;

namespace Restaurant.Controllers;

[Authorize(Roles ="Admin")]
public class ProductCategoriesController : Controller
{
    private readonly IGenericRepository<Category> _category;
    private readonly IMapper _mapper;
    RestaurantContext context;

    public ProductCategoriesController(IGenericRepository<Category> category, IMapper mapper, RestaurantContext context)
    {
        this._category = category;
        _mapper = mapper;
        this.context = context;
    }


    [HttpGet]
    public IActionResult Index()
    {
        var categories = _category.GetAll();
        //var mappedCategories = _mapper.Map<List<CategoryViewModel>>(categories);

        return View(categories);

        // when Products Ctrl done, return a partial view
        //return PartialView();
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    // POST: /Categories/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(string name)
    {
        var category = _category.Find(x => x.Name == name);

        if (ModelState.IsValid)
        {
            if (category.Count() != 0)
            {
                // show message category already exsited if found
                ViewBag.CategoryFound = name;
                return PartialView("_CategoryExists");
            }

            // if not found add the new category to db
            var newCategory = new Category { Name = name };
            context.Categories.Add(newCategory);
            context.SaveChanges();

            return RedirectToAction("Index", "ProductCategories");
        }
        return View();
    }


    [HttpGet]
    public IActionResult GetDetails(int id)
    {
        var category = _category.GetByID(id);

        //var mappedCategory = _mapper.Map<CategoryNameDetailViewModel>(category);
        return View(category);
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        var category = _category.GetByID(id);

        if (category == null) return NotFound();

        var vm = new CategoryViewModel
        {
            Id = id,
            Name = category.Name,
        };

        if (category != null)
        {
            return View(vm);
        }

        // If Err
        return RedirectToAction("Index");
        //var mappedCategory = _mapper.Map<CategoryNameEditViewModel>(category);
    }

    // For admin 
    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit([FromRoute] int id, CategoryNameEditViewModel model)
    {
        //var mappedCategore = _mapper.Map<CategoryNameDetailViewModel>(category);

        var category = _category.GetByID(id);
        if (category == null) return NotFound();

        if (model.Name != null)
        {
            // edit the name
            category.Name = model.Name;
            // save changes, (to be refactored to repos dir)
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        return RedirectToAction("Index");
    }

    [HttpGet]
    public IActionResult Delete(int id, CategoryViewModel vm)
    {
        var category = _category.GetByID(id);

        if (category != null)
        {
            return RedirectToAction("Index");
        }

        // if ERR
        return RedirectToAction("Index");
    }

    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id)
    {
        try
        {
            // delete the catecory
            _category.Delete(id);
            return RedirectToAction("Index");
        }
        catch (Exception ex)
        {

            throw new Exception("Err occured during deleting an category record: " + ex.Message);
        }

    }
}
