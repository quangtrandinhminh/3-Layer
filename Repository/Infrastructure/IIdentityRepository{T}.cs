using System.Linq.Expressions;

namespace Repository.Infrastructure
{
    public interface IIdentityRepository<Tkey> where Tkey : class, new()
    {
        void RefreshEntity(Tkey entity);
        IQueryable<Tkey> Get(Expression<Func<Tkey, bool>>? predicate = null, params Expression<Func<Tkey, object>>[] includeProperties);
        Tkey? GetSingle(Expression<Func<Tkey, bool>>? predicate = null, params Expression<Func<Tkey, object>>[] includeProperties);
        Tkey Add(Tkey entity);
        Task AddAsync(Tkey entity, CancellationToken cancellationToken = default);
        List<Tkey> AddRange(params Tkey[] entities);
        void Update(Tkey entity);
        void Update(Tkey entity, params Expression<Func<Tkey, object>>[] changedProperties);
        void Delete(Tkey entity);
    }
}