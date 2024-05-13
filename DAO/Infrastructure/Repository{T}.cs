using Microsoft.AspNetCore.Http;
using Serilog;
using WaterCity.Contract.Repository.IBase;
using WaterCity.Contract.Repository.Infrastructure;
using WaterCity.Contract.Repository.Models.BaseEntity;
using WaterCity.Contract.Repository.Interface;
using WaterCity.Contract.Repository.Models;
using WaterCity.Core.Constants;
using WaterCity.Core.Exceptions;
using WaterCity.Repository.Base;
using WaterCity.Repository.Repositories;

namespace WaterCity.Repository.Infrastructure
{
    public abstract class Repository<T> : BaseRepository<T>, IRepository<T> ,IBaseRepository<T> where T : Entity, new()
    {
        private readonly ILogger _logger;
        public Repository(IDbContext dbContext) : base(dbContext)
        {
            _logger = Log.Logger;
        }

        public async Task<string> CreateAsync(T entity, CancellationToken cancellationToken = default)
        {
            var model = await GetSingleAsync(_ => _.Id == entity.Id);
            if (model != null)
            {
                _logger.Error($"- {typeof(T).Name} Insert Database is duplicated: id - {entity.Id}");
                throw new CoreException(ResponseCodeConstants.DUPLICATE, ApplicationConstants.DUPLICATE);
            }
            await AddAsync(entity, cancellationToken);
            return Task.FromResult(entity.Id).Result;
        }

        public async Task<string> CreateListAsync(List<T> entity, CancellationToken cancellationToken = default)
        {
            foreach (var item in entity)
            {
                var model = await GetSingleAsync(_ => _.Id == item.Id);
                if (model != null)
                {
                    _logger.Error($"- {typeof(T).Name} Insert Database is duplicated: id - {item.Id}");
                    throw new CoreException(ResponseCodeConstants.DUPLICATE, ApplicationConstants.DUPLICATE);
                }
                else
                {
                    await AddAsync(item, cancellationToken);
                    return Task.FromResult(item.Id).Result;
                }
            }
            return null;
        }

        public Task UpdateAsync(T entity, bool isUpdateKeyId = false, CancellationToken cancellationToken = default)
        {
            if (typeof(T).GetProperty(ApplicationConstants.KeyId) != null)
            {
                var keyId = (string)entity.GetType().GetProperty(ApplicationConstants.KeyId).GetValue(entity);
                if (isUpdateKeyId)
                {
                    var dupModel = GetSingle(x => (x as IdentityOptionalEntity).KeyId == keyId);
                    if (dupModel != null)
                    {
                        _logger.Information(ErrorCode.NotUnique, keyId);
                        throw new CoreException(code: ResponseCodeConstants.EXISTED, message: ReponseMessageConstantsCommon.EXISTED, statusCode: StatusCodes.Status400BadRequest);
                    }
                }
            }

            Update(entity);
            return Task.CompletedTask;
        }

        public Task UpdateListAsync(List<T> entity, CancellationToken cancellationToken = default)
        {
            foreach (var item in entity)
            {
                Update(item);
            }
            return Task.CompletedTask;

        }
    }
}