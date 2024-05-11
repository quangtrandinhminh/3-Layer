﻿using DTO.Utils;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WaterCity.Core.Utils;

namespace Repository.Models.BaseEntity;

public abstract class Entity
{
    protected Entity()
    {
        Id = Guid.NewGuid().ToString("N");
        CreatedTime = LastUpdatedTime = CoreHelper.SystemTimeNow;
    }

    [Key]
    public string Id { get; set; }
    //public string KeyId { get; set; }
    public string? CreatedBy { get; set; }
    public string? LastUpdatedBy { get; set; }
    public string? DeletedBy { get; set; }

    public DateTimeOffset CreatedTime { get; set; }

    public DateTimeOffset LastUpdatedTime { get; set; }

    public DateTimeOffset? DeletedTime { get; set; }

    [NotMapped]
    private bool IsDisposed { get; set; }

    #region Dispose
    public void Dispose()
    {
        Dispose(isDisposing: true);
        GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool isDisposing)
    {
        if (!IsDisposed)
        {
            if (isDisposing)
            {
                DisposeUnmanagedResources();
            }

            IsDisposed = true;
        }
    }

    protected virtual void DisposeUnmanagedResources()
    {
    }

    ~Entity()
    {
        Dispose(isDisposing: false);
    }
    #endregion Dispose
}