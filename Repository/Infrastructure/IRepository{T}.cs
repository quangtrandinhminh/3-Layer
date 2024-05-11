using Repository.IBase;
using Repository.Models.BaseEntity;

namespace Repository.Infrastructure
{
    public interface IRepository<T> : IBaseRepository<T> where T : Entity, new()
    {
        Task<string> CreateAsync(T entity, CancellationToken cancellationToken = default);
        Task UpdateAsync(T entity, bool isUpdateKeyId = false, CancellationToken cancellationToken = default);
        Task<string> CreateListAsync(List<T> entity, CancellationToken cancellationToken = default);
        Task UpdateListAsync(List<T> entity, CancellationToken cancellationToken = default);

    }
}
