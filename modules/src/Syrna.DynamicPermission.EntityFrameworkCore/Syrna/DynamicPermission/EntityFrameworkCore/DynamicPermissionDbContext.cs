using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.DynamicPermission.PermissionDefinitions;

namespace Syrna.DynamicPermission.EntityFrameworkCore
{
    [ConnectionStringName(DynamicPermissionDbProperties.ConnectionStringName)]
    public class DynamicPermissionDbContext : AbpDbContext<DynamicPermissionDbContext>, IDynamicPermissionDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */
        public DbSet<PermissionDefinition> PermissionDefinitions { get; set; }

        public DynamicPermissionDbContext(DbContextOptions<DynamicPermissionDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSyrnaDynamicPermission();
        }
    }
}
