using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CategoryViewModel;

namespace Restaurant.Controllers;

public class CategoriesController : Controller
{
    private readonly IGenericRepository<Category> _category;
    private IMapper _mapper;

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
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Create(CategoryNameCreateViewModel vm)
    {
        var mappedCategory = _mapper.Map<Category>(vm);
        _category.Insert(mappedCategory);

        return RedirectToAction("Index", "Categories");
    }


    [HttpGet]
    public IActionResult GetDetails(int id)
    {
        var category = _category.GetByID(id);
        var mappedCategory = _mapper.Map<CategoryNameDetailViewModel>(category);
        return View(mappedCategory);
    }


    [HttpGet]
    public IActionResult Edit(int id)
    {
        var category = _category.GetByID(id);
        var mappedCategory = _mapper.Map<CategoryNameEditViewModel>(category);
        return View(mappedCategory);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Edit(CategoryNameEditViewModel vm)
    {
        //var category = _category.GetByID(id);
        //var mappedCategore = _mapper.Map<CategoryNameDetailViewModel>(category);

        // TODO: should it be similar to delete action expected an id params, or view model

        //_category.Edit();

        return RedirectToAction("Index", "Categories");
    }


    [HttpGet]
    public IActionResult Delete(int id)
    {
        var category = _category.GetByID(id);
        //var mappedCategory = _mapper.Map<CategoryNameDeleteViewModel>(category);
        return View(category);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult Delete(int id, CategoryNameDeleteViewModel vm)
    {
        _category.Delete(id);

        return RedirectToAction("Index", "Categories");
    }



}
