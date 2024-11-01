using AbpScanProject.Localization;
using Volo.Abp.Application.Services;

namespace AbpScanProject;

/* Inherit your application services from this class.
 */
public abstract class AbpScanProjectAppService : ApplicationService
{
    protected AbpScanProjectAppService()
    {
        LocalizationResource = typeof(AbpScanProjectResource);
    }
}
