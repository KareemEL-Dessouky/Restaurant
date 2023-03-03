using System.Linq.Expressions;

using Restaurant.Models;

namespace Restaurant.Repositories
{
    public class OrderRepository : IGenericRepository<Order>
    {
        RestaurantContext context;

        public OrderRepository(RestaurantContext _context)
        {
            context = _context;
        }

        public IEnumerable<Order> GetAll()
        {
            return context.CustomerOrders.ToList();
        }

        public Order GetByID(int id)
        {
            return context.CustomerOrders.FirstOrDefault(p => p.ID == id);
        }

        public IEnumerable<Order> GetAllOrdersByCustomerId(int id)
        {
            return context.CustomerOrders.Where(o => o.CustomerID == id).ToList();
        }

        public void Delete(int id)
        {
            Order order = GetByID(id);

            context.CustomerOrders.Remove(order);
            context.SaveChanges();
        }

        public void Edit(Order order)
        {
            Order ExistingOrder = GetByID(order.ID);

            // Use auto-mapper
            // ViewModel reference = ExistingOrder

            context.SaveChanges();
        }

        public void Insert(Order NewOrder)
        {
            context.CustomerOrders.Add(NewOrder);
            context.SaveChanges();
        }

        public IEnumerable<Order> Find(Expression<Func<Order, bool>> expression)
        {
            return context.Set<Order>().Where(expression).ToList();
        }
    }
}
