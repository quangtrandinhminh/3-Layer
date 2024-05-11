using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System.Linq.Expressions;
using DAO.Exceptions;
using DTO.Utils;
using DTO.Constants;
using Repository.IBase;
using Repository.Infrastructure;
using Repository.Models.BaseEntity;
using DTO.Utils;

namespace DAO.Base
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : Entity, new()
    {
        protected readonly IDbContext _context;
        protected readonly DbSet<T> _dbSet;
        public BaseRepository(IDbContext context)
        {
            _context = context;
        }

        public void Add(T entity)
        {
            entity.CreatedTime = entity.LastUpdatedTime = CoreHelper.SystemTimeNow;
            _dbSet.Add(entity);
        }
        
        public IQueryable<T> GetAll()
        {
            return _dbSet.AsQueryable();
        }
        
        public void Delete(T entity)
        {
            entity.DeletedTime = CoreHelper.SystemTimeNow;
            _dbSet.Update(entity);
        }
        
        public void Update(T entity)
        {
            /*var tracker = _context.Attach(entity);
            tracker.State = EntityState.Modified;*/
            entity.LastUpdatedTime = CoreHelper.SystemTimeNow;
            _dbSet.Update(entity);
        }
    }
}
