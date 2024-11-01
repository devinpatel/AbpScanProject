using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpScanProject.Data;
using Volo.Abp.DependencyInjection;

namespace AbpScanProject.EntityFrameworkCore;

public class EntityFrameworkCoreAbpScanProjectDbSchemaMigrator
    : IAbpScanProjectDbSchemaMigrator, ITransientDependency
{
    private readonly IServiceProvider _serviceProvider;

    public EntityFrameworkCoreAbpScanProjectDbSchemaMigrator(IServiceProvider serviceProvider)
    {
        _serviceProvider = serviceProvider;
    }

    public async Task MigrateAsync()
    {
        /* We intentionally resolving the AbpScanProjectDbContext
         * from IServiceProvider (instead of directly injecting it)
         * to properly get the connection string of the current tenant in the
         * current scope.
         */

        await _serviceProvider
            .GetRequiredService<AbpScanProjectDbContext>()
            .Database
            .MigrateAsync();
    }
}
