﻿using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Serilog;
using Volo.Abp;
using Volo.Abp.Data;
using Syrna.DynamicPermission.MainDemo.Data;

namespace Syrna.DynamicPermission.MainDemo.DbMigrator
{
    public class DbMigratorHostedService : IHostedService
    {
        private readonly IHostApplicationLifetime _hostApplicationLifetime;

        public DbMigratorHostedService(IHostApplicationLifetime hostApplicationLifetime)
        {
            _hostApplicationLifetime = hostApplicationLifetime;
        }

        public async Task StartAsync(CancellationToken cancellationToken)
        {
            using var application = await AbpApplicationFactory.CreateAsync<MainDemoDbMigratorModule>(options =>
            {
                options.UseAutofac();
                //options.Services.AddLogging(c => c.AddSerilog());
                options.Services.AddDataMigrationEnvironment();
            });
            await application.InitializeAsync();

            await application
                .ServiceProvider
                .GetRequiredService<MainDemoDbMigrationService>()
                .MigrateAsync();

            await application.ShutdownAsync();

            _hostApplicationLifetime.StopApplication();
        }

        public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
    }
}