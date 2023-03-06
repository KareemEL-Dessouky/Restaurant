using AutoMapper;

using Microsoft.AspNetCore.Mvc;

using Newtonsoft.Json;

using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CartViewModel;

namespace Restaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly IGenericRepository<Product> _product;
        private readonly IGenericRepository<OrderItems> _orderItems;
        private readonly IGenericRepository<Customer> _customer;
        private readonly IGenericRepository<Order> _order;
        private readonly RestaurantContext _context;
        private readonly IMapper _mapper;
        public CartController(IGenericRepository<Product> productRepository, IGenericRepository<OrderItems> orderItemsRepository, IGenericRepository<Customer> customerRepository, IGenericRepository<Order> orderRepository, IMapper mapper, RestaurantContext context)
        {
            _product = productRepository;
            _orderItems = orderItemsRepository;
            _customer = customerRepository;
            _order = orderRepository;
            _mapper = mapper;
            _context = context;
        }



        // GET: /Cart/AddtoCart
        // get related cart info for specific customer
        public IActionResult AddToCart(int id, int quantity)
        {
            var addedProduct = _product.GetByID(id);

            if (addedProduct == null)
            {
                // output msg: try again
                return RedirectToAction("Index");
            }


            var mappedProduct = _mapper.Map<CartItemViewModel>(addedProduct);
            mappedProduct.Quantity = quantity;

            // save cart item to session
            HttpContext.Session.SetString("CartItem", JsonConvert.SerializeObject(mappedProduct));


            // Redirect user to checkout page
            return RedirectToAction("Checkout");

        }

        // GET: /Cart/Checkout
        [HttpGet]
        public IActionResult Checkout(CartItemViewModel cartItemViewModel)
        {
            // get and deserialize data json
            var cartItemJson = HttpContext.Session.GetString("CartItem");
            var cartItem = cartItemJson != null ?
                JsonConvert.DeserializeObject<CartItemViewModel>(cartItemJson) : null;

            var order = _context.OrderItems.FirstOrDefault(o => o.ProductID == cartItem.Id);

            // check if sufficient quantity avaiable
            if (cartItem.Quantity > order.Quantity)
            {
                ViewBag.NotAvailable = "There is not enough quantity in the store at the moment, try another time!";
                return View();
            }
            // decrease the items quantity according to user choice
            order.Quantity -= cartItem.Quantity;

            _context.SaveChanges();

            var mappedProduct = _mapper.Map<CartItemViewModel>(cartItem);
            return View(mappedProduct);
        }
    }
}

