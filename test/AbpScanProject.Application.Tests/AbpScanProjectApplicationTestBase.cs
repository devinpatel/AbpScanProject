using Volo.Abp.Modularity;

namespace AbpScanProject;

public abstract class AbpScanProjectApplicationTestBase<TStartupModule> : AbpScanProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
