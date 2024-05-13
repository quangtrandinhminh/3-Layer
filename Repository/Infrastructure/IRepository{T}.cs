using Repository.IBase;
using Repository.Models.BaseEntity;

namespace Repository.Infrastructure
{
    public interface IRepository<T> : IBaseRepository<T> where T : class, new()
    {
        
    }
}
