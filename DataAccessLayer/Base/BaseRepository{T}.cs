using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using BussinessObject.Objects;
using DAO.Exceptions;
using DTO.Utils;
using DTO.Constants;
using Repository.IBase;
using Repository.Infrastructure;
using Repository.Models.BaseEntity;
using DTO.Utils;

namespace DAO.Base
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class, new()
    {
        protected readonly MyStoreContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository()
        {
            _context = new MyStoreContext();
            _dbSet = _context.Set<T>();
        }

        public void Add(T entity)
        {
            _dbSet.Add(entity);
            _context.SaveChanges();
        }
        
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }
        
        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
            _context.SaveChanges();
        }
        
        public void Update(T entity)
        {
            var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;
            _context.SaveChanges();
        }
    }
}
