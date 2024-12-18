using Syrna.DynamicPermission.MainDemo;
using Syrna.DynamicPermission.MainDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicPermission.MainDemo.SettingManagement;

public abstract class SettingManagementAppServiceBase : ApplicationService
{
    protected SettingManagementAppServiceBase()
    {
        ObjectMapperContext = typeof(MainDemoApplicationModule);
        LocalizationResource = typeof(MainDemoResource);
    }
}
