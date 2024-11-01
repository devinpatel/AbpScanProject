using AbpScanProject.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpScanProject.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpScanProjectController : AbpControllerBase
{
    protected AbpScanProjectController()
    {
        LocalizationResource = typeof(AbpScanProjectResource);
    }
}
