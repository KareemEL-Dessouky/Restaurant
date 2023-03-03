using Restaurant.Models;
using System.Linq;
using System.Linq.Expressions;

namespace Restaurant.Repositories
{
    public class ProductRepository : IGenericRepository<Product>
    {
        RestaurantContext context;

        public ProductRepository(RestaurantContext _context)
        {
            context = _context;
        }

        public IEnumerable<Product> GetAll()
        {
            return context.Products.ToList();
        }

        public Product GetByID(int id)
        {
            return context.Products.FirstOrDefault(p => p.ID == id);
        }

        public void Delete(int id)
        {
            Product product = GetByID(id);

            if (product != null)
            {
                context.Products.Remove(product);
                context.SaveChanges();
            }

            return;
        }

        public void Edit(Product product)
        {
            //Product ExistingProduct = GetByID(product.ID);

            

            context.SaveChanges();
        }

        public void Insert(Product NewProduct)
        {
            context.Products.Add(NewProduct);
            context.SaveChanges();
        }

        public IEnumerable<Product> Find(Expression<Func<Product, bool>> expression)
        {
            return context.Set<Product>().Where(expression).ToList();
        }
    }
}
