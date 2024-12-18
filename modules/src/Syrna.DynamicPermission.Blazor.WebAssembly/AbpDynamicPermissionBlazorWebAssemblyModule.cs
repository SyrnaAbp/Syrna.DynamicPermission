using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission.Blazor.WebAssembly
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionBlazorModule),
        typeof(SyrnaDynamicPermissionHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class SyrnaDynamicPermissionBlazorWebAssemblyModule : AbpModule
    {
        
    }
}