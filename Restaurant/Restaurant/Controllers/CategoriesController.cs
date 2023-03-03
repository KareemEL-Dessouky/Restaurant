using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CategoryViewModel;

namespace Restaurant.Controllers;

public class CategoriesController : Controller
{
    private readonly IGenericRepository<Category> _category;
    private readonly IMapper _mapper;

    public CategoriesController(IGenericRepository<Category> category, IMapper mapper)
    {
        this._category = category;
        _mapper = mapper;
    }


    [HttpGet]
    public IActionResult Index()
    {
        var categories = _category.GetAll();
        var mappedCategories = _mapper.Map<List<CategoryViewModel>>(categories);

        return View(mappedCategories);

        //return PartialView(mappedCategories);
    }

    [HttpGet]
    public IActionResult Create()
    {
        var NewCategory = new Category();

        return View(NewCategory);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _category.Insert(category);
        
            return RedirectToAction("Index", "Categories");
        }

        return View(category);
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

        if (category != null)
            return View(category);
        else
            return RedirectToAction("Index");
        //var mappedCategory = _mapper.Map<CategoryNameEditViewModel>(category);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(int id, Category category)
    {
        //var mappedCategore = _mapper.Map<CategoryNameDetailViewModel>(category);

        // TODO: should it be similar to delete action expected an id params, or view model

        if (ModelState.IsValid)
        {
            _category.Edit(category);
        }

        return View(category);
    }

    public IActionResult Delete(int id)
    {
        _category.Delete(id);

        return RedirectToAction("Index");
    }
}
