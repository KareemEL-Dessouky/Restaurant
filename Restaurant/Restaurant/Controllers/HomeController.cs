using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CartViewModel;
using Restaurant.ViewModels.ProductViewModel;
using Microsoft.AspNetCore.Http;
using System.Diagnostics;
using System.Collections.Generic;
using Restaurant.Helper;

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
        private readonly IHttpContextAccessor session;

        List<CartItemViewModel> ShoppingCartItems = new List<CartItemViewModel>();

        public HomeController(IGenericRepository<Product> product, IGenericRepository<OrderItems> orderItems, IMapper mapper, IHttpContextAccessor session)
        {
            _product = product;
            _orderItems = orderItems;
            _mapper = mapper;
            this.session = session;
        }

        //[Authorize] // check cookie expired or not ??
        public IActionResult Index()
        {
            
            var products = _product.GetAll();

            var mappedProducts = _mapper.Map<List<HomeProductViewModel>>(products);

            return View(mappedProducts);
        }

        public IActionResult AddToCart(int id)
        {
            var AddedProduct = _product.GetByID(id);

            if (AddedProduct == null)
            {
                return RedirectToAction("Index");
            }

            var mappedProduct = _mapper.Map<CartItemViewModel>(AddedProduct);

            HttpContext.Session.Set<CartItemViewModel>("item", mappedProduct);

            return RedirectToAction("Index");
        }


        // Search on a Product by title
        public IActionResult SearchProduct(string Seacrchname)
        {
             
            var product =
                (from prod in _product.GetAll()
                 where prod.Title.Contains(Seacrchname)
                 select prod).ToList();

            if (product != null)
            {
                return View(product);
            }

            return RedirectToAction("Index");
        }


        public IActionResult Privacy()
        {
            //var item = HttpContext.Session.Get<CartItemViewModel>("item");
            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}
    }
}