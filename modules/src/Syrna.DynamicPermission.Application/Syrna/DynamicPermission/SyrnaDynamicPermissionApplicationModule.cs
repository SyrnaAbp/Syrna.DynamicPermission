using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;

namespace Syrna.DynamicPermission
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionDomainModule),
        typeof(SyrnaDynamicPermissionApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpAutoMapperModule)
        )]
    public class SyrnaDynamicPermissionApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<SyrnaDynamicPermissionApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<SyrnaDynamicPermissionApplicationModule>(validate: true);
            });
        }
    }
}
