using Microsoft.Extensions.Localization;
using AbpScanProject.Localization;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpScanProject;

[Dependency(ReplaceServices = true)]
public class AbpScanProjectBrandingProvider : DefaultBrandingProvider
{
    private IStringLocalizer<AbpScanProjectResource> _localizer;

    public AbpScanProjectBrandingProvider(IStringLocalizer<AbpScanProjectResource> localizer)
    {
        _localizer = localizer;
    }

    public override string AppName => _localizer["AppName"];
}
