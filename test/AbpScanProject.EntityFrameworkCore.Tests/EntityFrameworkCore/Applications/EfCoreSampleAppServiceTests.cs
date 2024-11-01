using AbpScanProject.Samples;
using Xunit;

namespace AbpScanProject.EntityFrameworkCore.Applications;

[Collection(AbpScanProjectTestConsts.CollectionDefinitionName)]
public class EfCoreSampleAppServiceTests : SampleAppServiceTests<AbpScanProjectEntityFrameworkCoreTestModule>
{

}
