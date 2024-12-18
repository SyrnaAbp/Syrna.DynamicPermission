using System.Threading.Tasks;

namespace Syrna.DynamicPermission.MainDemo.Data;

public interface IMainDemoDbSchemaMigrator
{
    Task MigrateAsync();
}
