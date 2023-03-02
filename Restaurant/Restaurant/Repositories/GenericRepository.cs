using Restaurant.Models;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
namespace Restaurant.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        RestaurantContext context;

        public GenericRepository(RestaurantContext _context)
        {
            context = _context;
        }

        public IEnumerable<T> GetAll()
        {
            return context.Set<T>().ToList();
        }

        public T GetByID(int id)
        {
            return context.Set<T>().Find(id);//FirstOrDefault(p => p.ID == id);
        }

        public void Delete(int id)
        {
            T entity = GetByID(id);

            context.Set<T>().Remove(entity);
            context.SaveChanges();
        }

        public void Edit(T entity)
        {
            context.Set<T>().Attach(entity);
            context.Entry(entity).State = EntityState.Modified;
        }

        public void Insert(T New)
        {
            context.Set<T>().Add(New);
            context.SaveChanges();
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return context.Set<T>().Where(expression).ToList();
        }
    }
}
