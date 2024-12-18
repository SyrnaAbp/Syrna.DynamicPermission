using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission.MainDemo.Blazor.Server;

[DependsOn(
    typeof(MainDemoBlazorModule)
)]
public class MainDemoBlazorServerModule : AbpModule
{

}
