using Volo.Abp.Modularity;

namespace AbpScanProject;

[DependsOn(
    typeof(AbpScanProjectDomainModule),
    typeof(AbpScanProjectTestBaseModule)
)]
public class AbpScanProjectDomainTestModule : AbpModule
{

}
