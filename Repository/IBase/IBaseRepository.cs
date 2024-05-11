using System.Linq.Expressions;
using Repository.Models.BaseEntity;


namespace Repository.IBase;

    public interface IBaseRepository<T> where T : Entity, new()
    {
        public void Add(T entity);
        public IQueryable<T> GetAll();
        public void Delete(T entity);
        public void Update(T entity);
        
    }
