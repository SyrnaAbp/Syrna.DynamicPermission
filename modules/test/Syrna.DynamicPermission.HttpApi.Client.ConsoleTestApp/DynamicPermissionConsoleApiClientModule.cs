using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class DynamicPermissionConsoleApiClientModule : AbpModule
    {
        
    }
}
