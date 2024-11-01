using Volo.Abp.Modularity;

namespace AbpScanProject;

/* Inherit from this class for your domain layer tests. */
public abstract class AbpScanProjectDomainTestBase<TStartupModule> : AbpScanProjectTestBase<TStartupModule>
    where TStartupModule : IAbpModule
{

}
