using Volo.Abp.Account;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.AuditLogging;
using Volo.Abp.LanguageManagement;
using Volo.Saas.Host;
using Volo.Abp.Gdpr;
using Volo.Abp.OpenIddict;
using Volo.Blogging;
using Volo.Blogging.Admin;
using Volo.Chat;
using Volo.CmsKit;
using Volo.Docs;
using Volo.Docs.Admin;
using Volo.FileManagement;

namespace AbpScanProject;

[DependsOn(
    typeof(AbpScanProjectDomainSharedModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpIdentityApplicationContractsModule),
    typeof(AbpAccountPublicApplicationContractsModule),
    typeof(AbpAccountAdminApplicationContractsModule),
    typeof(SaasHostApplicationContractsModule),
    typeof(AbpAuditLoggingApplicationContractsModule),
    typeof(AbpOpenIddictProApplicationContractsModule),
    typeof(LanguageManagementApplicationContractsModule),
    typeof(AbpGdprApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationContractsModule)
)]
[DependsOn(typeof(BloggingApplicationContractsModule))]
    [DependsOn(typeof(BloggingAdminApplicationContractsModule))]
    [DependsOn(typeof(ChatApplicationContractsModule))]
    [DependsOn(typeof(CmsKitApplicationContractsModule))]
    [DependsOn(typeof(DocsApplicationContractsModule))]
    [DependsOn(typeof(DocsAdminApplicationContractsModule))]
    [DependsOn(typeof(FileManagementApplicationContractsModule))]
    public class AbpScanProjectApplicationContractsModule : AbpModule
{
    public override void PreConfigureServices(ServiceConfigurationContext context)
    {
        AbpScanProjectDtoExtensions.Configure();
    }
}
