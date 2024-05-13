using System.Linq.Expressions;

namespace Repository.IBase;

    public interface IBaseRepository<T> where T : class, new()
    {
        void Add(T entity);
        IQueryable<T> GetAll();
        void Delete(T entity);
        void Update(T entity);
    }
