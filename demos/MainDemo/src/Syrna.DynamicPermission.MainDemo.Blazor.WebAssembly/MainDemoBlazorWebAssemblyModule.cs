using Syrna.DynamicPermission.MainDemo.Blazor;
using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission.MainDemo.Blazor.WebAssembly;

[DependsOn(
    typeof(MainDemoBlazorModule)
)]
public class MainDemoBlazorWebAssemblyModule : AbpModule
{
}
