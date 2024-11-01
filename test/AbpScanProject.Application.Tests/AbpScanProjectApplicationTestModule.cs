using Volo.Abp.Modularity;

namespace AbpScanProject;

[DependsOn(
    typeof(AbpScanProjectApplicationModule),
    typeof(AbpScanProjectDomainTestModule)
)]
public class AbpScanProjectApplicationTestModule : AbpModule
{

}
