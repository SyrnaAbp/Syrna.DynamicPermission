using Syrna.DynamicPermission.Localization;
using Microsoft.AspNetCore.Mvc;
using Volo.Abp.AspNetCore.Mvc;

namespace Syrna.DynamicPermission
{
    [Area(SyrnaDynamicPermissionRemoteServiceConsts.ModuleName)]
    public abstract class DynamicPermissionController : AbpControllerBase
    {
        protected DynamicPermissionController()
        {
            LocalizationResource = typeof(DynamicPermissionResource);
        }
    }
}
