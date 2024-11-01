using AbpScanProject.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.Modularity;

namespace AbpScanProject.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpScanProjectEntityFrameworkCoreModule),
    typeof(AbpScanProjectApplicationContractsModule)
)]
public class AbpScanProjectDbMigratorModule : AbpModule
{
}
