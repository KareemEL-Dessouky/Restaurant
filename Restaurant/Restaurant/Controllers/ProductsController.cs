using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

using Restaurant.Helper;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.ProductViewModel;

namespace Restaurant.Controllers
{
    [Authorize(Roles ="Admin")]
    public class ProductsController : Controller
    {
        private readonly IGenericRepository<Category> _category;

        private readonly IGenericRepository<Product> _product;

        RestaurantContext _context;
        private IMapper _mapper;

        // upload img
        //private readonly FileUploader _fileUpload;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductsController(IGenericRepository<Product> product, IMapper mapper, IGenericRepository<Category> category, /*FileUploader fileUpload,*/ IWebHostEnvironment webHostEnvironment, RestaurantContext context)
        {
            _product = product;
            _mapper = mapper;
            _category = category;
            //_fileUpload = fileUpload;
            _webHostEnvironment = webHostEnvironment;
            _context = context;
        }


        // GET: ProductsController 
        //[Authorize] // check cookie expired or not ??
        public IActionResult Index()
        {
            var products = _product.GetAll();

            var mappedProducts = _mapper.Map<IEnumerable<ProductListViewModel>>(products);

            if (mappedProducts == null) return NotFound();
            foreach (var product in mappedProducts)
            {
                var category = _category.Find(c => c.ID == product.CategoryID).FirstOrDefault();
                product.Category = category?.Name;
            }

            // render UI
            return View(mappedProducts);
        }



        // GET: Product/Create
        [HttpGet]
        public IActionResult Create()
        {
            var vm = new ProductViewModel();

            var categories = _category.GetAll();

            // populate list for select html view
            ViewBag.CategoriesList = new SelectList(categories, "ID", "Name");
            ViewBag.Categories = categories;
            return View(vm);
        }


        // POST: Product/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductViewModel vm)
        {
            //    //// for image upload
            //FileUploader fileupload = new FileUploader(_webHostEnvironment);
            //string imgFileName = fileupload.Upload(vm.Image);

            // get the choose category from user form
            var choosenCategory = _category.Find(c => c.ID == vm.CategoryID).FirstOrDefault();

            if (ModelState.IsValid)
            {
                // map view model data from user into a record
                var newProduct = _mapper.Map<Product>(vm);

                try
                {
                    // update db records for products
                    _product.Insert(newProduct);
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Error occured during insertdatabase, please try again: " + ex.Message);

                    return View(vm);

                }
            }
            // unexpected err
            return RedirectToAction(nameof(Index));
        }


        // GET: ProductsController/Edit/5
        public IActionResult Edit([FromRoute] int id)
        {

            var product = _product.GetByID(id);
            if (product == null)
            {
                return NotFound();
            }

            // get the model out of the record
            var productViewModel = _mapper.Map<ProductViewModel>(product);

            var categories = _category.GetAll();

            //// update categories into the view
            //productViewModel.Categories = categories;

            // populate list for select html view
            ViewBag.CategoriesList = new SelectList(categories, "ID", "Name");
            ViewBag.Categories = categories;

            return View(productViewModel);
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProductViewModel vm)
        {

            if (ModelState.IsValid)
            {
                //var product = _mapper.Map<Product>(ProductViewModel);

                var product = _product.GetByID(id);

                var chosenCategory = _category.Find(c => c.ID == vm.CategoryID).FirstOrDefault();
                //product.Category = chosenCategory;


                try
                {
                    // to refactor to product repository
                    product.Price = vm.Price;
                    product.Title = vm.Title;
                    product.Category = chosenCategory;
                    // apply change to db
                    _context.SaveChanges();
                }
                catch (Exception ex)
                {
                    ModelState.AddModelError(string.Empty, "Error occured during updating the database, please try again: " + ex.Message);

                    return View(vm);
                }

                return RedirectToAction(nameof(Index));
            }

            // unexpected err
            return RedirectToAction(nameof(Index));
        }

        // Post: ProductsController/Delete/5

        [HttpGet]
        public IActionResult Delete(int id, ProductViewModel vm)
        {
            var product = _product.GetByID(id);

            if (product != null)
            {
                return RedirectToAction("Index");
            }

            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            try
            {
                // delete the product
                _product.Delete(id);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                throw new Exception("Err occured during deleting the product record: " + ex.Message);
            }

        }

        
    }
}
