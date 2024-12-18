using Syrna.DynamicPermission.MainDemo.Localization;
using Volo.Abp.Application.Services;

namespace Syrna.DynamicPermission.MainDemo;

/* Inherit your application services from this class.
 */
public abstract class MainDemoAppService : ApplicationService
{
    protected MainDemoAppService()
    {
        LocalizationResource = typeof(MainDemoResource);
    }
}
