using Localization.Resources.AbpUi;
using Syrna.DynamicPermission.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;

namespace Syrna.DynamicPermission
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionApplicationContractsModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class SyrnaDynamicPermissionHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(SyrnaDynamicPermissionHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<DynamicPermissionResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
