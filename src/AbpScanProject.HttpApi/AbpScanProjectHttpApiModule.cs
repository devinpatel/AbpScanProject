using Localization.Resources.AbpUi;
using AbpScanProject.Localization;
using Volo.Abp.Account;
using Volo.Abp.SettingManagement;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.Localization;
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
    typeof(AbpScanProjectApplicationContractsModule),
    typeof(AbpPermissionManagementHttpApiModule),
    typeof(AbpSettingManagementHttpApiModule),
    typeof(AbpIdentityHttpApiModule),
    typeof(AbpAccountAdminHttpApiModule),
    typeof(AbpAuditLoggingHttpApiModule),
    typeof(AbpOpenIddictProHttpApiModule),
    typeof(LanguageManagementHttpApiModule),
    typeof(SaasHostHttpApiModule),
    typeof(AbpGdprHttpApiModule),
    typeof(AbpAccountPublicHttpApiModule),
    typeof(AbpFeatureManagementHttpApiModule)
    )]
[DependsOn(typeof(BloggingHttpApiModule))]
    [DependsOn(typeof(BloggingAdminHttpApiModule))]
    [DependsOn(typeof(ChatHttpApiModule))]
    [DependsOn(typeof(CmsKitHttpApiModule))]
    [DependsOn(typeof(DocsHttpApiModule))]
    [DependsOn(typeof(DocsAdminHttpApiModule))]
    [DependsOn(typeof(FileManagementHttpApiModule))]
    public class AbpScanProjectHttpApiModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        ConfigureLocalization();
    }

    private void ConfigureLocalization()
    {
        Configure<AbpLocalizationOptions>(options =>
        {
            options.Resources
                .Get<AbpScanProjectResource>()
                .AddBaseTypes(
                    typeof(AbpUiResource)
                );
        });
    }
}
