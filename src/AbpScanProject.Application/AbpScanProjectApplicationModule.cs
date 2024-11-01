using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Modularity;
using Volo.Abp.AuditLogging;
using Volo.Abp.Gdpr;
using Volo.Abp.LanguageManagement;
using Volo.Abp.OpenIddict;
using Volo.Saas.Host;
using Volo.Blogging;
using Volo.Blogging.Admin;
using Volo.Chat;
using Volo.CmsKit;
using Volo.Docs;
using Volo.Docs.Admin;
using Volo.FileManagement;

namespace AbpScanProject;

[DependsOn(
    typeof(AbpScanProjectDomainModule),
    typeof(AbpScanProjectApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpAccountPublicApplicationModule),
    typeof(AbpAccountAdminApplicationModule),
    typeof(SaasHostApplicationModule),
    typeof(AbpAuditLoggingApplicationModule),
    typeof(AbpOpenIddictProApplicationModule),
    typeof(LanguageManagementApplicationModule),
    typeof(AbpGdprApplicationModule),
    typeof(AbpSettingManagementApplicationModule)
    )]
[DependsOn(typeof(BloggingApplicationModule))]
    [DependsOn(typeof(BloggingAdminApplicationModule))]
    [DependsOn(typeof(ChatApplicationModule))]
    [DependsOn(typeof(CmsKitApplicationModule))]
    [DependsOn(typeof(DocsApplicationModule))]
    [DependsOn(typeof(DocsAdminApplicationModule))]
    [DependsOn(typeof(FileManagementApplicationModule))]
    public class AbpScanProjectApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpAutoMapperOptions>(options =>
        {
            options.AddMaps<AbpScanProjectApplicationModule>();
        });
    }
}
