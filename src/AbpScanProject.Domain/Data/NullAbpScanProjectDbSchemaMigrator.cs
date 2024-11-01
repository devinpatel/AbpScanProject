using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpScanProject.Data;

/* This is used if database provider does't define
 * IAbpScanProjectDbSchemaMigrator implementation.
 */
public class NullAbpScanProjectDbSchemaMigrator : IAbpScanProjectDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
