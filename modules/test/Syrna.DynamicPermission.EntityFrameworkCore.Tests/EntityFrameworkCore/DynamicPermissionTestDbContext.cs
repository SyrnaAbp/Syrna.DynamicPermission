using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.PermissionManagement.EntityFrameworkCore;

namespace Syrna.DynamicPermission.EntityFrameworkCore
{
    [ConnectionStringName("Default")]
    public class DynamicPermissionTestDbContext : AbpDbContext<DynamicPermissionTestDbContext>
    {
        public DynamicPermissionTestDbContext(DbContextOptions<DynamicPermissionTestDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureSyrnaDynamicPermission();
            builder.ConfigurePermissionManagement();
        }
    }
}
