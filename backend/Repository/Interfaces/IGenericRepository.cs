using System.Linq.Expressions;

namespace backend.Repository.Interfaces
{
    public interface IGenericRepository<T> where T : class
    {
        Task<ICollection<T>> GetAll();
        Task<T> GetByid(int id);
        IEnumerable<T> Find(Expression<Func<T, bool>> expression);
        Task Create(T entity);
        Task Update(T entity);
        Task Delete(T entity);
    }
}
