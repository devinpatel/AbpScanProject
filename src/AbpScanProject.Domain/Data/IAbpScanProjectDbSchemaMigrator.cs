using System.Threading.Tasks;

namespace AbpScanProject.Data;

public interface IAbpScanProjectDbSchemaMigrator
{
    Task MigrateAsync();
}
