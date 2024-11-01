using Xunit;

namespace AbpScanProject.EntityFrameworkCore;

[CollectionDefinition(AbpScanProjectTestConsts.CollectionDefinitionName)]
public class AbpScanProjectEntityFrameworkCoreCollection : ICollectionFixture<AbpScanProjectEntityFrameworkCoreFixture>
{

}
