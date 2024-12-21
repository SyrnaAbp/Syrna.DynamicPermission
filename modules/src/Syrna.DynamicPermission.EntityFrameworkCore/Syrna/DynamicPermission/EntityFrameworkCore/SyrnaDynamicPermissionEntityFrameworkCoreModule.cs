using Syrna.DynamicPermission.PermissionDefinitions;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission.EntityFrameworkCore
{
    [DependsOn(
        typeof(SyrnaDynamicPermissionDomainModule),
        typeof(AbpEntityFrameworkCoreModule)
    )]
    public class SyrnaDynamicPermissionEntityFrameworkCoreModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<DynamicPermissionDbContext>(options =>
            {
                /* Add custom repositories here. Example:
                 * options.AddRepository<Question, EfCoreQuestionRepository>();
                 */
                options.AddRepository<PermissionDefinition, PermissionDefinitionRepository>();
            });
        }
    }
}
