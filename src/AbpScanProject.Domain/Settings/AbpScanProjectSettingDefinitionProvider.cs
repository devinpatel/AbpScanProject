using Volo.Abp.Settings;

namespace AbpScanProject.Settings;

public class AbpScanProjectSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpScanProjectSettings.MySetting1));
    }
}
