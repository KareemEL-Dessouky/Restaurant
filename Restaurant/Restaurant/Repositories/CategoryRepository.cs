using Restaurant.Models;
using System.Linq.Expressions;

namespace Restaurant.Repositories
{
    public class CategoryRepository : IGenericRepository<Category>
    {
        RestaurantContext context;

        public CategoryRepository(RestaurantContext _context)
        {
            context = _context;
        }

        public IEnumerable<Category> GetAll()
        {
            return context.Categories.ToList();
        }

        public Category GetByID(int id)
        {
            return context.Categories.FirstOrDefault(c => c.ID == id);
        }

        public IEnumerable<Category> Find(Expression<Func<Category, bool>> expression)
        {
            return context.Set<Category>().Where(expression).ToList();
        }

        public void Delete(int id)
        {
            Category category = GetByID(id);

            context.Categories.Remove(category);
            context.SaveChanges();
        }

        public void Edit(Category category)
        {
            Category ExistingCategory = GetByID(category.ID);

            // Use auto-mapper
            // ViewModel reference = ExistingCategory

            context.SaveChanges();
        }

        public void Insert(Category NewCategory)
        {
            context.Categories.Add(NewCategory);
            context.SaveChanges();

            //context.Set<Category>().Add(NewCategory);
        }

    }
}
