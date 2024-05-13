using BussinessObject.Objects;
using DAO.Base;
using DAO.Exceptions;
using Microsoft.AspNetCore.Http;
using Repository.IBase;
using Repository.Infrastructure;
using Repository.Models.BaseEntity;
using Serilog;

namespace DAO.Infrastructure
{
    public abstract class Repository<T> : BaseRepository<T> ,IBaseRepository<T> where T : class, new()
    {
        public Repository()
        {
        }
    }
}