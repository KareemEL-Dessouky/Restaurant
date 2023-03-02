using System.Linq.Expressions;

namespace Restaurant.Repositories
{
    public interface IGenericRepository<T>
    {
        IEnumerable<T> GetAll();
        T GetByID(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        void Insert(T entity);
        void Edit(T entity);
        void Delete(int id);
    }
}
