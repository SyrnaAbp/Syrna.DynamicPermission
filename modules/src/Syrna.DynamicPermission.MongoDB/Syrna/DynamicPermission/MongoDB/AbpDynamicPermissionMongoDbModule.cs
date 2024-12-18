using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;
using Volo.Abp.MongoDB;

namespace Syrna.DynamicPermission.MongoDB
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionDomainModule),
        typeof(AbpMongoDbModule)
        )]
    public class SyrnaDynamicPermissionMongoDbModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddMongoDbContext<DynamicPermissionMongoDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, MongoQuestionRepository>();
                 */
            });
        }
    }
}
