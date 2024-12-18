using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Syrna.DynamicPermission
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class SyrnaDynamicPermissionHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = SyrnaDynamicPermissionRemoteServiceConsts.RemoteServiceName;

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(SyrnaDynamicPermissionApplicationContractsModule).Assembly,
                RemoteServiceName
            );
            
            Configure<AbpVirtualFileSystemOptions>(options =>
            {
                options.FileSets.AddEmbedded<SyrnaDynamicPermissionHttpApiClientModule>();
            });
        }
    }
}
