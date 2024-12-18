using System;
using Volo.Abp.Data;
using Volo.Abp.Modularity;
using Volo.Abp.Uow;

namespace Syrna.DynamicPermission.MongoDB
{
    [DependsOn(
        typeof(DynamicPermissionTestBaseModule),
        typeof(SyrnaDynamicPermissionMongoDbModule)
        )]
    public class DynamicPermissionMongoDbTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpDbConnectionOptions>(options =>
            {
                options.ConnectionStrings.Default = MongoDbFixture.GetRandomConnectionString();
            });
        }
    }
}
