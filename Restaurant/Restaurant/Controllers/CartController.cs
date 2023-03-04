using Microsoft.AspNetCore.Mvc;

using Restaurant.Models;
using Restaurant.Repositories;
using Restaurant.ViewModels.CartViewModel;

namespace Restaurant.Controllers
{
    public class CartController : Controller
    {
        private readonly IGenericRepository<Product> _productRepository;
        private readonly IGenericRepository<OrderItems> _orderItemsRepository;
        private readonly IGenericRepository<Customer> _customerRepository;
        private readonly IGenericRepository<Order> _orderRepository;
        public CartController(IGenericRepository<Product> productRepository, IGenericRepository<OrderItems> orderItemsRepository, IGenericRepository<Customer> customerRepository, IGenericRepository<Order> orderRepository)
        {
            _productRepository = productRepository;
            _orderItemsRepository = orderItemsRepository;
            _customerRepository = customerRepository;
            _orderRepository = orderRepository;
        }

        /// <summary>
        /// NEED repository service for testing, based on the following actions
        /// Actions: add, remove, view checkout info, perform checkout and redirect to thank you page
        /// Final Order receipt action based on CustomerOrderRepository
        /// </summary>

        // GET: /Cart
        // get related cart info for specific customer
        public IActionResult Index(CartCheckOutViewModel vm)
        {
            // get all orders by customer id
            //var orderedByCustomer = _orderRepository.GetAllOrdersByCustomerId(id);


            //var cartItems = _orderItemsRepository.GetByID(id);

            // fill the CartCheckOutViewModel from tables:
            // CustomerOrders, Products, Customer, OrderItems


            return Content("test");
        }



        public IActionResult AddToCart(int id)
        {
            var product = _productRepository.GetByID(id);
            if (product != null)
            {
                // add the product to card
                // decrement quantity of one (from order items table)
            }
            return RedirectToAction("Index");
        }

        public IActionResult RemoveFromCart(int id)
        {
            var product = _productRepository.GetByID(id);
            if (product != null)
            {
                // remove the selected product
                // decrement quantity by 1 (from order items table)
            }
            return RedirectToAction("Index");
        }


        [HttpPost]
        public IActionResult Checkout(CartCheckOutViewModel vm)
        {
            if (ModelState.IsValid)
            {
                // Get Checkout Cart Info

                // Create the Order

                // redirect to thank you page if successful



                return RedirectToAction("Complete");
            }
            return View(vm);
        }


    }
}

