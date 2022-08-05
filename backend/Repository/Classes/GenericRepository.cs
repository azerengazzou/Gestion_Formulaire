using backend.Models;
using backend.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace backend.Repository.Classes
{
    public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public DBFormContext _context;

        public GenericRepository(DBFormContext context)
        {
            _context = context;
        }
        public async Task<T> GetByid(int id)
        {
            return await _context.Set<T>().FindAsync(id);
        }

        public IEnumerable<T> Find(Expression<Func<T, bool>> expression)
        {
            return _context.Set<T>().Where(expression);
        }

        public async Task<ICollection<T>> GetAll()
        {
            return await _context.Set<T>().ToListAsync();
        }

        public async Task Create(T entity)
        {
            await _context.Set<T>().AddAsync(entity);
            _context.SaveChanges();
        }
        public Task Update(T entity)
        {
            _context.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            _context.SaveChanges();
            return Task.CompletedTask;
        }


        public Task Delete(T entity)
        {
            _context.Set<T>().RemoveRange(entity);
            _context.SaveChanges();
            return Task.CompletedTask;
        }
    }
}
