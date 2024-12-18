using Syrna.DynamicPermission.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicPermission
{
    public abstract class DynamicPermissionAppService : ApplicationService
    {
        protected DynamicPermissionAppService()
        {
            LocalizationResource = typeof(DynamicPermissionResource);
            ObjectMapperContext = typeof(SyrnaDynamicPermissionApplicationModule);
        }
    }
}
