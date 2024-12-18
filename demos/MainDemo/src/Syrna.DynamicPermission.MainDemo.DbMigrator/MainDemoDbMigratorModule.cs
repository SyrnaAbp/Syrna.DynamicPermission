﻿using Syrna.DynamicPermission.MainDemo;
using Syrna.DynamicPermission.MainDemo.SqlServer.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace Syrna.DynamicPermission.MainDemo.DbMigrator;

[DependsOn(typeof(AbpAutofacModule))]
[DependsOn(typeof(MainDemoEntityFrameworkCoreSqlServerModule))]
[DependsOn(typeof(MainDemoApplicationContractsModule))]
public class MainDemoDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        //Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        Configure<AbpDbContextOptions>(options =>
        {
            /* The main point to change your DBMS.
             * See also LayoutMigrationsDbContextFactory for EF Core tooling. */
            options.UseSqlServer(x => x.UseCompatibilityLevel(120));
        });
    }
}
