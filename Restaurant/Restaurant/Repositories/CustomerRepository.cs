using Restaurant.Models;
using System.Linq;
using System.Linq.Expressions;

namespace Restaurant.Repositories
{
    public class CustomerRepository : IGenericRepository<Customer>
    {
        RestaurantContext context;

        public CustomerRepository(RestaurantContext _context)
        {
            context = _context;
        }

        public IEnumerable<Customer> GetAll()
        {
            return context.Customers.ToList();
        }

        public Customer GetByID(int id)
        {
            return context.Customers.FirstOrDefault(c => c.ID == id);
        }

        public void Delete(int id)
        {
            Customer customer = GetByID(id);

            context.Customers.Remove(customer);
            context.SaveChanges();
        }

        public void Edit(Customer customer)
        {
            Customer ExistingCustomer = GetByID(customer.ID);

            // Use auto-mapper
            // ViewModel reference = ExistingCustomer

            context.SaveChanges();
        }

        public void Insert(Customer NewCustomer)
        {
            context.Customers.Add(NewCustomer);
            context.SaveChanges();
        }

        public IEnumerable<Customer> Find(Expression<Func<Customer, bool>> expression)
        {
            return context.Set<Customer>().Where(expression).ToList();
        }
    }
}
