﻿namespace WaterCity.Contract.Repository.Infrastructure
{
    public interface IBootstrapper
    {
        Task InitialAsync(CancellationToken cancellationToken = default);
    }
}
