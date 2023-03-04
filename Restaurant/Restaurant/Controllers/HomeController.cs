using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.ProductViewModel;
using System.Diagnostics;

namespace Restaurant.Controllers
{
    public class HomeController : Controller
    {
        //private readonly ILogger<HomeController> _logger;

        //public HomeController(ILogger<HomeController> logger)
        //{
        //    _logger = logger;
        //}

        private readonly IGenericRepository<Product> _product;
        private readonly IGenericRepository<OrderItems> _orderItems;
        private readonly IMapper _mapper;

        List<Product> ShoppingCartItems = new List<Product>();

        public HomeController(IGenericRepository<Product> product, IGenericRepository<OrderItems> orderItems, IMapper mapper)
        {
            _product = product;
            _orderItems = orderItems;
            _mapper = mapper;
        }

        public IActionResult Index()
        {
            var products = _product.GetAll();

            var mappedProducts = _mapper.Map<List<HomeProductViewModel>>(products);

            return View(mappedProducts);
        }

        public IActionResult AddToCart(int id)
        {
            var AddedProduct = _product.GetByID(id);
            //var AddedProduct = _mapper.Map<Product>(vm);

            ShoppingCartItems.Add(AddedProduct);

            return RedirectToAction("Index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}