using AbpScanProject.Samples;
using Xunit;

namespace AbpScanProject.EntityFrameworkCore.Domains;

[Collection(AbpScanProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleDomainTests : SampleDomainTests<AbpScanProjectEntityFrameworkCoreTestModule>
{

}
