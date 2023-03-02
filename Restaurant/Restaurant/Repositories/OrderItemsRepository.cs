using Restaurant.Models;
using System.Linq.Expressions;

namespace Restaurant.Repositories
{
    public class OrderItemsRepository : IGenericRepository<OrderItems>
    {
        RestaurantContext context;

        public OrderItemsRepository(RestaurantContext _context)
        {
            context = _context;
        }

        public IEnumerable<OrderItems> GetAll()
        {
            return context.OrderItems.ToList();
        }

        public OrderItems GetByID(int id)
        {
            return context.OrderItems.FirstOrDefault(o => o.OrderID == id);
        }

        public void Delete(int id)
        {
            OrderItems orderItem = GetByID(id);

            context.OrderItems.Remove(orderItem);
            context.SaveChanges();
        }

        public void Edit(OrderItems orderItem)
        {
            OrderItems ExistingOrderItem = GetByID(orderItem.ID);

            // Use auto-mapper
            // ViewModel reference = ExistingOrderItems

            context.SaveChanges();
        }

        public void Insert(OrderItems NewOrderItem)
        {
            context.OrderItems.Add(NewOrderItem);
            context.SaveChanges();
        }

        public IEnumerable<OrderItems> Find(Expression<Func<OrderItems, bool>> expression)
        {
            return context.Set<OrderItems>().Where(expression).ToList();
        }
    }
}
