using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(SyrnaDynamicPermissionBlazorModule)
        )]
    public class SyrnaDynamicPermissionBlazorServerModule : AbpModule
    {
        
    }
}