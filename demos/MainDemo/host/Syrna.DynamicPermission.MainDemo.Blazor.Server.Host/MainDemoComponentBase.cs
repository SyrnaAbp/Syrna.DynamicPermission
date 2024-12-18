using Syrna.DynamicPermission.MainDemo.Localization;
using Volo.Abp.AspNetCore.Components;

namespace Syrna.DynamicPermission.MainDemo.Blazor.Server.Host
{
    public abstract class MainDemoComponentBase : AbpComponentBase
    {
        protected MainDemoComponentBase()
        {
            LocalizationResource = typeof(MainDemoResource);
        }
    }
}
