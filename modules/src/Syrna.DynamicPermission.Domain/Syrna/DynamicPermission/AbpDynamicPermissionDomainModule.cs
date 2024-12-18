using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Domain;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Syrna.DynamicPermission
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(AbpPermissionManagementDomainModule),
        typeof(SyrnaDynamicPermissionDomainSharedModule)
    )]
    public class SyrnaDynamicPermissionDomainModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.Configure<PermissionManagementOptions>(options =>
            {
                options.IsDynamicPermissionStoreEnabled = true;
            });
        }
    }
}