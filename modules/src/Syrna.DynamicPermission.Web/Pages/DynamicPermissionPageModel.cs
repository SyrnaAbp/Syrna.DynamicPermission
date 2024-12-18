using Syrna.DynamicPermission.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace Syrna.DynamicPermission.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class DynamicPermissionPageModel : AbpPageModel
    {
        protected DynamicPermissionPageModel()
        {
            LocalizationResourceType = typeof(DynamicPermissionResource);
            ObjectMapperContext = typeof(SyrnaDynamicPermissionWebModule);
        }
    }
}