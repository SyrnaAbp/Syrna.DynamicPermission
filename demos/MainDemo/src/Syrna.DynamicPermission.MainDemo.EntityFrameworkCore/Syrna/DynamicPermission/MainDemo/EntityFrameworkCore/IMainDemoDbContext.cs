using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;
using Syrna.DynamicPermission;

namespace Syrna.DynamicPermission.MainDemo.EntityFrameworkCore
{
    [ConnectionStringName(DynamicPermissionDbProperties.ConnectionStringName)]
    public interface IMainDemoDbContext : IEfCoreDbContext
    {
    }
}
