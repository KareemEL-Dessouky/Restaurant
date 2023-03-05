using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

using Restaurant.Helper;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.ProductViewModel;

namespace Restaurant.Controllers
{
    public class ProductsController : Controller
    {
        // TODO: refactor for category list items (name, value)
        private readonly IGenericRepository<Category> _categoryModel;

        private readonly IGenericRepository<Product> _product;
        private IMapper _mapper;

        // upload img
        private readonly FileUploader _fileUpload;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductsController(IGenericRepository<Product> product, IMapper mapper, IGenericRepository<Category> category, /*FileUploader fileUpload,*/ IWebHostEnvironment webHostEnvironment)
        {
            _product = product;
            _mapper = mapper;
            _categoryModel = category;
            //_fileUpload = fileUpload;
            _webHostEnvironment = webHostEnvironment;
        }


        // GET: ProductsController 
        // TODO: Fix Product Service Bug!
        // Try on this method & comment others
        public IActionResult Index()
        {
            //var products = _product.GetAll();
            //var mappedProducts = _mapper.Map<IEnumerable<ProductViewModel>>(products);
            IEnumerable<Product> products = _product.GetAll();

            //return Content("Test");
            return View(products);
        }



        // GET: ProductsController/Details/5
        public IActionResult Details(int id)
        {
            // product with it's category
            //var products = _product.GetWithCategoryByID(id);

            var product = _product.GetByID(id);
            return View();
        }



        // GET: ProductsController/Create
        [HttpGet]
        public IActionResult Create()
        {

            var vm = new ProductCreateNewViewModel();
            //vm.CategoriesIds = _categoryModel.GetAll().Select(c => c.ID).ToList();
            vm.Categories = _categoryModel.GetAll();

            return View(vm);
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(ProductCreateNewViewModel vm)
        {
            //// for image upload
            //FileUploader fileupload = new FileUploader(_webHostEnvironment);

            //string imgFileName = fileupload.Upload(vm.Image);

            // NEED repo helper to get selected categories by name or ids
            //var selectedCategories = _product.Find()

            //var newProduct = new Product
            //{
            //    //Image = imgFileName.ToString(),
            //    Title = vm.Title,
            //    Price = vm.Price,
            //    CategoryID = vm.CategoryID,
            //};

            if (ModelState.IsValid)
            {
                var newProduct = _mapper.Map<Product>(vm);

                _product.Insert(newProduct);

                RedirectToAction("Index");
            }

            return View(vm);
        }

        // GET: ProductsController/Edit/5
        public IActionResult Edit(int id)
        {
            var ExistingProduct = _product.GetByID(id);

            if (ExistingProduct != null)
            {
                var vm = _mapper.Map<ProductCreateNewViewModel>(ExistingProduct);

                return View(vm);
            }

            return RedirectToAction("Index");
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(int id, ProductCreateNewViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var ModifiedProduct = _product.GetByID(id);
                ModifiedProduct = _mapper.Map<Product>(vm);
                ModifiedProduct.ID = id;

                _product.Edit(ModifiedProduct);
            }

            return View(vm);
        }

        // Post: ProductsController/Delete/5
        public IActionResult Delete(int id)
        {
            _product.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
