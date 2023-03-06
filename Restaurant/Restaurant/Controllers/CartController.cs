using AutoMapper;

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

using Restaurant.Helper;
using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CartViewModel;

namespace Restaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IGenericRepository<Product> _product;
        private readonly IGenericRepository<OrderItems> _orderItems;
        private readonly IGenericRepository<Customer> _customer;
        private readonly IGenericRepository<Order> _customerOrder;
        private readonly RestaurantContext _context;
        private readonly IMapper _mapper;
        public CartController(IGenericRepository<Product> productRepository, IGenericRepository<OrderItems> orderItemsRepository, IGenericRepository<Customer> customerRepository, IGenericRepository<Order> orderRepository, IMapper mapper, RestaurantContext context, UserManager<ApplicationUser> userManager)
        {
            _product = productRepository;
            _orderItems = orderItemsRepository;
            _customer = customerRepository;
            _customerOrder = orderRepository;
            _mapper = mapper;
            _context = context;
            _userManager = userManager;
        }



        // GET: /Cart/AddtoCart
        // get related cart info for specific customer
        public IActionResult AddToCart(int id, int quantity)
        {
            var addedProduct = _product.GetByID(id);

            if (addedProduct == null)
            {
                // output msg: try again
                return RedirectToAction("Index", "Home");
            }


            var mappedProduct = _mapper.Map<CartItemViewModel>(addedProduct);
            mappedProduct.Quantity = quantity;

            // save cart item to session
            HttpContext.Session.Set("CartItem", mappedProduct);

            return RedirectToAction("Index", "Home");

        }

        // GET: /Cart/Checkout
        [HttpGet]
        public IActionResult Checkout()
        {
            // get and deserialize data json
            var cartItem = HttpContext.Session.Get<CartItemViewModel>("CartItem");

            return View(cartItem);
        }

        public IActionResult PlaceOrder()
        {
            var user = _userManager.GetUserAsync(User);
            var mockUserId = 1;

            // get and deserialize data json
            var cartItem = HttpContext.Session.Get<CartItemViewModel>("CartItem");


            var customerOrder = new Order
            {
                CustomerID = mockUserId,
                TotalPrice = cartItem.ItemsTotalPrice,
                PlacedAt = DateTime.UtcNow,
            };

            // Add the customer order to the database
            _customerOrder.Insert(customerOrder);

            // create order item accordingly
            var orderItem = new OrderItems
            {
                OrderID = customerOrder.ID,
                ProductID = cartItem.Id,
                Quantity = cartItem.Quantity,
                Price = cartItem.Price
            };

            // check if sufficient quantity avaiable or possible null
            if (orderItem == null || orderItem.Quantity == 0  /*||cartItem.Quantity > orderItem.Quantity*/)
            {
                ViewBag.NotAvailable = "There is not enough quantity in the store at the moment, try another time!";
                return View();
            }


            _orderItems.Insert(orderItem);

            _context.SaveChanges();

            return View();
        }
    }
}

