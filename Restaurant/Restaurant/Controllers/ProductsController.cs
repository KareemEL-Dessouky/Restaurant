using AutoMapper;

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

        private readonly IGenericRepository<ProductRepository> _product;
        private IMapper _mapper;

        // upload img
        private readonly FileUploader _fileUpload;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public ProductsController(IGenericRepository<ProductRepository> product, IMapper mapper, IGenericRepository<Category> category, FileUploader fileUpload, IWebHostEnvironment webHostEnvironment)
        {
            _product = product;
            _mapper = mapper;
            _categoryModel = category;
            _fileUpload = fileUpload;
            _webHostEnvironment = webHostEnvironment;
        }


        // GET: ProductsController 
        // TODO: Fix Product Service Bug!
        // Try on this method & comment others
        public ActionResult Index()
        {
            var products = _product.GetAll();
            //var mappedProducts = _mapper.Map<IEnumerable<ProductViewModel>>(products);

            return Content("Test");
        }



        // GET: ProductsController/Details/5
        public ActionResult Details(int id)
        {
            // product with it's category
            //var products = _product.GetWithCategoryByID(id);

            var products = _product.GetByID(id);
            return View();
        }



        // GET: ProductsController/Create
        [HttpGet]
        public ActionResult Create()
        {

            var vm = new ProductInfoViewModel();
            vm.CategoriesIds = _categoryModel.GetAll().Select(c => c.ID).ToList();
            vm.CategoriesNames = _categoryModel.GetAll().Select(c => c.Name).ToList();

            return View(vm);
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ProductCreateNewViewModel vm)
        {
            //// for image upload
            //FileUploader fileupload = new FileUploader(_webHostEnvironment);

            //string imgFileName = fileupload.Upload(vm.Image);

            // NEED repo helper to get selected categories by name or ids
            //var selectedCategories = _product.Find()

            var newProduct = new ProductCreateNewViewModel
            {
                //Image = imgFileName.ToString(),
                Title = vm.Title,
                Price = vm.Price,
                SelectedCategories = vm.SelectedCategories,
            };

            return View();

        }

        // GET: ProductsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ProductsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ProductsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ProductsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
