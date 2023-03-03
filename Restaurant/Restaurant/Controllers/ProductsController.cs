using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Restaurant.Repositories;

namespace Restaurant.Controllers
{
    public class ProductsController : Controller
    {
        private readonly IGenericRepository<ProductRepository> _product;
        private IMapper _mapper;

        public ProductsController(IGenericRepository<ProductRepository> product, IMapper mapper)
        {
            _product = product;
            _mapper = mapper;
        }


        // GET: ProductsController
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
        public ActionResult Create()
        {
            return View();
        }

        // POST: ProductsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
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
