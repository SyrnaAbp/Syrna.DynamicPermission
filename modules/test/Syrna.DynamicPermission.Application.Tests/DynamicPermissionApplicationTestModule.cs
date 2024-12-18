using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Syrna.DynamicPermission
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionApplicationModule),
        typeof(DynamicPermissionDomainTestModule)
    )]
    public class DynamicPermissionApplicationTestModule : AbpModule
    {

    }
}
