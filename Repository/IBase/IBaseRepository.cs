using System.Linq.Expressions;
using Repository.Models.BaseEntity;


namespace Repository.IBase;

<<<<<<< Updated upstream

    public interface IBaseRepository<T> where T : Entity, new()
=======
    public interface IBaseRepository<T> where T : class, new()
>>>>>>> Stashed changes
    {
        void RefreshEntity(T entity);

        IQueryable<T> Include(params Expression<Func<T, object>>[] includeProperties);

        IQueryable<T> Set();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, bool isIncludeDeleted = false, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> Get(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        IQueryable<T> GetTracking(Expression<Func<T, bool>> predicate = null, params Expression<Func<T, object>>[] includeProperties);
        T GetSingle(Expression<Func<T, bool>> predicate, bool isIncludeDeleted = false, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetSingleAsync(Expression<Func<T, bool>> predicate, bool isIncludeDeleted = false, params Expression<Func<T, object>>[] includeProperties);
        Task<List<T>> GetAsync(Expression<Func<T, bool>> predicate, Expression<Func<T, DateTimeOffset>> orderby=null, bool isIncludeDeleted = false, params Expression<Func<T, object>>[] includeProperties);
        Task<List<T>> GetWithIncludesAsync(Expression<Func<T, bool>> predicate = null, bool isIncludeDeleted = false, params Expression<Func<T, object>>[] includeProperties);
        T GetSingleTracking(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);
        Task<T> GetSingleAsyncWithProperties(Expression<Func<T, bool>> predicate, bool isIncludeDeleted = false, params Expression<Func<T, object>>[] includeProperties);
        T Add(T entity);
        Task AddAsync(T entity, CancellationToken cancellationToken = default);

        List<T> AddRange(params T[] entities);

        void Update(T entity, params Expression<Func<T, object>>[] changedProperties);
        void Update(T entity, params string[] changedProperties);
        void Update(T entity);
        void UpdateWhere(Expression<Func<T, bool>> predicate, T entityNewData, params Expression<Func<T, object>>[] changedProperties);
        void UpdateWhere(Expression<Func<T, bool>> predicate, T entityNewData, params string[] changedProperties);
        void UpdateRange(IEnumerable<T> entities, params Expression<Func<T, object>>[] changedProperties);

        void Delete(T entity);
        void Delete(T entity, bool isPhysicalDelete = false);
        void DeleteWhere(Expression<Func<T, bool>> predicate, bool isPhysicalDelete = false);
        void DeleteWhere(List<string> ids, bool isPhysicalDelete = false);
        void DeleteWhere(Expression<Func<T, bool>> predicate);
        void DeleteRange(ICollection<T> entities);

        Task<T> GetSingleTrackingAsync(Expression<Func<T, bool>> predicate, params Expression<Func<T, object>>[] includeProperties);

    }
